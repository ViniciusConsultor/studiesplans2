namespace StudiesPlans.Views
{
    partial class ValidateRules
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.gvRules = new Telerik.WinControls.UI.RadGridView();
            this.btnVerify = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvRules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.btnVerify);
            this.radGroupBox1.Controls.Add(this.gvRules);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Weryfikacja";
            this.radGroupBox1.Location = new System.Drawing.Point(13, 13);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(836, 331);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Weryfikacja";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.Transparent;
            // 
            // gvRules
            // 
            this.gvRules.Location = new System.Drawing.Point(14, 24);
            // 
            // gvRules
            // 
            this.gvRules.MasterTemplate.AddNewRowPosition = Telerik.WinControls.UI.SystemRowPosition.Bottom;
            this.gvRules.MasterTemplate.AllowAddNewRow = false;
            this.gvRules.MasterTemplate.AllowColumnReorder = false;
            this.gvRules.MasterTemplate.AllowColumnResize = false;
            this.gvRules.MasterTemplate.AllowDeleteRow = false;
            this.gvRules.MasterTemplate.AllowDragToGroup = false;
            this.gvRules.MasterTemplate.AllowEditRow = false;
            this.gvRules.MasterTemplate.AllowRowResize = false;
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Reguła";
            gridViewTextBoxColumn6.Name = "rule";
            gridViewTextBoxColumn6.Width = 180;
            gridViewTextBoxColumn7.HeaderText = "Semestr";
            gridViewTextBoxColumn7.Name = "semester";
            gridViewTextBoxColumn7.Width = 100;
            gridViewTextBoxColumn8.HeaderText = "Przedmiot";
            gridViewTextBoxColumn8.Name = "subject";
            gridViewTextBoxColumn8.Width = 150;
            gridViewTextBoxColumn9.HeaderText = "Typ Przedmiotu";
            gridViewTextBoxColumn9.Name = "subjectType";
            gridViewTextBoxColumn9.Width = 120;
            gridViewTextBoxColumn10.HeaderText = "Wartość";
            gridViewTextBoxColumn10.Name = "value";
            gridViewTextBoxColumn10.Width = 75;
            gridViewCheckBoxColumn2.FormatString = "";
            gridViewCheckBoxColumn2.HeaderText = "Spełniona";
            gridViewCheckBoxColumn2.MinWidth = 40;
            gridViewCheckBoxColumn2.Name = "passed";
            gridViewCheckBoxColumn2.Width = 60;
            this.gvRules.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewCheckBoxColumn2});
            this.gvRules.MasterTemplate.ShowFilteringRow = false;
            this.gvRules.Name = "gvRules";
            this.gvRules.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.gvRules.ShowGroupPanel = false;
            this.gvRules.Size = new System.Drawing.Size(702, 294);
            this.gvRules.TabIndex = 0;
            this.gvRules.Text = "radGridView1";
            // 
            // btnVerify
            // 
            this.btnVerify.ForeColor = System.Drawing.Color.Black;
            this.btnVerify.Location = new System.Drawing.Point(724, 24);
            this.btnVerify.Name = "btnVerify";
            // 
            // 
            // 
            this.btnVerify.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnVerify.Size = new System.Drawing.Size(99, 24);
            this.btnVerify.TabIndex = 1;
            this.btnVerify.Text = "Weryfikuj";
            this.btnVerify.Click += new System.EventHandler(this.BtnVerifyClick);
            // 
            // ValidateRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 356);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "ValidateRules";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Weryfikacja planu";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gvRules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVerify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadGridView gvRules;
        private Telerik.WinControls.UI.RadButton btnVerify;
    }
}