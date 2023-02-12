using Admin.Models;
using Microsoft.AspNetCore.Mvc;

namespace Admin.Controllers
{
    public class DirectoryController : Controller
    {
        private IWebHostEnvironment hostEnvironment;
        public DirectoryController(IWebHostEnvironment hostEnvironment)
        {
            this.hostEnvironment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DirectoryRoomProperties(int page = 0)
        {
            return View();
        }
        [HttpPost]  
        public IActionResult RoomProperties()
        {
            string NameProperties = Request.Form["NameProperties"];
            string DescProperties = Request.Form["Description"];
            return View();
        }
        [HttpPost]
        public IActionResult RoomPropertiesModel(RoomProperties roomProperties)
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoomPropertiesModel(IFormFile photo)
        {
            using (var stream = new FileStream(Path.Combine(hostEnvironment.WebRootPath, photo.FileName), FileMode.OpenOrCreate))
            {
                await photo.CopyToAsync(stream);
            }
            string fileName = photo.FileName;
            return View();

    }
    }
}
