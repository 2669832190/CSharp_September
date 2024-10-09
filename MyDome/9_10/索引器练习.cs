using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10 {
	internal class 索引器练习 {
		public static void maina() {
			Birds birds = new Birds();
			
			BirdD birdD1 = new BirdD(){Name = "布谷鸟",Age = 18 };
			BirdD birdD2 = new BirdD(){Name = "百灵鸟",Age = 6 };
			
			birds.AddBird(birdD1);
			birds.AddBird(birdD2);
			//调用set 方法
			//birds["布谷鸟"] = 布谷鸟

			//调用get 方法
			//birds["布谷鸟"] 通过索引器查询到对应的鸟
			//对应的鸟.Age 获取到 对应的年纪
			Console.WriteLine(birds["布谷鸟"].Age);


        }

		
	}

	public class BirdD {
		public string Name { get; set; }
		public int Age { get; set; }
		public void Call() {
			Console.WriteLine("鸟开始叫");
		}


	}

	public class Birds { 
		private BirdD[] birdD = new BirdD[0];

		public void AddBird(BirdD bird) { 
			Array.Resize(ref birdD, birdD.Length+1);
			birdD[birdD.Length - 1] = bird;
		}

		public BirdD this[string name] {
			get {
				foreach ( BirdD bird in birdD ) {
					if ( bird.Name == name ) return bird;
				}
				return null;
			}
		
		}
	}
}
