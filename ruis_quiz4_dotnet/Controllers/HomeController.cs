using Microsoft.AspNetCore.Mvc;
using ruis_quiz4_dotnet.Models;
using System.Diagnostics;

namespace ruis_quiz4_dotnet.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = "Database access has already been done on April 6, 2026 by Ruisheng Wang";
            return View();
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