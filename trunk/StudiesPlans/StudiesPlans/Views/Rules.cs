using System.Collections.Generic;
using System.Windows.Forms;
using StudiesPlansModels.Repositories;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using StudiesPlansModels.Repositories.Interfaces;
using Telerik.WinControls;

namespace StudiesPlans.Views
{
    public partial class Rules : Telerik.WinControls.UI.RadForm
    {
        private readonly ISubjectTypesRepository _subjectTypeRepository = new SubjectTypesRepository();
        private readonly IRulesRepository _rulesRepository = new RulesRepository();
        private readonly Plan _selectedPlan;
        public Rules()
        {
            InitializeComponent();
            FillDdlSubjectType();
        }

        public Rules(Plan selectedPlan)
        {
            InitializeComponent();
            _selectedPlan = selectedPlan;
            FillDdlSubjectType();
            FillDdlSemester();
            FillDdlSubject();
            addToRuleList();
        }

        private void FillDdlSubjectType()
        {
            if(_subjectTypeRepository.ListSubjectTypes() != null)
            foreach (var subjectType in _subjectTypeRepository.ListSubjectTypes())
            {
                ddlECTSSubjectType.Items.Add(subjectType.Name);
                ddlHoursSubjectType.Items.Add(subjectType.Name);   
            }
            else
            {
                cbTotalECTSSubjectTypeCount.Enabled = false;
                ddlECTSSubjectType.Enabled = false;
                tbECTSSubjectTypeCount.Enabled = false;
                cbTotalHoursSubjectTypeCount.Enabled = false;
                tbHoursSubjectTypeCount.Enabled = false;
                ddlHoursSubjectType.Enabled = false;

            }
        }

        private void FillDdlSemester()
        {
            if (_selectedPlan.SemesterEnd == null) return;
            int semesterCount = _selectedPlan.SemesterEnd.Value;
            ddlSemester.Items.Add("Cały plan");
            for(int i=1; i<=semesterCount; i++)
            {
                ddlSemester.Items.Add(i.ToString());
            }
        }

        private void FillDdlSubject()
        {
            if(_selectedPlan.SubjectsDatas.Count != 0)
            {
                foreach (SubjectsData sd in _selectedPlan.SubjectsDatas)
                {
                    ddlECTSSubject.Items.Add(sd.Subject.Name);
                    ddlHoursSubject.Items.Add(sd.Subject.Name);
                }
            }
            else
            {
                cbTotalECTSSubjectCount.Enabled = false;
                cbTotalHoursSubjectCount.Enabled = false;
                ddlECTSSubject.Enabled = false;
                ddlHoursSubject.Enabled = false;
                tbECTSSubjectCount.Enabled = false;
                tbHoursSubjectCount.Enabled = false;
            }
        }

