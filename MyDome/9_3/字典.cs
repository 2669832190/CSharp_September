using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3 {
	internal class 字典 {
		public static void maina () {
			//字典 只能存储同类型的数据 长度不固定
			//键值对
			//Dictionary<键，值>

			//声明的同时也可以进行赋值
			//键不可重复 值可以重复
			Dictionary<string,int> caiDan = new Dictionary<string, int> (){
				{ "小汉堡",10},
				{ "臭豆腐",5},
				{ "钵钵鸡",1},
				{ "腐乳",10}
			};
			//通过索引 索引填入的是键名 获取到的是对应的值
			Console.WriteLine(caiDan[ "钵钵鸡"]);

            //查询存不存在对应的键
            Console.WriteLine(caiDan.ContainsKey("臭豆腐"));

            //查询是否包含特定的值
            Console.WriteLine(caiDan.ContainsValue(20));

            //获取字典中所有的键（组成一个集合list）
            Console.WriteLine(caiDan.Keys);

			//遍历所有的键
			foreach ( string str in caiDan.Keys ) {
                Console.WriteLine(str);
            }

			//遍历所有的值
			foreach ( int i in caiDan.Values ) {
                Console.WriteLine(i);
            }

			//当键和值都需要遍历的时候 这种就很合适
			foreach ( var item in caiDan ) {
				Console.WriteLine("i的键是:"+item.Key+"i的值为:"+item.Value);
			}
			a();
        }
		public static void a () {
			Dictionary<string,int> caidan = new Dictionary<string, int>(){
				{ "鸡蛋灌饼",5},
				{ "火鸡面裹凉皮",8},
				{ "肠粉",8},
				{ "鸡蛋灌饼豪华套餐",7},
				{ "焖面",10}
			};
			foreach ( var str in caidan ) {
                Console.WriteLine(str.Key+",一份"+str.Value+"元。");
            }
		}
	}
}
