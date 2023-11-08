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
        private String uploadsDirectory;
        private String watermarkDir;
        private String watermarkPath;
        private MagickImage watermark;
        public UploadModel(IWebHostEnvironment environment)
        {
            _environment = environment;

            uploadsDirectory = Path.Combine(_environment.WebRootPath, "images");
            if (!Directory.Exists(uploadsDirectory))
            {
                Directory.CreateDirectory(uploadsDirectory);
            }

            watermarkDir = Path.Combine(_environment.WebRootPath, "watermark");
            watermarkPath = Path.Combine(watermarkDir, "watermark.png");
            watermark = new MagickImage(watermarkPath);
            // przezroczystosc znaku wodnego
            watermark.Evaluate(Channels.Alpha, EvaluateOperator.Divide, 2);
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
                /*
                var uploadsDirectory = Path.Combine(_environment.WebRootPath, "images");

                if (!Directory.Exists(uploadsDirectory))
                {
                    Directory.CreateDirectory(uploadsDirectory);
                }
                */

                string uniqueFileName = Guid.NewGuid().ToString() + "_" + Image.FileName;
                string filePath = Path.Combine(uploadsDirectory, uniqueFileName);
                /*
                var watermarkDir = Path.Combine(_environment.WebRootPath, "watermark");
                var watermarkPath = Path.Combine(watermarkDir, "watermark.png");
                */
                string galleryDir = Path.Combine(_environment.WebRootPath, "gallery");
                string galleryPath = Path.Combine(galleryDir, uniqueFileName);
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    Image.CopyTo(stream);

                    using var image = new MagickImage(filePath);

                    // narysowanie znaku wodnego
                    image.Composite(watermark, Gravity.Southeast, CompositeOperator.Over);
                    //using (var galleryStream = new FileStream(galleryPath, FileMode.Create))
                    image.Write(galleryPath);

                }
                return RedirectToPage("/Index");
            }

            return Page();
        }
    }
}
