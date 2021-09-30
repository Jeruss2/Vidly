using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }




        // GET: Movies
        [Route("movies/index")]
        public ViewResult Index()
        {
            //var movies = GetMovies();

            var movies = _context.Movies.Include(m => m.GenreType).ToList();


            return View(movies);
        }


        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(x => x.GenreType).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        public ActionResult NewMovie()
        {
            var genreTypes = _context.GenreTypes.ToList();

            var viewModel = new MovieFormViewModel
            {
                //Movie = new Movie(),
                GenreTypes = genreTypes
            };


            return View("MovieForm", viewModel);

        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return HttpNotFound();
            }

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,

                GenreTypes = _context.GenreTypes.ToList()
            };


            return View("MovieForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    GenreTypes = _context.GenreTypes.ToList()
                };

                return View("MovieForm", viewModel);

            }


            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }


            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;
                movieInDb.GenreTypeId = movie.GenreTypeId;

            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}

