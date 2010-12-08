namespace StudiesPlans.Views
{
    partial class Institutes
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
            this.listInstitutes = new Telerik.WinControls.UI.RadListControl();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.tbNewInstituteName = new Telerik.WinControls.UI.RadTextBox();
            this.lblValidation = new Telerik.WinControls.UI.RadLabel();
            this.btnDepartamentsMngmt = new System.Windows.Forms.Button();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.clbDepartaments = new System.Windows.Forms.CheckedListBox();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.cbDepartamentFilter = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.listInstitutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewInstituteName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartamentFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // listInstitutes
            // 
            this.listInstitutes.CaseSensitiveSort = true;
            this.listInstitutes.Location = new System.Drawing.Point(13, 13);
            this.listInstitutes.Name = "listInstitutes";
            this.listInstitutes.Size = new System.Drawing.Size(185, 208);
            this.listInstitutes.SortStyle = Telerik.WinControls.Enumerations.SortStyle.Ascending;
            this.listInstitutes.TabIndex = 7;
            this.listInstitutes.Text = "radListControl1";
            this.listInstitutes.DoubleClick += new System.EventHandler(this.listInstitutes_DoubleClick);
            ((Telerik.WinControls.UI.RadListElement)(this.listInstitutes.GetChildAt(0))).CaseSensitiveSort = true;
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.tbNewInstituteName);
            this.radGroupBox1.Controls.Add(this.lblValidation);
            this.radGroupBox1.Controls.Add(this.btnDepartamentsMngmt);
            this.radGroupBox1.Controls.Add(this.btnDelete);
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.clbDepartaments);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnAdd);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Zarz�dzanie";
            this.radGroupBox1.Location = new System.Drawing.Point(208, 3);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(268, 262);
            this.radGroupBox1.TabIndex = 1;
            this.radGroupBox1.Text = "Zarz�dzanie";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(10, 56);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(54, 18);
            this.radLabel3.TabIndex = 25;
            this.radLabel3.Text = "Wydzia�y:";
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(10, 25);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(89, 18);
            this.radLabel2.TabIndex = 24;
            this.radLabel2.Text = "Nazwa instytutu:";
            // 
            // tbNewInstituteName
            // 
            this.tbNewInstituteName.Location = new System.Drawing.Point(102, 23);
            this.tbNewInstituteName.Name = "tbNewInstituteName";
            this.tbNewInstituteName.Size = new System.Drawing.Size(154, 20);
            this.tbNewInstituteName.TabIndex = 0;
            this.tbNewInstituteName.TabStop = false;
            // 
            // lblValidation
            // 
            this.lblValidation.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(10, 169);
            this.lblValidation.Name = "lblValidation";
            // 
            // 
            // 
            this.lblValidation.RootElement.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Size = new System.Drawing.Size(2, 2);
            this.lblValidation.TabIndex = 22;
            // 
            // btnDepartamentsMngmt
            // 
            this.btnDepartamentsMngmt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDepartamentsMngmt.BackgroundImage = global::StudiesPlans.Properties.Resources.management;
            this.btnDepartamentsMngmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepartamentsMngmt.Location = new System.Drawing.Point(72, 56);
            this.btnDepartamentsMngmt.Margin = new System.Windows.Forms.Padding(0);
            this.btnDepartamentsMngmt.Name = "btnDepartamentsMngmt";
            this.btnDepartamentsMngmt.Size = new System.Drawing.Size(21, 21);
            this.btnDepartamentsMngmt.TabIndex = 1;
            this.btnDepartamentsMngmt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamentsMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartamentsMngmt.UseVisualStyleBackColor = true;
            this.btnDepartamentsMngmt.Click += new System.EventHandler(this.btnDepartamentsMngmt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(199, 216);
            this.btnDelete.Name = "btnDelete";
            // 
            // 
            // 
            this.btnDelete.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(57, 33);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Usu�";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(136, 216);
            this.btnSave.Name = "btnSave";
            // 
            // 
            // 
            this.btnSave.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(57, 33);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Zapisz";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // clbDepartaments
            // 
            this.clbDepartaments.CheckOnClick = true;
            this.clbDepartaments.FormattingEnabled = true;
            this.clbDepartaments.HorizontalScrollbar = true;
            this.clbDepartaments.Location = new System.Drawing.Point(102, 56);
            this.clbDepartaments.Name = "clbDepartaments";
            this.clbDepartaments.Size = new System.Drawing.Size(155, 106);
            this.clbDepartaments.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(73, 216);
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(57, 33);
            this.btnCancel.TabIndex = 4;
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
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbDepartamentFilter
            // 
            this.cbDepartamentFilter.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbDepartamentFilter.Location = new System.Drawing.Point(13, 245);
            this.cbDepartamentFilter.Name = "cbDepartamentFilter";
            this.cbDepartamentFilter.Size = new System.Drawing.Size(190, 20);
            this.cbDepartamentFilter.TabIndex = 8;
            this.cbDepartamentFilter.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cbDepartamentFilter_SelectedIndexChanged);
            ((Telerik.WinControls.UI.RadDropDownListElement)(this.cbDepartamentFilter.GetChildAt(0))).DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 227);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(99, 18);
            this.radLabel1.TabIndex = 27;
            this.radLabel1.Text = "Filtruj po wydziale:";
            // 
            // Institutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 277);
            this.Controls.Add(this.cbDepartamentFilter);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.listInstitutes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Institutes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zarz�dzanie instytutami";
            this.ThemeName = "ControlDefault";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Institutes_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.listInstitutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewInstituteName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartamentFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl listInstitutes;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private System.Windows.Forms.Button btnDepartamentsMngmt;
        private System.Windows.Forms.CheckedListBox clbDepartaments;
        private Telerik.WinControls.UI.RadLabel lblValidation;
        private Telerik.WinControls.UI.RadDropDownList cbDepartamentFilter;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox tbNewInstituteName;
    }
}

