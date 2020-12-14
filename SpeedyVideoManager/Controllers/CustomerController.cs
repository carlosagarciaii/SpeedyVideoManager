using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeedyVideoManager.Models;
using System.Data.Entity;


namespace SpeedyVideoManager.Controllers
{
    public class CustomerController : Controller
    {


        private ApplicationDbContext db ;


        public CustomerController()
        {
            db = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            if (db != null) { db.Dispose(); }
            base.Dispose(disposing);
        }

        // GET: Customer
        public ActionResult Index()
        {

            var viewList = db.Customer.Include(c => c.MembershipType).ToList().OrderBy(c => c.LastName).ThenBy(c => c.FirstName);

            return View(viewList);
        }

        [Route("Customer/Details/{CustomerID}")]
        public ActionResult Details(int CustomerID)
        {
            var customer = db.Customer.FirstOrDefault<Customer>(c => c.ID == CustomerID);
            return View(customer);
        }


    }
}