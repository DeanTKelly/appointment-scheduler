using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeanKellyAppointmentApp
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int AddressID { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int CityID { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public int CountryID { get; set; }
        public string Country { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public User CreatedBy { get; set; }
        public DateTime LastUpdate { get; set; }
        public User LastUpdatedBy { get; set; }

        public Customer()
        {

        }
        public Customer(int id, string name, string address, string phone, string city, string postalCode, string country, bool active, DateTime createDate)
        {
            CustomerID = id;
            CustomerName = name;
            Address = address;
            Phone = phone;
            City = city;
            PostalCode = postalCode;
            Country = country;
            Active = active;
            CreateDate = createDate;
        }
    }
}
