using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAndClass.Model
{
    public class Students
    {
        public long StudentsId { get; set; }
        public string StudentsName { get; set; }
        public string Sex { get; set; }
        public string ClassName { get; set; }
        public virtual Class Class { get; set; }
    }
}
