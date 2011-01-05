using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using StudiesPlansModels.Models;

namespace FacultyModelTest
{
    public class NewFacultyTest
    {
        private NewFaculty _newFaculty;

        [SetUp]
        public void Init()
        {
            _newFaculty = new NewFaculty();
        }

        [Test]
        public void ShouldCreateErrorMessageForNullDepartment()
        {
           const string errorMessage = "Wybierz przynajmniej jeden wydział";

           _newFaculty.Departaments = null;
           bool result = _newFaculty.IsValid;

           Assert.IsNotNull(_newFaculty);
           Assert.IsFalse(result);
           Assert.IsTrue(_newFaculty.Errors.Count > 0);
           Assert.IsTrue(_newFaculty.Errors.Contains(errorMessage));
        }

        [Test]
        public void ShouldNotCreateErrorMessageForValidDepartment()
        {
            var departaments = new List<Departament>();
            var d = new Departament {Name = "Department"};
            departaments.Add(d);
            _newFaculty.Departaments = departaments.AsEnumerable();
            _newFaculty.FacultyName = "Kierunek";
            bool result = _newFaculty.IsValid;

            Assert.IsNotNull(_newFaculty);
            Assert.IsTrue(result);
            Assert.IsNull(_newFaculty.Errors);
        }

        [Test]
        public void ShouldCreateErrorMessageForEmptyFacultyName()
        {
            const string errorMessage = "Nazwa kierunku jest wymagana";

            _newFaculty.FacultyName = "";
            bool result = _newFaculty.IsValid;
            
            Assert.IsNotNull(_newFaculty);
            Assert.IsFalse(result);
            Assert.IsTrue(_newFaculty.Errors.Count > 0);
            Assert.IsTrue(_newFaculty.Errors.Contains(errorMessage));
        }

        [Test]
        public void ShouldCreateErrorMessageForTooLongFacultyName()
        {
            const string errorMessage = "Maksymalna długość nawy kierunku to\n250 znaków";

            _newFaculty.FacultyName = "looooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooong";
            bool result = _newFaculty.IsValid;

            Assert.IsNotNull(_newFaculty);
            Assert.IsFalse(result);
            Assert.IsTrue(_newFaculty.Errors.Count > 0);
            Assert.IsTrue(_newFaculty.Errors.Contains(errorMessage));
        }

        [Test]
        public void ShouldNotCreateErrorMessageForCorrectFacultyName()
        {
            var departaments = new List<Departament>();
            var d = new Departament {Name = "Department"};
            departaments.Add(d);
            _newFaculty.FacultyName = "Kierunek";
            _newFaculty.Departaments = departaments.AsEnumerable();
            bool result = _newFaculty.IsValid;

            Assert.IsNotNull(_newFaculty);
            Assert.IsTrue(result);
            Assert.IsNull(_newFaculty.Errors);
        }
    }
    
}
