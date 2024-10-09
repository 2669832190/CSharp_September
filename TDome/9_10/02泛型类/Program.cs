using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02泛型类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal<string> animal = new Animal<string>();
            animal.value = "张三";
            Console.WriteLine(animal.value);

            Bird<int,string> bird = new Bird<int,string>();
            
            Cuckoo<string> cuckoo = new Cuckoo<string>();
            string s = cuckoo.Fly("起飞");
            Console.WriteLine(s);
        }
    }

    //泛型类
    public class Animal<T>
    {
        public T value {  get; set; }
    }

    public class Bird<T,T2> : Animal<T>
    {
        public T2 leg { get; set; }
    }
    //接口
    public interface FlyingAnimals<T>
    {
        //返回值类型 方法名(参数类型 参数名)
        T Fly(T howtofly);
    }
    public class Cuckoo<T> : FlyingAnimals<T>
    {
        //访问修饰符 返回值类型 方法名(参数类型 参数名)
        //参数类型和返回值类型 一样
        public T Fly(T howtofly)
        {
            return howtofly;
        }
    }
}
