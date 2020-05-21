using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult AllMovies()
        {
            var movie = new Movie() { Name = "Kung Fu Panda" };

            return View(movie);
        }
    }
}