using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using System.Data;

namespace StudiesPlans.Controllers
{
    public class StudiesTypeController
    {
        private static StudiesTypeController instance;
        private IStudiesTypesRepository repository;

        public static StudiesTypeController Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudiesTypeController(new StudiesTypesRepository());

                return instance;
            }
        }

        public StudiesTypeController(StudiesTypesRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<StudiesType> ListStudiesTypes()
        {
            return this.repository.ListStudiesTypes();
        }

        public bool AddStudiesType(NewStudiesType toAdd)
        {
            StudiesType s = this.repository.GetStudiesType(toAdd.StudiesTypeName);
            if (s != null)
                toAdd.AddError("Typ studiów o takiej nazwie już\nistnieje");
            if (toAdd.IsValid)
            {
                this.repository.AddStudiesType(toAdd);
                return true;
            }
            return false;
        }

        public void DeleteStudiesType(StudiesTypeEdit toEdit)
        {
            StudiesType s = this.repository.GetStudiesType(toEdit.StudiesTypeName);
            if (s != null && s.Plans.Count > 0)
                throw new UpdateException("Nie można usunąć typu studiów,\nponieważ posiada powiązania");
            else
            {
                this.repository.DeleteStudiesType(s);
            }
        }

        public StudiesTypeEdit GetStudiesTypeEdit(string studiesTypeName)
        {
            return this.repository.GetStudiesTypeEdit(studiesTypeName);
        }

        public bool EditStudiesType(StudiesTypeEdit toEdit)
        {
            if (toEdit != null)
            {
                StudiesType st = this.repository.GetStudiesType(toEdit.StudiesTypeName);
                if (st != null && st.StudiesTypeID != toEdit.StudiesTypeID && st.Name.Equals(toEdit.StudiesTypeName))
                    toEdit.AddError("Typ studiów o takiej nazwie\njuż istnieje");

                if (toEdit.IsValid)
                {
                    st = this.repository.GetStudiesType(toEdit.StudiesTypeID);
                    st.Name = toEdit.StudiesTypeName;

                    this.repository.EditStudiesType(st);
                    return true;
                }
            }
            return false;
        }
    }
}
