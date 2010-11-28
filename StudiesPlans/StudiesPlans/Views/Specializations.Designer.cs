namespace StudiesPlans.Views
{
    partial class Specializations
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
            this.listSpecializations = new Telerik.WinControls.UI.RadListControl();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnFacultiesManagement = new Telerik.WinControls.UI.RadButton();
            this.btnDepartamentsMngmt = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.lstFaculties = new Telerik.WinControls.UI.RadDropDownList();
            this.lstDepartaments = new Telerik.WinControls.UI.RadDropDownList();
            this.lblValidation = new Telerik.WinControls.UI.RadLabel();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.tbNewSpecializationName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listSpecializations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacultiesManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartamentsMngmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstFaculties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDepartaments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewSpecializationName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // listSpecializations
            // 
            this.listSpecializations.CaseSensitiveSort = true;
            this.listSpecializations.Location = new System.Drawing.Point(13, 13);
            this.listSpecializations.Name = "listSpecializations";
            this.listSpecializations.Size = new System.Drawing.Size(189, 252);
            this.listSpecializations.TabIndex = 5;
            this.listSpecializations.Text = "radListControl1";
            this.listSpecializations.DoubleClick += new System.EventHandler(this.listSpecializations_DoubleClick);
            ((Telerik.WinControls.UI.RadListElement)(this.listSpecializations.GetChildAt(0))).CaseSensitiveSort = true;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.tbNewSpecializationName);
            this.radGroupBox1.Controls.Add(this.btnFacultiesManagement);
            this.radGroupBox1.Controls.Add(this.btnDepartamentsMngmt);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.lstFaculties);
            this.radGroupBox1.Controls.Add(this.lstDepartaments);
            this.radGroupBox1.Controls.Add(this.lblValidation);
            this.radGroupBox1.Controls.Add(this.btnDelete);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnAdd);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Zarządzanie";
            this.radGroupBox1.Location = new System.Drawing.Point(208, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(268, 262);
            this.radGroupBox1.TabIndex = 6;
            this.radGroupBox1.Text = "Zarządzanie";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            // 
            // btnFacultiesManagement
            // 
            this.btnFacultiesManagement.BackgroundImage = global::StudiesPlans.Properties.Resources.management;
            this.btnFacultiesManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacultiesManagement.Image = global::StudiesPlans.Properties.Resources.management;
            this.btnFacultiesManagement.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFacultiesManagement.Location = new System.Drawing.Point(66, 90);
            this.btnFacultiesManagement.Name = "btnFacultiesManagement";
            this.btnFacultiesManagement.Size = new System.Drawing.Size(20, 20);
            this.btnFacultiesManagement.TabIndex = 22;
            this.btnFacultiesManagement.Click += new System.EventHandler(this.btnFacultiesManagement_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnFacultiesManagement.GetChildAt(0))).Image = global::StudiesPlans.Properties.Resources.management;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnFacultiesManagement.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDepartamentsMngmt
            // 
            this.btnDepartamentsMngmt.BackgroundImage = global::StudiesPlans.Properties.Resources.management;
            this.btnDepartamentsMngmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepartamentsMngmt.Image = global::StudiesPlans.Properties.Resources.management;
            this.btnDepartamentsMngmt.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDepartamentsMngmt.Location = new System.Drawing.Point(66, 64);
            this.btnDepartamentsMngmt.Name = "btnDepartamentsMngmt";
            this.btnDepartamentsMngmt.Size = new System.Drawing.Size(20, 20);
            this.btnDepartamentsMngmt.TabIndex = 22;
            this.btnDepartamentsMngmt.Click += new System.EventHandler(this.btnDepartamentsMngmt_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDepartamentsMngmt.GetChildAt(0))).Image = global::StudiesPlans.Properties.Resources.management;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDepartamentsMngmt.GetChildAt(0))).ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 92);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(52, 18);
            this.radLabel2.TabIndex = 26;
            this.radLabel2.Text = "Kierunek:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 66);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(48, 18);
            this.radLabel1.TabIndex = 25;
            this.radLabel1.Text = "Wydział:";
            // 
            // lstFaculties
            // 
            this.lstFaculties.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.lstFaculties.Location = new System.Drawing.Point(92, 90);
            this.lstFaculties.Name = "lstFaculties";
            this.lstFaculties.Size = new System.Drawing.Size(163, 20);
            this.lstFaculties.TabIndex = 24;
            // 
            // lstDepartaments
            // 
            this.lstDepartaments.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.lstDepartaments.Location = new System.Drawing.Point(92, 64);
            this.lstDepartaments.Name = "lstDepartaments";
            this.lstDepartaments.Size = new System.Drawing.Size(163, 20);
            this.lstDepartaments.TabIndex = 23;
            this.lstDepartaments.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.lstDepartaments_SelectedIndexChanged);
            // 
            // lblValidation
            // 
            this.lblValidation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(16, 125);
            this.lblValidation.Name = "lblValidation";
            // 
            // 
            // 
            this.lblValidation.RootElement.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Size = new System.Drawing.Size(2, 2);
            this.lblValidation.TabIndex = 22;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(199, 216);
            this.btnDelete.Name = "btnDelete";
            // 
            // 
            // 
            this.btnDelete.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(57, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(136, 216);
            this.btnSave.Name = "btnSave";
            // 
            // 
            // 
            this.btnSave.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(57, 33);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Zapisz";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(73, 216);
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(57, 33);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(10, 216);
            this.btnAdd.Name = "btnAdd";
            // 
            // 
            // 
            this.btnAdd.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(57, 33);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbNewSpecializationName
            // 
            this.tbNewSpecializationName.Location = new System.Drawing.Point(92, 38);
            this.tbNewSpecializationName.Name = "tbNewSpecializationName";
            this.tbNewSpecializationName.Size = new System.Drawing.Size(163, 20);
            this.tbNewSpecializationName.TabIndex = 27;
            this.tbNewSpecializationName.TabStop = false;
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 40);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(42, 18);
            this.radLabel3.TabIndex = 26;
            this.radLabel3.Text = "Nazwa:";
            // 
            // Specializations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 277);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.listSpecializations);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Specializations";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarządzanie specjalnościami";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Specializations_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listSpecializations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFacultiesManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartamentsMngmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstFaculties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstDepartaments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewSpecializationName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl listSpecializations;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel lblValidation;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList lstFaculties;
        private Telerik.WinControls.UI.RadDropDownList lstDepartaments;
        private Telerik.WinControls.UI.RadButton btnFacultiesManagement;
        private Telerik.WinControls.UI.RadButton btnDepartamentsMngmt;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox tbNewSpecializationName;
    }
}

