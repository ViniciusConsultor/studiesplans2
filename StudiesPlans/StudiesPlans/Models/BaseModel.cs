using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.ComponentModel.DataAnnotations;

namespace StudiesPlans.Models
{
    public class BaseModel
    {
        List<string> Errors { get; set; }

        public BaseModel()
        {
            Errors = new List<string>();
        }

        public IEnumerable<string> GetErrors()
        {
            return Errors;
        }

        public void AddError(string error)
        {
            Errors.Add(error);
        }

        public bool IsValid()
        {
            Type type = this.GetType();
            PropertyInfo[] properties = type.GetProperties();
            bool wasError = false;
            foreach (PropertyInfo property in properties)
            {
                Object[] attributes2 = property.GetCustomAttributes(true);

                foreach (Object attr in attributes2)
                {
                    if (attr.GetType() == typeof(StringLengthAttribute))
                    {
                        StringLengthAttribute stringlength = (StringLengthAttribute)attr;
                        string temp = property.GetValue(this, null).ToString();
                        if (temp.Length < stringlength.MinimumLength || temp.Length > stringlength.MaximumLength)
                        {
                            this.AddError(stringlength.ErrorMessage);
                            wasError = true;
                        }
                    }
                    else if (attr.GetType() == typeof(RequiredAttribute))
                    {
                        if (property.GetValue(this, null).ToString() == null ||
                            property.GetValue(this, null).ToString().Equals(string.Empty) ||
                            property.GetValue(this, null).ToString().Equals(int.MinValue.ToString()))
                        {
                            this.AddError(((RequiredAttribute)attr).ErrorMessage);
                            wasError = true;
                        }
                    }
                }
            }
            if (wasError)
                return false;
            return true;
        }
    }
}
