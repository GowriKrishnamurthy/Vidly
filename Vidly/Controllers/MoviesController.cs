using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult AllMovies()
        {
            var movie = new Movie() { Name = "Kung Fu Panda" };
            var customers = new List<Customer>
            {
                new Customer{Name="Customer 1"},
                new Customer{Name="Customer 2"}
            };

            AllMoviesViewModel viewModel = new AllMoviesViewModel
            {
                Movies = movie,
                Customers = customers
            };
             
            return View(viewModel);
        }
    }
}