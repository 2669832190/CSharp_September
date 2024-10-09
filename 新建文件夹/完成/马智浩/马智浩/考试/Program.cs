namespace 考试
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Car car1=new Car(Kind.宝马, "擎天柱","A1B1C1D1",997);
			Car car2=new Car(Kind.奔驰, "霸天虎","A2B2C2D2",998);
			Car car3=new Car(Kind.五菱, "威震天","A3B3C3D3",999);
			User user=new User();
			user.ADD(car1);
			user.ADD(car2);
			user.ADD(car3);
			

            Console.WriteLine("您已进入租赁汽车系统");
            while (true) 
			{
                Console.WriteLine("请输入你要进行的操作\n1.添加汽车\t2.删除汽车\t3.租车\t4.还车\t5.查询汽车信息\t6.退出系统");
				int i=Convert.ToInt32(Console.ReadLine());
				switch (i)
				{
					case 1:
						user.Add();
						break;
					case 2:
						user.Remove();
						break;
					case 3:
						user.GetCar();
						break;
					case 4:
						user.BackCar();
						break;
					case 5:
						user.InFo();
						break;
					case 6:
						return;
				}
            }
		}
	}
	public enum Kind
	{ 
	宝马,
	奔驰,
	大众,
	五菱
	}
	public class Car
	{
		public Kind Kind { get; set; }
		public string Name { get; set; }
		public string ID { get; set; }
		public double dayPrice { get; set; }
		//true表示车还在  false表示车已被借出
		public bool IsCar { get; set; }=true;
		public int Day { get; set; } = 0;

		public Car(Kind kind, string name, string iD, double dayprice) 
		{
			Kind = kind;
			Name = name;
			ID = iD;
			dayPrice = dayprice;
		}
		public void Info()
		{
            Console.WriteLine("车的品牌："+this.Kind);
            Console.WriteLine("车的车型："+this.Name);
            Console.WriteLine("车的车牌号："+this.ID);
            Console.WriteLine("车的每日租金："+this.dayPrice);
            if (this.IsCar)
            {
				Console.WriteLine("车的状态：未借出");
                Console.WriteLine("租界天数：0天");
            }
            else
            {
                Console.WriteLine("车的状态：已借出");
                Console.WriteLine("租界天数："+this.Day);
            }

        }
	}
	public class User
	{ 
		public Car[] list=new Car[0];

		public Car this[int index]
		{
			get => list[index];
			set=> list[index] = value;
		}

		public int Count { get => list.Length; }

		public void ADD(Car car)
		{
			Array.Resize(ref list, list.Length + 1);
			list[list.Length - 1] = car;
		}

		public void Add()
		{
            Console.WriteLine("请输入汽车的品牌\n宝马\t奔驰\t大众\t五菱");
			string s=Console.ReadLine();
			Kind kind = (Kind)Enum.Parse(typeof(Kind), s);
            Console.WriteLine("请输入汽车的车型");
			string name=Console.ReadLine();
            Console.WriteLine("请输入汽车的车牌号（8位字符串，大写英文字母加数字组成）");
			string id= Console.ReadLine();
			if (id.Length == 8)
			{
				for (int i = 0; i < id.Length; i++)
				{
					if ((id[i] >= 48 && id[i] <= 57) || (id[i] >= 65 && id[i] <= 90))
					{ }
					else
					{
						Console.WriteLine("输入字符串不符合规矩");
						return;
					}
				}

				Console.WriteLine("请输入汽车的每日租金");
				double dayprice = double.Parse(Console.ReadLine());
				Car car = new Car(kind, name, id, dayprice);
				Array.Resize(ref list, list.Length + 1);
				list[list.Length - 1] = car;
				Console.WriteLine("该车已添加成功");
			}
			else
			{
				Console.WriteLine("您输入的长度不符");
				return;
			}

          
		}

		public void InFo()
		{
            Console.WriteLine("请输入要查询信息车辆的车牌号");
			string s= Console.ReadLine();
			if (s.Length == 8)
			{
				for (int i = 0; i < s.Length; i++)
				{
					if ((s[i] >= 48 && s[i] <= 57) || (s[i] >= 65 && s[i] <= 90))
					{ }
					else
					{
						Console.WriteLine("输入字符串不符合规矩");
						return;
					}
				}
				for (int i = 0; i < list.Length; i++)
				{
					if (list[i].ID == s)
					{
						list[i].Info();
						return;
					}
				}
				Console.WriteLine("未找到对应车牌号的车辆");
			}
			else 
			{
				Console.WriteLine("您输入的长度不符");
				return;
			}
			
		}

		public void Remove()
		{
            Console.WriteLine("请输入一个车牌号");
			string s=Console.ReadLine();
			if (s.Length == 8)
			{
				for (int i = 0; i < s.Length; i++)
				{
					if ((s[i] >= 48 && s[i] <= 57) || (s[i] >= 65 && s[i] <= 90))
					{ }
					else 
					{
						Console.WriteLine("输入字符串不符合规矩");
						return; 
					}
				}
				for (int i = 0; i < list.Length; i++)
				{
					if (list[i].ID == s)
					{
						list[i] = list[list.Length - 1];
						Array.Resize(ref list, list.Length - 1);
					}
				}
				Console.WriteLine("该车已删除成功");
			}
			else 
			{
				Console.WriteLine("您输入的长度不符");
				return;
			}
			
           
		}

		public void GetCar()
		{
            for (int i = 0; i < list.Length; i++)
            {
				list[i].Info();
                Console.WriteLine("----------------------");
            }
            Console.WriteLine("请输入要租车辆的车牌号");
			string s= Console.ReadLine();

			if (s.Length == 8)
			{
				for (int i = 0; i < s.Length; i++)
				{
					if ((s[i] >= 48 && s[i] <= 57) || (s[i] >= 65 && s[i] <= 90))
					{ }
					else
					{
						Console.WriteLine("输入字符串不符合规矩");
						return;
					}
				}
				for (int i = 0; i < list.Length; i++)
				{
					if (list[i].ID == s)
					{
						if (list[i].IsCar)
						{
						Console.WriteLine("请输入要租借的天数");
						int ints = Convert.ToInt32(Console.ReadLine());
						list[i].Day=ints;
						double price = list[i].dayPrice*ints;
                        Console.WriteLine($"请支付{price}元");
						list[i].IsCar= false;
						return;
						}
						 else
						{
                        Console.WriteLine("抱歉，该车已被借走");
						return;
						}
					}
				}
				Console.WriteLine("没有对应车牌号的车辆");
			}
			else
			{
				Console.WriteLine("您输入的长度不符");
				return;
			}
		}
		public void BackCar()
		{
			for (int i = 0; i < list.Length; i++)
			{
				list[i].Info();
				Console.WriteLine("----------------------");
			}
            Console.WriteLine("请输入归还的车牌号");
			string s= Console.ReadLine();
			if (s.Length == 8)
			{
				for (int i = 0; i < s.Length; i++)
				{
					if ((s[i] >= 48 && s[i] <= 57) || (s[i] >= 65 && s[i] <= 90))
					{ }
					else
					{
						Console.WriteLine("输入字符串不符合规矩");
						return;
					}
				}
			for (int i = 0; i < list.Length; i++)
			{
				if (list[i].ID == s)
				{
					if (list[i].IsCar)
					{
                        Console.WriteLine("对应车牌号的车辆本店未借出");
                    }
					else
					{
						Console.WriteLine("请输入实际租借的天数");
						int ints = Convert.ToInt32(Console.ReadLine());
                        if (list[i].Day==ints)
                        {
                            Console.WriteLine("感谢你准时归还车辆");
							list[i].IsCar = true;
							return;
						}
                        else if (ints>list[i].Day)
                        {
							int day = ints - list[i].Day;
							double price = list[i].dayPrice * day * 2;
							Console.WriteLine($"很抱歉，您实际归还日期超出应当归还日期{day}天，需额外支付{price}元");
							list[i].IsCar = true;
							return;
						}
                        else if (ints < list[i].Day)
                        {
							int day =  list[i].Day-ints;
							double price = list[i].dayPrice * day;
							Console.WriteLine($"您实际归还日期比应当归还日期提前{day}天，返还您{price}元");
							list[i].IsCar = true;
							return;
						}

                    }
				}
				
			}
				Console.WriteLine("没有对应车牌号的车辆");
			}
			else
			{
				Console.WriteLine("您输入的长度不符");
				return;
			}
		}

	}
}
