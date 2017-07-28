using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Reviews
    {
        [Key]
        public int ReviewID { get; set; }

        [Display(Name = "Name")]
        public string ReviewerName { get; set; }

        [Display(Name = "Reviewer Location")]
        public string ReviewerHome { get; set; }

        [Display(Name = "Trip Date")]
        public string TravelDate { get; set; }

        [Display(Name = "Review Date")]
        public DateTime ReviewDate { get; set; }

        [Display(Name ="Review")]
        public string Review { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }
    }
}