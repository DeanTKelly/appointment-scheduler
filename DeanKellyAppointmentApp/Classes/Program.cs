using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;

namespace DeanKellyAppointmentApp
{
    static class Program
    {       
    
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
        static void Main()
        {
            //Changes region to German for quick testing purposes
            //Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("de");
            //Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
