using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业2
{
    public class CitizenWages
    {
        public virtual void printWages()
        {
            Console.WriteLine("市民平均工资3500");
        }
    }
    public class Programmer : CitizenWages
    {
        public override void printWages()
        {
            Console.WriteLine("程序员工资7.5K");
        }
    }
    public class Cleaner : CitizenWages
    {
        public override void printWages()
        {
            Console.WriteLine("清洁工工资2.5K");
        }
    }
    //...
    internal class Program
    {
        static void Main(string[] args)
        {
            CitizenWages[] citizenWages = new CitizenWages[3]
            {
                new CitizenWages(),
                new Programmer(),
                new Cleaner()
            };

            foreach (CitizenWages item in citizenWages)
            {
                item.printWages();
            }
        }
    }
}
