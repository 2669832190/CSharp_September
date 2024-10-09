using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05索引器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Animal animals = new Animal();
            animals.Add("狗");
            animals.Add("猫");
            animals.Add("老鼠");

            //为什么这个不报错?
            animals[0] = "老虎";
            Console.WriteLine(animals[0]);

            //为什么这个报错?
            animals["猫"] = "鸟";
            Console.WriteLine(animals["猫"]);
            Console.WriteLine(animals["鸟"]);
            */

            //最终要的效果
            Bird birds = new Bird();
            birds.Add("布谷鸟");
            birds.Add("啄木鸟");
            birds[0] = "";
            Console.WriteLine(birds[0]);
            birds["布谷鸟"] = "";
            Console.WriteLine(birds["布谷鸟"]);
        }
    }

    //动物
    public class Animal
    {
        //用来保存动物的名字
        private List<string> list = new List<string>();

        //添加一个动物
        public void Add(string name)
        {
            list.Add(name);
        }
        //索引器
        //访问修饰符 返回值类型 当前对象[规定索引类型 变量名]
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        //自定义的字符串的索引器
        public string this[string name]
        {
            get
            {
                foreach (string item in list)
                {
                    if (item == name)
                    {
                        return item;
                    }
                }
                return null;
            }
            set
            {
                for(int i =0; i < list.Count; i++)
                {
                    if(list[i] == name)
                    {
                        list[i] = value;
                    }
                }
            }
        }
    }
}
