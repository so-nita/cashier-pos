using CashierPOS.Model;
using Microsoft.AspNetCore.Mvc;

namespace CashierPOS.WebApi.Controllers
{
    [ApiController]
    [Route("api/uploadImage")]
    public class UplodImageController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public UplodImageController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult Get(string imageName)
        {
            if (string.IsNullOrEmpty(imageName))
            {
                return BadRequest("Image name cannot be null or empty.");
            }
            try
            {
                string imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", imageName);

                if (System.IO.File.Exists(imagePath))
                {
                    var fileBytes = System.IO.File.ReadAllBytes(imagePath);
                    return File(fileBytes, "image/jpeg");  
                }
                else
                {
                    return NotFound("Image not found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal Server Error: {ex.Message}");
            }
        }


        [HttpPost]
        public IActionResult UploadImage([FromForm] ImageModel request)
        {
            try
            {
                var test = UploadedFile(request);
                return Ok(test);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Internal Server Error: {ex.Message}");
            }
        }

        private string UploadedFile(ImageModel model)
        {
            string uniqueFileName = null!;
            try
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath ?? string.Empty, "images");
                // Check if the directory exists, create it if it doesn't
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                uniqueFileName = Guid.NewGuid().ToString() + "_" + Path.GetFileName(model.Image.FileName);
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
                return uniqueFileName;
            }
            catch (Exception ex)
            {
                // Log or handle the exception as needed
                Console.WriteLine($"Exception during file upload: {ex.Message}");
                return null!;
            }
        }


    }
}
