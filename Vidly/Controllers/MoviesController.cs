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
        // GET: Movies/Random   --> controller:Movies and action: Random
        public ActionResult Random()
        {
            var movies = GetMovies();
            //var movie = new Movie() { Name = "Shrek!" };

            //var customers = new List<Customer>
            //{
            //    new Customer {Name = "Customer1"},
            //    new Customer { Name = "Customer2" }
            //};

            //var viewModel = new RandomMovieViewModel
            //{
            //    Movie = movie,
            //    Customers = customers

            //};
            //return View(viewModel);

            return View(movies);

            //return Content("Hello"); 
            //return HttpNotFound();

            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });

        }

        public ActionResult Index()
        {
            var movies = GetMovies();
            return View(movies);
                    
        }

        //Movies/Edit/1 or /Movies/Edit?id=1
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        ////Movies
        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //    {
        //        pageIndex = 1;
        //    }

        //    if (string.IsNullOrWhiteSpace(sortBy))
        //    {
        //        sortBy = "Name";
        //    }

        //    return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));

        //}

        //Use custom route
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ Id=1,Name ="Bangalore Days"},
                new Movie(){Id=2, Name="Onam"}
            };
        }
    }
}