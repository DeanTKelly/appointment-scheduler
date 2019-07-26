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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }       
        //Save Button
        private void addCustomerSaveButton_Click(object sender, EventArgs e)
        {
            if (addCustomerNameBox.Text == "" || addCustomerAddressBox.Text == "" || addCustomerPhoneBox.Text == "")
            {
                MessageBox.Show("Please complete all fields.");
                return;
            }
            string country = "";
            switch (addCustomerCityComboBox.Text)
            {
                case "Phoenix":
                    country = "USA";
                    break;
                case "New York":
                    country = "USA";
                    break;
                case "London":
                    country = "England";
                    break;
            }
            Customer newCust = new Customer()
            {
                CustomerName = addCustomerNameBox.Text,
                Address = addCustomerAddressBox.Text,
                City = addCustomerCityComboBox.Text,
                CityID = Database.GetCityIdByCity(addCustomerCityComboBox.Text),
                Phone = addCustomerPhoneBox.Text,
                PostalCode = addCustomerPostalCodeBox.Text,
                Country = country,
                CountryID = Database.GetCountryIdByCountry(country),
                Active = addCustomerActiveCheckBox.Checked,
            };
            Database.AddNewCustomer(newCust);
            this.Hide();
            new CustomerForm().ShowDialog();
        }
        //Cancel Button
        private void addCustomerCancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CustomerForm().ShowDialog();
        }
        
        private void addCustomerPostalCodeBox_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
        }

        private void addCustomerPhoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }
        }
    }
}
