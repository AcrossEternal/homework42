using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models
{
    public class Post
    {
        public string PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        //相当于数据库外码
        public int BlogId { get; set; }
        //
        public virtual Blog Blog { get; set; }
        
    }
}
