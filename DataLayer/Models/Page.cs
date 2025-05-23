using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class Page
    {
        [Key]
        public int PageID { get; set; }

        [Display(Name = "Page Group")]
        [Required(ErrorMessage = "Please enter {0}")]
        public int GroupID { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(250)]
        public string Title { get; set; }

        [Display(Name = "Short Description")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(350)]
        [DataType(DataType.MultilineText)]
        public string ShortDescription { get; set; }

        [Display(Name = "Text")]
        [Required(ErrorMessage = "Please enter {0}")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Display(Name = "Views")]
        public int Visit { get; set; }

        [Display(Name = "Images")]
        public string ImageName { get; set; }

        [Display(Name = "Slider")]
        public bool ShowInSlider { get; set; }

        [Display(Name = "Creation Date")]
        [DisplayFormat(DataFormatString ="{0: yyyy/MM/dd}")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Tags Cloud")]
        public string Tags { get; set; }

        // Navigation Property
        public virtual PageGroup PageGroup { get; set; }

        public virtual List<PageComment> PageComments { get; set; }

        public Page()
        {
            
        }
    }
}
