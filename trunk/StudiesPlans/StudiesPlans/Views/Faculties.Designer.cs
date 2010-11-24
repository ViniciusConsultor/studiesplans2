namespace StudiesPlans.Views
{
    partial class Faculties
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
            this.listFaculties = new Telerik.WinControls.UI.RadListControl();
            this.groupManagement = new Telerik.WinControls.UI.RadGroupBox();
            this.btnDepartamentsMngmt = new Telerik.WinControls.UI.RadButton();
            this.lblValidation = new Telerik.WinControls.UI.RadLabel();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAddFaculty = new Telerik.WinControls.UI.RadButton();
            this.tbNewFacultyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clbDepartaments = new System.Windows.Forms.CheckedListBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.cbDepartamentFilter = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.listFaculties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupManagement)).BeginInit();
            this.groupManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartamentsMngmt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartamentFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // listFaculties
            // 
            this.listFaculties.CaseSensitiveSort = true;
            this.listFaculties.Location = new System.Drawing.Point(12, 12);
            this.listFaculties.Name = "listFaculties";
            this.listFaculties.Size = new System.Drawing.Size(190, 210);
            this.listFaculties.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.listFaculties.TabIndex = 0;
            this.listFaculties.Text = "radListControl1";
            this.listFaculties.ThemeName = "Office2010";
            this.listFaculties.DoubleClick += new System.EventHandler(this.listFaculties_DoubleClick);
            this.listFaculties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listFaculties_KeyDown);
            // 
            // groupManagement
            // 
            this.groupManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupManagement.Controls.Add(this.btnDepartamentsMngmt);
            this.groupManagement.Controls.Add(this.lblValidation);
            this.groupManagement.Controls.Add(this.btnDelete);
            this.groupManagement.Controls.Add(this.btnSave);
            this.groupManagement.Controls.Add(this.btnCancel);
            this.groupManagement.Controls.Add(this.btnAddFaculty);
            this.groupManagement.Controls.Add(this.tbNewFacultyName);
            this.groupManagement.Controls.Add(this.label2);
            this.groupManagement.Controls.Add(this.label1);
            this.groupManagement.Controls.Add(this.clbDepartaments);
            this.groupManagement.FooterImageIndex = -1;
            this.groupManagement.FooterImageKey = "";
            this.groupManagement.HeaderImageIndex = -1;
            this.groupManagement.HeaderImageKey = "";
            this.groupManagement.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.groupManagement.HeaderText = "Zarz¹dzanie";
            this.groupManagement.Location = new System.Drawing.Point(208, 3);
            this.groupManagement.Name = "groupManagement";
            this.groupManagement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.groupManagement.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.groupManagement.RootElement.ShouldPaint = true;
            this.groupManagement.Size = new System.Drawing.Size(268, 262);
            this.groupManagement.TabIndex = 1;
            this.groupManagement.Text = "Zarz¹dzanie";
            this.groupManagement.ThemeName = "ControlDefault";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.groupManagement.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            // 
            // btnDepartamentsMngmt
            // 
            this.btnDepartamentsMngmt.BackgroundImage = global::StudiesPlans.Properties.Resources.management;
            this.btnDepartamentsMngmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepartamentsMngmt.Image = global::StudiesPlans.Properties.Resources.management;
            this.btnDepartamentsMngmt.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDepartamentsMngmt.Location = new System.Drawing.Point(80, 56);
            this.btnDepartamentsMngmt.Name = "btnDepartamentsMngmt";
            this.btnDepartamentsMngmt.Size = new System.Drawing.Size(20, 20);
            this.btnDepartamentsMngmt.TabIndex = 25;
            this.btnDepartamentsMngmt.Click += new System.EventHandler(this.btnDepartamentsMngmt_Click);
            // 
            // lblValidation
            // 
            this.lblValidation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(13, 162);
            this.lblValidation.Name = "lblValidation";
            // 
            // 
            // 
            this.lblValidation.RootElement.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Size = new System.Drawing.Size(2, 2);
            this.lblValidation.TabIndex = 24;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(199, 216);
            this.btnDelete.Name = "btnDelete";
            // 
            // 
            // 
            this.btnDelete.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(57, 33);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Usuñ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(136, 216);
            this.btnSave.Name = "btnSave";
            // 
            // 
            // 
            this.btnSave.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(57, 33);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Zapisz";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(73, 216);
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(57, 33);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddFaculty
            // 
            this.btnAddFaculty.ForeColor = System.Drawing.Color.Black;
            this.btnAddFaculty.Location = new System.Drawing.Point(10, 216);
            this.btnAddFaculty.Name = "btnAddFaculty";
            // 
            // 
            // 
            this.btnAddFaculty.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnAddFaculty.Size = new System.Drawing.Size(57, 33);
            this.btnAddFaculty.TabIndex = 20;
            this.btnAddFaculty.Text = "Dodaj";
            this.btnAddFaculty.Click += new System.EventHandler(this.btnAddFaculty_Click);
            // 
            // tbNewFacultyName
            // 
            this.tbNewFacultyName.Location = new System.Drawing.Point(106, 30);
            this.tbNewFacultyName.Name = "tbNewFacultyName";
            this.tbNewFacultyName.Size = new System.Drawing.Size(153, 20);
            this.tbNewFacultyName.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Wydzia³y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nazwa kierunku:";
            // 
            // clbDepartaments
            // 
            this.clbDepartaments.CheckOnClick = true;
            this.clbDepartaments.FormattingEnabled = true;
            this.clbDepartaments.Location = new System.Drawing.Point(106, 56);
            this.clbDepartaments.Name = "clbDepartaments";
            this.clbDepartaments.Size = new System.Drawing.Size(153, 106);
            this.clbDepartaments.TabIndex = 4;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 228);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(99, 18);
            this.radLabel1.TabIndex = 26;
            this.radLabel1.Text = "Filtruj po wydziale:";
            // 
            // cbDepartamentFilter
            // 
            this.cbDepartamentFilter.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbDepartamentFilter.Location = new System.Drawing.Point(12, 245);
            this.cbDepartamentFilter.Name = "cbDepartamentFilter";
            this.cbDepartamentFilter.Size = new System.Drawing.Size(190, 20);
            this.cbDepartamentFilter.TabIndex = 26;
            this.cbDepartamentFilter.Text = "radDropDownList1";
            this.cbDepartamentFilter.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cbDepartamentFilter_SelectedIndexChanged);
            // 
            // Faculties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 277);
            this.Controls.Add(this.cbDepartamentFilter);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.groupManagement);
            this.Controls.Add(this.listFaculties);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Faculties";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarz¹dzanie kierunkami";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Faculties_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listFaculties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupManagement)).EndInit();
            this.groupManagement.ResumeLayout(false);
            this.groupManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDepartamentsMngmt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartamentFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl listFaculties;
        private Telerik.WinControls.UI.RadGroupBox groupManagement;
        private System.Windows.Forms.CheckedListBox clbDepartaments;
        private System.Windows.Forms.TextBox tbNewFacultyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnAddFaculty;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadLabel lblValidation;
        private Telerik.WinControls.UI.RadButton btnDepartamentsMngmt;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList cbDepartamentFilter;
    }
}

