using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引用命名空间
//using 命名空间名称
using _01静态自增;

//声明一个命名空间
//namesapce 名称
//文件夹 仓库
namespace _02命名空间
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff("张三");
            Console.WriteLine(staff.ID + " : " + staff.Name);
        }
    }
}
