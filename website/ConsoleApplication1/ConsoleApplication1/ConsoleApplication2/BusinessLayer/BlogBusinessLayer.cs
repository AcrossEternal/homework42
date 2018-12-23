using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.DataAccessLayer;
using System.Data.Entity;

namespace ConsoleApplication2.BusinessLayer
{
    public class BlogBusinessLayer
    {
        public void Add(Blogs blog)
        {
            using (var db=new BloggingContext())
            {
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
        }
        public List<Blogs> Query()
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.ToList();
            }
        }
        public Blogs QueryBlog(int id)
        {
            using (var db = new BloggingContext())
            {
                return db.Blogs.Find(id);
            }
        }
        public void Update(Blogs blog)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(blog).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
        public void Delete(Blogs blog)
        {
            using (var db = new BloggingContext())
            {
                db.Entry(blog).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }
    }
}
