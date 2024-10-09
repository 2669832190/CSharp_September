using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业答案
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff staff1 = new Staff(11, "张三", 20, 8000);
            Staff staff2 = new Staff(12, "李四", 80, 15000);
            Staff staff3 = new Staff(13, "王五", 60, 3000);

            //把信息保存到list里
            List<Staff> list = new List<Staff>();
            list.Add(staff1);
            list.Add(staff2);
            list.Add(staff3);

            //20 80 60
            //20 60 80
            //数组名称.Sort( 两个参数的返回int的lambda表达式 )
            //数组将每两个元素依次放入表达式 如果返回结果为正数 交换位置
            list.Sort((x, y) => y.Age - x.Age);
            //数组名称.ForEach( 一个参数的没有返回值的lambda表达式 )
            //数组会将每一个元素依次放入表达式 运行
            list.ForEach(x => x.printStaffInfo());

            list.Sort((x, y) => (int)(y.AfterTaxSalary - y.AfterTaxSalary));
            list.ForEach(x => x.printStaffInfo());
        }
    }
}
