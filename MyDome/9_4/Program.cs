using System.Runtime.InteropServices;

namespace _9_4 {
	/// <summary>
	/// ！！！！！！！！！练习！！！！！！！！！
	/// </summary>
    public struct _Count
    {
		public int _index ;
		public int _value ;
    }
	public struct _Menu { 
		public string _name;
		public int _price;
	}
    internal class Program {
		public static void Add (Dictionary<string,int> menu) {
			again:
            Console.Write("请输入新菜菜名：");
			string newmenu = Console.ReadLine();
			if ( menu.ContainsKey(newmenu) ) {
				Console.WriteLine("已存在" + newmenu + "。请重新输入！");
				goto again;
			} else {
                Console.Write("请输入新菜价格：");
				int price = int.Parse(Console.ReadLine());
				
				menu.Add(newmenu, price);
            }
            Console.WriteLine();
            Console.WriteLine("添加完新菜后的菜单为：");
            foreach ( var item in menu ) {
				Console.WriteLine(item.Key + "\t" + item.Value);
			}
		}
		public static void parint ( Dictionary<string , int> menu ) {
			Console.WriteLine("低于20元的菜有：");
			foreach ( var item in menu ) {
				if ( item.Value < 20 ) {
                    Console.WriteLine(item.Key+"\t"+item.Value);
                }
			}
			
		}
		public static void addprice ( Dictionary<string , int> menu ) {
			again:
            Console.WriteLine("请输入涨价的菜名：");
			string name = Console.ReadLine();
			if ( menu.ContainsKey(name) ) {
				Console.WriteLine("请输入涨多少钱：");
				int price = int.Parse(Console.ReadLine());
				menu[name] += price;
				Console.WriteLine();
				Console.WriteLine("添加完新菜后的菜单为：");
				foreach ( var item in menu ) {
					Console.WriteLine(item.Key + "\t" + item.Value);
				}
			} else {
                Console.WriteLine("无"+name+"菜品，请重新输入！");
				goto again;
            }
        }
		public static void maina () {
			again:
			Dictionary<string,int> menu = new Dictionary<string,int> (){
				{ "A套餐",10},
				{ "B套餐",15},
				{ "C套餐",20},
				{ "D套餐",25}
		};
            Console.WriteLine("现在的菜单为：");
            foreach ( var item in menu ) {
				Console.WriteLine(item.Key + "\t" + item.Value);
			}
            Console.WriteLine();
            Console.WriteLine("0.添加新菜");
            Console.WriteLine("1.输出价格小于20的菜品");
            Console.WriteLine("2.对菜单菜品进行涨价处理");
            Console.Write("请输入想要对菜单进行的操作：");
			int num = int.Parse(Console.ReadLine());
			switch ( num ) {
				case 0:
					Add(menu);
					goto again;
				case 1:
					parint(menu);
					goto again;
				case 2:
					addprice(menu);
					goto again;
				default:
                    Console.WriteLine("程序结束运行！");
                    break;
			}
			

			/*
			List<string> strings = new List<string> (){"a", "b","c","b","d","a"};
			List<_Count> _Counts = new List<_Count>();
			Dictionary<string,int> alike = new Dictionary<string,int>();
			for ( int i = 0; i < strings.Count; i++ ) {
				if ( strings.IndexOf(strings[i]) != strings.LastIndexOf(strings[i])) {
					if ( alike.ContainsKey(strings[i]) ) {
						alike[strings[i]]++;
					} else { 
						alike.Add(strings[i], 1);
					}
					_Count count;
					count._index = i;
					count._value = alike[strings[i]];
					_Counts.Add(count);
				}
			}
			foreach ( _Count s in _Counts ) {
				strings[s._index] = strings[s._index] + s._value;
			}
			foreach ( string item in strings ) {
                Console.Write(item+" ");
            }
			*/
			/*List<_Count> _Counts = new List<_Count>();
			List<string> strings = new List<string> (){"a", "b","c","b","d","a"};
			Dictionary<string,int> dic =  new Dictionary<string, int> ();
			for ( int i = 0; i < strings.Count; i++ ) {
				if ( strings.IndexOf(strings[i])!= strings.LastIndexOf(strings[i]) ) {
					if ( dic.ContainsKey(strings[i]) ) {
						dic[strings[i]]++;
					} else {
						dic.Add(strings[i] , 1);
					}
					_Count count;
					count._index = i;
					count._value = dic[strings[i]];
					_Counts.Add(count);
				}
			}
			foreach ( _Count s in _Counts ) {
				strings[s._index] = strings[s._index] + s._value;
			}
			foreach ( string item in strings ) {
                Console.Write(item+" ");
            }*/
		}
	}
}
