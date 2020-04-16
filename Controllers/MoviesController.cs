﻿using CobaMVCNetFramework.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.Web.Mvc;

namespace CobaMVCNetFramework.Models
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "John Smith" },
                new Customer { Name = "Marry Williams" }
            };
            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = _context.Customers.ToList();
            return View(movies);
        }
        [Route("movies/released/{year:regex(\\d{4}):range(1900, 2999)}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {         
            return Content(year + "/" + month);
        }       
    }
}