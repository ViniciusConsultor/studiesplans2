using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlansModels.Models
{
    public class NewStudiesType : BaseModel
    {
        [RequiredAttribute(ErrorMessage = "Nazwa typu studiów jest wymagana")]
        [StringLength(100, ErrorMessage = "Maksymalna długość nazwy\nspecjalizacji to 150 znaków")]
        public string StudiesTypeName { get; set; }
    }

    public class StudiesTypeEdit : BaseModel
    {
        [RequiredAttribute(ErrorMessage = "Nazwa typu studiów jest wymagana")]
        [StringLength(100, ErrorMessage = "Maksymalna długość nazwy\typu studiów to 150 znaków")]
        public string StudiesTypeName { get; set; }

        public int StudiesTypeID { get; set; }
    }
}
