//!
using System.Runtime.Serialization.Json;

namespace 序列化 {
	internal class Program {
		static void Main(string[] args) {
			//Console.WriteLine("Hello, World!");

			//序列化引用程序集（需要引用命名空间）
			Student student = new Student("张三",18,"男");

			Write(student);
		}

		private static void Write(Student student) {
			//文件流 创建一个文件
			FileStream fs = new FileStream("./student.json",FileMode.Create);
			//json序列化器 new DataContractJsonSerializer(需要进行序列化的数据类型)
			DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Student));
			//写json文件
			//json序列化器.WriteObject(文件流，写什么内容（对象（类））)
			jsonSer.WriteObject(fs,student);
			//释放文件流（内存）
			fs.Close();
			
		}

		private static void Read() {
			//文件流 创建一个文件
			FileStream fs = new FileStream("./student.json",FileMode.Open);
			DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Student));

			//读文件
			//json序列化器.ReadObject(文件流)
			Student student = (Student)jsonSer.ReadObject(fs);
			//释放文件流（内存）
			fs.Close();
			//输出读取出来的信息
            Console.WriteLine("姓名："+student.Name+"，年龄："+student.Age+"，性别："+student.Sex);
        }
	}
}
