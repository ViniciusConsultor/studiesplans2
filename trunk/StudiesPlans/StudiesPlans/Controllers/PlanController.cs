using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Repositories.Interfaces;
using StudiesPlansModels.Models;
using StudiesPlansModels.Repositories;
using StudiesPlansModels.Helpers;

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

            if (plan.SemesterEnd <= 0 || plan.SemesterStart <= 0)
                plan.AddError("Niepoprawna wartość semestru");

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
            return this.repository.ListActivePlans().ToList<Plan>();
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

        public List<Plan> ListArchivedPlans()
        {
            return this.repository.ListArchivedPlans().ToList();
        }

        public void CopyArchivePlan(int sourcePlanId, int targetPlanId)
        {
            Plan source = this.repository.GetPlan(sourcePlanId);
            Plan target = this.repository.GetPlan(targetPlanId);
            
            if (source != null && target != null)
            {
                foreach (SubjectsData sd in source.SubjectsDatas)
                {
                    NewSubject ns = new NewSubject()
                    {
                        PlanId = targetPlanId,
                        DepartamentId = sd.DepartamentID,
                        Ects = sd.Ects,
                        FacultyId = sd.FacultyID,
                        IsElective = sd.IsElective,
                        IsExam = sd.IsExam,
                        IsGeneral = sd.IsGeneral,
                        Name = sd.Subject.Name,
                        SemesterId = sd.SemesterID,
                    };

                    if(sd.SpecializationsData != null)
                    {
                        List<NewSpecializationData> specList = new List<NewSpecializationData>();
                        NewSpecializationData nsd = new NewSpecializationData()
                        {
                            IsElective = sd.SpecializationsData.IsElective,
                            IsGenereal = sd.SpecializationsData.IsGeneral,
                            SpecializationId = sd.SpecializationsData.SpecializationID
                        };

                        specList.Add(nsd);
                        ns.Specializations = specList.AsEnumerable();
                    }

                    List<NewSubjectTypeData> nstdList = new List<NewSubjectTypeData>();

                    foreach (SubjectTypesData std in sd.SubjectTypesDatas)
                    {
                        NewSubjectTypeData nstd = new NewSubjectTypeData()
                        {
                            Hours = (float)std.Hours,
                            SubjectTypeId = std.SubjectTypeID
                        };

                        nstdList.Add(nstd);
                    }

                    ns.SubjectTypes = nstdList.AsEnumerable();

                    if (sd.InstituteID > 0)
                        ns.InstituteId = (int)sd.InstituteID;
                    else
                        sd.InstituteID = null;

                    SubjectController.Instance.AddSubject(ns);
                }
            }
        }

        public List<Plan> ListPlans(PlanFilter filter)
        {
            return this.repository.ListPlans(filter).ToList();
        }

        public bool EditPlan(Plan LoadedPlan)
        {
            try
            {
                this.repository.EditPlan(LoadedPlan);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
