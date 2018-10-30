using System;
using MbmStore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Invoice
    {
        // fields
        private int invoiceId;
        private DateTime orderDate;
        private decimal totalPrice;
        private Customer customer;
        private List<OrderItem> orderItems = new List<OrderItem>();

        // properties
        public int InvoiceId
        {
            get { return invoiceId; }
            set { invoiceId = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public decimal TotalPrice
        {
            get { return totalPrice; }
        }

        public Customer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public List<OrderItem> OrderItems
        {
            get { return orderItems; }
        }

        // constructors
        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.invoiceId = invoiceId;
            this.orderDate = orderDate;
            this.customer = customer;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }
    }
}
