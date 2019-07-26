using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Resources;
using System.Globalization;
using System.Threading;
using System.Reflection;
using System.IO;

namespace DeanKellyAppointmentApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }       
        private void loginLogInButton_Click(object sender, EventArgs e)
        {
            using (MySqlCommand getUserCommand = new MySqlCommand("SELECT COUNT(*) FROM user WHERE userName = @username AND password = @password", Database.con))
            {
                string userName = loginUsernameTextBox.Text;
                string password = loginPasswordTextBox.Text;
                Database.OpenDatabase();
                getUserCommand.Parameters.AddWithValue("@username", loginUsernameTextBox.Text);
                getUserCommand.Parameters.AddWithValue("@password", loginPasswordTextBox.Text);
                int userCount = Convert.ToInt32(getUserCommand.ExecuteScalar());
                if (userCount > 0)
                {
                    using (StreamWriter streamWriter = new StreamWriter("userlogins.txt", append: true))
                    {
                        streamWriter.WriteLine("User Name: " + loginUsernameTextBox.Text + " Login Time:" + DateTime.Now.ToString());
                    }

                        this.Hide();
                    new AppointmentForm().ShowDialog();                    
                }
                else
                {
                    MessageBox.Show(GlobalStrings.MessageBoxText);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("username.txt"))
            {
                using (StreamReader streamReader = new StreamReader("username.txt"))
                {
                    loginUsernameTextBox.Text = streamReader.ReadLine();
                }
            }
        }
    }
}
