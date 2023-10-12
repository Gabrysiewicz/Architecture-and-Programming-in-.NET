using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Laboratorium7b.Models;
using Laboratorium7b.Data;

namespace Laboratorium7b.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ChinookDbContext _chinook;
    public HomeController(ILogger<HomeController> logger,
    ChinookDbContext chinook)
    {
        _logger = logger;
        _chinook = chinook;
    }


    public IActionResult Index()
    {
        return View(_chinook.Customers.ToList());
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
