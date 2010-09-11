namespace StudiesPlans
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managemntBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pages = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.gbUsers = new System.Windows.Forms.GroupBox();
            this.btnRolesMngmt = new System.Windows.Forms.Button();
            this.btnCancelEdit = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblValidation = new System.Windows.Forms.Label();
            this.cbRoles = new System.Windows.Forms.ComboBox();
            this.tbNewEmail = new System.Windows.Forms.TextBox();
            this.tbNewRepeatPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbNewUsername = new System.Windows.Forms.TextBox();
            this.txtRoleId = new System.Windows.Forms.Label();
            this.txtNewEmail = new System.Windows.Forms.Label();
            this.txtNewRepeatPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.Label();
            this.txtNewUsername = new System.Windows.Forms.Label();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastActiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.pages.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.gbUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 590);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(855, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(855, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.helpToolStripMenuItem.Text = "Pomoc";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.oProgramieToolStripMenuItem.Text = "O Programie";
            // 
            // managemntBtn
            // 
            this.managemntBtn.Location = new System.Drawing.Point(839, 27);
            this.managemntBtn.Name = "managemntBtn";
            this.managemntBtn.Size = new System.Drawing.Size(17, 560);
            this.managemntBtn.TabIndex = 3;
            this.managemntBtn.Text = ">";
            this.managemntBtn.UseVisualStyleBackColor = true;
            this.managemntBtn.Click += new System.EventHandler(this.managementBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(862, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 355);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(130, 17);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 69);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(130, 69);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 100);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.pages.Controls.Add(this.tabPage1);
            this.pages.Controls.Add(this.tabPage2);
            this.pages.Controls.Add(this.tabPage3);
            this.pages.Controls.Add(this.tabPage4);
            this.pages.Controls.Add(this.tabPage5);
            this.pages.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.pages.ItemSize = new System.Drawing.Size(40, 100);
            this.pages.Location = new System.Drawing.Point(0, 27);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(833, 560);
            this.pages.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.pages.TabIndex = 6;
            this.pages.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl_DrawItem);
            this.pages.SelectedIndexChanged += new System.EventHandler(this.pages_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(104, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(725, 552);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Przedmioty";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(104, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(725, 552);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tworzenie planu";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(104, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(725, 552);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Podgląd planu";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(104, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(725, 552);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Archiwum";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.gbUsers);
            this.tabPage5.Controls.Add(this.gridUsers);
            this.tabPage5.Location = new System.Drawing.Point(104, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(725, 552);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Użytkownicy";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // gbUsers
            // 
            this.gbUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gbUsers.Controls.Add(this.btnRolesMngmt);
            this.gbUsers.Controls.Add(this.btnCancelEdit);
            this.gbUsers.Controls.Add(this.btnAddUser);
            this.gbUsers.Controls.Add(this.btnUpdate);
            this.gbUsers.Controls.Add(this.lblValidation);
            this.gbUsers.Controls.Add(this.cbRoles);
            this.gbUsers.Controls.Add(this.tbNewEmail);
            this.gbUsers.Controls.Add(this.tbNewRepeatPassword);
            this.gbUsers.Controls.Add(this.tbNewPassword);
            this.gbUsers.Controls.Add(this.tbNewUsername);
            this.gbUsers.Controls.Add(this.txtRoleId);
            this.gbUsers.Controls.Add(this.txtNewEmail);
            this.gbUsers.Controls.Add(this.txtNewRepeatPassword);
            this.gbUsers.Controls.Add(this.txtNewPassword);
            this.gbUsers.Controls.Add(this.txtNewUsername);
            this.gbUsers.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbUsers.ForeColor = System.Drawing.Color.Black;
            this.gbUsers.Location = new System.Drawing.Point(456, 3);
            this.gbUsers.Name = "gbUsers";
            this.gbUsers.Size = new System.Drawing.Size(266, 311);
            this.gbUsers.TabIndex = 1;
            this.gbUsers.TabStop = false;
            this.gbUsers.Text = "Zarządzanie";
            // 
            // btnRolesMngmt
            // 
            this.btnRolesMngmt.Image = global::StudiesPlans.Properties.Resources.management;
            this.btnRolesMngmt.Location = new System.Drawing.Point(234, 124);
            this.btnRolesMngmt.Margin = new System.Windows.Forms.Padding(0);
            this.btnRolesMngmt.Name = "btnRolesMngmt";
            this.btnRolesMngmt.Size = new System.Drawing.Size(25, 25);
            this.btnRolesMngmt.TabIndex = 14;
            this.btnRolesMngmt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRolesMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolesMngmt.UseVisualStyleBackColor = true;
            this.btnRolesMngmt.Click += new System.EventHandler(this.btnRolesMngmt_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Location = new System.Drawing.Point(92, 257);
            this.btnCancelEdit.Name = "btnCancelEdit";
            this.btnCancelEdit.Size = new System.Drawing.Size(80, 48);
            this.btnCancelEdit.TabIndex = 13;
            this.btnCancelEdit.Text = "Anuluj edycję";
            this.btnCancelEdit.UseVisualStyleBackColor = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(6, 257);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(80, 48);
            this.btnAddUser.TabIndex = 12;
            this.btnAddUser.Text = "Dodaj użytkownika";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(178, 257);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 48);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Zapisz zmiany";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(6, 151);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(0, 13);
            this.lblValidation.TabIndex = 10;
            // 
            // cbRoles
            // 
            this.cbRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoles.FormattingEnabled = true;
            this.cbRoles.Location = new System.Drawing.Point(117, 124);
            this.cbRoles.Name = "cbRoles";
            this.cbRoles.Size = new System.Drawing.Size(114, 21);
            this.cbRoles.TabIndex = 9;
            // 
            // tbNewEmail
            // 
            this.tbNewEmail.Location = new System.Drawing.Point(117, 98);
            this.tbNewEmail.Name = "tbNewEmail";
            this.tbNewEmail.Size = new System.Drawing.Size(143, 20);
            this.tbNewEmail.TabIndex = 8;
            // 
            // tbNewRepeatPassword
            // 
            this.tbNewRepeatPassword.Location = new System.Drawing.Point(117, 74);
            this.tbNewRepeatPassword.Name = "tbNewRepeatPassword";
            this.tbNewRepeatPassword.Size = new System.Drawing.Size(143, 20);
            this.tbNewRepeatPassword.TabIndex = 7;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(117, 48);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(143, 20);
            this.tbNewPassword.TabIndex = 6;
            // 
            // tbNewUsername
            // 
            this.tbNewUsername.Location = new System.Drawing.Point(117, 22);
            this.tbNewUsername.Name = "tbNewUsername";
            this.tbNewUsername.Size = new System.Drawing.Size(143, 20);
            this.tbNewUsername.TabIndex = 5;
            // 
            // txtRoleId
            // 
            this.txtRoleId.AutoSize = true;
            this.txtRoleId.Location = new System.Drawing.Point(6, 127);
            this.txtRoleId.Name = "txtRoleId";
            this.txtRoleId.Size = new System.Drawing.Size(32, 13);
            this.txtRoleId.TabIndex = 4;
            this.txtRoleId.Text = "Rola:";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.AutoSize = true;
            this.txtNewEmail.Location = new System.Drawing.Point(6, 101);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(35, 13);
            this.txtNewEmail.TabIndex = 3;
            this.txtNewEmail.Text = "Email:";
            // 
            // txtNewRepeatPassword
            // 
            this.txtNewRepeatPassword.AutoSize = true;
            this.txtNewRepeatPassword.Location = new System.Drawing.Point(6, 77);
            this.txtNewRepeatPassword.Name = "txtNewRepeatPassword";
            this.txtNewRepeatPassword.Size = new System.Drawing.Size(78, 13);
            this.txtNewRepeatPassword.TabIndex = 2;
            this.txtNewRepeatPassword.Text = "Powtórz hasło:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AutoSize = true;
            this.txtNewPassword.Location = new System.Drawing.Point(6, 51);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(39, 13);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Text = "Hasło:";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.AutoSize = true;
            this.txtNewUsername.Location = new System.Drawing.Point(6, 25);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(105, 13);
            this.txtNewUsername.TabIndex = 0;
            this.txtNewUsername.Text = "Nazwa użytkownika:";
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gridUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.username,
            this.email,
            this.lastActiveDate,
            this.role,
            this.edit,
            this.Column1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUsers.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridUsers.Location = new System.Drawing.Point(3, 10);
            this.gridUsers.MultiSelect = false;
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.RowHeadersVisible = false;
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(447, 539);
            this.gridUsers.TabIndex = 0;
            this.gridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsers_CellClick);
            // 
            // username
            // 
            this.username.HeaderText = "Nazwa";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // lastActiveDate
            // 
            this.lastActiveDate.HeaderText = "Ostatnie logowanie";
            this.lastActiveDate.Name = "lastActiveDate";
            this.lastActiveDate.ReadOnly = true;
            // 
            // role
            // 
            this.role.HeaderText = "Rola";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // edit
            // 
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 22;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.MinimumWidth = 22;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 22;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 22;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 22;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 22;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Width = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 612);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.managemntBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plany Studiów";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.pages.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.gbUsers.ResumeLayout(false);
            this.gbUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.Button managemntBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl pages;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.GroupBox gbUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastActiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.ComboBox cbRoles;
        private System.Windows.Forms.TextBox tbNewEmail;
        private System.Windows.Forms.TextBox tbNewRepeatPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbNewUsername;
        private System.Windows.Forms.Label txtRoleId;
        private System.Windows.Forms.Label txtNewEmail;
        private System.Windows.Forms.Label txtNewRepeatPassword;
        private System.Windows.Forms.Label txtNewPassword;
        private System.Windows.Forms.Label txtNewUsername;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnCancelEdit;
        private System.Windows.Forms.Button btnRolesMngmt;
    }
}

