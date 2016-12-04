using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers {
    public class MoviesController : Controller {
        private static IEnumerable<Movie> Movies = new[] {
            new Movie {
                Name = "Shrek",
                Id = 1
            },
            new Movie {
                Name = "Finding Dory",
                Id = 2
            },
        };

        // GET: Movies
        public ActionResult Random() {
            var customers = new List<Customer> {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel {
                Movie = Movies.First(),
                Customer = customers
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id) {
            return Content("id=" + id);
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month) {
            return Content(year + "/" + month);
        }

        //Movies
        public ActionResult Index() {
            return View(Movies);
        }
    }
}