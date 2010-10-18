using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlansModels.Models
{
    public class InstitutesRepository : IInstitutesRepository
    {
        public IEnumerable<Institute> ListInstitutes()
        {
            return (from Institute i in SPDatabase.DB.Institutes select i);
        }

        public Institute GetInstitute(string instituteName)
        {
            return (from Institute i in SPDatabase.DB.Institutes
                    where string.Compare(i.Name, instituteName, true) == 0
                    select i).FirstOrDefault();
        }

        public Institute GetInstitute(int instituteId)
        {
            return (from Institute i in SPDatabase.DB.Institutes
                    where i.InstituteID == instituteId
                    select i).FirstOrDefault();
        }

        public void AddInstitute(NewInstitute toAdd)
        {
            if (toAdd != null)
            {
                Institute i = new Institute()
                {
                    Name = toAdd.InstituteName,
                };
                foreach (Departament d in toAdd.Departaments)
                {
                    i.Departaments.Add(d);
                }

                SPDatabase.DB.Institutes.AddObject(i);
                SPDatabase.DB.SaveChanges();
            }
        }

        public void DeleteInstitute(Institute i)
        {
            SPDatabase.DB.Institutes.DeleteObject(i);
            SPDatabase.DB.SaveChanges();
        }

        public InstituteEdit GetInstituteEdit(string instituteName)
        {
            Institute i = this.GetInstitute(instituteName);
            i.Departaments.Load();
            if (i != null)
            {
                InstituteEdit ii = new InstituteEdit()
                {
                    InstituteName = i.Name,
                    InstituteID = i.InstituteID,
                    Departaments = i.Departaments
                };
                return ii;
            }

            return null;
        }

        public void EditInstitute(Institute toEdit)
        {
            if (toEdit != null)
            {
                SPDatabase.DB.SaveChanges();
            }
        }
    }
}
