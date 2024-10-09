using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6 {
	internal class 里氏转换 {
		public static void maina () { 
			//声明父类型  new子类型 这时候对象无法调用子类型的方法 需要用到里氏转换
			Animal1 animal1 = new Reptile("蜥蜴",8);
            Console.WriteLine(animal1.name+" "+animal1.age);
            Console.WriteLine(animal1.type);
			animal1.CHLS();

			//声明的类型是父类 所以只能使用父类里的功能
			//animal1.Climb();


			//父类可以强制转换为子类
			Reptile rep = (Reptile)animal1;
            Console.WriteLine(rep.type);
			rep.CHLS();
			rep.Climb();



			//里氏转换
			//判断父类是否能够转为子类		因为父类能够转为子类 所以为 true
			//is如果能够转换则为True 不能转换则为false
            Console.WriteLine(animal1 is Reptile);//true
            //没有血缘关系 无法转换
            //Vehice vehice = (Vehice)animal1;
            Console.WriteLine(animal1 is Vehice);//false


            //as尝试转换		如果转换成功 返回一个转换后的结果
            //				如果转换失败 返回Null
            Reptile reptile = animal1 as Reptile;



			//完整的 安全的 类型转换 
			//先判断 能不能转换
			
			if ( animal1 is Reptile ) { 
				//尝试转换
				Reptile reptile1 = animal1 as Reptile;
				if ( reptile1 == null ) {
					reptile1 = new Reptile("默认" , 0);
				}
			}
        }
	}
}
