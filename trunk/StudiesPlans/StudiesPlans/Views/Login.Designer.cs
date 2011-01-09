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
            this.gbLogin = new Telerik.WinControls.UI.RadGroupBox();
            this.tPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.tUsername = new Telerik.WinControls.UI.RadTextBox();
            this.bCancel = new Telerik.WinControls.UI.RadButton();
            this.bLogin = new Telerik.WinControls.UI.RadButton();
            this.lErrors = new System.Windows.Forms.Label();
            this.cbAnnymous = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gbLogin)).BeginInit();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAnnymous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Controls.Add(this.radLabel3);
            this.gbLogin.Controls.Add(this.cbAnnymous);
            this.gbLogin.Controls.Add(this.tPassword);
            this.gbLogin.Controls.Add(this.radLabel2);
            this.gbLogin.Controls.Add(this.radLabel1);
            this.gbLogin.Controls.Add(this.tUsername);
            this.gbLogin.Controls.Add(this.bCancel);
            this.gbLogin.Controls.Add(this.bLogin);
            this.gbLogin.Controls.Add(this.lErrors);
            this.gbLogin.FooterImageIndex = -1;
            this.gbLogin.FooterImageKey = "";
            this.gbLogin.HeaderImageIndex = -1;
            this.gbLogin.HeaderImageKey = "";
            this.gbLogin.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.gbLogin.HeaderText = "Zaloguj siê";
            this.gbLogin.Location = new System.Drawing.Point(12, 3);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.gbLogin.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.gbLogin.Size = new System.Drawing.Size(240, 167);
            this.gbLogin.TabIndex = 2;
            this.gbLogin.Text = "Zaloguj siê";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.gbLogin.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.gbLogin.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(71, 49);
            this.tPassword.Name = "tPassword";
            this.tPassword.PasswordChar = '*';
            this.tPassword.Size = new System.Drawing.Size(158, 20);
            this.tPassword.TabIndex = 1;
            this.tPassword.TabStop = false;
            this.tPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tPassword_KeyDown);
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 51);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(37, 18);
            this.radLabel2.TabIndex = 18;
            this.radLabel2.Text = "Has³o:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(34, 18);
            this.radLabel1.TabIndex = 17;
            this.radLabel1.Text = "Login";
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(71, 23);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(158, 20);
            this.tUsername.TabIndex = 0;
            this.tUsername.TabStop = false;
            this.tUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tUsername_KeyDown);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.Black;
            this.bCancel.Location = new System.Drawing.Point(134, 130);
            this.bCancel.Name = "bCancel";
            // 
            // 
            // 
            this.bCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.bCancel.Size = new System.Drawing.Size(95, 24);
            this.bCancel.TabIndex = 3;
            this.bCancel.Text = "Zamknij";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.bCancel.GetChildAt(0))).Text = "Zamknij";
            // 
            // bLogin
            // 
            this.bLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLogin.ForeColor = System.Drawing.Color.Black;
            this.bLogin.Location = new System.Drawing.Point(12, 130);
            this.bLogin.Name = "bLogin";
            // 
            // 
            // 
            this.bLogin.RootElement.ForeColor = System.Drawing.Color.Black;
            this.bLogin.RootElement.ShouldPaint = false;
            this.bLogin.RootElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bLogin.Size = new System.Drawing.Size(95, 24);
            this.bLogin.TabIndex = 2;
            this.bLogin.Text = "Zaloguj";
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.bLogin.GetChildAt(0))).Text = "Zaloguj";
            // 
            // lErrors
            // 
            this.lErrors.AutoSize = true;
            this.lErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lErrors.ForeColor = System.Drawing.Color.Red;
            this.lErrors.Location = new System.Drawing.Point(13, 96);
            this.lErrors.Name = "lErrors";
            this.lErrors.Size = new System.Drawing.Size(0, 13);
            this.lErrors.TabIndex = 12;
            // 
            // cbAnnymous
            // 
            this.cbAnnymous.Location = new System.Drawing.Point(71, 75);
            this.cbAnnymous.Name = "cbAnnymous";
            this.cbAnnymous.Size = new System.Drawing.Size(15, 15);
            this.cbAnnymous.TabIndex = 19;
            this.cbAnnymous.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.cbAnnymous.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.cbAnnymous_ToggleStateChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 75);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(48, 18);
            this.radLabel3.TabIndex = 20;
            this.radLabel3.Text = "Anonim:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 182);
            this.Controls.Add(this.gbLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.gbLogin)).EndInit();
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbAnnymous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox gbLogin;
        private Telerik.WinControls.UI.RadTextBox tPassword;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox tUsername;
        private Telerik.WinControls.UI.RadButton bCancel;
        private Telerik.WinControls.UI.RadButton bLogin;
        private System.Windows.Forms.Label lErrors;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadCheckBox cbAnnymous;

    }
}

