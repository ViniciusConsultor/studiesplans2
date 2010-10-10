using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlansModels.Models
{
    public class StudiesTypesRepository : IStudiesTypesRepository 
    {
        public IEnumerable<StudiesType> ListStudiesTypes()
        {
            return (from StudiesType s in SPDatabase.DB.StudiesTypes select s);
        }

        public StudiesType GetStudiesType(string name)
        {
            return (from StudiesType s in SPDatabase.DB.StudiesTypes
                    where string.Compare(s.Name, name, true) == 0
                    select s).FirstOrDefault();
        }

        public StudiesType GetStudiesType(int studiesTypeId)
        {
            return (from StudiesType s in SPDatabase.DB.StudiesTypes
                    where s.StudiesTypeID == studiesTypeId
                    select s).FirstOrDefault();
        }

        public void AddStudiesType(NewStudiesType toAdd)
        {
            if (toAdd != null)
            {
                StudiesType st = new StudiesType()
                {
                    Name = toAdd.StudiesTypeName,
                };

                SPDatabase.DB.StudiesTypes.AddObject(st);
                SPDatabase.DB.SaveChanges();
            }
        }

        public void DeleteStudiesType(StudiesType s)
        {
            SPDatabase.DB.StudiesTypes.DeleteObject(s);
            SPDatabase.DB.SaveChanges();
        }

        public StudiesTypeEdit GetStudiesTypeEdit(string studiesTypeName)
        {
            StudiesType s = this.GetStudiesType(studiesTypeName);
            if (s != null)
            {
                StudiesTypeEdit ss = new StudiesTypeEdit()
                {
                    StudiesTypeID = s.StudiesTypeID,
                    StudiesTypeName = s.Name
                };
                return ss;
            }

            return null;
        }

        public void EditStudiesType(StudiesType toEdit)
        {
            if (toEdit != null)
            {
                SPDatabase.DB.SaveChanges();
            }
        }

    }
}
