using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlansModels.Models
{
    public class NewPlan : BaseModel
    {
        [Required(ErrorMessage = "Nazwa planu jest wymagana")]
        [StringLength(100, ErrorMessage = "Maksymalna długość nazwy to 100 znaków")]
        public string Name { get; set; }

        public DateTime YearStart { get; set; }
        public DateTime YearEnd { get; set; }
        public int SemesterStart { get; set; }
        public int SemesterEnd { get; set; }

        [Required(ErrorMessage = "Wydział jest wymagany")]
        [Range(1, int.MaxValue, ErrorMessage = "Wybierz wydział")]
        public int DepartamentId { get; set; }

        [Required(ErrorMessage = "Kierunek jest wymagany")]
        [Range(1, int.MaxValue, ErrorMessage = "Wybierz kierunek")]
        public int FacultyId { get; set; }

        [Required(ErrorMessage = "Typ studiów jest wymagany")]
        [Range(1, int.MaxValue, ErrorMessage = "Wybierz typ studiów")]
        public int StudiesTypeId { get; set; }

        public int LastEditedUserId { get; set; }
    }
}
