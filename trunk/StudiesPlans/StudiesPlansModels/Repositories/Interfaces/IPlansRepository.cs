using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using StudiesPlansModels.Helpers;

namespace StudiesPlansModels.Repositories.Interfaces
{
    public interface IPlansRepository
    {
        void AddPlan(NewPlan plan);

        IEnumerable<Plan> ListActivePlans();

        Plan GetPlan(string planName);

        Plan GetPlan(int planId);

        void AddPlanData(NewPlanData npd);

        IEnumerable<Plan> ListArchivedPlans();

        IEnumerable<Plan> ListPlans(PlanFilter filter);
    }
}
