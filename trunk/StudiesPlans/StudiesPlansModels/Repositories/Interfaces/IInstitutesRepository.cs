using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface IInstitutesRepository
    {
        IEnumerable<Institute> ListInstitutes();

        Institute GetInstitute(string p);

        Institute GetInstitute(int instituteId);

        void AddInstitute(NewInstitute toAdd);

        void DeleteInstitute(Institute i);

        InstituteEdit GetInstituteEdit(string instituteName);

        void EditInstitute(Institute i);

        List<Institute> ListInstitutes(int departamentId);
    }
}
