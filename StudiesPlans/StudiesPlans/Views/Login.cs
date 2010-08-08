﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudiesPlans.Models;
using StudiesPlans.Controllers;
using System.Security.Cryptography;

namespace StudiesPlans.Views
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // Login button event
        private void bLogin_Click(object sender, EventArgs e)
        {
            lErrors.Text = "";

            UserLogin login = new UserLogin()
            {
                UserName = tUsername.Text,
                Password = tPassword.Text
            };

            // if user is valid and exists in databse
            if (AccountController.Instance.LoginUser(ref login) != null)
            {
                new MainForm().Show();
                this.Hide();
            }
            else
                foreach (string error in login.GetErrors())
                    lErrors.Text += error + "\n";
        }

        // Cancel button event
        private void bCancel_Click(object sender, EventArgs e)
        {
            tPassword.Text += "Addherepostfix";

            Encoder enc = System.Text.Encoding.Unicode.GetEncoder();
            byte[] unicodeText = new byte[tPassword.Text.Length * 2];
            enc.GetBytes(tPassword.Text.ToCharArray(), 0, tPassword.Text.Length, unicodeText, 0, true);

            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(unicodeText);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
                sb.Append(result[i].ToString("X2"));

            lErrors.Text = sb.ToString();

            //this.Close();
        }
    }
}