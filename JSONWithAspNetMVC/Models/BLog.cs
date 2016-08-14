using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace JSONWithAspNetMVC.Models
{
    [Table("NextPosts")]
    public class BLog
    {
        [Key]
        public int PostedId { get; set; }

        [MaxLength(500)]
        [Column(TypeName = "varchar")]
        public string PostTitle { get; set; }

        [MaxLength(1000)]
        [Column(TypeName = "text")]
        public string ShortPostContent { get; set; }

        [Column(TypeName ="text")]
        public string FullPostContent { get; set; }

        [MaxLength(255)]
        public string MataKeywords { get; set; }

        [MaxLength(500)]
        public string MetaDescription { get; set; }

        public DateTime PostAddDate { get; set; }

        public int CategoryId { get; set; }

        //Mapping
        //public virtual Category Category { get; set; }


    }
}