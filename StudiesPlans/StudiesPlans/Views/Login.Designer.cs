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
            this.components = new System.ComponentModel.Container();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.bCancel = new Telerik.WinControls.UI.RadButton();
            this.ellipseShape1 = new Telerik.WinControls.EllipseShape();
            this.bLogin = new Telerik.WinControls.UI.RadButton();
            this.lErrors = new System.Windows.Forms.Label();
            this.tPassword = new System.Windows.Forms.TextBox();
            this.tUsername = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.lUsername = new System.Windows.Forms.Label();
            this.roundRectShape1 = new Telerik.WinControls.RoundRectShape(this.components);
            this.qaShape1 = new Telerik.WinControls.Tests.QAShape();
            this.donutShape1 = new Telerik.WinControls.Tests.DonutShape();
            this.mediaShape1 = new Telerik.WinControls.Tests.MediaShape();
            this.customShape1 = new Telerik.WinControls.OldShapeEditor.CustomShape();
            this.gbLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogin.Controls.Add(this.bCancel);
            this.gbLogin.Controls.Add(this.bLogin);
            this.gbLogin.Controls.Add(this.lErrors);
            this.gbLogin.Controls.Add(this.tPassword);
            this.gbLogin.Controls.Add(this.tUsername);
            this.gbLogin.Controls.Add(this.lPassword);
            this.gbLogin.Controls.Add(this.lUsername);
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(296, 149);
            this.gbLogin.TabIndex = 1;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Podaj dane";
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCancel.ForeColor = System.Drawing.Color.Black;
            this.bCancel.Location = new System.Drawing.Point(163, 111);
            this.bCancel.Name = "bCancel";
            // 
            // 
            // 
            this.bCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.bCancel.RootElement.Shape = this.roundRectShape1;
            this.bCancel.Size = new System.Drawing.Size(95, 32);
            this.bCancel.TabIndex = 8;
            this.bCancel.Text = "Anuluj";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.bCancel.GetChildAt(0))).Text = "Anuluj";
            ((Telerik.WinControls.UI.RadButtonElement)(this.bCancel.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // bLogin
            // 
            this.bLogin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bLogin.ForeColor = System.Drawing.Color.Black;
            this.bLogin.Location = new System.Drawing.Point(42, 111);
            this.bLogin.Name = "bLogin";
            // 
            // 
            // 
            this.bLogin.RootElement.ForeColor = System.Drawing.Color.Black;
            this.bLogin.RootElement.ShouldPaint = false;
            this.bLogin.RootElement.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.bLogin.Size = new System.Drawing.Size(95, 32);
            this.bLogin.TabIndex = 7;
            this.bLogin.Text = "Zaloguj";
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.bLogin.GetChildAt(0))).Text = "Zaloguj";
            ((Telerik.WinControls.UI.RadButtonElement)(this.bLogin.GetChildAt(0))).Shape = this.roundRectShape1;
            // 
            // lErrors
            // 
            this.lErrors.AutoSize = true;
            this.lErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lErrors.ForeColor = System.Drawing.Color.Red;
            this.lErrors.Location = new System.Drawing.Point(6, 77);
            this.lErrors.Name = "lErrors";
            this.lErrors.Size = new System.Drawing.Size(0, 13);
            this.lErrors.TabIndex = 6;
            // 
            // tPassword
            // 
            this.tPassword.Location = new System.Drawing.Point(123, 49);
            this.tPassword.Name = "tPassword";
            this.tPassword.Size = new System.Drawing.Size(159, 20);
            this.tPassword.TabIndex = 3;
            this.tPassword.UseSystemPasswordChar = true;
            this.tPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tPassword_KeyDown);
            // 
            // tUsername
            // 
            this.tUsername.Location = new System.Drawing.Point(123, 23);
            this.tUsername.Name = "tUsername";
            this.tUsername.Size = new System.Drawing.Size(159, 20);
            this.tUsername.TabIndex = 2;
            this.tUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tUsername_KeyDown);
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(6, 52);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(39, 13);
            this.lPassword.TabIndex = 1;
            this.lPassword.Text = "Has³o:";
            // 
            // lUsername
            // 
            this.lUsername.AutoSize = true;
            this.lUsername.Location = new System.Drawing.Point(6, 26);
            this.lUsername.Name = "lUsername";
            this.lUsername.Size = new System.Drawing.Size(112, 13);
            this.lUsername.TabIndex = 0;
            this.lUsername.Text = "Nazwa u¿ytkownika:";
            // 
            // customShape1
            // 
            this.customShape1.Dimension = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 173);
            this.Controls.Add(this.gbLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ThemeName = "ControlDefault";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private Telerik.WinControls.UI.RadButton bCancel;
        private Telerik.WinControls.UI.RadButton bLogin;
        private System.Windows.Forms.Label lErrors;
        private System.Windows.Forms.TextBox tPassword;
        private System.Windows.Forms.TextBox tUsername;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label lUsername;
        private Telerik.WinControls.EllipseShape ellipseShape1;
        private Telerik.WinControls.RoundRectShape roundRectShape1;
        private Telerik.WinControls.Tests.QAShape qaShape1;
        private Telerik.WinControls.Tests.DonutShape donutShape1;
        private Telerik.WinControls.Tests.MediaShape mediaShape1;
        private Telerik.WinControls.OldShapeEditor.CustomShape customShape1;
    }
}

