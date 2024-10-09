using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _9_1 {
	internal class 作业 {

		public enum SexIndex {
			男,
			女
		}

		public struct Student
        {
			public string name;
			public Enum Sex;
			/// <summary>
			/// double GradeLanguage;
			///double GradeMaths;
			///double GradeEnglish;
			///double MaxGrade;
			///double MinGrade;
			///double AverageGrade;
			///double SumGrade;
			/// </summary>
			//double[] GradeArray;
			//= new double[7]

			public double GradeLanguage;
			public double GradeMaths;
			public double GradeEnglish;
			public double MaxGrade;
			public double MinGrade;
			public double AverageGrade;
			public double SumGrade;

			public string Subject;
			public Student ( string name , bool Isman,double GradeLanguage ,double GradeMaths ,double GradeEnglish) { 
				this.name = name;
				if ( Isman ) {
					Sex = SexIndex.男;
				} else { 
					Sex = SexIndex.女;
				}
				double[] doubles = StudentGrade(GradeLanguage , GradeMaths , GradeEnglish);
				MaxGrade = doubles[0];
				MinGrade = doubles[1];
				AverageGrade = doubles[2];
				SumGrade = doubles[3];
                
            }

			public double[] StudentGrade ( double GradeLanguage , double GradeMaths , double GradeEnglish) {
				int[] num = GradeMessage(GradeLanguage , GradeMaths , GradeEnglish);
				double[] doubles = new double[4];
				this.GradeLanguage = GradeLanguage;
				this.GradeMaths = GradeMaths;
				this.GradeEnglish = GradeEnglish;
				switch ( num[0] ) {
					case 0:
						Subject = "语文";
						break;
					case 1:
						Subject = "数学";
						break;
					case 2:
						Subject = "英语";
						break;
				}
				doubles[0] = doubles[num[0]];
				doubles[1] = doubles[num[1]];
				doubles[3] = GradeLanguage + GradeMaths + GradeEnglish;
				doubles[2] = doubles[3] / 3;
				return doubles;
			}

			public static int[] GradeMessage ( double GradeLanguage , double GradeMaths , double GradeEnglish ) {
				int max = -1;
				int min = -1;
				//最大值
				if ( GradeLanguage > GradeMaths ) {
					max = 0;
					if ( GradeEnglish > max ) {
						max = 2;
					}
				} else {
					max = 1;
					if ( GradeEnglish > max ) {
						max = 2;
					}
				}
				//最小值
				if ( GradeLanguage > GradeMaths ) {
					min = 1;
					if ( min > GradeEnglish ) {
						min = 2;
					}
				} else {
					min = 0;
					if ( min > GradeEnglish ) {
						min = 2;
					}
				}

				return new int[]{ max ,min };
			}

			public void parint () {
                Console.WriteLine("学生姓名："+name+"，性别："+Sex+"，语文成绩："+GradeLanguage+"，数学成绩："+GradeMaths+"，英语成绩："+GradeEnglish+"，最高分科目："+Subject+"，最高分："+MaxGrade+"，最低分："+MinGrade+"，平均分："+AverageGrade+"，总分："+SumGrade+"。");
            }

		}
		public static Student[] Assign () {
			string[] name = { "甲","乙","丙","丁"};
			Student[] students = new Student[4];
			Student student = new Student(name[0],true,90,88,95);
			students[0] = student;
			Student student1 = new Student(name[1],false,80,78,85);
			students[1] = student1;
			Student student2 = new Student(name[2],false,81,82,83);
			students[2] = student2;
			Student student3 = new Student(name[3],true,91,80,86);
			students[3] = student3;
			return students;
		}

		//查找
		/*public static bool find (string name , Student[] student) {
			bool found = false;
			for (int i=0; i < student.Length; i++ ) {
				found = student[i].name.Equals(name);
			}
			if ( found ) {
				return true;
			} else { 
				return false;
			}
		}*/

		public static void maina () {
			
			Student[] StudentsMessage = Assign();
            Console.WriteLine("请输入一个学生的姓名（甲乙丙丁）：");
			string names = Console.ReadLine();
			StudentsMessage[Array.FindIndex(StudentsMessage , (names) => StudentsMessage.Equals(names))].parint();

        }
		
	}
}
