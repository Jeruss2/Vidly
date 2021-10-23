using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;
using Image = vidly.Models.Image;

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




        //[HttpPost]
        //public ActionResult RetrieveImage()
        //{
        //    //Image img = db.Images.OrderByDescending
        //    //    (i => i.Id).SingleOrDefault();

        //    var img = _context.Images;

        //    var imgList = new List<string>();

        //    foreach (var image in img)
        //    {
        //        imgList.Add(Convert.ToBase64String(image.Images));
        //    }


        //    //string imageBase64Data =
        //    //    Convert.ToBase64String(_context.Images);

        //    string imageDataURL =
        //        string.Format("data:image/jpg;base64,{0}",
        //            imgList.FirstOrDefault());



        //    ViewBag.ImageDataUrl = imageDataURL;

        //    return View("Index");
        //}



        // GET: Movies
        [Route("movies/index")]
        public ViewResult Index()
        {
            //var movies = GetMovies();

            var movies = _context.Movies.Include(m => m.GenreType).Include(i=>i.Image).ToList();

            //Added include i=>Image...

            return View(movies);
        }


        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(x => x.GenreType).Include(m=>m.Image.Images).SingleOrDefault(c => c.Id == id);

            //added images here...

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }


        public ActionResult NewMovie()
        {
            var genreTypes = _context.GenreTypes.ToList();
            var images = _context.Images.ToList();

            var viewModel = new MovieFormViewModel
            {
                //Movie = new Movie(),
                GenreTypes = genreTypes,
                Images = images

                //Added images here...

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

                GenreTypes = _context.GenreTypes.ToList(),

                Images = _context.Images.ToList()

                //Added Images here
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
                    GenreTypes = _context.GenreTypes.ToList(),
                    Images = _context.Images.ToList()
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
                movieInDb.Image = movie.Image;

                //Added Image here...


            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Movies");
        }
    }
}

