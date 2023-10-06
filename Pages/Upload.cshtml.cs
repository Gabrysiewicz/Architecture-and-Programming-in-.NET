using System;
using System.IO;
using ImageMagick;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Laboratorium4.Pages
{
    public class UploadModel : PageModel
    {
        private readonly IWebHostEnvironment _environment;

        public UploadModel(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        [BindProperty]
        public IFormFile Image { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (Image != null && Image.Length > 0)
            {
                var uploadsDirectory = Path.Combine(_environment.WebRootPath, "images");

                if (!Directory.Exists(uploadsDirectory))
                {
                    Directory.CreateDirectory(uploadsDirectory);
                }

                var uniqueFileName = Guid.NewGuid().ToString() + "_" + Image.FileName;
                var filePath = Path.Combine(uploadsDirectory, uniqueFileName);
                var watermarkDir = Path.Combine(_environment.WebRootPath, "watermark");
                var watermarkPath = Path.Combine(watermarkDir, "watermark.png");
                var galleryDir = Path.Combine(_environment.WebRootPath, "gallery");
                var galleryPath = Path.Combine(galleryDir, uniqueFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    Image.CopyTo(stream);

                    using var image = new MagickImage(filePath);
                    using var watermark = new MagickImage(watermarkPath);
                    // przezroczystosc znaku wodnego
                    watermark.Evaluate(Channels.Alpha, EvaluateOperator.Divide, 2);
                    // narysowanie znaku wodnego
                    image.Composite(watermark, Gravity.Southeast, CompositeOperator.Over);
                    var galleryStream = new FileStream(galleryPath, FileMode.Create);
                    image.Write(galleryStream);

                }

                // Optionally, you can save the file path to a database or do other processing here.

                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
