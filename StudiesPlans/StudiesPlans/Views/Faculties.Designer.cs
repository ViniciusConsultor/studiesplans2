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
            this.listFaculties = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDepartamentsMngmt = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddFaculty = new System.Windows.Forms.Button();
            this.tbNewFacultyName = new System.Windows.Forms.TextBox();
            this.clbDepartaments = new System.Windows.Forms.CheckedListBox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listFaculties
            // 
            this.listFaculties.FormattingEnabled = true;
            this.listFaculties.Location = new System.Drawing.Point(12, 12);
            this.listFaculties.Name = "listFaculties";
            this.listFaculties.Size = new System.Drawing.Size(182, 303);
            this.listFaculties.TabIndex = 0;
            this.listFaculties.DoubleClick += new System.EventHandler(this.listFaculties_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDepartamentsMngmt);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAddFaculty);
            this.groupBox1.Controls.Add(this.tbNewFacultyName);
            this.groupBox1.Controls.Add(this.clbDepartaments);
            this.groupBox1.Controls.Add(this.lblValidation);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(199, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 306);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarządzanie";
            // 
            // btnDepartamentsMngmt
            // 
            this.btnDepartamentsMngmt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDepartamentsMngmt.BackgroundImage = global::StudiesPlans.Properties.Resources.management;
            this.btnDepartamentsMngmt.Location = new System.Drawing.Point(72, 45);
            this.btnDepartamentsMngmt.Margin = new System.Windows.Forms.Padding(0);
            this.btnDepartamentsMngmt.Name = "btnDepartamentsMngmt";
            this.btnDepartamentsMngmt.Size = new System.Drawing.Size(21, 21);
            this.btnDepartamentsMngmt.TabIndex = 15;
            this.btnDepartamentsMngmt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamentsMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartamentsMngmt.UseVisualStyleBackColor = true;
            this.btnDepartamentsMngmt.Click += new System.EventHandler(this.btnDepartamentsMngmt_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(207, 277);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(141, 277);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(75, 277);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(60, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddFaculty
            // 
            this.btnAddFaculty.Location = new System.Drawing.Point(9, 277);
            this.btnAddFaculty.Name = "btnAddFaculty";
            this.btnAddFaculty.Size = new System.Drawing.Size(60, 23);
            this.btnAddFaculty.TabIndex = 5;
            this.btnAddFaculty.Text = "Dodaj";
            this.btnAddFaculty.UseVisualStyleBackColor = true;
            this.btnAddFaculty.Click += new System.EventHandler(this.btnAddFaculty_Click);
            // 
            // tbNewFacultyName
            // 
            this.tbNewFacultyName.Location = new System.Drawing.Point(99, 19);
            this.tbNewFacultyName.Name = "tbNewFacultyName";
            this.tbNewFacultyName.Size = new System.Drawing.Size(168, 20);
            this.tbNewFacultyName.TabIndex = 4;
            // 
            // clbDepartaments
            // 
            this.clbDepartaments.FormattingEnabled = true;
            this.clbDepartaments.Location = new System.Drawing.Point(99, 45);
            this.clbDepartaments.Name = "clbDepartaments";
            this.clbDepartaments.Size = new System.Drawing.Size(168, 154);
            this.clbDepartaments.TabIndex = 3;
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(6, 206);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(0, 13);
            this.lblValidation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wydziały:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa kierunku:";
            // 
            // Faculties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 330);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listFaculties);
            this.Name = "Faculties";
            this.Text = "Zarządzanie kierunkami";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listFaculties;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddFaculty;
        private System.Windows.Forms.TextBox tbNewFacultyName;
        private System.Windows.Forms.CheckedListBox clbDepartaments;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDepartamentsMngmt;
    }
}