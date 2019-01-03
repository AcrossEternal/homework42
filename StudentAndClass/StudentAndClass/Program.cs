using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentAndClass.Model;
using StudentAndClass.BusinessLayer;

namespace StudentAndClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            createClass();
            //Update();
            //Delete();
            QueryClass();
            Console.WriteLine("按任意键退出");
            Console.ReadKey();
        }
        //增加
        static void createClass()
        {
            Console.WriteLine("请输入一个班级名称");
            string ClassName = Console.ReadLine();
            Class classe = new Class();
            classe.ClassName = ClassName;
            ClassBusinessLayer cbl = new ClassBusinessLayer();
            cbl.Add(classe);
        }
        //显示
        static void QueryClass()
        {
            ClassBusinessLayer cbl = new ClassBusinessLayer();
            var Classes = cbl.Query();
            foreach (var item in Classes)
            {
                Console.WriteLine(item.ClassId + " " + item.ClassName);
            }
        }
        //凭id来修改
        static void Update()
        {
            Console.WriteLine("请输入班级id");
            int id = int.Parse(Console.ReadLine());
            ClassBusinessLayer cbl = new ClassBusinessLayer();
            Class classe = cbl.Query(id);
            Console.WriteLine("请输入新的班级名称");
            string name = Console.ReadLine();
            classe.ClassName = name;
            cbl.Update(classe);
        }
        //删除
        static void Delete()
        {
            ClassBusinessLayer cbl = new ClassBusinessLayer();
            Console.WriteLine("请输入你要删除的班级id");
            int id = int.Parse(Console.ReadLine());
            Class classe = cbl.Query(id);
            cbl.Delete(classe);
        }
    }
}
