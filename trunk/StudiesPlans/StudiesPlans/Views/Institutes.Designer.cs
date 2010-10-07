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
            this.listInstitutes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.btnDepartamentsMngmt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.clbDepartaments = new System.Windows.Forms.CheckedListBox();
            this.tbNewInstituteName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listInstitutes
            // 
            this.listInstitutes.FormattingEnabled = true;
            this.listInstitutes.Location = new System.Drawing.Point(12, 12);
            this.listInstitutes.Name = "listInstitutes";
            this.listInstitutes.Size = new System.Drawing.Size(153, 238);
            this.listInstitutes.TabIndex = 0;
            this.listInstitutes.DoubleClick += new System.EventHandler(this.listInstitutes_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValidation);
            this.groupBox1.Controls.Add(this.btnDepartamentsMngmt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.clbDepartaments);
            this.groupBox1.Controls.Add(this.tbNewInstituteName);
            this.groupBox1.Location = new System.Drawing.Point(171, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarządzanie";
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Location = new System.Drawing.Point(8, 160);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(35, 13);
            this.lblValidation.TabIndex = 17;
            this.lblValidation.Text = "label3";
            // 
            // btnDepartamentsMngmt
            // 
            this.btnDepartamentsMngmt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDepartamentsMngmt.BackgroundImage = global::StudiesPlans.Properties.Resources.management;
            this.btnDepartamentsMngmt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDepartamentsMngmt.Location = new System.Drawing.Point(72, 45);
            this.btnDepartamentsMngmt.Margin = new System.Windows.Forms.Padding(0);
            this.btnDepartamentsMngmt.Name = "btnDepartamentsMngmt";
            this.btnDepartamentsMngmt.Size = new System.Drawing.Size(21, 21);
            this.btnDepartamentsMngmt.TabIndex = 16;
            this.btnDepartamentsMngmt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDepartamentsMngmt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDepartamentsMngmt.UseVisualStyleBackColor = true;
            this.btnDepartamentsMngmt.Click += new System.EventHandler(this.btnDepartamentsMngmt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wydziały:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nazwa instytutu:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(214, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(62, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(62, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(78, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(62, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // clbDepartaments
            // 
            this.clbDepartaments.FormattingEnabled = true;
            this.clbDepartaments.Location = new System.Drawing.Point(102, 45);
            this.clbDepartaments.Name = "clbDepartaments";
            this.clbDepartaments.Size = new System.Drawing.Size(168, 109);
            this.clbDepartaments.TabIndex = 1;
            // 
            // tbNewInstituteName
            // 
            this.tbNewInstituteName.Location = new System.Drawing.Point(102, 19);
            this.tbNewInstituteName.Name = "tbNewInstituteName";
            this.tbNewInstituteName.Size = new System.Drawing.Size(168, 20);
            this.tbNewInstituteName.TabIndex = 0;
            // 
            // Institutes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 262);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listInstitutes);
            this.Name = "Institutes";
            this.Text = "Intitutes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listInstitutes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox clbDepartaments;
        private System.Windows.Forms.TextBox tbNewInstituteName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDepartamentsMngmt;
        private System.Windows.Forms.Label lblValidation;
    }
}