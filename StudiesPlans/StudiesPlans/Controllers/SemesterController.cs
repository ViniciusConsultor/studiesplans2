using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using System.Data;

namespace StudiesPlans.Controllers
{
    public class SemesterController
    {
        private static SemesterController instance;
        private ISemestersRepository repository;

        public static SemesterController Instance
        {
            get
            {
                if (instance == null)
                    instance = new SemesterController(new SemestersRepository());

                return instance;
            }
        }

        public SemesterController(ISemestersRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Semester> ListSemesters()
        {
            return this.repository.ListSemesters();
        }

        public bool AddSemester(NewSemester toAdd)
        {
            Semester s = this.repository.GetSemester(toAdd.SemesterName, toAdd.SemesterNo, toAdd.SemesterYear);
            if (s != null)
                toAdd.AddError("Semestr o podanych danych już\nistnieje");

            if (toAdd.IsValid)
            {
                this.repository.AddSemester(toAdd);
                return true;
            }
            return false;
        }

        public SemesterEdit GetSemesterEdit(string semesterName, int semesterNo, int semesterYear)
        {
            Semester s = this.repository.GetSemester(semesterName, semesterNo, semesterYear);
            if (s != null)
            {
                SemesterEdit se = new SemesterEdit()
                {
                    SemesterID = s.SemesterID,
                    SemesterName = s.Name,
                    SemesterNo = s.Semester1,
                    SemesterYear = s.StudyYear
                };
                return se;
            }
            return null;
        }

        public void DeleteSemester(SemesterEdit toEdit)
        {
            Semester s = this.repository.GetSemester(toEdit.SemesterName, toEdit.SemesterNo, toEdit.SemesterYear);
            if (s != null && s.SubjectsDatas.Count > 0)
                throw new UpdateException("Nie można usunąć semestru,\nponieważ posiada powiązania");
            else
            {
                this.repository.DeleteSpecialization(s);
            }
        }

        public bool EditSemester(SemesterEdit toEdit)
        {
            if (toEdit != null)
            {
                Semester s = this.repository.GetSemester(toEdit.SemesterName, toEdit.SemesterNo, toEdit.SemesterYear);
                if (s != null && s.SemesterID != toEdit.SemesterID && s.Name.Equals(toEdit.SemesterName) && 
                    s.Semester1 == toEdit.SemesterNo && s.StudyYear == toEdit.SemesterYear)
                    toEdit.AddError("Semestr o takich danych\njuż istnieje");

                if (toEdit.IsValid)
                {
                    s = this.repository.GetSemester(toEdit.SemesterID);
                    s.Name = toEdit.SemesterName;
                    s.Semester1 = toEdit.SemesterNo;
                    s.StudyYear = toEdit.SemesterYear;

                    this.repository.EditSemester(s);
                    return true;
                }
            }
            return false;
        }
    }
}
