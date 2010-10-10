using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models.Interfaces;

namespace StudiesPlansModels.Models
{
    public class SubjectTypesRepository : ISubjectTypesRepository
    {
        public IEnumerable<SubjectType> ListSubjectTypes()
        {
            return (from SubjectType st in SPDatabase.DB.SubjectTypes select st);
        }

        public SubjectType GetSubjectType(string name)
        {
            return (from SubjectType st in SPDatabase.DB.SubjectTypes
                    where string.Compare(st.Name, name, true) == 0
                    select st).FirstOrDefault();
        }

        public SubjectType GetSubjectType(int subjectTypeId)
        {
            return (from SubjectType st in SPDatabase.DB.SubjectTypes
                    where st.SubjectTypeID == subjectTypeId
                    select st).FirstOrDefault();
        }

        public void AddSubjectType(NewSubjectType toAdd)
        {
            if (toAdd != null)
            {
                SubjectType st = new SubjectType()
                {
                    Name = toAdd.SubjectTypeName,
                };

                SPDatabase.DB.SubjectTypes.AddObject(st);
                SPDatabase.DB.SaveChanges();
            }
        }

        public SubjectTypeEdit GetSubjectTypeEdit(string subjectTypeName)
        {
            SubjectType st = this.GetSubjectType(subjectTypeName);
            if (st != null)
            {
                SubjectTypeEdit ste = new SubjectTypeEdit()
                {
                    SubjectTypeID = st.SubjectTypeID,
                    SubjectTypeName = st.Name
                };
                return ste;
            }

            return null;
        }

        public void DeleteSubjectType(SubjectType st)
        {
            SPDatabase.DB.SubjectTypes.DeleteObject(st);
            SPDatabase.DB.SaveChanges();
        }

        public void EditSubjectType(SubjectType toEdit)
        {
            if (toEdit != null)
            {
                SPDatabase.DB.SaveChanges();
            }
        }
    }
}
