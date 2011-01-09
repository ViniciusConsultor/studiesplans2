using System;
using System.Data.Objects.DataClasses;
using System.Text;
using System.Windows.Forms;
using StudiesPlansModels.Models;
using StudiesPlans.Controllers;
using System.Security.Cryptography;
using Telerik.WinControls.Enumerations;

namespace StudiesPlans.Views
{
    public partial class Login : Telerik.WinControls.UI.RadForm
    {
        private bool _anonymous { get; set; }

        public Login()
        {
            _anonymous = false;
            InitializeComponent();
            ShowButtonsToolTips();
        }

        private void ShowButtonsToolTips()
        {
            bLogin.ButtonElement.ToolTipText = "Zaloguj siê";
            bCancel.ButtonElement.ToolTipText = "Zamknij";
        }

         // Login button event
        private void bLogin_Click(object sender, EventArgs e)
        {
            if (!_anonymous)
            {
                lErrors.Text = "";

                UserLogin login = new UserLogin()
                                      {
                                          UserName = tUsername.Text,
                                          Password = tPassword.Text
                                      };

                // if user is valid and exists in databse
                if (AccountController.Instance.LoginUser(ref login))
                {
                    UserLastActive updateActive = new UserLastActive()
                                                      {
                                                          LastActiveDate = DateTime.Now,
                                                          UserID = login.UserId
                                                      };

                    //set new last login time
                    AccountController.Instance.UpdateLastActiveUser(updateActive);
                    StudiesPlans.Program.user = AccountController.Instance.GetUser(login);
                    this.DialogResult = DialogResult.OK;
                }
                else // if user is not valid show errors
                    foreach (string error in login.Errors)
                        lErrors.Text += error + "\n";
            }
            else
            {
                User u = new User()
                             {
                                 Name = "Anonim",
                                 Role = new Role()
                                            {
                                                Name = "Anonim"
                                            }
                             };
                Privilage p = RoleController.Instance.GetPrivilage("Przegl¹danie");
                u.Role.Privilages.Add(p);
                StudiesPlans.Program.user = u;
                this.DialogResult = DialogResult.OK;
            }
        }

        // Cancel button event
        private void bCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Enter pressed
        private void tUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                this.bLogin_Click(this, null);
        }

        // Enter pressed
        private void tPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
                this.bLogin_Click(this, null);
        }

        private void cbAnnymous_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if(args.ToggleState == ToggleState.On)
            {
                _anonymous = true;
                this.tUsername.Enabled = false;
                this.tPassword.Enabled = false;
            }
            else
            {
                _anonymous = false;
                this.tUsername.Enabled = true;
                this.tPassword.Enabled = true;
            }
        }
    }
    
}
