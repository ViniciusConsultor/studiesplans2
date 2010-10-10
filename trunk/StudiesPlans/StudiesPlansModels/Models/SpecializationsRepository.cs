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
                    SpecializationName = s.Name
                };
                return ss;
            }

            return null;
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
