using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;

namespace StudiesPlansModels.Repositories.Interfaces
{
    public interface IPlansRepository
    {
        void AddPlan(NewPlan plan);

        IEnumerable<Plan> ListPlans();

        Plan GetPlan(string planName);

        Plan GetPlan(int planId);

        void AddPlanData(NewPlanData npd);
    }
}
