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
    public partial class UpdateCustomerForm : Form
    {
        public UpdateCustomerForm(Customer customer)
        {
            InitializeComponent();

            updateCustomerIDBox.Text = customer.CustomerID.ToString();
            updateCustomerNameBox.Text = customer.CustomerName;
            updateCustomerAddressBox.Text = customer.Address;
            updateCustomerPhoneBox.Text = customer.Phone;
            updateCustomerCityComboBox.Text = customer.City;
            updateCustomerPostalCodeBox.Text = customer.PostalCode;
            updateCustomerActiveCheckBox.Checked = customer.Active;
        }
        //Save Button
        private void updateCustomerSaveButton_Click(object sender, EventArgs e)
        {
            if (updateCustomerNameBox.Text == "" || updateCustomerAddressBox.Text == "" || updateCustomerPhoneBox.Text == "" ||
                updateCustomerCityComboBox.Text == "" || updateCustomerPostalCodeBox.Text == "")
            {
                MessageBox.Show("Please complete all fields before saving.");
                return;
            }
            Customer updatedCustomer = new DeanKellyAppointmentApp.Customer(Convert.ToInt32(updateCustomerIDBox.Text), updateCustomerNameBox.Text, 
            updateCustomerAddressBox.Text, updateCustomerPhoneBox.Text, updateCustomerCityComboBox.Text, updateCustomerPostalCodeBox.Text, 
            updateCustomerCountryBox.Text, updateCustomerActiveCheckBox.Checked, DateTime.Now);
            updatedCustomer.AddressID = updatedCustomer.CustomerID;
            Database.UpdateCustomer(updatedCustomer);
            this.Hide();
            new CustomerForm().ShowDialog();
        }
        //Cancel Button
        private void updateCustomerCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerForm().ShowDialog();
        }

        private void updateCustomerPostalCodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (updateCustomerPostalCodeBox.Text != "")
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
        }

        private void updateCustomerPhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (updateCustomerPhoneBox.Text != "")
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
        }
    }
}
