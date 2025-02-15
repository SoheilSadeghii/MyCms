using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageGroup
    {
        [Key]
        public int CommentID { get; set; }

        [Display(Name = "News")]
        [Required(ErrorMessage = "Please enter {0}")]
        public int PageID { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(150)]
        public string Name { get; set; }
        [Display(Name = "Email")]
        [MaxLength(200)]
        public string Email { get; set; }
        [Display(Name = "Website")]
        [MaxLength(200)]
        public string WebSite { get; set; }

        [Display(Name = "Comments")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(500)]
        public string Comment { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime CreateDate { get; set; }

        // Nvigation Property
        public virtual List<Page> Page { get; set; }

        public PageGroup()
        {
                
        }
    }
}
