using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NewMusic.Models
{
    public class MusicCC
    {
        [Display(Name ="歌曲编号")]
        public int ID { get; set; }
        [Display(Name = "歌曲名称")]
        public string MusicName { get; set; }
    }
}