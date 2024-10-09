using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01静态自增
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff1 = new Staff("张三");
            Staff staff2 = new Staff("李四");
            Staff staff3 = new Staff("王五");

            List<Staff> list = new List<Staff>();
            list.Add(staff1);
            list.Add(staff2);
            list.Add(staff3);


            list.ForEach(x => Console.WriteLine(x.Name + " : " + x.ID));
        }
    }
}
