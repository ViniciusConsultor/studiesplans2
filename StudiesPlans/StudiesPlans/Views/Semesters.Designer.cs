namespace StudiesPlans.Views
{
    partial class Semesters
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.lblValidation = new Telerik.WinControls.UI.RadLabel();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.dgSemesters = new Telerik.WinControls.UI.RadGridView();
            this.tbNewSemesterName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.tbNewSemestrNo = new Telerik.WinControls.UI.RadTextBox();
            this.tbNewSemesterYear = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSemesters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewSemesterName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewSemestrNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewSemesterYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.tbNewSemesterYear);
            this.radGroupBox1.Controls.Add(this.tbNewSemestrNo);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.tbNewSemesterName);
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
            this.radGroupBox1.HeaderText = "Zarz¹dzanie";
            this.radGroupBox1.Location = new System.Drawing.Point(233, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(243, 262);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Zarz¹dzanie";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            // 
            // lblValidation
            // 
            this.lblValidation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(13, 118);
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
            this.btnDelete.Location = new System.Drawing.Point(181, 216);
            this.btnDelete.Name = "btnDelete";
            // 
            // 
            // 
            this.btnDelete.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(50, 33);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Usuñ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(125, 216);
            this.btnSave.Name = "btnSave";
            // 
            // 
            // 
            this.btnSave.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(50, 33);
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
            this.btnCancel.Location = new System.Drawing.Point(69, 216);
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(50, 33);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(13, 216);
            this.btnAdd.Name = "btnAdd";
            // 
            // 
            // 
            this.btnAdd.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(50, 33);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgSemesters
            // 
            this.dgSemesters.AutoSize = true;
            this.dgSemesters.AutoSizeRows = true;
            this.dgSemesters.Location = new System.Drawing.Point(13, 13);
            // 
            // dgSemesters
            // 
            this.dgSemesters.MasterTemplate.AllowAddNewRow = false;
            this.dgSemesters.MasterTemplate.AllowDragToGroup = false;
            this.dgSemesters.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nazwa";
            gridViewTextBoxColumn1.Name = "cName";
            gridViewTextBoxColumn1.Width = 119;
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Numer";
            gridViewTextBoxColumn2.Name = "cNo";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Rok";
            gridViewTextBoxColumn3.Name = "cYear";
            gridViewTextBoxColumn3.Width = 44;
            this.dgSemesters.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.dgSemesters.MasterTemplate.ShowRowHeaderColumn = false;
            this.dgSemesters.Name = "dgSemesters";
            this.dgSemesters.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.dgSemesters.ReadOnly = true;
            // 
            // 
            // 
            this.dgSemesters.RootElement.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.dgSemesters.RootElement.ToolTipText = "Kliknij dwukrotnie element, aby edytowaæ";
            this.dgSemesters.ShowGroupPanel = false;
            this.dgSemesters.Size = new System.Drawing.Size(214, 252);
            this.dgSemesters.TabIndex = 4;
            this.dgSemesters.Text = "radGridView1";
            this.dgSemesters.CellDoubleClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.dgSemesters_CellDoubleClick);
            // 
            // tbNewSemesterName
            // 
            this.tbNewSemesterName.Location = new System.Drawing.Point(112, 37);
            this.tbNewSemesterName.Name = "tbNewSemesterName";
            this.tbNewSemesterName.Size = new System.Drawing.Size(119, 20);
            this.tbNewSemesterName.TabIndex = 23;
            this.tbNewSemesterName.TabStop = false;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 37);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(39, 18);
            this.radLabel1.TabIndex = 24;
            this.radLabel1.Text = "Nazwa";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 61);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(92, 18);
            this.radLabel2.TabIndex = 25;
            this.radLabel2.Text = "Numer semestru:";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 85);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(28, 18);
            this.radLabel3.TabIndex = 25;
            this.radLabel3.Text = "Rok:";
            // 
            // tbNewSemestrNo
            // 
            this.tbNewSemestrNo.Location = new System.Drawing.Point(112, 63);
            this.tbNewSemestrNo.Name = "tbNewSemestrNo";
            this.tbNewSemestrNo.Size = new System.Drawing.Size(119, 20);
            this.tbNewSemestrNo.TabIndex = 24;
            this.tbNewSemestrNo.TabStop = false;
            // 
            // tbNewSemesterYear
            // 
            this.tbNewSemesterYear.Location = new System.Drawing.Point(112, 89);
            this.tbNewSemesterYear.Name = "tbNewSemesterYear";
            this.tbNewSemesterYear.Size = new System.Drawing.Size(119, 20);
            this.tbNewSemesterYear.TabIndex = 24;
            this.tbNewSemesterYear.TabStop = false;
            // 
            // Semesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 277);
            this.Controls.Add(this.dgSemesters);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Semesters";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zarz¹dzanie semestrami";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Semesters_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSemesters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewSemesterName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewSemestrNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewSemesterYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel lblValidation;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadGridView dgSemesters;
        private Telerik.WinControls.UI.RadTextBox tbNewSemesterYear;
        private Telerik.WinControls.UI.RadTextBox tbNewSemestrNo;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox tbNewSemesterName;

    }
}

