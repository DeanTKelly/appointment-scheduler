using System;
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
    public partial class AppointmentForm : Form
    {
        DateTime selectedDate;
        DataTable table;
        public AppointmentForm()
        {
            InitializeComponent();
            FillApptDataGridView();
            formatDGV(apptDataGridView);
            //The following lambdas reduced the amount of code needed to implement event handlers to display a message instructing the user how to utilize the radio buttons for checking appointments by week or month
            this.radioButtonWeek.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Please select a date from the calendar that falls within the week you wish to view.");
            };
            this.radioButtonMonth.Click += (object sender, EventArgs e) =>
            {
                MessageBox.Show("Please select a date from the calendar that falls within the month you wish to view.");
            };
        }

        private void FillApptDataGridView()
        {
            DateTime today = apptCalendar.SelectionRange.Start.Date;
            table = Database.FillAppointmentView(today, radioButtonWeek.Checked);            
            apptDataGridView.DataSource = table;
        }        

        private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
            d.Sort(d.Columns["appointmentId"], ListSortDirection.Ascending);
        }
        private void apptExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void apptAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddAppointmentForm().ShowDialog();
        }
                
        private void apptCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            FillApptDataGridView();
            selectedDate = apptCalendar.SelectionRange.Start.Date;
            table = Database.FillAppointmentView(selectedDate, radioButtonWeek.Checked);
            apptDataGridView.DataSource = table;
            formatDGV(apptDataGridView);
        }

        private void weekRadio_CheckedChanged(object sender, EventArgs e)
        {            
            selectedDate = apptCalendar.SelectionRange.Start.Date;
            table = Database.FillAppointmentView(selectedDate, true);
            apptDataGridView.DataSource = table;
            FillApptDataGridView();
            formatDGV(apptDataGridView);
        }

        private void monthRadio_CheckedChanged(object sender, EventArgs e)
        {
            selectedDate = apptCalendar.SelectionRange.Start.Date;
            table = Database.FillAppointmentView(selectedDate, false);
            apptDataGridView.DataSource = table;
            FillApptDataGridView();
            formatDGV(apptDataGridView);
        }

        private void apptDeleteButton_Click(object sender, EventArgs e)
        {
            int apptID = Convert.ToInt32(apptDataGridView.CurrentRow.Cells[0].Value);
            Database.DeleteAppointment(apptID);
            FillApptDataGridView();
            formatDGV(apptDataGridView);
        }

        private void apptUpdateButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            int appointmentID = Convert.ToInt32(apptDataGridView.CurrentRow.Cells["appointmentId"].Value);
            Appointment selectedAppointment = Database.SelectedAppointment(appointmentID);
            new UpdateAppointmentForm(selectedAppointment).ShowDialog();
            FillApptDataGridView();
        }       

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerForm().ShowDialog();
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ReportsForm().ShowDialog();
        }
    }
}
