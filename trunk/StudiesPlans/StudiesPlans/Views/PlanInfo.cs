using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using StudiesPlansModels.Models;

namespace StudiesPlans.Views
{
    public partial class PlanInfo : Telerik.WinControls.UI.RadForm
    {
        public PlanInfo(Plan plan)
        {
            InitializeComponent();
            lblName.Text = plan.Name;
            lblFaculty.Text = plan.Faculty.Name;
            lblDepartament.Text = plan.Departament.Name;
            lblSemStart.Text = plan.SemesterStart.HasValue ? plan.SemesterStart.Value.ToString() : "";
            lblSemEnd.Text = plan.SemesterEnd.HasValue ? plan.SemesterEnd.Value.ToString() : "";
            lblYearStart.Text = plan.YearStart.HasValue ? plan.YearStart.Value.Year.ToString() : "";
            lblYearEnd.Text = plan.YearEnd.HasValue ? plan.YearEnd.Value.Year.ToString() : "";
            lblMandatory.Text = plan.IsMandatory ? "Tak" : "Nie";
            lblArchieved.Text = plan.IsArchiewed ? "Tak" : "Nie";
            tbReview.Text = plan.Review;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
