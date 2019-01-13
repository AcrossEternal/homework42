using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMusic.Models
{
    public class LoveMusic
    {
        [Key]
        public int MusciID { get; set; }
        [Display(Name ="歌曲名字")]
        public string MusicName { get; set; }
        [Display(Name ="谁唱的歌曲")]
        public string MusicWhoName { get; set; }
        public virtual ICollection<Collect> Collects { get; set; }

    }
}