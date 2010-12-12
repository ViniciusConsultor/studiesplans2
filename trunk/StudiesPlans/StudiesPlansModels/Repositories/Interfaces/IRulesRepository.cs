using System.Collections.Generic;
using StudiesPlansModels.Models;

namespace StudiesPlansModels.Repositories.Interfaces
{
    public interface IRulesRepository
    {
        void AddRule(Rule rule);

        IEnumerable<Rule> GetRules(int planId);

        Rule GetRule(int ruleId);

        void DeleteRule(Rule rule);
    }
}
