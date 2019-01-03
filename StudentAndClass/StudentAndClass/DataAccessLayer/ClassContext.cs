using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAndClass.Model;
using System.Data.Entity;

namespace StudentAndClass.DataAccessLayer
{
    public class ClassContext:DbContext
    {
        public DbSet<Class> Classes { get; set; }
        public DbSet<Students> Student { get; set; }
    }
}
