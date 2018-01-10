using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = getCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = getCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public List<Customer> getCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Steven", Id = 1},
                new Customer { Name = "Lucky", Id = 2}
            };

            return customers;
        }
    }
}