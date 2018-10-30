using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Customer
    {
        // fields
        private int customerId;
        private string firstname;
        private string lastname;
        private string address;
        private string zip;
        private string city;
        private List<string> phonenumbers = new List<string>();
        private DateTime birthday;
        private List<Invoice> invoices = new List<Invoice>();

        // properties
        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Zip
        {
            get { return zip; }
            set { zip = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public List<string> Phonenumbers
        {
            get { return phonenumbers; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
        }

        public List<Invoice> Invoices
        {
            get { return invoices; }
            set { invoices = value; }
        }

        public int Age
        {
            get {
                DateTime now = DateTime.Now;
                int age; age = now.Year - birthday.Year;
                if (now.Month < birthday.Month || (now.Month == birthday.Month && now.Day < birthday.Day))
                {
                    age--;
                }

                if (age < 0 || age > 120)
                {
                    throw new Exception("Age not accepted");
                }

                return age;
            }
        }
        // Vi udregner alderen i forhold til angivet fødselsdag og hvad den nuværende dato er på systemet(computeren).
        // Vi har set en aldersgrænse, da der ingen mennesker har været over 120 år gammel

        // constructors
        public Customer(int customerId, string firstname, string lastname, string address, string zip, string city, DateTime birthday)
        {
            this.customerId = customerId;
            this.firstname = firstname;
            this.lastname = lastname;
            this.address = address;
            this.zip = zip;
            this.city = city;
            this.birthday = birthday;
        }

        public void addPhone(string phone)
        {
            phonenumbers.Add(phone);
        }

        public void AddInvoice(Invoice invoice)
        {
            invoices.Add(invoice);
        }
    }

}
