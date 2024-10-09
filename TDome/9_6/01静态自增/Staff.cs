using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01静态自增
{
    public class Staff
    {
        public int ID {  get; set; }
        public string Name { get; set; }
        //每创建一个对象 自增1
        //静态属性: 这个属性属于类 不属于对象
        public static int Count { get; set; } = 1;

        public Staff(string name)
        {
            Name = name;
            //每创建一个对象 ID拿到Count的值
            ID = Count;
            //Count自增
            Count++;
        }
    }
}
