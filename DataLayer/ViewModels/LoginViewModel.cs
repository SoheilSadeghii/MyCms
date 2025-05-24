using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.ViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200)]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200)]
        [DataType(DataType.Password)]
        public string Password { get; set; }    

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
