using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormCurd.Models
{
    public class SignUp
    {
        [Key]
        public int SignUpId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password",ErrorMessage ="Password Not Matched")]
        public string ConfirmPassword { get; set; }

    }
}
