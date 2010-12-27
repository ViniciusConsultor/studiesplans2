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
                if (_selectedPlan.SubjectsDatas.Count != 0)
                {
                    foreach (Rule rule in rules)
                    {

                        if (rule.Description.Equals("Total ECTS Count"))
                            resultList.Add(ValidateTotalEctsCount(rule));
                        if (rule.Description.Equals("Total ECTS Subject Count"))
                            resultList.Add(ValidateTotalEctsSubjectCount(rule));
                        if (rule.Description.Equals("Total ECTS Subject Type Count"))
                            resultList.Add(ValidateTotalEctsSubjectTypeCount(rule));
                        if (rule.Description.Equals("Total Hours Count"))
                            resultList.Add(ValidateTotalHoursCount(rule));
                        if (rule.Description.Equals("Total Hours Subject Count"))
                            resultList.Add(ValidateTotalHoursSubjectCount(rule));
                        if (rule.Description.Equals("Total Hours Subject Type Count"))
                            resultList.Add(ValidateTotalHoursSubjectTypeCount(rule));
                    }
                    updateGrid(resultList);
                }
                else
                {
                    RadMessageBox.Show(
                        "W planie nie ma żadnego przedmiotu!", "Brak przedmiotów", MessageBoxButtons.OK,
                        RadMessageIcon.Info);
                }

            }
            else
                RadMessageBox.Show(
                   "Nie ma reguł dla zadanego planu!", "Brak reguł", MessageBoxButtons.OK, RadMessageIcon.Info);
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

        private bool ValidateTotalEctsCount(Rule rule)
        {
            if (_selectedPlan.SubjectsDatas.Count != 0)
            {
                double ectsCount = 0;
                foreach (SubjectsData sd in _selectedPlan.SubjectsDatas)
                {
                    if(rule.Semester == 0)
                        ectsCount += sd.Ects;
                    else
                    {
                        if (sd.Semester.Semester1.Equals(rule.Semester))
                            ectsCount += sd.Ects;
                    }
                }
                if (rule.Value.Equals(ectsCount))
                    return true;
                else
                    return false;
            }
            return false;
        }
        
        #endregion

        #region TotalEctsSubjectCount

        private bool ValidateTotalEctsSubjectCount(Rule rule)
        {
            double ectsCount = 0;

            if (_selectedPlan.SubjectsDatas.Count != 0)
            {
                foreach (SubjectsData sd in _selectedPlan.SubjectsDatas)
                {
                    if(rule.Subject.Equals(sd.Subject.Name))
                    {
                        if(rule.Semester == 0)
                            ectsCount += sd.Ects;
                        else
                         {
                             if (sd.Semester.Semester1.Equals(rule.Semester))
                                 ectsCount += sd.Ects;
                         }
                        ectsCount = sd.Ects;
                    }
                }
                if (rule.Value.Equals(ectsCount))
                    return true;
                else       
                    return false;
            }
            return false;
        }

        #endregion

        #region TotalEctsSubjectTypeCount

        private bool ValidateTotalEctsSubjectTypeCount(Rule rule)
        {
            double ectsCount = 0;

            if (_selectedPlan.SubjectsDatas.Count != 0)
            {
                foreach (SubjectsData sd in _selectedPlan.SubjectsDatas)
                {
                    foreach (SubjectTypesData st in sd.SubjectTypesDatas)
                    {
                        if (st.SubjectType.Name.Equals(rule.SubjectType))
                        {
                            if (rule.Semester == 0)
                                ectsCount += sd.Ects;
                            else
                            {
                                if (sd.Semester.Semester1.Equals(rule.Semester))
                                    ectsCount += sd.Ects;
                            }
                        }
                    }
                }
                if (rule.Value.Equals(ectsCount))
                    return true;
                else
                    return false;
            }
            return false;
        }

        #endregion

        #region TotalHoursCount

        private bool ValidateTotalHoursCount(Rule rule)
        {
            double hoursCount = 0;

            if (_selectedPlan.SubjectsDatas.Count != 0)
            {
                foreach (SubjectsData sd in _selectedPlan.SubjectsDatas)
                {
                        if (rule.Semester == 0)
                        {
                            foreach ( SubjectTypesData std in sd.SubjectTypesDatas)
                            {
                                hoursCount += std.Hours;
                            }
                        }
                        else
                        {
                            foreach (SubjectTypesData std in sd.SubjectTypesDatas)
                            {
                                if (sd.Semester.Semester1.Equals(rule.Semester))
                                hoursCount += std.Hours;
                            } 
                        }
                }
                if (rule.Value.Equals(hoursCount))
                    return true;
                else
                    return false;
            }
            return false;
        }

        #endregion

        #region TotalHoursSubjectCount

        private bool ValidateTotalHoursSubjectCount(Rule rule)
        {
            double hoursCount = 0;

            if (_selectedPlan.SubjectsDatas.Count != 0)
            {
                foreach (SubjectsData sd in _selectedPlan.SubjectsDatas)
                {
                    if (rule.Subject.Equals(sd.Subject.Name))
                    {
                        if (rule.Semester == 0)
                        {
                            foreach (SubjectTypesData std in sd.SubjectTypesDatas)
                            {
                                hoursCount += std.Hours;
                            }
                        }
                        else
                        {
                            foreach (SubjectTypesData std in sd.SubjectTypesDatas)
                            {
                                if (sd.Semester.Semester1.Equals(rule.Semester))
                                    hoursCount += std.Hours;
                            }
                        }
                    }
                }
                if (rule.Value.Equals(hoursCount))
                    return true;
                else
                    return false;
            }
            return false;
        }

        #endregion

        #region TotalHoursSubjectCount

        private bool ValidateTotalHoursSubjectTypeCount(Rule rule)
        {
            double hoursCount = 0;

            if (_selectedPlan.SubjectsDatas.Count != 0)
            {
                foreach (SubjectsData sd in _selectedPlan.SubjectsDatas)
                {
                    foreach (SubjectTypesData st in sd.SubjectTypesDatas)
                    {
                        if (st.SubjectType.Name.Equals(rule.Subject))
                        {
                            if (rule.Semester == 0)
                                hoursCount += st.Hours;
                            else
                            {
                                if (sd.Semester.Semester1.Equals(rule.Semester))
                                    hoursCount += st.Hours;
                            }
                        }
                    }
                }
                if (rule.Value.Equals(hoursCount))
                    return true;
                else
                    return false;
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
            if (resultList.Count != 0)
            {
                for (int i = 0; i < gvRules.Rows.Count; i++)
                {
                    gvRules.Rows[i].Cells["passed"].Value = resultList[i];
                }
            }
        }
    }
}
