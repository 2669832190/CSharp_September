using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业
{
    public enum Gender
    {
        男,
        女
    }
    public struct Student
    {
        //姓名
        public string _name;
        //性别
        public Gender _gender;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             学生成绩信息
             1. 学生的信息通过结构体保存
             信息中包括:姓名,性别(枚举)
             2. 查询:输入一个学生的姓名,显示这个学生相关的信息
             */
            //保存姓名的数组
            string[] nameList = { "张三", "李四", "王五", "赵六", "孙七", "周八" };
            //创建一个用于保存学生信息的结构体数组 长度是姓名的数量
            Student[] stuList = new Student[nameList.Length];

            #region 单个结构体怎么访问？
            //stuList[0]获取到第一个结构体
            //结构体._name  来访问这个结构体的字段
            stuList[0]._name = "张三";
            #endregion

            //通过循环修改所有学生的信息
            for (int i = 0; i < stuList.Length; i++)
            {
                //第i个学生的名字 = 姓名数组的第i项
                stuList[i]._name = nameList[i];
                //性别
                stuList[i]._gender = Gender.男;
            }

            //查询:输入一个学生的姓名,显示这个学生相关的信息
            Console.WriteLine("请输入学生姓名:");
            //输入的姓名
            string name = Console.ReadLine();

            //便利每个学生 如果名字和输入的姓名相同 则输出这个学生的信息
            foreach (Student student in stuList)
            {
                if (name == student._name)
                {
                    Console.WriteLine("这个学生的名字是:" + student._name);
                    Console.WriteLine("这个学生的性别是:" + student._gender);
                }
            }
        }
    }
}
