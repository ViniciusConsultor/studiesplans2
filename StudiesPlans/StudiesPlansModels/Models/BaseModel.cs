using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using StudiesPlans.Models.Validation;
using System.Text.RegularExpressions;

namespace StudiesPlansModels.Models
{
    public class BaseModel
    {
        // List with error messages for each object which was validate
        public List<string> Errors { get; set; }
        
        // Method to validate object
        public bool IsValid
        {
            get
            {
                return Validate(this);
            }
        }

        // Private method to validate each property of object
        private bool Validate(Object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                bool valid = true;
                Object[] attributes = property.GetCustomAttributes(false);
                foreach (Object attribute in attributes)
                {
                    valid = ((ValidationAttribute)attribute).IsValid(property.GetValue(obj, null));
                    if (!valid)
                        this.AddError(((ValidationAttribute)attribute).ErrorMessage);
                }
            }
            if (Errors != null && Errors.Count > 0)
                return false;
            return true;
        }

        public void AddError(string errorMessage)
        {
            if (Errors == null)
                Errors = new List<string>();
            Errors.Add(errorMessage);
        }

        public void ClearErrors()
        {
            if (Errors != null)
                this.Errors.Clear();
        }
    }
}
