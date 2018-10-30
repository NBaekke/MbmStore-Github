using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Customer nicoB = new Customer(1, "Nicolaj", "Bække", "Søndervangen 93, 1. 102", "8260", "Viby J", new DateTime(1995, 10, 15));
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer(2, "Jesper", "Greve", "Tyrrodsvej 124", "8280", "Viby J", new DateTime(1925, 11, 20)));
            customerList.Add(nicoB);

            customerList[0].addPhone("51816513");
            nicoB.addPhone("22275130");
            nicoB.addPhone("65198124");

            ViewBag.CustomerList = customerList;
            return View();
        }
    }
}