namespace StudiesPlans.Views
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn3 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn4 = new Telerik.WinControls.UI.GridViewImageColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pages = new Telerik.WinControls.UI.RadPageView();
            this.plancreate = new Telerik.WinControls.UI.RadPageViewPage();
            this.review = new Telerik.WinControls.UI.RadPageViewPage();
            this.archive = new Telerik.WinControls.UI.RadPageViewPage();
            this.users = new Telerik.WinControls.UI.RadPageViewPage();
            this.gridUsers = new Telerik.WinControls.UI.RadGridView();
            this.gbUsers1 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnCancelEdit = new Telerik.WinControls.UI.RadButton();
            this.btnAddUser = new Telerik.WinControls.UI.RadButton();
            this.btnRolesMngmt = new System.Windows.Forms.Button();
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
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.lUserName = new Telerik.WinControls.UI.RadLabelElement();
            this.lRole = new Telerik.WinControls.UI.RadLabelElement();
            this.office2010Theme1 = new Telerik.WinControls.Themes.Office2010Theme();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.radToolStrip1 = new Telerik.WinControls.UI.RadToolStrip();
            this.radToolStripElement1 = new Telerik.WinControls.UI.RadToolStripElement();
            this.radToolStripItem1 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement1 = new Telerik.WinControls.UI.RadButtonElement();
            this.radToolStripSeparatorItem1 = new Telerik.WinControls.UI.RadToolStripSeparatorItem();
            this.radToolStripItem2 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement2 = new Telerik.WinControls.UI.RadButtonElement();
            this.radToolStripItem3 = new Telerik.WinControls.UI.RadToolStripItem();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            ((System.ComponentModel.ISupportInitialize)(this.pages)).BeginInit();
            this.pages.SuspendLayout();
            this.users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.gbUsers1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pages
            // 
            this.pages.Controls.Add(this.plancreate);
            this.pages.Controls.Add(this.review);
            this.pages.Controls.Add(this.archive);
            this.pages.Controls.Add(this.users);
            this.pages.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pages.Location = new System.Drawing.Point(0, 30);
            this.pages.Name = "pages";
            this.pages.SelectedPage = this.users;
            this.pages.Size = new System.Drawing.Size(842, 548);
            this.pages.TabIndex = 15;
            this.pages.Text = "radPageView1";
            this.pages.ThemeName = "ControlDefault";
            this.pages.SelectedPageChanged += new System.EventHandler(this.pages_SelectedPageChanged);
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.pages.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // plancreate
            // 
            this.plancreate.Location = new System.Drawing.Point(10, 37);
            this.plancreate.Name = "plancreate";
            this.plancreate.Size = new System.Drawing.Size(821, 500);
            this.plancreate.Text = "Tworzenie planu";
            // 
            // review
            // 
            this.review.Location = new System.Drawing.Point(10, 37);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(821, 489);
            this.review.Text = "Przegl¹d planu";
            // 
            // archive
            // 
            this.archive.Location = new System.Drawing.Point(10, 37);
            this.archive.Name = "archive";
            this.archive.Size = new System.Drawing.Size(821, 489);
            this.archive.Text = "Archiwum";
            // 
            // users
            // 
            this.users.Controls.Add(this.gridUsers);
            this.users.Controls.Add(this.gbUsers1);
            this.users.Location = new System.Drawing.Point(10, 37);
            this.users.Name = "users";
            this.users.Size = new System.Drawing.Size(821, 500);
            this.users.Text = "U¿ytkownicy";
            // 
            // gridUsers
            // 
            this.gridUsers.AutoSizeRows = true;
            this.gridUsers.Location = new System.Drawing.Point(3, 3);
            // 
            // gridUsers
            // 
            this.gridUsers.MasterTemplate.AllowEditRow = false;
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "Nazwa";
            gridViewTextBoxColumn5.Name = "username";
            gridViewTextBoxColumn5.Width = 110;
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Email";
            gridViewTextBoxColumn6.Name = "Email";
            gridViewTextBoxColumn6.Width = 110;
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Ostatnie logowanie";
            gridViewTextBoxColumn7.MinWidth = 8;
            gridViewTextBoxColumn7.Name = "Ostatnie logowanie";
            gridViewTextBoxColumn7.Width = 144;
            gridViewTextBoxColumn7.WrapText = true;
            gridViewTextBoxColumn8.FormatString = "";
            gridViewTextBoxColumn8.HeaderText = "Rola";
            gridViewTextBoxColumn8.Name = "Rola";
            gridViewTextBoxColumn8.Width = 100;
            gridViewImageColumn3.AllowSort = false;
            gridViewImageColumn3.DataType = typeof(System.Drawing.Image);
            gridViewImageColumn3.FormatString = "";
            gridViewImageColumn3.HeaderText = "";
            gridViewImageColumn3.Name = "column1";
            gridViewImageColumn3.Width = 25;
            gridViewImageColumn4.AllowSort = false;
            gridViewImageColumn4.DataType = typeof(System.Drawing.Image);
            gridViewImageColumn4.FormatString = "";
            gridViewImageColumn4.HeaderText = "";
            gridViewImageColumn4.Name = "column2";
            gridViewImageColumn4.Width = 25;
            this.gridUsers.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewImageColumn3,
            gridViewImageColumn4});
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridUsers.ReadOnly = true;
            // 
            // 
            // 
            this.gridUsers.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gridUsers.ShowGroupPanel = false;
            this.gridUsers.Size = new System.Drawing.Size(531, 494);
            this.gridUsers.TabIndex = 3;
            this.gridUsers.Text = "radGridView2";
            this.gridUsers.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.gridUsers_CellClick);
            // 
            // gbUsers1
            // 
            this.gbUsers1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.gbUsers1.Controls.Add(this.btnUpdate);
            this.gbUsers1.Controls.Add(this.btnCancelEdit);
            this.gbUsers1.Controls.Add(this.btnAddUser);
            this.gbUsers1.Controls.Add(this.btnRolesMngmt);
            this.gbUsers1.Controls.Add(this.lblValidation);
            this.gbUsers1.Controls.Add(this.cbRoles);
            this.gbUsers1.Controls.Add(this.tbNewEmail);
            this.gbUsers1.Controls.Add(this.tbNewRepeatPassword);
            this.gbUsers1.Controls.Add(this.tbNewPassword);
            this.gbUsers1.Controls.Add(this.tbNewUsername);
            this.gbUsers1.Controls.Add(this.txtRoleId);
            this.gbUsers1.Controls.Add(this.txtNewEmail);
            this.gbUsers1.Controls.Add(this.txtNewRepeatPassword);
            this.gbUsers1.Controls.Add(this.txtNewPassword);
            this.gbUsers1.Controls.Add(this.txtNewUsername);
            this.gbUsers1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbUsers1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbUsers1.ForeColor = System.Drawing.Color.Black;
            this.gbUsers1.Location = new System.Drawing.Point(540, 3);
            this.gbUsers1.Name = "gbUsers1";
            this.gbUsers1.Size = new System.Drawing.Size(278, 347);
            this.gbUsers1.TabIndex = 2;
            this.gbUsers1.TabStop = false;
            this.gbUsers1.Text = "Zarz¹dzanie";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(188, 293);
            this.btnUpdate.Name = "btnUpdate";
            // 
            // 
            // 
            this.btnUpdate.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(84, 48);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Zapisz zmiany";
            this.btnUpdate.TextWrap = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancelEdit
            // 
            this.btnCancelEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelEdit.Enabled = false;
            this.btnCancelEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnCancelEdit.ForeColor = System.Drawing.Color.Black;
            this.btnCancelEdit.Location = new System.Drawing.Point(97, 293);
            this.btnCancelEdit.Name = "btnCancelEdit";
            // 
            // 
            // 
            this.btnCancelEdit.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnCancelEdit.Size = new System.Drawing.Size(84, 48);
            this.btnCancelEdit.TabIndex = 16;
            this.btnCancelEdit.Text = "Anuluj edycjê";
            this.btnCancelEdit.TextWrap = true;
            this.btnCancelEdit.Click += new System.EventHandler(this.btnCancelEdit_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.btnAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Location = new System.Drawing.Point(6, 293);
            this.btnAddUser.Name = "btnAddUser";
            // 
            // 
            // 
            this.btnAddUser.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnAddUser.Size = new System.Drawing.Size(84, 48);
            this.btnAddUser.TabIndex = 15;
            this.btnAddUser.Text = "Dodaj u¿ytkownika";
            this.btnAddUser.TextWrap = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnRolesMngmt
            // 
            this.btnRolesMngmt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRolesMngmt.BackgroundImage = global::StudiesPlans.Properties.Resources.management;
            this.btnRolesMngmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRolesMngmt.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRolesMngmt.Location = new System.Drawing.Point(234, 124);
            this.btnRolesMngmt.Margin = new System.Windows.Forms.Padding(0);
            this.btnRolesMngmt.Name = "btnRolesMngmt";
            this.btnRolesMngmt.Size = new System.Drawing.Size(21, 21);
            this.btnRolesMngmt.TabIndex = 14;
            this.btnRolesMngmt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRolesMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRolesMngmt.UseVisualStyleBackColor = true;
            this.btnRolesMngmt.Click += new System.EventHandler(this.btnRolesMngmt_Click);
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
            this.txtRoleId.Size = new System.Drawing.Size(33, 13);
            this.txtRoleId.TabIndex = 4;
            this.txtRoleId.Text = "Rola:";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.AutoSize = true;
            this.txtNewEmail.Location = new System.Drawing.Point(6, 101);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(37, 13);
            this.txtNewEmail.TabIndex = 3;
            this.txtNewEmail.Text = "Email:";
            // 
            // txtNewRepeatPassword
            // 
            this.txtNewRepeatPassword.AutoSize = true;
            this.txtNewRepeatPassword.Location = new System.Drawing.Point(6, 77);
            this.txtNewRepeatPassword.Name = "txtNewRepeatPassword";
            this.txtNewRepeatPassword.Size = new System.Drawing.Size(83, 13);
            this.txtNewRepeatPassword.TabIndex = 2;
            this.txtNewRepeatPassword.Text = "Powtórz has³o:";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.AutoSize = true;
            this.txtNewPassword.Location = new System.Drawing.Point(6, 51);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(39, 13);
            this.txtNewPassword.TabIndex = 1;
            this.txtNewPassword.Text = "Has³o:";
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.AutoSize = true;
            this.txtNewUsername.Location = new System.Drawing.Point(6, 25);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.Size = new System.Drawing.Size(112, 13);
            this.txtNewUsername.TabIndex = 0;
            this.txtNewUsername.Text = "Nazwa u¿ytkownika:";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.AutoSize = true;
            this.radStatusStrip1.ForeColor = System.Drawing.Color.Black;
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.lUserName,
            this.lRole});
            this.radStatusStrip1.LayoutStyle = Telerik.WinControls.UI.RadStatusBarLayoutStyle.Stack;
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 584);
            this.radStatusStrip1.Name = "radStatusStrip1";
            // 
            // 
            // 
            this.radStatusStrip1.RootElement.ForeColor = System.Drawing.Color.Black;
            this.radStatusStrip1.Size = new System.Drawing.Size(842, 28);
            this.radStatusStrip1.SizingGrip = false;
            this.radStatusStrip1.TabIndex = 16;
            this.radStatusStrip1.Text = "radStatusStrip1";
            // 
            // lUserName
            // 
            this.lUserName.Margin = new System.Windows.Forms.Padding(1);
            this.lUserName.Name = "lUserName";
            this.radStatusStrip1.SetSpring(this.lUserName, false);
            this.lUserName.Text = "U¿ytkownik: ";
            this.lUserName.TextWrap = true;
            // 
            // lRole
            // 
            this.lRole.Margin = new System.Windows.Forms.Padding(1);
            this.lRole.Name = "lRole";
            this.radStatusStrip1.SetSpring(this.lRole, false);
            this.lRole.Text = "Rola: ";
            this.lRole.TextWrap = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 22;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 22;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 22;
            // 
            // radToolStrip1
            // 
            this.radToolStrip1.AllowDragging = false;
            this.radToolStrip1.AllowFloating = false;
            this.radToolStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radToolStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radToolStripElement1});
            this.radToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.radToolStrip1.MinimumSize = new System.Drawing.Size(5, 5);
            this.radToolStrip1.Name = "radToolStrip1";
            this.radToolStrip1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // 
            // 
            this.radToolStrip1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.radToolStrip1.RootElement.MinSize = new System.Drawing.Size(5, 5);
            this.radToolStrip1.ShowOverFlowButton = true;
            this.radToolStrip1.Size = new System.Drawing.Size(842, 29);
            this.radToolStrip1.TabIndex = 17;
            this.radToolStrip1.Text = "radToolStrip1";
            // 
            // radToolStripElement1
            // 
            this.radToolStripElement1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radToolStripItem1,
            this.radToolStripItem2,
            this.radToolStripItem3});
            this.radToolStripElement1.Name = "radToolStripElement1";
            // 
            // radToolStripItem1
            // 
            this.radToolStripItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement1,
            this.radToolStripSeparatorItem1});
            this.radToolStripItem1.Key = "0";
            this.radToolStripItem1.Name = "radToolStripItem1";
            this.radToolStripItem1.Text = "radToolStripItem1";
            // 
            // radButtonElement1
            // 
            this.radButtonElement1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement1.Name = "radButtonElement1";
            this.radButtonElement1.ShowBorder = false;
            this.radButtonElement1.Text = "but";
            this.radButtonElement1.Click += new System.EventHandler(this.radButtonElement1_Click);
            // 
            // radToolStripSeparatorItem1
            // 
            this.radToolStripSeparatorItem1.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radToolStripSeparatorItem1.MinSize = new System.Drawing.Size(2, 0);
            this.radToolStripSeparatorItem1.Name = "radToolStripSeparatorItem1";
            this.radToolStripSeparatorItem1.Text = "radToolStripSeparatorItem1";
            // 
            // radToolStripItem2
            // 
            this.radToolStripItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement2});
            this.radToolStripItem2.Key = "1";
            this.radToolStripItem2.Name = "radToolStripItem2";
            this.radToolStripItem2.Text = "radToolStripItem2";
            // 
            // radButtonElement2
            // 
            this.radButtonElement2.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement2.Name = "radButtonElement2";
            this.radButtonElement2.ShowBorder = false;
            this.radButtonElement2.Text = "but2";
            this.radButtonElement2.Click += new System.EventHandler(this.radButtonElement2_Click);
            // 
            // radToolStripItem3
            // 
            this.radToolStripItem3.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radButtonElement3});
            this.radToolStripItem3.Key = "2";
            this.radToolStripItem3.Name = "radToolStripItem3";
            this.radToolStripItem3.Text = "radToolStripItem3";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.ShowBorder = false;
            this.radButtonElement3.Text = "but 3";
            this.radButtonElement3.Click += new System.EventHandler(this.radButtonElement3_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 612);
            this.Controls.Add(this.radToolStrip1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.pages);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plany Studiów";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.pages)).EndInit();
            this.pages.ResumeLayout(false);
            this.users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.gbUsers1.ResumeLayout(false);
            this.gbUsers1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancelEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radToolStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView pages;
        private Telerik.WinControls.UI.RadPageViewPage plancreate;
        private Telerik.WinControls.UI.RadPageViewPage review;
        private Telerik.WinControls.UI.RadPageViewPage archive;
        private Telerik.WinControls.UI.RadPageViewPage users;
        private System.Windows.Forms.GroupBox gbUsers1;
        private System.Windows.Forms.Button btnRolesMngmt;
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
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement lUserName;
        private Telerik.WinControls.UI.RadLabelElement lRole;
        private Telerik.WinControls.Themes.Office2010Theme office2010Theme1;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnCancelEdit;
        private Telerik.WinControls.UI.RadButton btnAddUser;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Telerik.WinControls.UI.RadGridView gridUsers;
        private Telerik.WinControls.UI.RadToolStrip radToolStrip1;
        private Telerik.WinControls.UI.RadToolStripElement radToolStripElement1;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem1;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement1;
        private Telerik.WinControls.UI.RadToolStripSeparatorItem radToolStripSeparatorItem1;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem2;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement2;
        private Telerik.WinControls.UI.RadToolStripItem radToolStripItem3;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;

    }
}

