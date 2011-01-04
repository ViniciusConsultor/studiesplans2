using System.Collections.Generic;
using System.Linq;
using StudiesPlansModels.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FacultyModelTest
{
    [TestClass]
    public class NewFacultyTest
    {
        private NewFaculty _newFaculty;

        #region Additional test attributes

        [TestInitialize]
        public void MyTestInitialize()
        {
            _newFaculty = new NewFaculty();
        }

        #endregion


        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
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
