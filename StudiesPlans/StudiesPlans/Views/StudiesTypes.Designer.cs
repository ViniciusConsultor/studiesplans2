namespace StudiesPlans
{
    partial class StudiesTypes
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
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnCancel = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.lblValidation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNewStudiesTypeName = new System.Windows.Forms.TextBox();
            this.listStudiesTypes = new Telerik.WinControls.UI.RadListControl();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listStudiesTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.Controls.Add(this.btnSave);
            this.radGroupBox1.Controls.Add(this.btnDelete);
            this.radGroupBox1.Controls.Add(this.btnCancel);
            this.radGroupBox1.Controls.Add(this.btnAdd);
            this.radGroupBox1.Controls.Add(this.lblValidation);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Controls.Add(this.tbNewStudiesTypeName);
            this.radGroupBox1.FooterImageIndex = -1;
            this.radGroupBox1.FooterImageKey = "";
            this.radGroupBox1.HeaderImageIndex = -1;
            this.radGroupBox1.HeaderImageKey = "";
            this.radGroupBox1.HeaderMargin = new System.Windows.Forms.Padding(0);
            this.radGroupBox1.HeaderText = "Zarz¹dzanie";
            this.radGroupBox1.Location = new System.Drawing.Point(181, 4);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            // 
            // 
            // 
            this.radGroupBox1.RootElement.Padding = new System.Windows.Forms.Padding(10, 20, 10, 10);
            this.radGroupBox1.Size = new System.Drawing.Size(237, 261);
            this.radGroupBox1.TabIndex = 0;
            this.radGroupBox1.Text = "Zarz¹dzanie";
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(0).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(0))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.radGroupBox1.GetChildAt(0).GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(221)))), ((int)(((byte)(32)))));
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(177, 217);
            this.btnSave.Name = "btnSave";
            // 
            // 
            // 
            this.btnSave.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(51, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Zapisz";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(120, 217);
            this.btnDelete.Name = "btnDelete";
            // 
            // 
            // 
            this.btnDelete.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Size = new System.Drawing.Size(51, 31);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Usuñ";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(63, 217);
            this.btnCancel.Name = "btnCancel";
            // 
            // 
            // 
            this.btnCancel.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(51, 31);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(6, 217);
            this.btnAdd.Name = "btnAdd";
            // 
            // 
            // 
            this.btnAdd.RootElement.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Size = new System.Drawing.Size(51, 31);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Dodaj";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblValidation
            // 
            this.lblValidation.AutoSize = true;
            this.lblValidation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblValidation.ForeColor = System.Drawing.Color.Red;
            this.lblValidation.Location = new System.Drawing.Point(13, 72);
            this.lblValidation.Name = "lblValidation";
            this.lblValidation.Size = new System.Drawing.Size(41, 13);
            this.lblValidation.TabIndex = 5;
            this.lblValidation.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nazwa:";
            // 
            // tbNewStudiesTypeName
            // 
            this.tbNewStudiesTypeName.Location = new System.Drawing.Point(62, 34);
            this.tbNewStudiesTypeName.Name = "tbNewStudiesTypeName";
            this.tbNewStudiesTypeName.Size = new System.Drawing.Size(161, 20);
            this.tbNewStudiesTypeName.TabIndex = 4;
            // 
            // listStudiesTypes
            // 
            this.listStudiesTypes.CaseSensitiveSort = true;
            this.listStudiesTypes.Location = new System.Drawing.Point(12, 13);
            this.listStudiesTypes.Name = "listStudiesTypes";
            this.listStudiesTypes.Size = new System.Drawing.Size(163, 252);
            this.listStudiesTypes.TabIndex = 1;
            this.listStudiesTypes.Text = "radListControl1";
            this.listStudiesTypes.DoubleClick += new System.EventHandler(this.listStudiesTypes_DoubleClick);
            // 
            // StudiesTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 277);
            this.Controls.Add(this.listStudiesTypes);
            this.Controls.Add(this.radGroupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudiesTypes";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Typy studiów";
            this.ThemeName = "ControlDefault";
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listStudiesTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Label lblValidation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNewStudiesTypeName;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadListControl listStudiesTypes;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnCancel;
    }
}

