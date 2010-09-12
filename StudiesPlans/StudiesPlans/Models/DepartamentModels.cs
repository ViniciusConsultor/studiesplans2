using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlans.Models
{
    public class NewDepartament : BaseModel
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(300, ErrorMessage = "Nazwa wydziału nie może\nprzekraczać 300 znaków")]
        public string DepartamentName { get; set; }
    }

    public class DepartamentEdit : BaseModel
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(300, ErrorMessage = "Nazwa wydziału nie może\nprzekraczać 300 znaków")]
        public string DepartamentName { get; set; }

        public int DepartamentID { get; set; }
    }
}
