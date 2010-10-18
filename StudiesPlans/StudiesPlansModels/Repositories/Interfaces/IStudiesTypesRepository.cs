using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface IStudiesTypesRepository
    {
        IEnumerable<StudiesType> ListStudiesTypes();

        StudiesType GetStudiesType(string studiesTypeName);

        void AddStudiesType(NewStudiesType toAdd);

        void DeleteStudiesType(StudiesType s);

        StudiesTypeEdit GetStudiesTypeEdit(string studiesTypeName);

        StudiesType GetStudiesType(int id);

        void EditStudiesType(StudiesType st);
    }
}
