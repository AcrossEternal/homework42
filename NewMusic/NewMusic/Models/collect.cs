using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewMusic.Models
{
    public class Collect
    {
        public int CollectID { get; set; }
        public int GenreID { get; set; }
        public int AlbumID { get; set; }
        public int MusciID { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual Album Album { get; set; }
        public virtual LoveMusic LoveMusic { get; set; }
    }
}