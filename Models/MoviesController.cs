using Microsoft.AspNetCore.Mvc;
using Movies.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MoviesController : Controller
    {
        MovieService service;

        public MoviesController(MovieService service)
        {
            this.service = service;
        }

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("movie-box/{id}")]
        public IActionResult MovieBox(int id)
        {
            MovieBoxVM model = service.GetMovieBoxVM(id);
            return PartialView("_MovieBox", model);
        }

        [Route("movie-data/{id}")]
        public IActionResult MovieData(int id)
        {
            MovieBoxVM model = service.GetMovieBoxVM(id);
            return Json(model);
        }

        [Route("movies-data/")]
        public IActionResult MoviesData()
        {
            int model = service.GetMovieQuantity();
            return Json(model);
        }
    }
}
