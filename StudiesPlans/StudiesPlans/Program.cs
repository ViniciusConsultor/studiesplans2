using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StudiesPlans.Views;
using StudiesPlansModels.Models;

namespace StudiesPlans
{
    static class Program
    {
        public static User user = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            //Privilage p = new Privilage()
            //{
            //    Name = "Edycja"
            //};
            //List<Privilage> pp = new List<Privilage>();
            //pp.Add(p);
            //Role r = new Role()
            //{
            //    Name = "a",
            //};
            //r.Privilages.Add(p);
            
            //user = new User()
            //{
            //    Name = "Administrator",
            //    Role = r
            //};
            if (login.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm(user));
            }
        }
    }
}
