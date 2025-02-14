using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageComment
    {
        [Key]
        public int GroupID { get; set; }

        [Display(Name = "Group Title")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(150)]
        public string GroupTitle { get; set; }

        // Navigation Property
        public virtual List<Page> Pages { get; set; }

        public PageComment()
        {
            
        }
    }
}
