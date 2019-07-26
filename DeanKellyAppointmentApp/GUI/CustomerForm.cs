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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            FillCustomerGridView();
            formatDGV(customerDataGridView);
        }
        //Customer Data Grid View
        private void FillCustomerGridView()
        {
            DataTable table = Database.FillCustomerView();
            customerDataGridView.DataSource = table;            
        }
        private void formatDGV(DataGridView d)
        {
            d.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            d.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            d.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            d.RowHeadersVisible = false;
        }
        //Add Button
        private void customerAddButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AddCustomerForm().ShowDialog();
        }
        //Update Button
        private void customerUpdateButton_Click(object sender, EventArgs e)
        {
            this.Hide();            
            int customerID = Convert.ToInt32(customerDataGridView.CurrentRow.Cells["customerId"].Value);
            Customer selectedCustomer = Database.SelectedCustomer(customerID);
            new UpdateCustomerForm(selectedCustomer).ShowDialog();
            FillCustomerGridView();
        }
        //Delete Button
        private void customerDeleteButton_Click(object sender, EventArgs e)
        {
            int customerID = Convert.ToInt32(customerDataGridView.CurrentRow.Cells["customerId"].Value);
            int addressID = Convert.ToInt32(customerDataGridView.CurrentRow.Cells["addressId"].Value);
            Database.DeleteCustomer(customerID, addressID);
            FillCustomerGridView();
        }
        //Back Button
        private void customerBackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AppointmentForm().ShowDialog();
        }
        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'u04pMbDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.u04pMbDataSet.customer);
        }
    }
}
