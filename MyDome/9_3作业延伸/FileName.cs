using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3作业延伸 {
	public struct Student {
		public string date;
		public string week;
		public string[] name;
	}
	internal class FileName {
		static void Maina ( string[] args ) {
			string[] nameList = { "王耀", "李文斌", "杨栋", "张相龙", "李政阳","吴焕鹏", "李泓江", "王宁宁",
				"王恩楚", "许家豪", "王一鸣", "张超峰", "裴开鹏", "楚文淼", "胡智聪", "尤贵才", "司宇帆",
				"马旭光", "郑珏", "徐广辉", "刘世豪", "韩铁城", "张权浩", "王宏冉", "韩文杰",
				"马智浩", "冉中良", "候立芃", "李宗桓", "杨成乾", "马啸天", "周新雨 ", "刘学良",
				"孙金明", "周彬", " 李耀泽", "邢志迪", "王文博", "王鑫洋", "邹旗顺", "陈朋"};

			Student[] student = new Student[21];
			DateTime time = DateTime.Now;
			int i2 = 0;
			for ( int i = 0; i < student.Length; i++ ) {
				string date = time.ToString("yyyy年MM月dd日");
				time = time.AddDays(1);
				string week = DateTime.Now.ToString("dddd");
				student[i].date = date;
				student[i].week = week;
				if ( week == "星期日" ) {
					i--;
					continue;
				}
				if ( i2 > 39 ) {
					student[i].name = new string[2] { nameList[i2] , null };
				} else {
					student[i].name = new string[2] { nameList[i2] , nameList[i2 + 1] };
					i2 = i2 + 2;
				}
			}

			foreach ( var item in student ) {
				if ( item.name[1] == null ) {
					Console.WriteLine($"{item.date},\t{item.week},\t{item.name[0]} 值日");

				} else {
					Console.WriteLine($"{item.date},{item.week},\t{item.name[0]}\t和 {item.name[1]} 值日");
					Console.WriteLine();
				}


			}
		}
	}
}
