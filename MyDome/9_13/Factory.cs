using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_13 {
	internal static class Factory {
		public static Animal GetAnimal(string name) {
			if ( name == "狗" ) {
				return new Dog();
			} else if ( name == "猫" ) {
				return new Cat();
			} else {
				return null;
			}
		}
	}
}
