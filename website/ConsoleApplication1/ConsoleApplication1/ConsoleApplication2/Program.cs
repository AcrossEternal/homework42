using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.DataAccessLayer;
using ConsoleApplication2.BusinessLayer;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //QueryBlog();     ////显示所有博客
            //createBlog();  ////新增
            //Update();      ////修改
            //Delete();        ////删除     
            SelectBolg();
            AddPost();
            QueryBlog();
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
        static void AddPost()
        {
            //显示博客列表
            QueryBlog();
            
            //根据指定到博客信息创建新帖子
            NewPosts();
        }

        static void SelectBolg()
        {
            Console.WriteLine("请输入你要查询的博客");
            string name = Console.ReadLine();
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            var query = bbl.Query1();

            foreach (var item in query)
            {
                Console.Write(item.Name);
            }
        }

        static void NewPosts()
        {
            //用户选择某个博客（id）
            int blogId = GetBlogId();
            //显示指定博客的帖子列表
            DisplayPosts(blogId);
            //根据指定到博客信息创建新帖子 
            Posts post = new Posts();
            Console.WriteLine("请输入一个帖子主题");
            post.Title = Console.ReadLine();
            Console.WriteLine("请输入一个帖子内容");
            string Content = Console.ReadLine();
            post.BlogId = blogId;

            using (var db = new BloggingContext())
            {
                db.Posts.Add(post);

                // db.Entry(post).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
            }
        }

        //用户选择某个博客（id）
        static int GetBlogId()
        {
            Console.WriteLine("请输入你想要输入的博客id");
            int id = int.Parse(Console.ReadLine());
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            return id;
        }

        //显示指定博客的帖子列表
        static void DisplayPosts(int blogId)
        {
            Console.WriteLine(blogId + "的帖子列表");

            List<Posts> list = null;
            //根据博客id获取博客 
            using (var db = new BloggingContext())
            {
                Blogs blogs = db.Blogs.Find(blogId);
                //根据博客导航属性，获取所有该博客的帖子
                list = blogs.Posts.ToList();
            }
            //遍历所有帖子，显示帖子标题（博客号-帖子标题）
            foreach (var item in list)
            {
                Console.WriteLine(item.Blogs.BlogId + "--" + item.Title);
            }
        }

        //增加--交互
        static void createBlog()
        {
            Console.WriteLine("请输入一个你所要新增博客名称");
            string name = Console.ReadLine();
            Blogs blog = new Blogs();
            blog.Name = name;
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            bbl.Add(blog);
        }

        //显示全部博客
        static void QueryBlog()
        {
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            var blogs = bbl.Query1();
            foreach (var item in blogs)
            {

                Console.WriteLine(item.BlogId + " " + item.Name);
            }
        }

        //凭id来修改
        static void Update()
        {
            Console.WriteLine("请输入你想要修改姓名的博客id");
            int id = int.Parse(Console.ReadLine());
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            Blogs blog = bbl.QueryBlog(id);
            Console.WriteLine("请输入新姓名");
            string name = Console.ReadLine();
            blog.Name = name;
            bbl.Update(blog);
        }

        //删除
        static void Delete()
        {
            BlogBusinessLayer bbl = new BlogBusinessLayer();
            Console.WriteLine("请输入你想要删除的id");
            int id = int.Parse(Console.ReadLine());
            Blogs blog = bbl.QueryBlog(id);
            bbl.Delete(blog);
        }
    }
}
