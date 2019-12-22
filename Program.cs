using Project_Management_System.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_System
{
    static class Program
    {
        public static readonly DBMS dbms = new DBMS();
        
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.ApplicationExit += Application_Exit;

            var t = dbms.GetAllEmployees();
            var tCapacity = t.Capacity;
            MessageBox.Show("developer note: database not integerated yet.");
            //dbms.OpenConnection();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmProject());
        }

        private static void Application_Exit(object sender, EventArgs e)
        {
            dbms.CloseConnection();
        }
    }
}
