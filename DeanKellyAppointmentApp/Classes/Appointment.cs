using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeanKellyAppointmentApp
{
    public class Appointment
    {
        public int AppointmentID { get; set; }
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int UserID { get; set; }
        public string Type { get; set; }        
        public DateTime DatePicker { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime LastUpdate { get; set; }
        public User LastUpdateBy { get; set; }

        public Appointment()
        {

        }

        public Appointment(int apptId, int custId, string type, DateTime start, DateTime end, DateTime lastUpdate)
        {
            AppointmentID = apptId;
            CustomerID = custId;
            Type = type;
            Start = start;
            End = end;
            LastUpdate = lastUpdate;
        }
    }
}
