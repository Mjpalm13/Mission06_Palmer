using Microsoft.AspNetCore.Mvc;
using Mission06_Palmer.Models;
using Mission06_Palmer.Data;

namespace Mission06_Palmer.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MovieContext _context;

        public MoviesController(MovieContext context)
        {
            _context = context;
        }

        // GET: Movies/AddMovie
        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }

        // POST: Movies/AddMovie
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            // If model state is invalid, return the same view with validation errors
            return View(movie);
        }
    }
}