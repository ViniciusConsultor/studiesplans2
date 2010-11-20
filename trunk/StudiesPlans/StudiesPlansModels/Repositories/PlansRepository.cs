using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Repositories.Interfaces;
using StudiesPlansModels.Models;

namespace StudiesPlansModels.Repositories
{
    public class PlansRepository : IPlansRepository
    {
        public void AddPlan(NewPlan plan)
        {
            if (plan != null)
            {
                Plan toAdd = new Plan()
                {
                    DepartamentID = plan.DepartamentId,
                    FacultyID = plan.FacultyId,
                    IsMandatory = false,
                    Name = plan.Name,
                    SemesterEnd = plan.SemesterEnd,
                    SemesterStart = plan.SemesterStart,
                    StudiesTypeID = plan.StudiesTypeId,
                    LastEditUserID = plan.LastEditedUserId
                };

                SPDatabase.DB.Plans.AddObject(toAdd);
                SPDatabase.DB.SaveChanges();
            }
        }

        public IEnumerable<Plan> ListActivePlans()
        {
            return (from Plan p in SPDatabase.DB.Plans where p.IsArchiewed == false select p);
        }

        public Plan GetPlan(string planName)
        { 
            return (from Plan p in SPDatabase.DB.Plans
                    where string.Compare(planName, p.Name, true) == 0
                    select p).FirstOrDefault();
        }

        public Plan GetPlan(int planId)
        {
            return (from Plan p in SPDatabase.DB.Plans
                    where p.PlanID == planId
                    select p).FirstOrDefault();
        }

        public void AddPlanData(NewPlanData newPlanData)
        {
            if (newPlanData != null)
            {
                
            }
            
        }

        public IEnumerable<Plan> ListArchivedPlans()
        { 
            return (from Plan p in SPDatabase.DB.Plans where p.IsArchiewed == true select p);
        }
    }
}
