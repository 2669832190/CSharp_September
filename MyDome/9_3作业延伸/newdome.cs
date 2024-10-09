using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3作业延伸 {
    public struct Teams
    {
        public string _date;
        public string _week;
        public string[] _name;
    }
    internal class newdome {
		public static void Main ( string[] args ) {
			string[] nameList = { "王耀", "李文斌", "杨栋", "张相龙", "李政阳","吴焕鹏", "李泓江", "王宁宁",
								"王恩楚", "许家豪", "王一鸣", "张超峰", "裴开鹏", "楚文淼", "胡智聪", "尤贵才", "司宇帆",
								"马旭光", "郑珏", "徐广辉", "刘世豪", "韩铁城", "张权浩", "王宏冉", "韩文杰",
								"马智浩", "冉中良", "候立芃", "李宗桓", "杨成乾", "马啸天", "周新雨 ", "刘学良",
								"孙金明", "周彬", " 李耀泽", "邢志迪", "王文博", "王鑫洋", "邹旗顺", "陈朋"};
			Teams[] teams = new Teams[nameList.Length];
            DateTime dateTime = DateTime.Now;

			for ( int i = 0; i < teams.Length; i++ ) {
				int a = i*2;
				teams[i]._date = dateTime.Date.ToString("yyyy年MM月dd日");
				teams[i]._week = dateTime.ToString("dddd");
				dateTime = dateTime.AddDays(1);
				if ( dateTime.DayOfWeek == 0 ) {
					dateTime = dateTime.AddDays(1);
				} 
				teams[i]._name = new string[2];
				teams[i]._name[0] = nameList[ a ];
				if ( nameList.Length - 1 >= a + 1 ) {
					teams[i]._name[1] = nameList[a + 1];
				} else { 
					a = 0;
					teams[i]._name[1] = nameList[a];
					a++;
				}
				
			}
			foreach ( Teams team in teams ) {
				Console.WriteLine(team._date +"\t"+ team._week +" "+ team._name[0] +"\t和 "+ team._name[1] +"\t值日。");
				//Console.WriteLine(team._date +" "+ team._week +" "+ team._name[0] +" "+ team._name[1] );
            }
		}
	}
}
