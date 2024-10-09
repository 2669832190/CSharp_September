using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03继承
{
    public class Animal
    {
        public int Age {  get; set; }
        public double Weight {  get; set; }
        public string Color { get; set; }

        public void CHLSS()
        {
            Console.WriteLine("动物可以吃喝拉撒睡");
        }

        public void Mating()
        {
            Console.WriteLine("动物可以交配");
        }

        //当前类才能访问 子类不能访问(子类不能继承)
        private void Fly()
        {
            Console.WriteLine("有些动物可以飞");
        }

        //受保护的
        //当前类和子类可以访问(子类可以继承)
        //外部不能调用
        protected void Swimming()
        {
            Console.WriteLine("有些动物能游泳");
        }
    }

    //猴子类 继承自 动物类
    //动物的属性和方法 猴子也都有
    public class Monkey : Animal
    {
        public void eatPeach()
        {
            Console.WriteLine("吃桃");
            //子类可以游泳 外部类不能调用
            this.Swimming();
        }

    }
}
