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
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        private void reportsBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AppointmentForm().ShowDialog();
        }

        private void scheduleReport_Click(object sender, EventArgs e)
        {
            FillScheduleGridView();
            formatscheduleDGV(dataGridView1);
        }

        private void customerApptReport_Click(object sender, EventArgs e)
        {
            FillCustomerReport();
            formatDGV(dataGridView1);
        }

        private void apptTypeReport_Click(object sender, EventArgs e)
        {
            FillTypeReport();
            formatDGV(dataGridView1);
        }
        private void FillScheduleGridView()
        {
            DataTable table = Database.FillScheduleReport();
            dataGridView1.DataSource = null;
            dataGridView1.DataMember = "";
            dataGridView1.DataSource = table;
        }
        private void FillTypeReport()
        {
            DataTable table = Database.FillTypeReport();
            dataGridView1.DataSource = table;
        }
        private void FillCustomerReport()
        {
            DataTable table = Database.FillUSCustomerReport();
            dataGridView1.DataSource = table;
        }
        private void formatscheduleDGV(DataGridView d)
        {
            d.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
            d.Sort(d.Columns["appointmentId"], ListSortDirection.Ascending);
        }
        private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
        }
    }
}
