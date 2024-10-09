using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace _9_25作业 {
	[Serializable]
	internal class poem {
		public string str;
		public poem(string str) { 
			this.str = str;
		}
	}
}
