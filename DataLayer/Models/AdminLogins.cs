using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class AdminLogins
    {
        [Key]
        public int LoginID { get; set; }

        [Display(Name = "UserName")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200)]
        public string UserName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(250)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200)]
        public string Password { get; set; }
    }
}
