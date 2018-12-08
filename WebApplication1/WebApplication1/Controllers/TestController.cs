using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public string CustomerName { get; private set; }
        public string Address { get; private set; }

        // GET: Test
        public string GetString()
        {
            return "你好，MVC！";
        }
        
        //public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "张三";
            c.Address = "柳州职业技术学院";
            return c;
        }
        public override string ToString()
        {
            return this.CustomerName + "-" + this.Address;
        }
    }
}