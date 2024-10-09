using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            ob b;
            b.name = "lu";
            b.age = 12;
            b.sex = mssage.男;
        }
        public struct ob
        {
            public string name;
            public int age;
            public mssage sex;

        }
        public enum mssage
        {
            男,女
        }
    }
}
