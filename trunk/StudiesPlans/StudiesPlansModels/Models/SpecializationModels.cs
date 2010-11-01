using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlansModels.Models
{
    public class NewSpecialization : BaseModel
    {
        [RequiredAttribute(ErrorMessage = "Nazwa specjalizacji jest wymagana")]
        [StringLength(150, ErrorMessage = "Maksymalna długość nazwy\nspecjalizacji to 150 znaków")]
        public string SpecializationName { get; set; }

        [Required(ErrorMessage = "Wydział jest wymagany")]
        public int DepartamentId { get; set; }

        [Required(ErrorMessage = "Kierunek jest wymagany")]
        public int FacultyId { get; set; }
    }

    public class SpecializationEdit : BaseModel
    {
        [RequiredAttribute(ErrorMessage = "Nazwa specjalizacji jest wymagana")]
        [StringLength(150, ErrorMessage = "Maksymalna długość nazwy\nspecjalizacji to 150 znaków")]
        public string SpecializationName { get; set; }

        public int SpecializationID { get; set; }

        [Required(ErrorMessage = "Wydział jest wymagany")]
        public int DepartamentId { get; set; }

        [Required(ErrorMessage = "Kierunek jest wymagany")]
        public int FacultyId { get; set; }
    }

    public class NewSpecializationData : BaseModel
    { 
        public int SpecializationId { get; set; }

        public bool IsElective { get; set; }

        public bool IsGenereal { get; set; }
    }
}
