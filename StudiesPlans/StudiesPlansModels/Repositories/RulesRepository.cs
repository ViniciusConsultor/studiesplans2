using System.Collections.Generic;
using System.Linq;
using StudiesPlansModels.Models;
using StudiesPlansModels.Repositories.Interfaces;

namespace StudiesPlansModels.Repositories
{
    public class RulesRepository : IRulesRepository
    {
        public void AddRule(Rule rule)
        {
            if (rule != null)
            {
                Rule ruleToAdd = new Rule()
                {
                    PlanId = rule.PlanId,
                    Description = rule.Description,
                    Value = rule.Value,
                    Semester = rule.Semester,
                    Subject = rule.Subject,
                    SubjectType = rule.SubjectType
                };

                SPDatabase.DB.Rules.AddObject(ruleToAdd);
                SPDatabase.DB.SaveChanges();
            }
        }

        public IEnumerable<Rule> GetRules(int planId)
        {
            return (from Rule r in SPDatabase.DB.Rules where r.PlanId == planId select r);
        }

        public Rule GetRule(int ruleId)
        {
            return (from Rule r in SPDatabase.DB.Rules where r.RuleId == ruleId select r).FirstOrDefault();
        }

        public void DeleteRule(Rule rule)
        {
            if (rule != null)
            {
                SPDatabase.DB.Rules.DeleteObject(rule);
                SPDatabase.DB.SaveChanges();
            }
        }
    }
}
