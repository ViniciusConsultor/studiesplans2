using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using StudiesPlans.Controllers;
using StudiesPlansModels.Models;

namespace StudiesPlans.Views
{
    public partial class PlansLoad : Telerik.WinControls.UI.RadForm
    {
        public bool IsArchive { get; set; }

        public PlansLoad(bool archive)
        {
            InitializeComponent();
            IsArchive = archive;
            if (!this.IsArchive)
                FillWithPlans();
            else
                FillWithArchive();
        }

        private void FillWithArchive()
        {
            List<Plan> plans = PlanController.Instance.ListArchivedPlans();
            if (plans != null)
                foreach (Plan p in plans)
                    lstPlan.Items.Add(p.Name);
        }

        private void FillWithPlans()
        {
            List<Plan> plans = PlanController.Instance.ListPlans();
            if (plans != null)
                foreach (Plan p in plans)
                    lstPlan.Items.Add(p.Name);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Plan toLoad = PlanController.Instance.GetPlan(lstPlan.SelectedItem.ToString());
            if (toLoad != null)
            {
                if (!this.IsArchive)
                    StudiesPlans.Views.MainForm.LoadedPlan = toLoad;
                else
                    StudiesPlans.Views.MainForm.ArchivedPlan = toLoad;
                this.Close();
            }
            else
                MessageBox.Show("Wybrany plan nie istnieje");               
        }
    }
}
