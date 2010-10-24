using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Repositories.Interfaces;
using StudiesPlansModels.Models;
using StudiesPlansModels.Repositories;

namespace StudiesPlans.Controllers
{
    public class PlanController
    {
        private static PlanController instance;
        private IPlansRepository repository;

        public static PlanController Instance
        {
            get
            {
                if (instance == null)
                    instance = new PlanController(new PlansRepository());

                return instance;
            }
        }

        public PlanController(PlansRepository repository)
        {
            this.repository = repository;
        }

        public bool AddPlan(NewPlan plan)
        {
            Plan p = this.repository.GetPlan(plan.Name);
            if (p != null && p.Name.ToLower().Equals(plan.Name.ToLower()))
                plan.AddError("Plan o podanej\nnazwie już istnieje");

            if (plan != null)
            {
                if (plan.IsValid)
                {
                    this.repository.AddPlan(plan);
                    return true;
                }
                else 
                    return false;
            }
            return false;
        }

        public List<Plan> ListPlans()
        {
            return this.repository.ListPlans().ToList<Plan>();
        }

        public Plan GetPlan(string planName)
        {
            return this.repository.GetPlan(planName);
        }

        public bool AddPlanData(NewPlanData npd)
        {
            SubjectsData sd = SubjectController.Instance.GetSubject(npd.SubjectId);
            Plan p = this.GetPlan(npd.PlanId);

            if (p == null || sd == null)
            {

                return false;
            }
            else
            {
                this.repository.AddPlanData(npd);
                return true;
            }
        }

        public Plan GetPlan(int planId)
        {
            return this.repository.GetPlan(planId);
        }
    }
}
