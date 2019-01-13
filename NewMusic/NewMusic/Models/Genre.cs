using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMusic.Models
{
    public class Genre
    {
        [Key]
        public int GenreID { get; set; }
        [Display(Name="流派名称")]
        public string GenreName { get; set; }

        public virtual ICollection<Collect> Collects { get; set; }
    }
}