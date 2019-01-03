using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using StudentAndClass.Model;
using StudentAndClass.DataAccessLayer;

namespace StudentAndClass.BusinessLayer
{
    public class ClassBusinessLayer
    {
        public void Add(Class Class)
        {
            using (var db = new ClassContext())
            {
                db.Classes.Add(Class);
                //db.Entry(Blog).State = EntityState.Added;
                db.SaveChanges();
            }
        }
        public List<Class> Query()
        {
            using (var db = new ClassContext())
            {
                return db.Classes.ToList();
            }
        }
        public Class Query(int id)
        {
            using (var db = new ClassContext())
            {
                return db.Classes.Find(id);
            }
        }
        public void Update(Class classe)
        {
            using (var db = new ClassContext())
            {
                db.Entry(classe).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Delete(Class classe)
        {
            using (var db = new ClassContext())
            {
                db.Entry(classe).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
