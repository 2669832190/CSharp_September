using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6 {
	internal class 静态自增 {
	}

	public class Staff { 
		public int Id { get; set; }
		public string Name { get; set; }

		//每创建一个对象 Count自增1
		//静态属性：这个属性属于类，不属于对象 ， 对象不能调用，类才能调用
		public static int Count { get; set; } = 1;

		public Staff(string Name) { 
			this.Name = Name;
			Id = Count;
			Count++;
		}
	}
}
