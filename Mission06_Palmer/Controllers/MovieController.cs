using Microsoft.AspNetCore.Mvc;
using Mission06_Palmer.Models;

namespace Mission06_Palmer.Controllers
{
    // Idk if you expect comments for this page but I feel like it is pointless here
    public class MovieController : Controller
    {
        private readonly MovieContext _context;

        public MovieController(MovieContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            var movie = new Movie();
            return View();
        }

        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }
    }
}