using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Repositories.Interfaces;
using StudiesPlansModels.Models;
using StudiesPlansModels.Helpers;
using System.Data.Objects;

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

        public IEnumerable<Plan> ListPlans(PlanFilter filter)
        {
            var query = (from Plan p in SPDatabase.DB.Plans
                    where (filter.Name != null ? p.Name.Contains(filter.Name) : true)
                    && (filter.DepartamentName != null ? string.Compare(filter.DepartamentName, p.Departament.Name, true) == 0 : true)
                    && (filter.FacultyName != null ? string.Compare(filter.FacultyName, p.Faculty.Name, true) == 0 : true)
                    && (filter.All == true? true : ( p.IsArchiewed == filter.IsArchieved && p.IsMandatory == filter.IsMandatory)) //filter.IsArchieved)// && p.IsMandatory == filter.IsMandatory)
                    && ((filter.YearStart > 0 && p.YearStart.HasValue) ? filter.YearStart <= p.YearStart.Value.Year : true)
                    && ((filter.YearEnd > 0 && p.YearEnd.HasValue) ? filter.YearEnd <= p.YearEnd.Value.Year : true )
                    && ((filter.SemesterStart > 0 && p.SemesterStart.HasValue) ? filter.SemesterStart == p.SemesterStart.Value : true)
                    && ((filter.SemesterEnd > 0 && p.SemesterEnd.HasValue) ? filter.SemesterEnd == p.SemesterEnd.Value : true)
                    select p);
            return query;
        }

        public void EditPlan(Plan plan)
        {
            if (plan != null)
                SPDatabase.DB.SaveChanges();
        }
    }
}
