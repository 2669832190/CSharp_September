using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. 引用程序集 System.Runtime.Serialization
//2. 引用命名空间
using System.Runtime.Serialization.Json;

namespace _06序列化
{
    internal class Program
    {
        //序列化: 将数据 转换为可保存的 可传输的内容的过程 比如:转为二进制保存 转为json xml之类的数据
        //反序列化: 将二进制或者json或者xml...保存的内容转换为数据
        static void Main(string[] args)
        {
            //Student student = new Student() { Name = "张三", age = 18, gender = "女" };

            //Write(student);
            Read();
        }

        //序列化写 传入一个学生信息 写入文件
        private static void Write(Student student)
        {
            //文件流 创建一个文件
            FileStream fs = new FileStream("./studentInfo.json",FileMode.Create);
            //Json序列化器  new DataContractJsonSerializer(需要进行序列化的数据类型)
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Student));
            //往文件里写
            //json序列化器.WriteObject(文件流，写什么内容)
            jsonSer.WriteObject(fs,student);

            //释放文件流资源
            fs.Close();
        }

        //反序列化 读
        private static void Read()
        {
            //文件流
            FileStream fs = new FileStream("./studentInfo.json",FileMode.Open);
            //json序列化器
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Student));
            //读文件
            //json序列化器.ReadObject(文件流)
            Student stu1 = (Student)jsonSer.ReadObject(fs);

            //释放文件流
            fs.Close();

            //输出读取出来的信息
            Console.WriteLine($"学生姓名是:{stu1.Name},年龄是:{stu1.age},性别是:{stu1.gender}");
        }
    }
}
