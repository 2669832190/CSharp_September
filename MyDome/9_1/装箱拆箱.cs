using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1 {
	internal class 装箱拆箱 {
		public static void maina () {
            Console.WriteLine("装箱拆箱:");
			//object
			//装箱
			object obj1 = 10;
			object obj2 = 2.5;
			object obj3 = "abc";
			//拆箱
			int a =(int)obj1;
			double b =(double)obj2;
			string c =(string)obj3;
        }
	}
}
