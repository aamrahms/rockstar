using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Assignment2.Models;

namespace Assignment2.Controllers;

public class SongController : Controller
{
    private readonly ILogger<SongController> _logger;

    public SongController(ILogger<SongController> logger)
    {
        _logger = logger;
    }

    public IActionResult Song()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
