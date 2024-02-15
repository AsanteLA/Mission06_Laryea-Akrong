using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TheJHFilmCollection.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TheJHFilmCollection.Controllers
{
    public class HomeController : Controller
    {
        private MovieEntryFormContext _context;
        public HomeController(MovieEntryFormContext temp) //Constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieEntryForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieEntryForm(MovieEntryForm response)
        {
            _context.MovieEntries.Add(response);  //Adds record to the database
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}
