using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudiesPlansModels.Models;
using StudiesPlansModels.Models.Interfaces;
using System.Data;

namespace StudiesPlans.Controllers
{
    public class InstituteController
    {
        private static InstituteController instance;
        private IInstitutesRepository repository;

        public static InstituteController Instance
        {
            get
            {
                if (instance == null)
                    instance = new InstituteController(new InstitutesRepository());

                return instance;
            }
        }

        public InstituteController(IInstitutesRepository repository)
        {
            this.repository = repository;
        }

        public List<Institute> ListInstitutes()
        {
            return this.repository.ListInstitutes().ToList<Institute>();
        }

        public bool AddInstitute(NewInstitute toAdd)
        {
            Institute i = this.repository.GetInstitute(toAdd.InstituteName);
            if (i != null)
                toAdd.AddError("Instytut o takiej nazwie już istnieje");
            if (toAdd.IsValid)
            {
                this.repository.AddInstitute(toAdd);
                return true;
            }
            return false;
        }

        public void DeleteInstitute(InstituteEdit toEdit)
        {
            Institute i = this.repository.GetInstitute(toEdit.InstituteName);
            if (i != null && i.SubjectsDatas.Count > 0)
                throw new UpdateException("Nie można usunąć instytutu,\nponieważ posiada powiązania");
            else
            {
                this.repository.DeleteInstitute(i);
            }
        }

        public InstituteEdit GetInstituteEdit(string instituteName)
        {
            return this.repository.GetInstituteEdit(instituteName);
        }

        public bool EditInstitute(InstituteEdit toEdit)
        {
            if (toEdit != null)
            {
                Institute i = this.repository.GetInstitute(toEdit.InstituteName);
                if (i != null && i.InstituteID != toEdit.InstituteID && i.Name.Equals(toEdit.InstituteName))
                    toEdit.AddError("Instytut o takiej nazwie już istnieje");

                if (toEdit.IsValid)
                {
                    i = this.repository.GetInstitute(toEdit.InstituteID);
                    i.Name = toEdit.InstituteName;
                    i.Departaments.Clear();
                    foreach (Departament d in toEdit.Departaments)
                        i.Departaments.Add(d);

                    this.repository.EditInstitute(i);
                    return true;
                }
            }
            return false;
        }

        public List<Institute> ListInstitutes(string departamentName)
        {
            Departament d = DepartamentController.Instance.GetDepartament(departamentName);
            if(d!=null)
                return this.repository.ListInstitutes(d.DepartamentID).ToList<Institute>();
            return null;
        }

        public Institute GetInstitute(string instituteName, int departamenId)
        {
            if (instituteName != null)
            {
                Institute institute = this.repository.GetInstitute(instituteName);

                if (institute != null)
                {
                    bool isDepartament = false;
                    foreach (Departament d in institute.Departaments)
                        if (d.DepartamentID == departamenId)
                        {
                            isDepartament = true;
                            break;
                        }

                    if (isDepartament)
                        return institute;
                }
                return null;
            }
            return null;
        }
    }
}
