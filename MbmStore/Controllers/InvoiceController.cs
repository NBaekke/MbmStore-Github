using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MbmStore.Infastructure;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MbmStore.Controllers
{
    public class InvoiceController : Controller
    {
        public IActionResult Index()
        {
            List<SelectListItem> customers = new List<SelectListItem>();

            foreach (Invoice invoice in Repository.Invoices)
            {
                customers.Add(new SelectListItem
                {
                    Text = invoice.Customer.Firstname + " " + invoice.Customer.Lastname, Value = invoice.Customer.CustomerId.ToString()
                });
            }

            customers = customers.GroupBy(x => x.Value).Select(y => y.First()).OrderBy(z => z.Text).ToList<SelectListItem>();

            ViewBag.Invoices = Repository.Invoices;
            ViewData["Customers"] = customers;

            return View();
        }

        [HttpPost]
        public IActionResult Index(int? customer)
        {
            List<SelectListItem> customers = new List<SelectListItem>();
            List<Invoice> invoices = new List<Invoice>();

            foreach (Invoice invoice in Repository.Invoices)
            {
                if (invoice.Customer.CustomerId == customer)
                {
                    customers.Add(new SelectListItem
                    {
                        Text = invoice.Customer.Firstname + " " + invoice.Customer.Lastname,
                        Value = invoice.Customer.CustomerId.ToString(),
                        Selected = true
                    });
                }

                else
                {
                    customers.Add(new SelectListItem
                    {
                        Text = invoice.Customer.Firstname + " " + invoice.Customer.Lastname,
                        Value = invoice.Customer.CustomerId.ToString()
                    });
                }
            }
            if (customer != null)
            {// select invoices for a customer with linq
                invoices = Repository.Invoices.Where(r => r.Customer.CustomerId == customer).ToList(); ;
            }

            ViewBag.Invoices = invoices;
            ViewBag.Customers = customers;

            return View();
        }
    }
}