using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelReview.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Display(Name ="Planet Name")]
        public string PlanetName { get; set; }
        [Display(Name ="Planet Type")]
        public string PlanetType { get; set; }

        public virtual ICollection<Reviews> Reviews { get; set; }

    }
}