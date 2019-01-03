using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Models
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Name { get; set; }
        //导航属性，目的是通过博客对象访问对应到
        public virtual List<Post> Posts { get; set; }
    }
}
