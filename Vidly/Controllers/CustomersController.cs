﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers {
    public class CustomersController : Controller {
        private static readonly IEnumerable<Customer> Customers = new[] {
            new Customer {
                Name = "Joe",
                Id = 1
            },
            new Customer {
                Name = "Bob",
                Id = 2
            },
        };


        // GET: Customers
        public ActionResult Index() {
            return View(new List<Customer>());
        }

        public ActionResult Details(int id) {
            var customer = Customers.SingleOrDefault(x => x.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}