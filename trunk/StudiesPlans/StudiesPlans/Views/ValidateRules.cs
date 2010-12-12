using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StudiesPlansModels.Models;
using StudiesPlansModels.Repositories;
using StudiesPlansModels.Repositories.Interfaces;
using Telerik.WinControls;
using Rule = StudiesPlansModels.Models.Rule;

namespace StudiesPlans.Views
{
    public partial class ValidateRules : Telerik.WinControls.UI.RadForm
    {
        private readonly IRulesRepository _rulesRepository = new RulesRepository();
        private readonly Plan _selectedPlan;
        
        public ValidateRules(Plan selectedPlan)
        {
            InitializeComponent();
            _selectedPlan = selectedPlan;
            fillGrid();
        }

        private void validateRules()
        {
            ArrayList resultList = new ArrayList();

            IEnumerable<Rule> rules = _rulesRepository.GetRules(_selectedPlan.PlanID);
            if (rules.Count() != 0)
            {
                foreach (Rule rule in rules)
                {
                    if (rule.Description.Equals("Total ECTS Count"))
                        resultList.Add(ValidateTotalEctsCount(rule.Value));
                    if (rule.Description.Equals("Total ECTS Subject Count"))
                        resultList.Add(ValidateTotalEctsSubjectCount(rule.Value, rule.Subject));
                    if (rule.Description.Equals("Total ECTS Subject Count"))
                        resultList.Add(ValidateTotalEctsSubjectTypeCount(rule.Value, rule.SubjectType));
                    updateGrid(resultList);
                }
                

            }
            else
                RadMessageBox.Show(
                   "Nastąpił błąd - nie ma reguł dla zadanego planu!", "Brak reguł", MessageBoxButtons.OK, RadMessageIcon.Error);
        }

        private void fillGrid()
        {
            IEnumerable<Rule> rules = _rulesRepository.GetRules(_selectedPlan.PlanID);

            if( rules.Count() != 0)
            {
                const string semester = "Cały plan";
                foreach (Rule rule in rules)
                {
                    gvRules.Rows.Add(null, null);
                    
                    gvRules.Rows[gvRules.Rows.Count - 1].Cells["rule"].Value = rule.Description;
                    if (rule.Semester == 0)
                        gvRules.Rows[gvRules.Rows.Count - 1].Cells["semester"].Value = semester;
                    else
                        gvRules.Rows[gvRules.Rows.Count - 1].Cells["semester"].Value = rule.Semester;
                    gvRules.Rows[gvRules.Rows.Count - 1].Cells["subject"].Value = rule.Subject;
                    gvRules.Rows[gvRules.Rows.Count - 1].Cells["subjectType"].Value = rule.SubjectType;
                    gvRules.Rows[gvRules.Rows.Count - 1].Cells["value"].Value = rule.Value;
                }
            }
        }


        #region TotalEctsCount

        private bool ValidateTotalEctsCount(double expectedEcts)
        {
            if (_selectedPlan.SubjectsDatas.Count != 0)
            {
                double ectsCount = _selectedPlan.SubjectsDatas.Sum(sd => sd.Ects);
                if (expectedEcts.Equals(ectsCount))
                    return true;
                else
                    return false;
            }
            else
            {
                RadMessageBox.Show(
                   "Nastąpił błąd - w planie nie ma żadnego przedmiotu!", "Brak przedmiotów", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            return false;
        }
        
        #endregion

        #region TotalEctsSubjectCount

        private bool ValidateTotalEctsSubjectCount(double expectedEcts, string subject)
        {
            double ectsCount = 0;

            if (_selectedPlan.SubjectsDatas.Count != 0)
            {
                foreach (SubjectsData sd in _selectedPlan.SubjectsDatas.Where(sd => sd.Subject.Name.Equals(subject)))
                {
                    ectsCount = sd.Ects;
                }
                if (expectedEcts.Equals(ectsCount))
                    return true;
                else
                    return false;
            }
            else
            {
                RadMessageBox.Show(
                   "Nastąpił błąd - w planie nie ma żadnego przedmiotu!", "Brak przedmiotów", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            return false;
        }

        #endregion

        #region TotalEctsSubjectTypeCount

        private bool ValidateTotalEctsSubjectTypeCount(double expectedEcts, string subjectType)
        {
            double ectsCount = 0;

            if (_selectedPlan.SubjectsDatas.Count != 0)
            {
                foreach (SubjectsData sd in _selectedPlan.SubjectsDatas)
                {
                    foreach (SubjectTypesData st in sd.SubjectTypesDatas)
                    {
                        if (st.SubjectType.Name.Equals(subjectType))
                            ectsCount += sd.Ects;
                    }
                }
                if (expectedEcts.Equals(ectsCount))
                    return true;
                else
                    return false;
            }
            else
            {
                RadMessageBox.Show(
                   "Nastąpił błąd - w planie nie ma żadnego przedmiotu!", "Brak przedmiotów", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
            return false;
        }

        #endregion

        private void BtnVerifyClick(object sender, EventArgs e)
        {
            validateRules();
        }

        private void updateGrid(ArrayList resultList)
        {
            for (int i = 0; i < gvRules.Rows.Count; i++ )
            {
                gvRules.Rows[i].Cells["passed"].Value = resultList[i];
            }
        }

    }
}
