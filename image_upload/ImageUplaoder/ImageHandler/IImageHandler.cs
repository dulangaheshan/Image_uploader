using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace image_upload.ImageUplaoder.ImageHandler
{
    public interface IImageHandler
    {
        Task<IActionResult> UploadImage(IFormFile file);
    }
}
