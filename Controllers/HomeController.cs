using Laboratorium3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PhoneBookService _phoneBook;

        // public HomeController(ILogger<HomeController> logger)
        // {
        //     _logger = logger;
        // }

        // Access to PhoneBookService
        public HomeController(ILogger<HomeController> logger, PhoneBookService phoneBook)
        {
            _logger = logger;
            _phoneBook = phoneBook;
        }

        public IActionResult Index()
        {
            Random r = new Random();
            ViewData["random"] = r.NextDouble();

            // return View();
            return View(_phoneBook.GetContacts());
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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _phoneBook.Add(contact);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Delete(int id)
        {
            bool removed = _phoneBook.Remove(id);
            if (!removed){
                return View("NotFound");

                // return NotFound(); // Zwraca kod 404, jeśli identyfikator nie istnieje
            }
            return RedirectToAction("Index");

        }
    }
}