using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication1.Models;
using ConsoleApplication1.BussinessLayer;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // createBlog(); ////新增
            //Update();     ////修改
            Delete();      ////删除 
            QueryBlog();
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }


        //增加--交互

        static void createBlog()
        {
            Console.WriteLine("请输入一个博客名称");
            string name = Console.ReadLine();
            Blog blog = new Blog();
            blog.Name = name;
            BlogBussinessLayer bbl = new BlogBussinessLayer();
            bbl.Add(blog);
        }

        //显示全部博客
        static void QueryBlog()
        {
            BlogBussinessLayer bbl = new BlogBussinessLayer();
            var blogs = bbl.Query();
            foreach(var item in blogs)
            {
                
                Console.WriteLine(item.BlogId + " "+item.Name);
            }
        }

        //凭id来修改
        static void Update()
        {
            Console.WriteLine("请输入id");
            int id = int.Parse(Console.ReadLine());
            BlogBussinessLayer bbl = new BlogBussinessLayer();
            Blog blog = bbl.Query(id);
            Console.WriteLine("请输入新姓名");
            string name = Console.ReadLine();
            blog.Name = name;
            bbl.Update(blog);
        }
        //删除
        static void Delete()
        {
            BlogBussinessLayer bbl = new BlogBussinessLayer();
            Console.WriteLine("请输入id");
            int id = int.Parse(Console.ReadLine());
            Blog blog = bbl.Query(id);
            bbl.Delete(blog);
        }
    }
}
