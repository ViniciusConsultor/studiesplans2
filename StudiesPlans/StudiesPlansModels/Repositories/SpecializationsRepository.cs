using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlansModels.Models
{
    public class SpecializationsRepository : ISpecializationsRepository
    {
        public IEnumerable<Specialization> ListSpecializations()
        {
            return (from Specialization s in SPDatabase.DB.Specializations select s);
        }

        public IEnumerable<Specialization> ListSpecializations(int departamentId, int facultyId)
        {
            return (from Specialization s in SPDatabase.DB.Specializations 
                    where s.DepartamentID == departamentId && s.FacultyID == facultyId
                    select s);
        }

        public Specialization GetSpecialization(string name)
        {
            return (from Specialization s in SPDatabase.DB.Specializations
                    where string.Compare(s.Name, name, true) == 0
                    select s).FirstOrDefault();
        }

        public Specialization GetSpecialization(int specializationId)
        {
            return (from Specialization s in SPDatabase.DB.Specializations
                    where s.SpecializationID == specializationId
                    select s).FirstOrDefault();
        }

        public void AddSpecialization(NewSpecialization toAdd)
        {
            if (toAdd != null)
            {
                Specialization i = new Specialization()
                {
                    Name = toAdd.SpecializationName,
                    FacultyID = toAdd.FacultyId,
                    DepartamentID = toAdd.DepartamentId
                };

                SPDatabase.DB.Specializations.AddObject(i);
                SPDatabase.DB.SaveChanges();
            }
        }

        public SpecializationEdit GetSpecializationEdit(string specializationame)
        {
            Specialization s = this.GetSpecialization(specializationame);
            if (s != null)
            {
                SpecializationEdit ss = new SpecializationEdit()
                {
                    SpecializationID = s.SpecializationID,
                    SpecializationName = s.Name,
                    DepartamentId = s.DepartamentID,
                    FacultyId = s.FacultyID
                };
                return ss;
            }

            return null;
        }

        public SpecializationDataEdit GetSpecializationEdit(string specName, int planId, bool general, bool elective, string subjectName, int semesterValue)
        {
            SpecializationsData sd = (from SpecializationsData ssd in SPDatabase.DB.SpecializationsDatas.Include("SubjectDatas")
                                      from SubjectsData subDat in ssd.SubjectsDatas
                                      from Plan p in subDat.Plans
                                      where string.Compare(ssd.Specialization.Name, specName, true) == 0 &&
                                      string.Compare(subDat.Subject.Name, subjectName, true) == 0 &&
                                      ssd.IsGeneral == general && ssd.IsElective == elective &&
                                      subDat.Semester.Semester1 == semesterValue &&
                                      p.PlanID == planId
                                      select ssd).FirstOrDefault();

            SpecializationDataEdit sde = new SpecializationDataEdit()
            {
                IsElective = sd.IsElective,
                IsGenereal = sd.IsGeneral,
                SpecializationDataID = sd.SpecializationDataID,
                SpecializationId = sd.SpecializationID
            };

            return sde;
                                      
        }

        public Specialization GetSpecialization(string specializationName, string departamentName, string facultyName)
        {
            return (from Specialization s in SPDatabase.DB.Specializations
                    where string.Compare(s.Name, specializationName, true) == 0 &&
                    string.Compare(s.Departament.Name, departamentName, true) == 0 &&
                    string.Compare(s.Faculty.Name, facultyName, true) == 0
                    select s).FirstOrDefault();
        }

        public Specialization GetSpecialization(string specializationName, int departamentId, int facultyId)
        {
            return (from Specialization s in SPDatabase.DB.Specializations
                    where string.Compare(s.Name, specializationName, true) == 0 &&
                    s.DepartamentID == departamentId &&
                    s.FacultyID == facultyId
                    select s).FirstOrDefault();
        }

        public void DeleteSpecialization(Specialization s)
        {
            SPDatabase.DB.Specializations.DeleteObject(s);
            SPDatabase.DB.SaveChanges();
        }

        public void EditSpecialization(Specialization toEdit)
        {
            if (toEdit != null)
            {
                SPDatabase.DB.SaveChanges();
            }
        }
    }
}
