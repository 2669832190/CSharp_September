using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05里氏转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //声明父类类型 new子类类型
            Animal ani = new Reptile("蜥蜴", 18);
            Console.WriteLine(ani.Type);
            ani.CHLS();
            //声明的类型是父类 所以只能使用父类里的功能
            //ani.Climb();

            //父类可以强制转换为子类
            Reptile rep = (Reptile)ani;
            Console.WriteLine(rep.Type);
            rep.CHLS();
            rep.Climb();

            //因为父类能够转为子类 所以为true
            Console.WriteLine(ani is Reptile);
            //没有血源关系
            //Vehicle veh = (Vehicle)ani;
            Console.WriteLine(ani is Vehicle);

            //尝试转换 如果转换成功 返回个转换后的结果
            //如果转换失败 返回Null
            Reptile reptile = ani as Reptile;

            //完整的安全的类型转换
            //先判断能不能转换
            if (ani is Reptile)
            {
                //再尝试转换
                Reptile reptile2 = ani as Reptile;
                if (reptile2 == null)
                {
                    reptile2 = new Reptile("默认", 0);
                }
            }
        }
    }
}
