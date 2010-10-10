using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlansModels.Models
{
    public class NewSubjectType : BaseModel
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(50, ErrorMessage = "Nazwa typu przedmiotu nie może\nprzekraczać 50 znaków")]
        public string SubjectTypeName { get; set; }
    }

    public class SubjectTypeEdit : BaseModel
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(50, ErrorMessage = "Nazwa typu przedmiotu nie może\nprzekraczać 50 znaków")]
        public string SubjectTypeName { get; set; }

        public int SubjectTypeID { get; set; }
    }
}
