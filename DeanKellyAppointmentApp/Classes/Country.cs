using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeanKellyAppointmentApp
{
    class Country
    {
        public List<City> CityList = new List<City>();
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public Country()
        {

        }
    }
}
