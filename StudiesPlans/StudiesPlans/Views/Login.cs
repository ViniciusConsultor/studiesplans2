using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudiesPlans.Models;

namespace StudiesPlans.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            lErrors.Text = "";

            UserLogin login = new UserLogin()
            {
                UserName = tUsername.Text,
                Password = tPassword.Text
            };

            // TODO - Loging using data from DB
            if (login.IsValid())
            {
                new MainForm().Show();
                this.Hide();
            }
            else 
                foreach(string error in login.GetErrors())
                    lErrors.Text += error + "\n";
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
