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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgSemesters = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewSemesterName = new System.Windows.Forms.TextBox();
            this.lblValidation = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbNewSemestrNo = new System.Windows.Forms.TextBox();
            this.tbNewSemesterYear = new System.Windows.Forms.TextBox();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSemesters)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbNewSemesterYear);
            this.groupBox1.Controls.Add(this.tbNewSemestrNo);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblValidation);
            this.groupBox1.Controls.Add(this.tbNewSemesterName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(210, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 238);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarządzanie";
            // 
            // dgSemesters
            // 
            this.dgSemesters.AllowUserToAddRows = false;
            this.dgSemesters.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgSemesters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgSemesters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgSemesters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSemesters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.cNo,
            this.cYear});
            this.dgSemesters.Location = new System.Drawing.Point(12, 12);
            this.dgSemesters.Name = "dgSemesters";
            this.dgSemesters.ReadOnly = true;
            this.dgSemesters.RowHeadersVisible = false;
            this.dgSemesters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgSemesters.Size = new System.Drawing.Size(192, 238);
            this.dgSemesters.TabIndex = 2;
            this.dgSemesters.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSemesters_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numer semestru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rok:";
            // 
            // tbNewSemesterName
            // 
            this.tbNewSemesterName.Location = new System.Drawing.Point(105, 19);
            this.tbNewSemesterName.Name = "tbNewSemesterName";
            this.tbNewSemesterName.Size = new System.Drawing.Size(121, 20);
            this.tbNewSemesterName.TabIndex = 3;
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(6, 102);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(41, 13);
            this.lblValidation.TabIndex = 6;
            this.lblValidation.Text = "label4";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 209);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(62, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(50, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(118, 209);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(50, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(174, 209);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(50, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbNewSemestrNo
            // 
            this.tbNewSemestrNo.CausesValidation = false;
            this.tbNewSemestrNo.Location = new System.Drawing.Point(105, 45);
            this.tbNewSemestrNo.Name = "tbNewSemestrNo";
            this.tbNewSemestrNo.Size = new System.Drawing.Size(121, 20);
            this.tbNewSemestrNo.TabIndex = 11;
            // 
            // tbNewSemesterYear
            // 
            this.tbNewSemesterYear.Location = new System.Drawing.Point(105, 72);
            this.tbNewSemesterYear.Name = "tbNewSemesterYear";
            this.tbNewSemesterYear.Size = new System.Drawing.Size(121, 20);
            this.tbNewSemesterYear.TabIndex = 12;
            // 
            // cName
            // 
            this.cName.HeaderText = "Nazwa";
            this.cName.Name = "cName";
            // 
            // cNo
            // 
            this.cNo.HeaderText = "Numer";
            this.cNo.Name = "cNo";
            this.cNo.Width = 50;
            // 
            // cYear
            // 
            this.cYear.HeaderText = "Rok";
            this.cYear.Name = "cYear";
            this.cYear.Width = 30;
            // 
            // Semesters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 262);
            this.Controls.Add(this.dgSemesters);
            this.Controls.Add(this.groupBox1);
            this.Name = "Semesters";
            this.Text = "Semesters";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSemesters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgSemesters;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.TextBox tbNewSemesterName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewSemesterYear;
        private System.Windows.Forms.TextBox tbNewSemestrNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cYear;
    }
}