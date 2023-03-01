using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Li_James_HW1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult FunFacts()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Designs()
        {
            return View();
        }
        public IActionResult Spotify()
        {
            return View();
        }

        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/James_Li_Resume.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "James_Li_Resume.pdf");
        }
    }

}