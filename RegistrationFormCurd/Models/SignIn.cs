using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationFormCurd.Models
{
    public class SignIn
    {
        [Key]
        public int SignId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
