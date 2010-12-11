using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using StudiesPlansModels.Models;
using StudiesPlans.Controllers;

namespace StudiesPlans.Views
{
    public partial class PlanEdit : Telerik.WinControls.UI.RadForm
    {
        Plan LoadedPlan = null;

        public PlanEdit(Plan plan)
        {
            InitializeComponent();
            this.LoadedPlan = plan;
            lblDepartament.Text = LoadedPlan.Departament.Name;
            lblFaculty.Text = LoadedPlan.Faculty.Name;
            lblName.Text = LoadedPlan.Name;
            tbReview.Text = LoadedPlan.Review;
            cbMandatory.Checked = LoadedPlan.IsMandatory;
            CheckMandatory(LoadedPlan.IsMandatory);
            FillWithYears(LoadedPlan.YearStart.HasValue? LoadedPlan.YearStart.Value.Year : 0,
                LoadedPlan.YearEnd.HasValue? LoadedPlan.YearEnd.Value.Year : 0);

            ShowButtonsToolTips();
        }

        private void ShowButtonsToolTips()
        {
            btnClose.ButtonElement.ToolTipText = "Zamknij";
            btnSave.ButtonElement.ToolTipText = "Zapisz zmiany";
        }

        private void CheckMandatory(bool mandatory)
        {
            if (mandatory)
            {
                dlYearEnd.Enabled = true;
                dlYearStart.Enabled = true;
            }
            else
            {
                dlYearEnd.Enabled = false;
                dlYearStart.Enabled = false;
            }
        }

        private void FillWithYears(int selectedStart, int selectedEnd)
        {
            int index = 0;
            for (int i = DateTime.Now.Year + 20; i > 1939; i--)
            {
                dlYearEnd.Items.Add(i.ToString());
                dlYearStart.Items.Add(i.ToString());

                if (i == selectedStart)
                    dlYearStart.SelectedIndex = index;
                if (i == selectedEnd)
                    dlYearEnd.SelectedIndex = index;

                index++;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (LoadedPlan.IsMandatory == true && cbArchieved.Checked == true)
            {
                if (DateTime.Now.Year < this.LoadedPlan.YearStart.Value.Year)
                {
                    RadMessageBox.Show("Nie mo¿na zarchiwizowaæ planu, dla którego\nrok zakoñczenia nie nast¹pi³", "B³¹d");
                    return;
                }
                this.LoadedPlan.IsArchiewed = cbArchieved.Checked;
                this.LoadedPlan.IsMandatory = false;
            }
            else if(cbArchieved.Checked == true)
                RadMessageBox.Show("Plan musi obowi¹zywaæ zanim zostanie zarchiwizowany", "B³¹d");

            if (!LoadedPlan.IsArchiewed)
            {
                this.LoadedPlan.IsMandatory = cbMandatory.Checked;
            }

            this.LoadedPlan.YearStart = DateTime.ParseExact(dlYearStart.SelectedItem.ToString(), "yyyy", null);
            this.LoadedPlan.YearEnd = DateTime.ParseExact(dlYearEnd.SelectedItem.ToString(), "yyyy", null); 
            this.LoadedPlan.Review = tbReview.Text;

            if (PlanController.Instance.EditPlan(LoadedPlan))
            {
                RadMessageBox.Show("Zmiany zosta³y zapisane", "Wiadomoœæ");
                this.Close();
            }
            else
                RadMessageBox.Show("Wyst¹pi³ b³¹d", "Wiadomoœæ");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbMandatory_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            CheckMandatory(cbMandatory.Checked);
        }

        private void cbArchieved_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            CheckArchieved(cbArchieved.Checked);
        }

        private void CheckArchieved(bool archieved)
        {
            if (archieved)
            {
                dlYearEnd.Enabled = false;
                dlYearStart.Enabled = false;
                cbMandatory.Enabled = false;
                cbMandatory.Checked = false;
            }
            else
            {
                dlYearEnd.Enabled = true;
                dlYearStart.Enabled = true;
                cbMandatory.Enabled = true;
            }
        }

        private void dlYearEnd_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (dlYearEnd.SelectedItem != null && dlYearStart.SelectedItem != null)
            {
                if (int.Parse(dlYearEnd.SelectedItem.ToString()) <= int.Parse(dlYearStart.SelectedItem.ToString()))
                {
                    FillWithYears(DateTime.Now.Year + 20, DateTime.Now.Year + 20);
                    RadMessageBox.Show("Rok zakoñczenia musi byæ wiêkszy od roku rozpoczêcia", "B³¹d");
                }
            }
        }
    }
}
