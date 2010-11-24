namespace StudiesPlans.Views
{
    partial class PlansLoad
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
            this.lstPlan = new Telerik.WinControls.UI.RadListControl();
            this.btnLoad = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.rbArchived = new Telerik.WinControls.UI.RadRadioButton();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.cbFaculty = new Telerik.WinControls.UI.RadDropDownList();
            this.cbDepartament = new Telerik.WinControls.UI.RadDropDownList();
            this.rbMandatory = new Telerik.WinControls.UI.RadRadioButton();
            this.tbPlanName = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.btnClearFilter = new Telerik.WinControls.UI.RadButton();
            this.btnSetFilter = new Telerik.WinControls.UI.RadButton();
            this.rbAll = new Telerik.WinControls.UI.RadRadioButton();
            this.cbYearStart = new Telerik.WinControls.UI.RadDropDownList();
            this.ckxYearStart = new Telerik.WinControls.UI.RadCheckBox();
            this.ckxYearEnd = new Telerik.WinControls.UI.RadCheckBox();
            this.cbYearEnd = new Telerik.WinControls.UI.RadDropDownList();
            this.ckxSemStart = new Telerik.WinControls.UI.RadCheckBox();
            this.ckxSemEnd = new Telerik.WinControls.UI.RadCheckBox();
            this.tbSemStart = new Telerik.WinControls.UI.RadTextBox();
            this.tbSemEnd = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lstPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbArchived)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFaculty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMandatory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlanName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYearStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckxYearStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckxYearEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYearEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckxSemStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckxSemEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSemStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSemEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPlan
            // 
            this.lstPlan.CaseSensitiveSort = true;
            this.lstPlan.Location = new System.Drawing.Point(12, 12);
            this.lstPlan.Name = "lstPlan";
            this.lstPlan.Size = new System.Drawing.Size(219, 290);
            this.lstPlan.TabIndex = 0;
            this.lstPlan.Text = "radListControl1";
            // 
            // btnLoad
            // 
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(12, 308);
            this.btnLoad.Name = "btnLoad";
            // 
            // 
            // 
            this.btnLoad.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Size = new System.Drawing.Size(100, 24);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Wczytaj";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(131, 308);
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(100, 24);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.tbSemEnd);
            this.radGroupBox1.Controls.Add(this.tbSemStart);
            this.radGroupBox1.Controls.Add(this.ckxSemEnd);
            this.radGroupBox1.Controls.Add(this.ckxSemStart);
            this.radGroupBox1.Controls.Add(this.cbYearEnd);
            this.radGroupBox1.Controls.Add(this.ckxYearEnd);
            this.radGroupBox1.Controls.Add(this.ckxYearStart);
            this.radGroupBox1.Controls.Add(this.cbYearStart);
            this.radGroupBox1.Controls.Add(this.rbAll);
            this.radGroupBox1.Controls.Add(this.rbArchived);
            this.radGroupBox1.Controls.Add(this.radLabel3);
            this.radGroupBox1.Controls.Add(this.cbFaculty);
            this.radGroupBox1.Controls.Add(this.cbDepartament);
            this.radGroupBox1.Controls.Add(this.rbMandatory);
            this.radGroupBox1.Controls.Add(this.tbPlanName);
            this.radGroupBox1.Controls.Add(this.radLabel2);
            this.radGroupBox1.Controls.Add(this.radLabel1);
            this.radGroupBox1.Controls.Add(this.btnClearFilter);
            this.radGroupBox1.Controls.Add(this.btnSetFilter);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Filtrowanie";
            this.radGroupBox1.Location = new System.Drawing.Point(237, 12);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(220, 320);
            this.radGroupBox1.TabIndex = 3;
            this.radGroupBox1.Text = "Filtrowanie";
            // 
            // rbArchived
            // 
            this.rbArchived.Location = new System.Drawing.Point(13, 125);
            this.rbArchived.Name = "rbArchived";
            this.rbArchived.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbArchived.Size = new System.Drawing.Size(194, 18);
            this.rbArchived.TabIndex = 10;
            this.rbArchived.Text = "Plany archiwalne";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(13, 77);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(52, 18);
            this.radLabel3.TabIndex = 9;
            this.radLabel3.Text = "Kierunek:";
            // 
            // cbFaculty
            // 
            this.cbFaculty.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbFaculty.Location = new System.Drawing.Point(71, 75);
            this.cbFaculty.Name = "cbFaculty";
            this.cbFaculty.Size = new System.Drawing.Size(136, 20);
            this.cbFaculty.TabIndex = 8;
            this.cbFaculty.Text = "radDropDownList1";
            // 
            // cbDepartament
            // 
            this.cbDepartament.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbDepartament.Location = new System.Drawing.Point(71, 49);
            this.cbDepartament.Name = "cbDepartament";
            this.cbDepartament.Size = new System.Drawing.Size(136, 20);
            this.cbDepartament.TabIndex = 7;
            this.cbDepartament.Text = "radDropDownList1";
            this.cbDepartament.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.cbDepartament_SelectedIndexChanged);
            // 
            // rbMandatory
            // 
            this.rbMandatory.Location = new System.Drawing.Point(13, 101);
            this.rbMandatory.Name = "rbMandatory";
            this.rbMandatory.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbMandatory.Size = new System.Drawing.Size(194, 18);
            this.rbMandatory.TabIndex = 6;
            this.rbMandatory.Text = "Plany obowi¹zuj¹ce";
            this.rbMandatory.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rbMandatory_ToggleStateChanged);
            // 
            // tbPlanName
            // 
            this.tbPlanName.Location = new System.Drawing.Point(71, 23);
            this.tbPlanName.Name = "tbPlanName";
            this.tbPlanName.Size = new System.Drawing.Size(136, 20);
            this.tbPlanName.TabIndex = 5;
            this.tbPlanName.TabStop = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(13, 51);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(48, 18);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Wydzia³:";
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(13, 25);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(42, 18);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Nazwa:";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(118, 283);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(89, 24);
            this.btnClearFilter.TabIndex = 1;
            this.btnClearFilter.Text = "Usuñ filtr";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnSetFilter
            // 
            this.btnSetFilter.Location = new System.Drawing.Point(13, 283);
            this.btnSetFilter.Name = "btnSetFilter";
            this.btnSetFilter.Size = new System.Drawing.Size(84, 24);
            this.btnSetFilter.TabIndex = 0;
            this.btnSetFilter.Text = "Ustaw filtr";
            this.btnSetFilter.Click += new System.EventHandler(this.btnSetFilter_Click);
            // 
            // rbAll
            // 
            this.rbAll.Location = new System.Drawing.Point(13, 149);
            this.rbAll.Name = "rbAll";
            this.rbAll.RadioCheckAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.rbAll.Size = new System.Drawing.Size(194, 18);
            this.rbAll.TabIndex = 11;
            this.rbAll.Text = "Wszystkie mo¿liwe plany";
            this.rbAll.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.rbAll_ToggleStateChanged);
            // 
            // cbYearStart
            // 
            this.cbYearStart.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbYearStart.Location = new System.Drawing.Point(71, 173);
            this.cbYearStart.Name = "cbYearStart";
            this.cbYearStart.Size = new System.Drawing.Size(136, 20);
            this.cbYearStart.TabIndex = 12;
            this.cbYearStart.Text = "radDropDownList1";
            // 
            // ckxYearStart
            // 
            this.ckxYearStart.Location = new System.Drawing.Point(50, 178);
            this.ckxYearStart.Name = "ckxYearStart";
            this.ckxYearStart.Size = new System.Drawing.Size(15, 15);
            this.ckxYearStart.TabIndex = 13;
            // 
            // ckxYearEnd
            // 
            this.ckxYearEnd.Location = new System.Drawing.Point(50, 204);
            this.ckxYearEnd.Name = "ckxYearEnd";
            this.ckxYearEnd.Size = new System.Drawing.Size(15, 15);
            this.ckxYearEnd.TabIndex = 14;
            // 
            // cbYearEnd
            // 
            this.cbYearEnd.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cbYearEnd.Location = new System.Drawing.Point(71, 199);
            this.cbYearEnd.Name = "cbYearEnd";
            this.cbYearEnd.Size = new System.Drawing.Size(136, 20);
            this.cbYearEnd.TabIndex = 15;
            this.cbYearEnd.Text = "radDropDownList2";
            // 
            // ckxSemStart
            // 
            this.ckxSemStart.Location = new System.Drawing.Point(50, 230);
            this.ckxSemStart.Name = "ckxSemStart";
            this.ckxSemStart.Size = new System.Drawing.Size(15, 15);
            this.ckxSemStart.TabIndex = 16;
            // 
            // ckxSemEnd
            // 
            this.ckxSemEnd.Location = new System.Drawing.Point(50, 256);
            this.ckxSemEnd.Name = "ckxSemEnd";
            this.ckxSemEnd.Size = new System.Drawing.Size(15, 15);
            this.ckxSemEnd.TabIndex = 17;
            // 
            // tbSemStart
            // 
            this.tbSemStart.Location = new System.Drawing.Point(71, 225);
            this.tbSemStart.Name = "tbSemStart";
            this.tbSemStart.Size = new System.Drawing.Size(136, 20);
            this.tbSemStart.TabIndex = 18;
            this.tbSemStart.TabStop = false;
            // 
            // tbSemEnd
            // 
            this.tbSemEnd.Location = new System.Drawing.Point(71, 251);
            this.tbSemEnd.Name = "tbSemEnd";
            this.tbSemEnd.Size = new System.Drawing.Size(136, 20);
            this.tbSemEnd.TabIndex = 19;
            this.tbSemEnd.TabStop = false;
            // 
            // PlansLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 344);
            this.Controls.Add(this.radGroupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lstPlan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlansLoad";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Wczytaj plan";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.lstPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbArchived)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbFaculty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDepartament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMandatory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbPlanName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClearFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYearStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckxYearStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckxYearEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbYearEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckxSemStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ckxSemEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSemStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSemEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadListControl lstPlan;
        private Telerik.WinControls.UI.RadButton btnLoad;
        private Telerik.WinControls.UI.RadButton btnCancel;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton btnClearFilter;
        private Telerik.WinControls.UI.RadButton btnSetFilter;
        private Telerik.WinControls.UI.RadRadioButton rbMandatory;
        private Telerik.WinControls.UI.RadTextBox tbPlanName;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDropDownList cbFaculty;
        private Telerik.WinControls.UI.RadDropDownList cbDepartament;
        private Telerik.WinControls.UI.RadRadioButton rbArchived;
        private Telerik.WinControls.UI.RadTextBox tbSemEnd;
        private Telerik.WinControls.UI.RadTextBox tbSemStart;
        private Telerik.WinControls.UI.RadCheckBox ckxSemEnd;
        private Telerik.WinControls.UI.RadCheckBox ckxSemStart;
        private Telerik.WinControls.UI.RadDropDownList cbYearEnd;
        private Telerik.WinControls.UI.RadCheckBox ckxYearEnd;
        private Telerik.WinControls.UI.RadCheckBox ckxYearStart;
        private Telerik.WinControls.UI.RadDropDownList cbYearStart;
        private Telerik.WinControls.UI.RadRadioButton rbAll;
    }
}

