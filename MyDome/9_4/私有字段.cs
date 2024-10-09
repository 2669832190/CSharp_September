using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4 {
	internal class 私有字段 {
		public static void maina () { 
			students students1 = new students();
			students1._name = "张三";
			students1.parint();

			students students2 = new students();
			students2._name = "李四";
			students2.SetAge(18);
			students2.parint();

		}
		public class students {
			public string _name;
			private int _age;

			public void parint () {
                Console.WriteLine(_name+_age);
            }
			public void SetAge ( int age ) { 
				_age = age;
			}
		}

	}
}
