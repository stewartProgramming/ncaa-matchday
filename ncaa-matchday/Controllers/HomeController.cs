using Microsoft.AspNetCore.Mvc;
using ncaa_matchday.Models;
using ncaa_matchday.Models.HomeModels;
using System.Diagnostics;

namespace ncaa_matchday.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new HomeList().Leagues);
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
