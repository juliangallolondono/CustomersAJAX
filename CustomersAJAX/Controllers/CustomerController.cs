using CustomersAJAX.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CustomersAJAX.Controllers
{
    public class CustomerController : Controller
    {
        Customer customer;
        List<Customer> customers;

        public CustomerController()
        {
            customers = new List<Customer>();
            customers.Add(new Customer(0, "Julian", 32));
            customers.Add(new Customer(1, "Tatiana", 32));
            customers.Add(new Customer(2, "Liliana", 54));
            customers.Add(new Customer(3, "Oscar", 50));
            customers.Add(new Customer(4, "Sara", 26));
            customers.Add(new Customer(5, "Javier", 72));
        }


        public ActionResult Index()
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[0]);
            return View("Customer", tuple);
        }

        [HttpPost] 
        public ActionResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<Customer>, Customer> tuple;
            tuple = new Tuple<List<Customer>, Customer>(customers, customers[Convert.ToInt32(CustomerNumber)]);
            return PartialView("_CustomerDetails", customers[Convert.ToInt32(CustomerNumber)]);
        }

    }
}