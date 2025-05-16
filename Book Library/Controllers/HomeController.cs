using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Smart_Tutor.Models;

namespace Smart_Tutor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Book");
        }
    }
}
