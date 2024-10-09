namespace _9_3作业延伸 {
	public struct Team {
		public string _date;
		public string _week;
		public string _name1;
		public string _name2;
	}
	internal class Program {
		static void Maina ( string[] args ) {
			//Console.WriteLine("Hello, World!");
			DateTime Time = DateTime.Today;
			string[] nameList = { "王耀", "李文斌", "杨栋", "张相龙", "李政阳","吴焕鹏", "李泓江", "王宁宁",
								"王恩楚", "许家豪", "王一鸣", "张超峰", "裴开鹏", "楚文淼", "胡智聪", "尤贵才", "司宇帆",
								"马旭光", "郑珏", "徐广辉", "刘世豪", "韩铁城", "张权浩", "王宏冉", "韩文杰",
								"马智浩", "冉中良", "候立芃", "李宗桓", "杨成乾", "马啸天", "周新雨 ", "刘学良",
								"孙金明", "周彬", " 李耀泽", "邢志迪", "王文博", "王鑫洋", "邹旗顺", "陈朋"};
			Team[] teams = new Team[78];
			//date and week
			int year = Time.Year;
			int day = Time.Day;
			int month = Time.Month;
			int weekIssunday = (int)Time.DayOfWeek;
			for ( int i = 0; i < teams.Length; i++ ) {
				if ( weekIssunday % 7 == 0 ) {
					i--;
					day++;
					if ( month == 4 || month == 6 || month == 9 || month == 11 ) {
						if ( day == 31 ) {
							day = 1;
							month++;
						}
					} else if ( month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 ) {
						if ( day == 32 ) {
							day = 1;
							if (month==12) {
								month = 1;
								year++;
							} else {
								month++;
							}
						}
					} else if(month==2) {
						if ( ( 0 == year % 4 && year % 100 != 0 ) || ( 0 == year % 400 ) ) {
							if ( day == 30 ) {
								day = 1;
								month++;
							}
						} else {
							if ( day ==29 ) {
								day = 1;
								month++;
							}
						}
					}
					
					weekIssunday = 1;
                    continue;
				} else {
					teams[i]._date = year + " 年 " + month + "\t月 " + day + "\t日\t";
					teams[i]._week = weekIssunday.ToString();
					day++;
					if ( month == 4 || month == 6 || month == 9 || month == 11 ) {
						if ( day == 31 ) {
							day = 1;
							month++;
						}
					} else if ( month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12 ) {
						if ( day == 32 ) {
							day = 1;
							if ( month == 12 ) {
								month = 1;
								year++;
							} else {
								month++;
							}
						}
					} else if ( month == 2 ) {
						if ( ( 0 == year % 4 && year % 100 != 0 ) || ( 0 == year % 400 ) ) {
							if ( day == 30 ) {
								day = 1;
								month++;
							}
						} else {
							if ( day == 29 ) {
								day = 1;
								month++;
							}
						}
					}
					weekIssunday++;
				}
			}
			//name
			int num =0;
			for ( int i = 0; i < teams.Length; i++ ) {
				
				if ( num == nameList.Length ) {
					num = 0;
					teams[i]._name1 = nameList[num];
					teams[i]._name2 = nameList[num+1];
					num +=2;
				} else {
					teams[i]._name1 = nameList[num];
					if (num == nameList.Length - 1) {
						num = 0;
						teams[i]._name2 = nameList[num];
						num = 1;
						continue;
					}
					teams[i]._name2 = nameList[num + 1];
					num += 2;
				}
			}
			//parint
			for ( int i = 0; i < teams.Length; i++ ) {
				Console.WriteLine(teams[i]._date + " 星期 " + Week(teams[i]._week) + "\t" + teams[i]._name1 + "\t和 " + teams[i]._name2 + " \t值日。");
                Console.WriteLine();
                Console.ReadKey(true);
			}
		}
		public static string Week ( string weeks ) {
			string week = null;
			switch ( weeks ) {
				case "1":
					week = "一";
					break;
				case "2":
					week = "二";
					break;
				case "3":
					week = "三";
					break;
				case "4":
					week = "四";
					break;
				case "5":
					week = "五";
					break;
				case "6":
					week = "六";
					break;
			}
			return week;
		}
	}
}
