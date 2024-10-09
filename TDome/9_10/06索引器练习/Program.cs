using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06索引器练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //鸟群
            Birds birds = new Birds();
            //鸟
            Bird bird = new Bird() { Name = "布谷", Age = 18 };
            Bird bird1 = new Bird() { Name = "百灵鸟", Age = 6 };
            //添加鸟
            birds.AddBird(bird);
            birds.AddBird(bird1);
            //调用set方法
            //bird["布谷"] = "啄木鸟";

            //调用get方法
            //birds["布谷"] 通过索引器查询到对应的鸟
            //对应的鸟.Age  获取到对应的年龄
            Console.WriteLine(birds["布谷"].Age);
        }
    }
}
