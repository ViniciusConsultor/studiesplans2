namespace StudiesPlans.Views
{
    partial class EditSubject
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.dgSubjectTypes = new Telerik.WinControls.UI.RadGridView();
            this.lblValidation = new Telerik.WinControls.UI.RadLabel();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnSaveSubject = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.cbInstitute = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.lblDepartament = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.lblFaculty = new Telerik.WinControls.UI.RadLabel();
            this.ckbxExam = new Telerik.WinControls.UI.RadCheckBox();
            this.seEcts = new Telerik.WinControls.UI.RadSpinEditor();
            this.cbSemester = new Telerik.WinControls.UI.RadDropDownList();
            this.tbSubjectName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjectTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbInstitute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDepartament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbxExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seEcts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemester)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSubjectTypes
            // 
            this.dgSubjectTypes.AutoSize = true;
            this.dgSubjectTypes.AutoSizeRows = true;
            this.dgSubjectTypes.Location = new System.Drawing.Point(242, 23);
            // 
            // dgSubjectTypes
            // 
            this.dgSubjectTypes.MasterTemplate.AllowAddNewRow = false;
            this.dgSubjectTypes.MasterTemplate.AllowColumnReorder = false;
            this.dgSubjectTypes.MasterTemplate.AllowColumnResize = false;
            this.dgSubjectTypes.MasterTemplate.AllowDeleteRow = false;
            this.dgSubjectTypes.MasterTemplate.AllowRowResize = false;
            this.dgSubjectTypes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Typ";
            gridViewTextBoxColumn1.Name = "subjectType";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 86;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Godziny";
            gridViewTextBoxColumn2.Name = "hours";
            gridViewTextBoxColumn2.Width = 84;
            this.dgSubjectTypes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.dgSubjectTypes.MasterTemplate.EnableGrouping = false;
            this.dgSubjectTypes.Name = "dgSubjectTypes";
            this.dgSubjectTypes.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            // 
            // 
            // 
            this.dgSubjectTypes.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.dgSubjectTypes.Size = new System.Drawing.Size(191, 170);
            this.dgSubjectTypes.TabIndex = 17;
            this.dgSubjectTypes.Text = "radGridView1";
            // 
            // lblValidation
            // 
            this.lblValidation.Location = new System.Drawing.Point(234, 25);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(2, 2);
            this.lblValidation.TabIndex = 16;
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(242, 210);
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(130, 32);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Zamknij";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveSubject
            // 
            this.btnSaveSubject.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSubject.Location = new System.Drawing.Point(72, 210);
            this.btnSaveSubject.Name = "btnSaveSubject";
            // 
            // 
            // 
            this.btnSaveSubject.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSubject.Size = new System.Drawing.Size(130, 32);
            this.btnSaveSubject.TabIndex = 14;
            this.btnSaveSubject.Text = "Zapisz zmiany";
            this.btnSaveSubject.Click += new System.EventHandler(this.btnSaveSubject_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.dgSubjectTypes);
            this.radGroupBox1.Controls.Add(this.lblValidation);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnSaveSubject);
            this.radGroupBox1.Controls.Add(this.cbInstitute);
            this.radGroupBox1.Controls.Add(this.radLabel9);
            this.radGroupBox1.Controls.Add(this.lblDepartament);
            this.radGroupBox1.Controls.Add(this.radLabel7);
            this.radGroupBox1.Controls.Add(this.lblFaculty);
            this.radGroupBox1.Controls.Add(this.ckbxExam);
            this.radGroupBox1.Controls.Add(this.seEcts);
            this.radGroupBox1.Controls.Add(this.cbSemester);
            this.radGroupBox1.Controls.Add(this.tbSubjectName);
            this.radGroupBox1.Controls.Add(this.radLabel5);
            this.radGroupBox1.Controls.Add(this.radLabel4);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Edytuj przedmiot";
            this.radGroupBox1.Location = new System.Drawing.Point(8, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(446, 255);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Edytuj przedmiot";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            // 
            // cbInstitute
            // 
            this.cbInstitute.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbInstitute.Location = new System.Drawing.Point(101, 173);
            this.cbInstitute.Name = "cbInstitute";
            this.cbInstitute.Size = new System.Drawing.Size(127, 20);
            this.cbInstitute.TabIndex = 13;
            this.cbInstitute.Text = "radDropDownList2";
            // 
            // radLabel9
            // 
            this.radLabel9.Location = new System.Drawing.Point(13, 173);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(46, 18);
            this.radLabel9.TabIndex = 12;
            this.radLabel9.Text = "Instytut:";
            // 
            // lblDepartament
            // 
            this.lblDepartament.Location = new System.Drawing.Point(101, 149);
            this.lblDepartament.Name = "lblDepartament";
            this.lblDepartament.Size = new System.Drawing.Size(55, 18);
            this.lblDepartament.TabIndex = 11;
            this.lblDepartament.Text = "radLabel8";
            // 
            // radLabel7
            // 
            this.radLabel7.Location = new System.Drawing.Point(13, 149);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(48, 18);
            this.radLabel7.TabIndex = 10;
            this.radLabel7.Text = "Wydzia³:";
            // 
            // lblFaculty
            // 
            this.lblFaculty.Location = new System.Drawing.Point(101, 125);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(55, 18);
            this.lblFaculty.TabIndex = 9;
            this.lblFaculty.Text = "radLabel6";
            // 
            // ckbxExam
            // 
            this.ckbxExam.Location = new System.Drawing.Point(101, 101);
            this.ckbxExam.Name = "ckbxExam";
            this.ckbxExam.Size = new System.Drawing.Size(15, 15);
            this.ckbxExam.TabIndex = 8;
            // 
            // seEcts
            // 
            this.seEcts.DecimalPlaces = 1;
            this.seEcts.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.seEcts.Location = new System.Drawing.Point(101, 75);
            this.seEcts.Name = "seEcts";
            // 
            // 
            // 
            this.seEcts.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren;
            this.seEcts.ShowBorder = true;
            this.seEcts.Size = new System.Drawing.Size(127, 20);
            this.seEcts.TabIndex = 7;
            this.seEcts.TabStop = false;
            // 
            // cbSemester
            // 
            this.cbSemester.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbSemester.Location = new System.Drawing.Point(101, 49);
            this.cbSemester.Name = "cbSemester";
            this.cbSemester.Size = new System.Drawing.Size(127, 20);
            this.cbSemester.TabIndex = 6;
            this.cbSemester.Text = "radDropDownList1";
            // 
            // tbSubjectName
            // 
            this.tbSubjectName.Location = new System.Drawing.Point(101, 23);
            this.tbSubjectName.Name = "tbSubjectName";
            this.tbSubjectName.Size = new System.Drawing.Size(127, 20);
            this.tbSubjectName.TabIndex = 5;
            this.tbSubjectName.TabStop = false;
            // 
            // radLabel5
            // 
            this.radLabel5.Location = new System.Drawing.Point(13, 125);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(52, 18);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "Kierunek:";
            // 
            // radLabel4
            // 
            this.radLabel4.Location = new System.Drawing.Point(13, 101);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(51, 18);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "Egzamin:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 77);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(71, 18);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Punkty ECTS:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 51);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(49, 18);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Semestr:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(42, 18);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Nazwa:";
            // 
            // EditSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 279);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSubject";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarz¹dzanie przedmiotami - edycja przedmiotu";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditSubject_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgSubjectTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSaveSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbInstitute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblDepartament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckbxExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seEcts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbSemester)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView dgSubjectTypes;
        private Telerik.WinControls.UI.RadLabel lblValidation;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnSaveSubject;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadDropDownList cbInstitute;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel lblDepartament;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel lblFaculty;
        private Telerik.WinControls.UI.RadCheckBox ckbxExam;
        private Telerik.WinControls.UI.RadSpinEditor seEcts;
        private Telerik.WinControls.UI.RadDropDownList cbSemester;
        private Telerik.WinControls.UI.RadTextBox tbSubjectName;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}

