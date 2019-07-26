using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeanKellyAppointmentApp
{
    public partial class UpdateAppointmentForm : Form
    {
        static MySqlDataAdapter adapter;
        public UpdateAppointmentForm(Appointment appt)
        {
            InitializeComponent();

            updateApptIDBox.Text = appt.AppointmentID.ToString();
            updateApptCustIDComboBox.Text = appt.CustomerName.ToString();
            updateApptTypeComboBox.Text = appt.Type;            
            updateApptStartTimePicker.Text = appt.Start.ToString();
            updateApptEndTimePicker.Text = appt.End.ToString();
            updateApptDatePicker.Text = updateApptStartTimePicker.Value.Date.ToString();
        }
        private void updateApptCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AppointmentForm().ShowDialog();
        }       
        private void updateApptSaveButton_Click(object sender, EventArgs e)
        {
            if (updateApptCustIDComboBox.Text == "" || updateApptTypeComboBox.Text == "" || updateApptDatePicker.Text == "" ||
                updateApptStartTimePicker.Text == "" || updateApptEndTimePicker.Text == "")
            {
                MessageBox.Show("Please fill all required fields before saving.");
                return;
            }

            Appointment updatedAppointment = new DeanKellyAppointmentApp.Appointment(Convert.ToInt32(updateApptIDBox.Text), 
            Convert.ToInt32(updateApptCustIDComboBox.SelectedValue), updateApptTypeComboBox.Text, Convert.ToDateTime(updateApptDatePicker.Value.Date.Add(updateApptStartTimePicker.Value.TimeOfDay)), 
            Convert.ToDateTime(updateApptDatePicker.Value.Date.Add(updateApptEndTimePicker.Value.TimeOfDay)), TimeZoneInfo.ConvertTimeToUtc(DateTime.Now));

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


                if (updateApptDatePicker.Value.Date.Add(updateApptStartTimePicker.Value.TimeOfDay) < dbEnd && dbStart < updateApptDatePicker.Value.Date.Add(updateApptEndTimePicker.Value.TimeOfDay))

                {
                    MessageBox.Show("The time you have selected overlaps with an existing appointment");
                    return;
                }
            };
            var min = new TimeSpan(08, 00, 00);
            var max = new TimeSpan(20, 00, 00);
            if (updateApptStartTimePicker.Value.TimeOfDay >= max || updateApptStartTimePicker.Value.TimeOfDay <= min)
            {
                MessageBox.Show("Please schedule your appointment during business hours. Business hours are from 8 am to 8 pm.");
                return;
            }
            if (updateApptEndTimePicker.Value.TimeOfDay >= max || updateApptEndTimePicker.Value.TimeOfDay <= min)
            {
                MessageBox.Show("Please schedule your appointment during business hours. Business hours are from 8 am to 8 pm.");
                return;
            }

            if (updateApptStartTimePicker.Value.TimeOfDay >= updateApptEndTimePicker.Value.TimeOfDay)
            {
                MessageBox.Show("Your appointment cannot end before it begins. Try again.");
                return;
            }
            if (updateApptEndTimePicker.Value.TimeOfDay <= updateApptStartTimePicker.Value.TimeOfDay)
            {
                MessageBox.Show("Your appointment cannot end before it begins. Try again.");
                return;
            }

            Database.UpdateAppointment(updatedAppointment);
            this.Hide();
            new AppointmentForm().ShowDialog();
        }

        private void UpdateAppointmentForm_Load(object sender, EventArgs e)
        {
            updateApptDatePicker.MinDate = DateTime.Today;
            updateApptDatePicker.MaxDate = DateTime.Today.AddYears(1);
            try
            {
                MySqlConnection con = new MySqlConnection("server=52.206.157.109;userid=U04pMb;database=U04pMb;password=53688309901;port=3306;SslMode=None");
                string selectQuery = "SELECT customerName, customerId FROM customer";
                MySqlCommand cmd = new MySqlCommand(selectQuery, con);
                adapter = new MySqlDataAdapter(cmd);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "customer");

                updateApptCustIDComboBox.ValueMember = "customerId";
                updateApptCustIDComboBox.DisplayMember = "customerName";
                updateApptCustIDComboBox.DataSource = ds.Tables["customer"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select customer from available options.");
            }
        }        
    }
}
