using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05析构函数
{
    public enum Colour
    {
        红,
        橙,
        黄,
        绿,
        青,
        蓝,
        紫
    }

    public class Bird
    {
        //重量 克
        public double Weight {  get; set; }
        //颜色
        public Colour Colour { get; set; }

        //如果没有构造的时候 ， 会自动生成一个不含参数的构造函数
        //当我们写了一个构造函数的时候 ， 就不会再自动生成构造函数
        public Bird(double Weight,Colour Colour)
        {
            this.Weight = Weight;
            this.Colour = Colour;
        }

        //下蛋
        public void layEggs()
        {
            Console.WriteLine("鸟开始下蛋");
        }

        //析构函数
        //对象死掉的时候调用
        //比如:程序运行结束了
        //准确来说,是当内存释放时会调用
        //GC:垃圾回收器 定期会找内存中 哪些东西用不到了 然后回收内存
        ~Bird()
        {
            Console.WriteLine("鸟死了");
        }
    }
}
