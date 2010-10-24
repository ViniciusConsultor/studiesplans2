using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlans.Controllers
{
    public class SubjectController
    {
        private static SubjectController instance;
        private ISubjectsRepository repository;

        public static SubjectController Instance
        {
            get
            {
                if (instance == null)
                    instance = new SubjectController(new SubjectsRepository());

                return instance;
            }
        }

        public SubjectController(ISubjectsRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<SubjectsData> ListSubjects()
        {
            return this.repository.ListSubjects();
        }

        public bool AddSubject(NewSubject ns)
        {
            SubjectsData sd = this.repository.GetSubjectData(ns.Name, ns.DepartamentId, ns.Ects, ns.FacultyId, ns.InstituteId, ns.IsExam, ns.PlanId, ns.SemesterId);
            if (sd != null)
                ns.AddError("Przedmiot o podanych danych już istnieje w planie");

            if (ns != null && ns.IsValid)
            {
                this.repository.AddSubject(ns);
                return true;
            }
            return false;
        }

        public SubjectsData GetSubject(int subjectDataId)
        {
            return this.repository.GetSubjectData(subjectDataId);
        }
    }
}
