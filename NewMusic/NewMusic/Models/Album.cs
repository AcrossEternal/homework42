using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NewMusic.Models
{
    public class Album
    {
        [Key]
        public int AlbumID { get; set; }
        [Display(Name ="唱片标题")]
        public string Title { get; set; }
        [Display(Name ="流派")]
        public virtual ICollection<Collect> Collects { get; set; }
    }
}