using System.Windows.Forms;
using StudiesPlansModels.Models;
using StudiesPlansModels.Repositories;
using StudiesPlansModels.Repositories.Interfaces;
using Telerik.WinControls;

namespace StudiesPlans.Controllers
{
    public class RuleController
    {
        private static RuleController _instance;
        private readonly IRulesRepository _repository;

        public static RuleController Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RuleController(new RulesRepository());

                return _instance;
            }
        }

        public RuleController(IRulesRepository repository)
        {
            _repository = repository;
        }

        public Rule GetRule(int ruleId)
        {
            return _repository.GetRule(ruleId);
        }

        public bool DeleteRule(int ruleId)
        {
            Rule rule = _repository.GetRule(ruleId);
            if (rule != null)
            {
                _repository.DeleteRule(rule);
                return true;
            }
                
            else
            {
                RadMessageBox.Show(
                        "Nastąpił błąd - nie można usunąć reguły", "Usuwanie reguły", MessageBoxButtons.OK, RadMessageIcon.Error);
                return false;
            }
        }

        public bool DeleteRule(Rule rule)
        {
            if (rule != null)
            {
                _repository.DeleteRule(rule);
                return true;
            }

            else
            {
                RadMessageBox.Show(
                        "Nastąpił błąd - nie można usunąć reguły", "Usuwanie reguły", MessageBoxButtons.OK, RadMessageIcon.Error);
                return false;
            }
        }
    }
}
