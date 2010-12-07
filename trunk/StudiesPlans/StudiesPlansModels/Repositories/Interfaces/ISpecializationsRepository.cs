using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudiesPlansModels.Models.Interfaces
{
    public interface ISpecializationsRepository
    {
        IEnumerable<Specialization> ListSpecializations();

        Specialization GetSpecialization(string name);

        void AddSpecialization(NewSpecialization toAdd);

        SpecializationEdit GetSpecializationEdit(string specializationName);

        void DeleteSpecialization(Specialization s);

        Specialization GetSpecialization(int id);

        void EditSpecialization(Specialization s);

        IEnumerable<Specialization> ListSpecializations(int departamentId, int facultyId);

        Specialization GetSpecialization(string specializationName, string departamentName, string facultyName);

        Specialization GetSpecialization(string specializationName, int departamentId, int facultyId);

        SpecializationDataEdit GetSpecializationEdit(string specName, int planId, bool general, bool elective, string subjectName, int semesterValue);
    }
}
