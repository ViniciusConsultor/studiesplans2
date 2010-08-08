using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudiesPlans
{
    public partial class MainForm : Form
    {
        Boolean isManagementShown = false;
        private
             SubjectManagement subjectManagementForm = new SubjectManagement();

        public MainForm()
        {
           
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f is SlideForm)
                {
                    isManagementShown = true;
                    f.Focus();
                    break;
                }
            }

            if (!isManagementShown)
            {
                subjectManagementForm = new SubjectManagement();
                subjectManagementForm.Show();
                isManagementShown = true;
            }
            else
            {
                isManagementShown = false;
                subjectManagementForm.Focus();
                subjectManagementForm.Dispose();
            }
        }
    }
}
