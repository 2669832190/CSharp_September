using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06练习
{
    public enum Gender
    {
        男,
        女,
        未知
    }

    public class Student
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }

        public Student(string name, Gender gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }

        public Student(string name, int age) : this(name, Gender.未知, age) { }

        public void SelfIntroduction()
        {
            Console.WriteLine($"姓名是:{Name},性别是:{Gender},年龄是:{Age}");
        }
    }
}
