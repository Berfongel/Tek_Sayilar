using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TekSayilarWebApplication.Models;

namespace TekSayilarWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(TekSayilar tekSayilar)
        {
            var message = string.Empty;
           ViewBag.Message = message;

            return View("tekSayilar");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}