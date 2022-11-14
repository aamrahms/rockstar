
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;
namespace asp.net.mvc.Controllers
{
    public class RockStarController : Controller
    {
        private readonly ILogger<RockStarController> _logger;
        //private MusicModel myModel = new MusicModel();

        public RockStarController(ILogger<RockStarController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GeorgeMichael()
        {
            return View();
        }

        public IActionResult GeorgeMichael2()
        {
            return View();
        }

        public IActionResult Queen()
        {
            return View();
        }

        public IActionResult Queen2()
        {
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
