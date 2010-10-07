using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlansModels.Models
{
    public class NewInstitute : BaseModel
    {
        [RequiredAttribute(ErrorMessage = "Nazwa instytutu jest wymagana")]
        [StringLength(300, ErrorMessage = "Maksymalna długość nawy instytutu to 300 znaków")]
        public string InstituteName { get; set; }

        [Required(ErrorMessage = "Wybierz przynajmniej jeden wydział")]
        public IEnumerable<Departament> Departaments { get; set; }
    }

    public class InstituteEdit : BaseModel
    {
        [RequiredAttribute(ErrorMessage = "Nazwa instytutu jest wymagana")]
        [StringLength(300, ErrorMessage = "Maksymalna długość nawy instytutu to 300 znaków")]
        public string InstituteName { get; set; }

        [Required(ErrorMessage = "Wybierz przynajmniej jeden wydział")]
        public IEnumerable<Departament> Departaments { get; set; }

        public int InstituteID { get; set; }
    }
}
