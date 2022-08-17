using GlobalizationCultures.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace GlobalizationCultures.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(PersonalDataModel data)
        {
            return View();
        }

        [HttpGet]
        public IActionResult GlobalizationOptions()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult GlobalizationOptions(GlobalizationOptionsModel options)
        {
            TempData["SelectedOption"] = options.Option;

            return RedirectToAction("Index");
        }
    }
}