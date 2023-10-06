using ImageMagick;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace Laboratorium4.Pages
{
    public class UploadModel : PageModel
    {
        [BindProperty]
        public IFormFile Upload { get; set; }

        private string imagesDir;
        public string LogMessage { get; set; } // Property to store log messages

        public UploadModel( IWebHostEnvironment environment)
        {
            imagesDir = Path.Combine(environment.WebRootPath, "images");
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            if (Upload != null)
            {
                string extension = ".jpg";
                switch (Upload.ContentType)
                {
                    case "image/png":
                        extension = ".png";
                        break;
                    case "image/gif":
                        extension = ".gif";
                        break;
                }
                var fileName =
                Path.GetFileNameWithoutExtension(Path.GetRandomFileName()) +
                extension;
                using (var fs =
                System.IO.File.OpenWrite(Path.Combine(imagesDir, fileName)))
                {
                    Upload.CopyTo(fs);
                }
            }
            return RedirectToPage("Index");
        }

    }
}
