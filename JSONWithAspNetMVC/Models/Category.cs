using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSONWithAspNetMVC.Models
{
    public class Category
    {
        [Key]
        [Required(ErrorMessage = "The field {0} is Required.")]
        public int CategoryId { get; set; }

        [MaxLength(25)]
        public string CategoryName { get; set; }

        //Mapping
        //public virtual ICollection<BLog> Blogs { get; set; }

    }
}