using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

using System.Data.Entity;

namespace Vidly.Controllers
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
        public ActionResult Index()
        {
            List<Movie> movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }
        

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(x => x.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
        public ActionResult New()
        {
            List<Genre> genres = _context.Genre.ToList();
            
            var viewModel = new MovieFormViewModel
            {
                Genre = genres
            };
            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
            {
                //New movie
                _context.Movies.Add(movie);
            }
            else
            {
                //existing movie
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.DateAdded= movie.DateAdded;
                movieInDb.ReleaseDate= movie.ReleaseDate;
                movieInDb.NumberInStock = movie.NumberInStock;

            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewmodel = new MovieFormViewModel
            {
                Movie = movie,
                Genre = _context.Genre.ToList()
            };
            return View("MovieForm", viewmodel);
        }
    }
}