using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 周六作业
{
    public class Student
    {
        //姓名
        public string Name { get; set; }
        //年龄
        public int Age { get; set; }
        //语文成绩
        public double ChineseScore { get; set; }
        //数学成绩
        public double MathScore { get; set; }
        //英语成绩
        public double EnglishScore { get; set; }
        //最高分
        public double MaxScore { get; set; }
        //总分
        public double TotalaScore { get; set; }
        //平均分
        public double AverageScore { get; set; }

        public Student(string name, int age, double chineseScore, double mathScore, double englishScore)
        {
            Name = name;
            Age = age;
            ChineseScore = chineseScore;
            MathScore = mathScore;
            EnglishScore = englishScore;

            TotalaScore = ChineseScore + MathScore + EnglishScore;
            AverageScore = TotalaScore / 3;
            //最高分
            MaxScore = Math.Max(Math.Max(chineseScore, mathScore), englishScore);
        }

        public void PrintInfo()
        {
            Console.WriteLine($"姓名:{Name},年龄:{Age},语文成绩:{ChineseScore}," +
                $"数学成绩:{MathScore},英语成绩:{EnglishScore},总分:{TotalaScore}," +
                $"最高分:{MaxScore},平均分:{AverageScore}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("张三", 18, 30, 60, 90);
            Student student2 = new Student("李四", 20, 70, 23.8, 73);
            Student student3 = new Student("王五", 22, 63.5, 82.3, 38.6);

            List<Student> list = new List<Student> { student1, student2, student3 };

            list.Sort((x, y) => (int)(x.TotalaScore - y.TotalaScore));
            list.ForEach(x => x.PrintInfo());
            //总分
            double total = 0;
            list.ForEach(x => total += x.TotalaScore);
            //平均成绩
            total /= 3;

            Console.WriteLine("============================");
            Console.WriteLine("平均成绩是:"+total);
            list.ForEach(x =>
            {
                if(x.TotalaScore >= total)
                {
                    x.PrintInfo();
                }
            });
        }
    }
}
