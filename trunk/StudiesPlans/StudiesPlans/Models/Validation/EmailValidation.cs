using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlans.Models.Validation
{
    public class EmailAttribute : RegularExpressionAttribute
    {
        public EmailAttribute() : base(@"^[\w+-]+(\.[\w+-]+)*@(([a-zA-Z]|([a-zA-Z][0-9])|([0-9][a-zA-Z])|([a-zA-Z]{2})|([a-zA-Z0-9][a-zA-Z0-9-]*[a-zA-Z0-9]))\.)+[a-zA-Z0-9]{2,6}$")
        {}
    }
}
