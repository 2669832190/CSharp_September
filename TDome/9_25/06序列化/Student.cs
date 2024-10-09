using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06序列化
{
    //默认情况下 类的对象是无法序列化的
    //需要标记为可序列化
    [Serializable]
    internal class Student
    {
        public string Name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
}
