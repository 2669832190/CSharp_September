using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04继承的特性
{
    public class Animal
    {
        public string Name { get; set; }
        public string Type { get; set; } = "动物";
        public int Age { get; set; }

        public Animal(string Name, string Type, int Age)
        {
            this.Name = Name;
            this.Type = Type;
            this.Age = Age;
        }

        public Animal(string Name, int Age)
        {
            this.Name = Name;
            this.Type = Type;
        }
    }
    //爬行动物 继承自 动物
    public class Reptile : Animal
    {
        //子类重新赋默认值 当创建子类的时候 会使用子类的默认值
        public string Type { get; set; } = "爬行动物";

        //base 调用父类的构造函数
        public Reptile(string Name, string Type, int Age) : base(Name, Type, Age) { }

        //不给动物类型赋值的构造函数
        public Reptile(string Name,int Age) : base(Name, Age) { }

    }
}
