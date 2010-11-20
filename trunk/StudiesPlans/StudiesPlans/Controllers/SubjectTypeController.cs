using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models.Interfaces;
using StudiesPlansModels.Models;
using System.Data;

namespace StudiesPlans.Controllers
{
    public class SubjectTypeController
    {
        private static SubjectTypeController instance;
        private ISubjectTypesRepository repository;

        public static SubjectTypeController Instance
        {
            get
            {
                if (instance == null)
                    instance = new SubjectTypeController(new SubjectTypesRepository());

                return instance;
            }
        }

        public SubjectTypeController(ISubjectTypesRepository repository)
        {
            this.repository = repository;
        }

        public List<SubjectType> ListSubjectTypes()
        {
            return this.repository.ListSubjectTypes().ToList<SubjectType>();
        }

        public bool AddSubjectType(NewSubjectType toAdd)
        {
            SubjectType st = this.repository.GetSubjectType(toAdd.SubjectTypeName);
            if (st != null)
                toAdd.AddError("Typ przedmiotu o takiej nazwie już\nistnieje");
            if (toAdd.IsValid)
            {
                this.repository.AddSubjectType(toAdd);
                return true;
            }
            return false;
        }

        public SubjectTypeEdit GetSubjectTypeEdit(string subjectTypeName)
        {
            return this.repository.GetSubjectTypeEdit(subjectTypeName);
        }

        public void DeleteSubjectType(SubjectTypeEdit toEdit)
        {
            SubjectType st = this.repository.GetSubjectType(toEdit.SubjectTypeName);
            if (st != null && st.SubjectTypesDatas.Count > 0)
                throw new UpdateException("Nie można usunąć typu przedmiotu,\nponieważ posiada powiązania");
            else
                this.repository.DeleteSubjectType(st);
        }

        public bool EditSubjectType(SubjectTypeEdit toEdit)
        {
            if (toEdit != null)
            {
                SubjectType st = this.repository.GetSubjectType(toEdit.SubjectTypeName);
                if (st != null && st.SubjectTypeID != toEdit.SubjectTypeID && st.Name.Equals(toEdit.SubjectTypeName))
                    toEdit.AddError("Typ przedmiotu o takiej nazwie\njuż istnieje");

                if (toEdit.IsValid)
                {
                    st = this.repository.GetSubjectType(toEdit.SubjectTypeID);
                    st.Name = toEdit.SubjectTypeName;

                    this.repository.EditSubjectType(st);
                    return true;
                }
            }
            return false;
        }

        public SubjectType GetSubjectType(string subjectTypeName)
        {
            return this.repository.GetSubjectType(subjectTypeName);
        }

        public SubjectType GetSubjectType(int subjectTypeId)
        {
            return this.repository.GetSubjectType(subjectTypeId);
        }
    }
}
