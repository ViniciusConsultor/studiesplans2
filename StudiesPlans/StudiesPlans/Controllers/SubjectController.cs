using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlans.Models;
using StudiesPlans.Models.Interfaces;

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
    }
}
