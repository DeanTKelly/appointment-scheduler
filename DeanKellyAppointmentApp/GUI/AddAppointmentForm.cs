using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DeanKellyAppointmentApp
{
    public partial class AddAppointmentForm : Form
    {
        static MySqlDataAdapter adapter;
        public AddAppointmentForm()
        {
            InitializeComponent();
        }      
        private void addApptSaveButton_Click(object sender, EventArgs e)
        {
            if (addApptCustIDComboBox.Text == "" || addApptTypeComboBox.Text == "")
            {
                MessageBox.Show("Please fill all required fields before saving.");
                return;
            }
            
            Appointment newAppt = new Appointment()
            {
                //AppointmentID = Convert.ToInt32(addApptIDBox.Text),
                CustomerID = Convert.ToInt32(addApptCustIDComboBox.SelectedValue),                
                Type = addApptTypeComboBox.Text,
                Start = addApptDatePicker.Value.Date.Add(addApptStartTimePicker.Value.TimeOfDay),
                End = addApptDatePicker.Value.Date.Add(addApptEndTimePicker.Value.TimeOfDay),
                UserID = Database.GetCurrentUserId(),
            };

            MySqlConnection con = new MySqlConnection("server=52.206.157.109;userid=U04pMb;database=U04pMb;password=53688309901;port=3306;SslMode=None");
            string selectQuery = "SELECT start, end FROM appointment";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(selectQuery, con);
            adapter = new MySqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {

                DateTime dbStart = ((DateTime)table.Rows[i][0]).ToLocalTime();
                DateTime dbEnd = ((DateTime)table.Rows[i][1]).ToLocalTime();


                if (addApptDatePicker.Value.Date.Add(addApptStartTimePicker.Value.TimeOfDay) < dbEnd && dbStart < addApptDatePicker.Value.Date.Add(addApptEndTimePicker.Value.TimeOfDay))

                {
                    MessageBox.Show("The time you have selected overlaps with an existing appointment");
                    return;
                }
            };

            var min = new TimeSpan(08, 00, 00);
            var max = new TimeSpan(20, 00, 00);
            if (addApptStartTimePicker.Value.TimeOfDay >= max || addApptStartTimePicker.Value.TimeOfDay <= min)
            {
                MessageBox.Show("Please schedule your appointment during business hours. Business hours are from 8 am to 8 pm.");
                return;
            }
            if (addApptEndTimePicker.Value.TimeOfDay >= max || addApptEndTimePicker.Value.TimeOfDay <= min)
            {
                MessageBox.Show("Please schedule your appointment during business hours. Business hours are from 8 am to 8 pm.");
                return;
            }

            if (addApptStartTimePicker.Value.TimeOfDay >= addApptEndTimePicker.Value.TimeOfDay)
            {
                MessageBox.Show("Your appointment cannot end before it begins. Try again.");
                return;
            }
            if (addApptEndTimePicker.Value.TimeOfDay <= addApptStartTimePicker.Value.TimeOfDay)
            {
                MessageBox.Show("Your appointment cannot end before it begins. Try again.");
                return;
            }

            Database.AddNewAppointment(newAppt);
            this.Hide();
            new AppointmentForm().ShowDialog();
                
            
        }
        private void addApptCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AppointmentForm().ShowDialog();
        }       

        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            addApptDatePicker.MinDate = DateTime.Today;
            addApptDatePicker.MaxDate = DateTime.Today.AddYears(1);
            try
                {
                    MySqlConnection con = new MySqlConnection("server=52.206.157.109;userid=U04pMb;database=U04pMb;password=53688309901;port=3306;SslMode=None");
                    string selectQuery = "SELECT customerName, customerId FROM customer";
                    MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                    adapter = new MySqlDataAdapter(cmd);
                    con.Open();
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "customer");

                    addApptCustIDComboBox.ValueMember = "customerId";
                    addApptCustIDComboBox.DisplayMember = "customerName";
                    addApptCustIDComboBox.DataSource = ds.Tables["customer"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please select customer from available options.");
                }            
        }        
    }
}
