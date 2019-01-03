using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndClass.Model
{
    public class Class
    {
        public string ClassName { get; set; }
        public long ClassId { get; set; }
        public long StudentsId { get; set; }
        public virtual List<Class> Classes { get; set; }
    }
}
