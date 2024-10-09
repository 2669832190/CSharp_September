using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_13 {
	internal class Cat : Animal {
		public string Name { get; set; } = "猫";
		public override void Call() {
            Console.WriteLine("喵喵喵！");
        }
	}
}
