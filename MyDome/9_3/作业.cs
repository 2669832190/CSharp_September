using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3 {
    public struct Team
    {
		public string _date;
		public string _week; 
		public string _name1;
		public string _name2;
    }
    internal class 作业 {
		public static void maina () {
			DateTime Time = DateTime.Today;  
			string[] nameList = { "王耀", "李文斌", "杨栋", "张相龙", "李政阳","吴焕鹏", "李泓江", "王宁宁",
								"王恩楚", "许家豪", "王一鸣", "张超峰", "裴开鹏", "楚文淼", "胡智聪", "尤贵才", "司宇帆",
								"马旭光", "郑珏", "徐广辉", "刘世豪", "韩铁城", "张权浩", "王宏冉", "韩文杰",
								"马智浩", "冉中良", "候立芃", "李宗桓", "杨成乾", "马啸天", "周新雨 ", "刘学良",
								"孙金明", "周彬", " 李耀泽", "邢志迪", "王文博", "王鑫洋", "邹旗顺", "陈朋"};
            Team[] teams = new Team[nameList.Length/2+1];
			int day = Time.Day; 
			int month = Time.Month;
			
			for ( int i = 0; i < teams.Length; i++ ) {
				
				if ( day==8||day==15||day ==22||day==29 ) {
					day++;
					if ( day == 32 ) {
						month++;
						day = 1;
					}
				}
				/*if ( day < 10 ) {
					teams[i]._date = Time.Year.ToString() + " 年 " + month + " 月 " + day + "  日 ";
				} else { 
					teams[i]._date = Time.Year.ToString() + " 年 " + month + " 月 " + day + " 日 ";
				}*/
				teams[i]._date = Time.Year.ToString() + " 年 " + month + " 月 " + day + "\t日\t";
				day++;
				if ( day == 32 ) {
					month++;
					day = 1;
				}
			}
			int week = (int)Time.DayOfWeek;
			for ( int i = 0; i < teams.Length; i++ ) {
				if ( week ==7 ) {
					week = 1;
				}
				teams[i]._week = week.ToString();
				week++;

				if ( week == 8 ) {
					week = 1;
				}
			}
			int num =0;
			for ( int i = 0; i < teams.Length; i++ ) {
				teams[i]._name1 = nameList[num];
				if ( num == nameList.Length-1 ) {
					teams[i]._name2 = null;
					break;
				} else {
					teams[i]._name2 = nameList[num + 1];
					num += 2;
				}
			}


			for ( int i = 0; i < teams.Length; i++ ) {
				if ( teams[i]._name2 == null ) {
					Console.WriteLine(teams[i]._date + " 星期 " + Week(teams[i]._week) + "\t" + teams[i]._name1 + "\t值日。");
				} else { 
					Console.WriteLine(teams[i]._date +" 星期 "+ Week(teams[i]._week) +"\t"+ teams[i]._name1 +"\t和 "+ teams[i]._name2+"\t值日。");
				}
				Console.ReadKey(true);
			}

        }
		public static string Week (string weeks) {
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
