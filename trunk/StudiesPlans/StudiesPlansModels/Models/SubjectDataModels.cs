using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlansModels.Models
{
    public class NewSubject : BaseModel
    {
        [Required(ErrorMessage = "Nazwa przedmiotu jest wymagana")]
        [StringLength(150, ErrorMessage = "Nazwa może mieć maskymalnie 150 znaków")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Wydział jest wymagany")]
        public int DepartamentId { get; set; }

        [Required(ErrorMessage = "Kierunek jest wymagany")]
        public int FacultyId { get; set; }

        [Required(ErrorMessage = "Instytut jest wymagany")]
        public int InstituteId { get; set; }

        public bool IsExam { get; set; }

        [Required(ErrorMessage = "Semestr jest wymagany")]
        public int SemesterId { get; set; }

        [Required(ErrorMessage = "Punkty ECTS są wymagane")]
        public double Ects { get; set; }

        public IEnumerable<NewSubjectTypeData> SubjectTypes { get; set; }
    }
}
