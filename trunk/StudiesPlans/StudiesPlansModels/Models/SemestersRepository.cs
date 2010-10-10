using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlansModels.Models
{
    public class SemestersRepository : ISemestersRepository
    {
        public IEnumerable<Semester> ListSemesters()
        {
            return (from Semester s in SPDatabase.DB.Semesters select s);
        }

        public Semester GetSemester(string semesterName, int semesterNo, int semesterYear)
        {
            return (from Semester s in SPDatabase.DB.Semesters
                    where s.StudyYear == semesterYear && s.Semester1 == semesterNo &&
                    string.Compare(semesterName, s.Name, true) == 0
                    select s).FirstOrDefault();
        }

        public Semester GetSemester(int semesterId)
        {
            return (from Semester s in SPDatabase.DB.Semesters
                    where s.SemesterID == semesterId
                    select s).FirstOrDefault();
        }

        public void AddSemester(NewSemester toAdd)
        {
            if (toAdd != null)
            {
                Semester s = new Semester()
                {
                    Name = toAdd.SemesterName,
                    Semester1 = toAdd.SemesterNo,
                    StudyYear = toAdd.SemesterYear
                };

                SPDatabase.DB.Semesters.AddObject(s);
                SPDatabase.DB.SaveChanges();
            }
        }

        public void DeleteSpecialization(Semester s)
        {
            SPDatabase.DB.Semesters.DeleteObject(s);
            SPDatabase.DB.SaveChanges();
        }

        public void EditSemester(Semester toEdit)
        {
            if (toEdit != null)
            {
                SPDatabase.DB.SaveChanges();
            }
        }
    }
}
