using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlansModels.Models
{
    public class NewRole : BaseModel
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Nazwa roli nie może przekraczać 50 znaków")]
        public string RoleName { get; set; }
    }

    public class RoleEdit : BaseModel
    {
        [Required(ErrorMessage = "Nazwa jest wymagana")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Nazwa roli nie może przekraczać 50 znaków")]
        public string RoleName { get; set; }

        public int RoleID { get; set; }
    }
}
