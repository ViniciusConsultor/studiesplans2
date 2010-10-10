using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlansModels.Models
{
    public class NewSemester : BaseModel
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(50, ErrorMessage = "Nazwa semestru nie może\nprzekraczać 50 znaków")]
        public string SemesterName { get; set; }

        [Required(ErrorMessage = "Numer semestru jest wymagany")]
        [Range(1, 50, ErrorMessage = "Numer semestru musi być\nz zakresu 1-50")]
        public int SemesterNo { get; set; }

        [Required(ErrorMessage = "Numer roku jest wymagany")]
        [Range(1, 25, ErrorMessage = "Numer roku  musi być\nz zakresu 1-25")]
        public int SemesterYear { get; set; }
    }

    public class SemesterEdit : BaseModel
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(50, ErrorMessage = "Nazwa semestru nie może\nprzekraczać 50 znaków")]
        public string SemesterName { get; set; }

        [Required(ErrorMessage = "Numer semestru jest wymagany")]
        [Range(1, 50, ErrorMessage = "Numer semestru musi być\nz zakresu 1-50")]
        public int SemesterNo { get; set; }

        [Required(ErrorMessage = "Numer roku jest wymagany")]
        [Range(1, 25, ErrorMessage = "Numer roku  musi być\nz zakresu 1-25")]
        public int SemesterYear { get; set; }

        public int SemesterID { get; set; }
    }
}
