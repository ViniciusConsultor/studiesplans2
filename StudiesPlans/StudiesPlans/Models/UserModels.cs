using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using StudiesPlans.Models.Validation;

namespace StudiesPlans.Models
{
    public class UserEdit : BaseModel
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Nazwa użytkownika musi mieć minimum 6 i maksimum 30 znaków")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Hasło musi mieć minimum 6 i maksimum 30 znaków")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Hasło musi mieć minimum 6 i maksimum 30 znaków")]
        public string RepeatPassword { get; set; }

        // TODO: email validation
        [StringLength(100, ErrorMessage = "Email może mieć maksymalnie 100 znaków")]
        [EmailAttribute(ErrorMessage = "Nieprawidłowy adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Rola jest wymagana")]
        public int RoleID { get; set; }

        public UserEdit(User user)
        {
            this.UserID = user.UserID;
            this.UserName = user.Name;
            this.Email = user.Email;
            this.RoleID = user.RoleID;
            this.Password = string.Empty;
            this.RepeatPassword = string.Empty;
        }
    }

    public class UserLastActive
    {
        public int UserID { get; set; }
        public DateTime LastActiveDate { get; set; }
    }

    public class NewUser : BaseModel
    {
        [Required(ErrorMessage = "Nazwa użytkownika jest wymagana")]
        [StringLength(30, MinimumLength = 6, ErrorMessage = "Nazwa użytkownika musi mieć minimum 6 i maksimum 30 znaków")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Hasło musi mieć minimum 6 i maksimum 30 znaków")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Hasło jest wymagane")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "Hasło musi mieć minimum 6 i maksimum 30 znaków")]
        public string RepeatPassword { get; set; }

        // TODO: email validation
        [StringLength(100, ErrorMessage = "Email może mieć maksymalnie 100 znaków")]
        [EmailAttribute(ErrorMessage = "Nieprawidłowy adres email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Rola jest wymagana")]
        public int RoleID { get; set; }

        public NewUser()
        {
            this.UserName = string.Empty;
            this.Email = string.Empty;
            this.RoleID = int.MinValue;
            this.Password = string.Empty;
            this.RepeatPassword = string.Empty;
        }
    }
    
    public class UserLogin : BaseModel
    {
        [Required(ErrorMessage = "Podaj nazwę użytkownika")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Podaj hasło")]
        public string Password { get; set; }

        public int UserId { get; set; }
    }
}
