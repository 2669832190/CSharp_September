using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6__9_7作业 {
	internal class Student {
		#region 属性设置
		/// <summary>
		/// 姓名
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// 年龄
		/// </summary>
		public int Age { get; set; }
		/// <summary>
		/// 语文成绩
		/// </summary>
		public double ChineseGrade { get; set; }
		/// <summary>
		/// 数学成绩
		/// </summary>
		public double MathsGrade { get; set; }
		/// <summary>
		/// 英语成绩
		/// </summary>
		public double EnglishGrade { get; set; }
		/// <summary>
		/// 最高分
		/// </summary>
		double MaxGrade;
		/// <summary>
		/// 总分
		/// </summary>
		double SumGrade;
		/// <summary>
		/// 平均分
		/// </summary>
		double AverageGrade;
		#endregion

		#region 构造函数
		public Student (string Name, int Age, double Chinese, double Maths , double English ) {
			#region 对基本信息进行赋值
			this.Name = Name;
			this.Age = Age;
			this.ChineseGrade = Chinese;
			this.MathsGrade = Maths;
			this.EnglishGrade = English;
			#endregion
			#region 对成绩进行处理
			this.MaxGrade = this.ChineseGrade > this.MathsGrade ? this.ChineseGrade : this.MathsGrade;
			this.MaxGrade = this.MaxGrade > this.EnglishGrade ? this.MaxGrade : this.EnglishGrade;
			this.SumGrade = this.ChineseGrade + this.MathsGrade + this.EnglishGrade;
			this.AverageGrade = this.SumGrade / 3;
			#endregion
		}
		#endregion

		#region 打印函数
		static void printf (Student student) {
			Console.WriteLine("姓名："+ student.Name +",年龄：" + student.Age +
				",语文成绩：" + student.ChineseGrade +
				",\t数学成绩：" + student.MathsGrade +
				",\t英语成绩：" + student.EnglishGrade +
				",\t总分：" + student.SumGrade +
				",\t最高分：" + student.MaxGrade +
				",\t平均分：" + student.AverageGrade +
				"。\n");
        }
		static void printf (double AllAverageGrade , Student student ) {
            Console.WriteLine("姓名：" + student.Name + ",年龄：" + student.Age +
				",语文成绩：" + student.ChineseGrade +
				",\t数学成绩：" + student.MathsGrade +
				",\t英语成绩：" + student.EnglishGrade +
				",\t总分：" + student.SumGrade +
				",\t最高分：" + student.MaxGrade +
				",\t平均分：" + student.AverageGrade +
				",\t全班平均分：" + AllAverageGrade +
				"。\n");
		}
		#endregion
		/// <summary>
		/// 按照总分进行从小到大排序打印
		/// </summary>
		/// <param name="students"></param>
		public static void SumGradePrintf ( List<Student> students ) {
			students.Sort((x,y)=> (int)(x.SumGrade - y.SumGrade));
			students.ForEach(x => printf(x));
		}

		public static void HeightAverageGradePrintf ( List<Student> students ) {
			double AllAverageGrade = 0;
			double AllSumGrade = 0;
			students.Sort(( x , y ) => (int)( x.SumGrade - y.SumGrade ));
			foreach ( Student item in students ) {
				AllSumGrade += item.SumGrade;
				AllAverageGrade = AllSumGrade / students.Count;
			}
			foreach ( Student item in students ) {
				if ( item.SumGrade > AllAverageGrade ) {
					printf(AllAverageGrade , item);
				}
			}
		}
	}
}
