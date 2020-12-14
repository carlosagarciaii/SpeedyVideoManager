using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SpeedyVideoManager.Models;
using SpeedyVideoManager.DB_Context;


namespace SpeedyVideoManager.Controllers
{
    public class MovieController : Controller
    {

        private ApplicationDbContext db;

        public MovieController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            if (db != null) { db.Dispose(); }
            
            base.Dispose(disposing);
        }


        // GET: Movie
        public ActionResult Index()
        {
            
            var movieView = db.Movie.ToList().OrderBy(m => m.Title).ThenBy(m => m.ReleaseYear);
            return View(movieView);
        }
    }
}