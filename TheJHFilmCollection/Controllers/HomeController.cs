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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View("MovieEntryForm", new MovieEntryForm());
        }

        [HttpPost]
        public IActionResult MovieEntryForm(MovieEntryForm response)
        {
            if(ModelState.IsValid)
            {
                _context.Movies.Add(response);  //Adds record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            else
            {
                ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

                return View(response);
            }
        }

        public IActionResult MovieDatabase()
        {
            //Linq
            var movies =
                _context.Movies
                .OrderBy(x => x.MovieID)
                .ToList();

            return View(movies);

            //Is there a default select all and how does the program know that?

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieID == id); //What if you want to show multiple records?

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View("MovieEntryForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieEntryForm UpdatedInfo)
        {
            _context.Update(UpdatedInfo);
            _context.SaveChanges();

            return RedirectToAction("MovieDatabase"); //Redirect to action takes you to the full action with all the functionalities and methods.
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieID == id); //What if you want to show multiple records?

            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(MovieEntryForm Delete)
        {
            _context.Remove(Delete);
            _context.SaveChanges();

            return RedirectToAction("MovieDatabase");
        }
    }
}
