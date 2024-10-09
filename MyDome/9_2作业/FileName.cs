/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2作业 {
    internal class FileName {
		public static void Main () {
			#region 赋值
			string[] names ={"小明","小红","小刚","小白" };
			Sexindex[] bools = { Sexindex.男,Sexindex.女,Sexindex.男,Sexindex.女};
			double[] ywcj = { 98,87,89,76};
			double[] sxcj = { 83,77,85,96};
			double[] yycj = { 78,88,96,86};
			Student[] students = new Student[4];
			for ( int i = 0; i < students.Length; i++ ) {
				students[i].name = names[i];
				students[i].Sex = bools[i];
				students[i].yw = ywcj[i];
				students[i].sx = sxcj[i];
				students[i].yy = yycj[i];
			}
			#endregion

			#region 第一题
			Console.WriteLine("第一题：");
            Console.WriteLine("请输入一个学生姓名：");
			string nume = Console.ReadLine();
			for ( int i = 0; i < students.Length; i++ ) {
				if ( students[i].name.Equals(nume) ) {
					students[i].Students();
					students[i].parint();
					break;
				}
				if ( i == students.Length - 1 ) {
					Console.WriteLine("无此学生！！！");
				}
			}
			#endregion

			#region 第二题
			Console.WriteLine("第二题：");
            Console.WriteLine("请输入一个学生姓名：");
			string name = Console.ReadLine();
			for ( int i = 0; i < students.Length; i++ ) {
				if ( students[i].name.Equals(name) ) {
					students[i].Students();
					Console.Write("请输入学生姓名：");
					string name1 = Console.ReadLine();
					students[i].name = name1;
					Console.Write("该学生的性别为（0男，1女）：");
					int num = int.Parse(Console.ReadLine());
					students[i].Sex = (Sexindex)num;
					Console.Write("语文成绩：");
					double yw = double.Parse(Console.ReadLine());
					students[i].yw = yw;
					Console.Write("数学成绩：");
					double sx = double.Parse(Console.ReadLine());
					students[i].sx = sx;
					Console.Write("英语成绩：");
					double yy = double.Parse(Console.ReadLine());
					students[i].yy = yy;
					students[i].Students();
					students[i].parint();
					break;
				}
				if ( i == students.Length - 1 ) {
					Console.WriteLine("无此学生！！！");
				}
			}
			#endregion

		}
	}

	#region 学生
	public enum Sexindex { 男, 女 };
	public struct Student {
		public string name;
		public bool Isman;
		public Sexindex Sex;
		public double yw;
		public double sx;
		public double yy;
		public string km;
		public double max;
		public double min;
		public double pj;
		public double sum;

		public void Students () {
			double[] cj = new double[]{yw,sx,yy };
			for ( int i = 0; i < cj.Length; i++ ) {
				sum += cj[i];
			}
			pj = sum / 3;
			if ( yw > sx ) {
				if ( yw > yy ) {
					max = yw;
					km = "语文";
					if ( sx > yy ) {
						min = yy;

					} else {
						min = sx;
					}
				} else {
					max = yy; min = sx;
					km = "英语";
				}
			} else {
				//sx>yw
				if ( sx > yy ) {
					max = sx;
					km = "数学";
					if ( yw > yy ) {
						min = yy;

					} else {
						min = yw;
					}
				} else {
					max = yy;
					min = yw;
					km = "英语";
				}
			}

		}
		public void parint () {
			Console.WriteLine("姓名：" + name + " 性别：" + Sex + " 语文：" + yw + " 数学：" + sx + " 英语：" + yy + " 最高分科目：" + km + " 最高分：" + max + " 最低分：" + min + " 平均分：" + pj + " 总分：" + sum);
		}
	}
	#endregion
}
*/