        private void BtnAddRuleClick(object sender, System.EventArgs e)
        {
            if (ddlSemester.SelectedIndex != -1)
            {
                if (cbTotalECTSCount.Checked)
                    AddTotalEctsRule();
                if (cbTotalECTSSubjectTypeCount.Checked)
                    AddTotalEctsSubjectTypeRule();
                if (cbTotalECTSSubjectCount.Checked)
                    AddTotalEctsSubjectRule();
                if (cbTotalHoursCount.Checked)
                    AddTotalHoursRule();
                if (cbTotalHoursSubjectTypeCount.Checked)
                    AddTotalHoursSubjectTypeRule();
                if (cbTotalHoursSubjectCount.Checked)
                    AddTotalHoursSubjectRule();
                addToRuleList();
            }
            else
            {
                RadMessageBox.Show(
                    "Nastąpił błąd - nie wybrano czasu obowiązywania reguł", "Zakres reguł", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        #region Add_TotalEctsRule

        private void AddTotalEctsRule()
        {
            double parseValue;
            double.TryParse(tbECTSCount.Text, out parseValue);
            if (parseValue != 0)
            {
                Rule newRule = new Rule()
                {
                    PlanId = _selectedPlan.PlanID,
                    Description = "Total ECTS Count",
                    Semester = (short)ddlSemester.SelectedIndex,
                    Value = parseValue
                };
                _rulesRepository.AddRule(newRule);
            }
            else
            {
                RadMessageBox.Show(
                    "Nastąpił błąd - podana liczba ECTS jest nieprawidłowa. \n Reguła nie zostanie " +
                    "dodana", "Całkowita liczba punktów ECTS", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        #endregion

        #region Add_TotalEctsSubjectTypeRule

        private void AddTotalEctsSubjectTypeRule()
        {
            double parseValue;
            double.TryParse(tbECTSSubjectTypeCount.Text, out parseValue);
            if (parseValue != 0)
            {
                Rule newRule = new Rule()
                {
                    PlanId = _selectedPlan.PlanID,
                    Description = "Total ECTS Subject Type Count",
                    Semester = (short) ddlSemester.SelectedIndex,
                    SubjectType = ddlECTSSubjectType.SelectedText,
                    Value = parseValue
                };
                _rulesRepository.AddRule(newRule);
            }
            else
            {
                RadMessageBox.Show(
                    "Nastąpił błąd - podana liczba ECTS jest nieprawidłowa. \n Reguła nie zostanie " +
                    "dodana", "Sumaryczna liczba punktów ECTS dla przedmiotu typu:" + ddlECTSSubjectType.SelectedText, MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        #endregion

        #region Add_TotalEctsSubjectRule

        private void AddTotalEctsSubjectRule()
        {
            double parseValue;
            double.TryParse(tbECTSSubjectCount.Text, out parseValue);
            if (parseValue != 0)
            {
                Rule newRule = new Rule()
                {
                    PlanId = _selectedPlan.PlanID,
                    Description = "Total ECTS Subject Count",
                    Semester = (short)ddlSemester.SelectedIndex,
                    Subject = ddlECTSSubject.SelectedText,
                    Value = parseValue
                };
                _rulesRepository.AddRule(newRule);
            }
            else
            {
                RadMessageBox.Show(
                    "Nastąpił błąd - podana liczba ECTS jest nieprawidłowa. \n Reguła nie zostanie " +
                    "dodana", "Sumaryczna liczba punktów ECTS dla przedmiotu:" + ddlECTSSubject.SelectedText, MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        #endregion

        #region Add_TotalHoursRule

        private void AddTotalHoursRule()
        {
            double parseValue;
            double.TryParse(tbHoursCount.Text, out parseValue);
            if (parseValue != 0)
            {
                Rule newRule = new Rule()
                {
                    PlanId = _selectedPlan.PlanID,
                    Description = "Total Hours Count",
                    Semester = (short)ddlSemester.SelectedIndex,
                    Value = parseValue
                };
                _rulesRepository.AddRule(newRule);
            }
            else
            {
                RadMessageBox.Show(
                    "Nastąpił błąd - podana liczba godzin jest nieprawidłowa. \n Reguła nie zostanie " +
                    "dodana", "Sumaryczna liczba godzin", MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        #endregion

        #region Add_TotalHoursSubjectRule

        private void AddTotalHoursSubjectRule()
        {
            double parseValue;
            double.TryParse(tbHoursCount.Text, out parseValue);
            if (parseValue != 0)
            {
                Rule newRule = new Rule()
                {
                    PlanId = _selectedPlan.PlanID,
                    Description = "Total Hours Subject Count",
                    Semester = (short)ddlSemester.SelectedIndex,
                    Subject = ddlHoursSubject.SelectedText,
                    Value = parseValue
                };
                _rulesRepository.AddRule(newRule);
            }
            else
            {
                RadMessageBox.Show(
                    "Nastąpił błąd - podana liczba godzin jest nieprawidłowa. \n Reguła nie zostanie " +
                    "dodana", "Sumaryczna liczba godzin dla przedmiotu:" + ddlHoursSubject.SelectedText, MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        #endregion

        #region Add_TotalHoursSubjectTypeRule

        private void AddTotalHoursSubjectTypeRule()
        {
            double parseValue;
            double.TryParse(tbHoursCount.Text, out parseValue);
            if (parseValue != 0)
            {
                Rule newRule = new Rule()
                {
                    PlanId = _selectedPlan.PlanID,
                    Description = "Total Hours Subject Count",
                    Semester = (short)ddlSemester.SelectedIndex,
                    SubjectType = ddlHoursSubjectType.SelectedText,
                    Value = parseValue
                };
                _rulesRepository.AddRule(newRule);
            }
            else
            {
                RadMessageBox.Show(
                    "Nastąpił błąd - podana liczba godzin jest nieprawidłowa. \n Reguła nie zostanie " +
                    "dodana", "Sumaryczna liczba godzin dla przedmiotu typu:" + ddlHoursSubjectType.SelectedText, MessageBoxButtons.OK, RadMessageIcon.Error);
            }
        }

        #endregion

        private void addToRuleList()
        {
            ruleList.Items.Clear();
            IEnumerable<Rule> rules = _rulesRepository.GetRules(_selectedPlan.PlanID);
            if (rules != null)
            {
                foreach (Rule rule in rules)
                {
                    string semester = "Cały plan";
                    if (rule.Semester == 0)
                        ruleList.Items.Add(rule.Description + "  Value: " + rule.Value + "  Semester: " + semester +
                                           "  Subject: " + rule.Subject + "  SubjectType: " + rule.SubjectType);
                    else
                    {
                        ruleList.Items.Add(rule.Description + "  Value: " + rule.Value + "  Semester: " + rule.Semester +
                                           "  Subject: " + rule.Subject + "  SubjectType: " + rule.SubjectType);
                    }
                }
            }
        }
    }
}
