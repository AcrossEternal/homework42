using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numList = { 10, 20, 30, 40, 11, 21, 31, 41 };
            var query1 = from x in numList
                         where (x % 2 == 0) && (x > 20)
                         select x;

            var query2 = numList.Where(x => x % 2 == 0).OrderBy(x => x).FirstOrDefault();

            foreach (var item in query1)
            {
                Console.Write(item.ToString() + " ");
            }

            string[] names = { "abc", "aaa", "bde", "bade", "xyz657" };

            //string str1 = "asldfjldjflasdf";

            //string str2 = "ok";

            //int y = String.Compare(str,"abc");
            //静态成员调用 类名.方法名

            //Console.WriteLine(y);


            var query = names.Where(s => s.Contains("abc")).FirstOrDefault();
             
            foreach (var item in query)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.ReadKey();
        }
    }
}
