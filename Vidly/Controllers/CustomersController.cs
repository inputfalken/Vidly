using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Customers
        public ActionResult Index()
        {
            var contextCustomers = _context.Customers.ToArray();
            return View(contextCustomers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Find(id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
    }
}