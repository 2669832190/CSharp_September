using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 序列化 {
	internal class Student {
		public string Name;
		public int Age;
		public string Sex;
		public Student(string Name , int Age , string Sex) { 
			this.Name = Name;
			this.Age = Age;
			this.Sex = Sex;
		}
	}
}
