namespace StudiesPlans.Views
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.lErrors = new System.Windows.Forms.Label();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogin.Controls.Add(this.lErrors);
            this.gbLogin.Controls.Add(this.bCancel);
            this.gbLogin.Controls.Add(this.bLogin);
            this.gbLogin.Controls.Add(this.tPassword);
            this.gbLogin.Controls.Add(this.tUsername);
            this.gbLogin.Controls.Add(this.lPassword);
            this.gbLogin.Controls.Add(this.lUsername);
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(288, 149);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Podaj dane";
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(147, 120);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(135, 23);
            this.bCancel.TabIndex = 5;
            this.bCancel.Text = "Anuluj";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(6, 120);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(135, 23);
            this.bLogin.TabIndex = 4;
            this.bLogin.Text = "Zaloguj";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(123, 83);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(159, 20);
            this.tPassword.TabIndex = 3;
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(123, 50);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(159, 20);
            this.tUsername.TabIndex = 2;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(6, 86);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(39, 13);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Hasło:";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(6, 53);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(105, 13);
            this.lUsername.TabIndex = 0;
            this.lUsername.Text = "Nazwa użytkownika:";
            // 
            // lErrors
            // 
            this.lErrors.AutoSize = true;
            this.lErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lErrors.ForeColor = System.Drawing.Color.Red;
            this.lErrors.Location = new System.Drawing.Point(6, 16);
            this.lErrors.Name = "lErrors";
            this.lErrors.Size = new System.Drawing.Size(0, 13);
            this.lErrors.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 173);
            this.Controls.Add(this.gbLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zaloguj się";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lUsername;
        private System.Windows.Forms.Label lErrors;
    }
}