using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCReviewSiteProject.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Display(Name="Location")]
        public string Name { get; set; }

        public virtual ICollection<Reviews>Reviews { get; set; }
    }
}