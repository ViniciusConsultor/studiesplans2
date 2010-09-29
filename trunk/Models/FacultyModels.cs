using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlansModels.Models
{
    public class NewFaculty : BaseModel
    {
        [RequiredAttribute(ErrorMessage = "Nazwa kierunku jest wymagana")]
        [StringLength(250, ErrorMessage = "Maksymalna długość nawy kierunku to 250 znaków")]
        public string FacultyName { get; set; }

        [Required(ErrorMessage = "Wybierz przynajmniej jeden wydział")]
        public IEnumerable<Departament> Departaments { get; set; }
    }

    public class FacultyEdit : BaseModel
    {
        [RequiredAttribute(ErrorMessage = "Nazwa kierunku jest wymagana")]
        [StringLength(250, ErrorMessage = "Maksymalna długość nawy kierunku to 250 znaków")]
        public string FacultyName { get; set; }

        [Required(ErrorMessage = "Wybierz przynajmniej jeden wydział")]
        public IEnumerable<Departament> Departaments { get; set; }

        public int FacultyID { get; set; }
    }
}
