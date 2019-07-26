using System;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace DeanKellyAppointmentApp
{
    class Database
    {        
        public static MySqlConnection con = new MySqlConnection("server=52.206.157.109;userid=U04pMb;database=U04pMb;password=53688309901;port=3306;SslMode=None");
        static MySqlCommand cmd;
        static MySqlDataAdapter adapter;
        public static void OpenDatabase()
        {
            con.Close();
            con.Open();
        }
        public static DataTable FillCustomerView()
        {
            string fillQuery = "SELECT customer.customerId, customer.customerName, address.addressId, address.address, city.city, " +
                "address.postalCode, country.country, address.phone, customer.active " +
                "FROM customer INNER JOIN address ON customer.addressId=address.addressId INNER JOIN city ON address.cityId=city.cityId " +
                "INNER JOIN country ON city.countryId=country.countryId";
            cmd = new MySqlCommand(fillQuery, con);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static DataTable FillAppointmentView(DateTime date, bool isWeekView)
        {
            DateTime start;
            DateTime end;
            if (isWeekView)
            {
                start = FirstDayOfWeek(date);
                end = LastDayOfWeek(date);
            }
            else
            {
                start = FirstDayOfMonth(date);
                end = LastDayOfMonth(date);
            }
            string fillQuery = "SELECT appointment.appointmentId, customer.customerName, appointment.type, appointment.start, " +
                "appointment.end, user.userName FROM appointment INNER JOIN customer ON appointment.customerId=customer.customerId " +
                "INNER JOIN user ON appointment.userId=user.userId WHERE start > @start AND end < @end;";
            cmd = new MySqlCommand(fillQuery, con);
            cmd.Parameters.AddWithValue("@start", start);
            cmd.Parameters.AddWithValue("@end", end);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                table.Rows[i][3] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i][3], TimeZoneInfo.Local);
                table.Rows[i][4] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)table.Rows[i][4], TimeZoneInfo.Local);
                TimeSpan duration = (DateTime)table.Rows[i][3] - DateTime.Now;

                if (duration.TotalMinutes > 0)

                    if (duration.TotalMinutes < 15)

                    {

                        MessageBox.Show("You have an upcoming appointment with " + table.Rows[i][1] + 
                            " starting at " + table.Rows[i][3]);

                    }

            }

            return table;
        }        
        public static DataTable FillScheduleReport()
        {
            string fillQuery = "SELECT appointment.appointmentId, customer.customerName," +
                " appointment.type, appointment.start, appointment.end, user.userName FROM appointment " +
                "INNER JOIN customer ON appointment.customerId=customer.customerId " +
                "INNER JOIN user ON appointment.userId=user.userId;";
            cmd = new MySqlCommand(fillQuery, con);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static DataTable FillTypeReport()
        {
            string fillQuery = "SELECT DATE_FORMAT(start, \"%M\") AS Month, type AS Type, COUNT(*) FROM appointment " +
                "GROUP BY type, DATE_FORMAT(start, \"%M\") DESC; ";
            cmd = new MySqlCommand(fillQuery, con);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static DataTable FillUSCustomerReport()
        {
            string fillQuery = "SELECT customerName AS Customer, city AS City, country AS Country FROM customer INNER JOIN address ON " +
                "customer.addressId = address.addressId INNER JOIN city ON address.cityId = city.cityId " +
                "INNER JOIN country ON city.countryId = country.countryId WHERE country.countryId = \"1\"; ";
            cmd = new MySqlCommand(fillQuery, con);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public static Customer SelectedCustomer(int customerId)
        {
            string customerQuery = "SELECT customerId, customerName, addressId, active FROM customer WHERE customerId = @customerId;";
            cmd = new MySqlCommand(customerQuery, con);
            cmd.Parameters.AddWithValue("@customerId", customerId);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow row = table.Rows[0];

            Customer customer = new Customer()
            {
                CustomerID = customerId,
                AddressID = Convert.ToInt32(row["addressId"]),
                CustomerName = row["customerName"].ToString(),
                Active = Convert.ToBoolean(row["active"].ToString())
            };

            string addressQuery = "SELECT address, postalCode, phone, cityId FROM address WHERE addressId = @addressId;";
            cmd = new MySqlCommand(addressQuery, con);
            cmd.Parameters.AddWithValue("@addressId", Convert.ToInt32(row["addressId"]));
            adapter = new MySqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            row = table.Rows[0];

            customer.Address = row["address"].ToString();
            customer.PostalCode = row["postalCode"].ToString();
            customer.Phone = row["phone"].ToString();
            customer.City = GetCityByCityId(Convert.ToInt32(row["cityId"]));
            if (customer.City == "London")
                customer.Country = "England";
            else
                customer.Country = "USA";

            return customer;
        }
        public static Appointment SelectedAppointment(int appointmentId)
        {
            string appointmentQuery = "SELECT appointmentId, customerId, start, end, type FROM appointment WHERE appointmentId = @appointmentId;";
            cmd = new MySqlCommand(appointmentQuery, con);
            cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            DataRow row = table.Rows[0];

            Appointment appointment = new Appointment()
            {
                AppointmentID = appointmentId,
                CustomerID = Convert.ToInt32(row["customerId"]),
                Start = Convert.ToDateTime(row["start"]).ToLocalTime(),
                End = Convert.ToDateTime(row["end"]).ToLocalTime(),
                Type = row["type"].ToString()
            };

            string customerQuery = "SELECT customerName FROM customer WHERE customerId = @customerId;";
            cmd = new MySqlCommand(customerQuery, con);
            cmd.Parameters.AddWithValue("@customerId", Convert.ToInt32(row["customerId"]));
            adapter = new MySqlDataAdapter(cmd);
            table = new DataTable();
            adapter.Fill(table);
            row = table.Rows[0];

            appointment.CustomerName = row["customerName"].ToString();

            return appointment;
        }
        public static DateTime FirstDayOfWeek(DateTime dt)
        {
            var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var diff = dt.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
            if (diff < 0)
                diff += 7;
            return dt.AddDays(-diff).Date;
        }
        public static DateTime LastDayOfWeek(DateTime dt)
        {
            return FirstDayOfWeek(dt).AddDays(6);
        }
        public static DateTime FirstDayOfMonth(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, 1);
        }
        public static DateTime LastDayOfMonth(DateTime dt)
        {
            return FirstDayOfMonth(dt).AddMonths(1).AddDays(-1);
        }                  
               
        //CUSTOMER        
        public static void AddNewCustomer(Customer customer)
        {
            string insertCountryQuery = "INSERT INTO country (country) VALUES (@country)";
            cmd = new MySqlCommand(insertCountryQuery, con);            
            cmd.Parameters.AddWithValue("@country", customer.Country);
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();

            string insertCityQuery = "INSERT INTO city (city, countryId) VALUES (@city, @countryId)";
            cmd = new MySqlCommand(insertCityQuery, con);
            cmd.Parameters.AddWithValue("@city", customer.City);
            cmd.Parameters.AddWithValue("@countryId", customer.CountryID);
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();

            string insertAddressQuery = "INSERT INTO address (address, cityId, postalCode, phone) VALUES (@address, @cityId, @postalCode, @phone)";
            cmd = new MySqlCommand(insertAddressQuery, con);
            cmd.Parameters.AddWithValue("@address", customer.Address);
            cmd.Parameters.AddWithValue("@cityId", customer.CityID);
            cmd.Parameters.AddWithValue("@postalCode", customer.PostalCode);
            cmd.Parameters.AddWithValue("@phone", customer.Phone);
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();

            string insertCustomerQuery = "INSERT INTO customer (customerName, addressId, active) VALUES (@customerName,LAST_INSERT_ID(), @active)";
            cmd = new MySqlCommand(insertCustomerQuery, con);
            cmd.Parameters.AddWithValue("@customerName", customer.CustomerName);
            cmd.Parameters.AddWithValue("@active", customer.Active);
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public static void UpdateCustomer(Customer customer)
        {
            string updateCustomerQuery = "UPDATE customer SET customerName = @customerName, addressId = @addressId, active = @active WHERE customerId = @customerId;";
            cmd = new MySqlCommand(updateCustomerQuery, con);
            cmd.Parameters.AddWithValue("@customerId", customer.CustomerID);
            cmd.Parameters.AddWithValue("@customerName", customer.CustomerName);
            cmd.Parameters.AddWithValue("@addressId", customer.AddressID);
            cmd.Parameters.AddWithValue("@active", customer.Active);
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();

            string updateAddressQuery = "UPDATE address SET address = @address, cityId = @cityId, postalCode = @postalCode, phone = @phone WHERE addressId = @addressId;";
            cmd = new MySqlCommand(updateAddressQuery, con);
            cmd.Parameters.AddWithValue("@addressId", customer.AddressID);
            cmd.Parameters.AddWithValue("@address", customer.Address);
            cmd.Parameters.AddWithValue("@cityId", GetCityIdByCity(customer.City));
            cmd.Parameters.AddWithValue("@postalCode", customer.PostalCode);
            cmd.Parameters.AddWithValue("@phone", customer.Phone);
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public static void DeleteCustomer(int customerId, int addressId)
        {
            try
            {
                string deleteCustomerQuery = "DELETE FROM customer WHERE customerId = @customerId;";
                cmd = new MySqlCommand(deleteCustomerQuery, con);
                cmd.Parameters.AddWithValue("@customerId", customerId);
                con.Close();
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (MySql.Data.MySqlClient.MySqlException e) when (e.Number == 1451)
            {
                MessageBox.Show("Cannot delete customer that is assigned to existing appointment");
                return;
            }
            string deleteAddressQuery = "DELETE FROM address WHERE addressId = @addressId;";
                cmd = new MySqlCommand(deleteAddressQuery, con);
                cmd.Parameters.AddWithValue("@addressId", addressId);
                con.Close();
                con.Open();
                cmd.ExecuteNonQuery();            
        }        
        //APPOINTMENT        
        public static void AddNewAppointment(Appointment appt)
        {
            string insertQuery = "INSERT INTO appointment (appointmentId, customerId, type, start, end, createDate, userId)" +
                " VALUES (@appointmentId, @customerId, @type, @start, @end, @createDate, @userId);";
            cmd = new MySqlCommand(insertQuery, con);
            cmd.Parameters.AddWithValue("@appointmentId", appt.AppointmentID);
            cmd.Parameters.AddWithValue("@customerId", appt.CustomerID);
            cmd.Parameters.AddWithValue("@userId", appt.UserID);
            cmd.Parameters.AddWithValue("@type", appt.Type);
            cmd.Parameters.AddWithValue("@start", TimeZoneInfo.ConvertTimeToUtc(appt.Start));
            cmd.Parameters.AddWithValue("@end", TimeZoneInfo.ConvertTimeToUtc(appt.End));            
            cmd.Parameters.AddWithValue("@createDate", TimeZoneInfo.ConvertTimeToUtc(DateTime.Now));                        
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
                
            
                        
        }
        public static void UpdateAppointment(Appointment appt)
        {
            string updateQuery = "UPDATE appointment SET appointmentId = @appointmentId, customerId = @customerId, userId = @userId, " +
                "type = @type, start = @start, end = @end WHERE appointmentId = @appointmentId;";
            cmd = new MySqlCommand(updateQuery, con);
            cmd.Parameters.AddWithValue("@appointmentId", appt.AppointmentID);
            cmd.Parameters.AddWithValue("@customerId", appt.CustomerID);
            cmd.Parameters.AddWithValue("@userId", Database.GetCurrentUserId());            
            cmd.Parameters.AddWithValue("@type", appt.Type);
            cmd.Parameters.AddWithValue("@start", TimeZoneInfo.ConvertTimeToUtc(appt.Start));
            cmd.Parameters.AddWithValue("@end", TimeZoneInfo.ConvertTimeToUtc(appt.End));
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
        }
        public static void DeleteAppointment(int appointmentId)
        {
            string deleteQuery = "DELETE FROM appointment WHERE appointmentId = @appointmentId;";
            cmd = new MySqlCommand(deleteQuery, con);
            cmd.Parameters.AddWithValue("@appointmentId", appointmentId);
            con.Close();
            con.Open();
            cmd.ExecuteNonQuery();
        }
        //
        //User
        //
        public static int GetCurrentUserId()
        {
            return 1;
        }
        public static string GetCurrentUserName()
        {
            return "test"
                ;
        }
        //
        //City
        //
        public static string GetCityByCityId(int cityId)
        {
            if (cityId == 2)
                return "Los Angeles";
            else if (cityId == 1)
                return "New York";
            else
                return "London";
        }
        public static int GetCityIdByCity(string city)
        {
            if (city == "London")
                return 3;
            else if (city == "New York")
                return 1;
            else
                return 2;
        }
        //
        //Country
        //
        public static int GetCountryIdByCountry(string country)
        {
            if (country == "UK")
                return 2;
            else
                return 1;
        }
                public static string GetCountryByCountryID(int countryId)
        {
            if (countryId == 2)
                return "UK";
            else
                return "USA";
        }
    }
}
