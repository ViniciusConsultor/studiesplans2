namespace StudiesPlans.Views
{
    partial class Departaments
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
            this.listDepartaments = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAddDepartament = new Telerik.WinControls.UI.RadButton();
            this.lblValidation = new System.Windows.Forms.Label();
            this.txtNewDepartamentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddDepartament)).BeginInit();
            this.SuspendLayout();
            // 
            // listDepartaments
            // 
            this.listDepartaments.FormattingEnabled = true;
            this.listDepartaments.HorizontalScrollbar = true;
            this.listDepartaments.Location = new System.Drawing.Point(12, 12);
            this.listDepartaments.Name = "listDepartaments";
            this.listDepartaments.Size = new System.Drawing.Size(180, 251);
            this.listDepartaments.Sorted = true;
            this.listDepartaments.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listDepartaments, "Kliknij dwukrotnie element, aby edytować");
            this.listDepartaments.DoubleClick += new System.EventHandler(this.listDepartaments_DoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnAddDepartament);
            this.groupBox1.Controls.Add(this.lblValidation);
            this.groupBox1.Controls.Add(this.txtNewDepartamentName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(195, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 254);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zarządzanie";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(198, 224);
            this.btnDelete.Name = "btnDelete";
            // 
            // 
            // 
            this.btnDelete.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(57, 24);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Usuń";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Control;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(135, 224);
            this.btnSave.Name = "btnSave";
            // 
            // 
            // 
            this.btnSave.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(57, 24);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Zapisz";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(72, 224);
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(57, 24);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddDepartament
            // 
            this.btnAddDepartament.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddDepartament.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddDepartament.ForeColor = System.Drawing.Color.Black;
            this.btnAddDepartament.Location = new System.Drawing.Point(9, 224);
            this.btnAddDepartament.Name = "btnAddDepartament";
            // 
            // 
            // 
            this.btnAddDepartament.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnAddDepartament.Size = new System.Drawing.Size(57, 24);
            this.btnAddDepartament.TabIndex = 7;
            this.btnAddDepartament.Text = "Dodaj";
            this.btnAddDepartament.Click += new System.EventHandler(this.btnAddDepartament_Click);
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(6, 49);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(0, 13);
            this.lblValidation.TabIndex = 2;
            // 
            // txtNewDepartamentName
            // 
            this.txtNewDepartamentName.Location = new System.Drawing.Point(110, 19);
            this.txtNewDepartamentName.Name = "txtNewDepartamentName";
            this.txtNewDepartamentName.Size = new System.Drawing.Size(124, 20);
            this.txtNewDepartamentName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa wydziału:";
            // 
            // Departaments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(465, 273);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listDepartaments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Departaments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zarządzanie wydziałami";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Departaments_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddDepartament)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listDepartaments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.TextBox txtNewDepartamentName;
        private System.Windows.Forms.Label label1;
        private Telerik.WinControls.UI.RadButton btnAddDepartament;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnSave;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}