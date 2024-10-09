using System.IO;
namespace _Directory {
	internal class Program {
		static void Main(string[] args) {
			Console.WriteLine("Hello, World!");
			//文件操作：File
			//文件夹操作：Directory


			//绝对路径	:从 根目录 出发的全部路径地址
			//绝对路径相当于：某球 某国 某省 某市 某县 某镇 某村 某街 某号

			//相对路径	:从 当前目录 出发的路径
			//相对路径相当于：我们街某号

			//  ./		:指当前文件夹
			//Directory.CreateDirectory("./new");

			//删除 没有此路径的情况 删除会报错 （当文件夹不为空的时候删除也会报错）
			//Directory.Delete("./new");
			//第二个参数为是否同意删除此目录下所有文件！
			//Directory.Delete("./new",true);

			//从哪来，到哪去（需要进行重命名）
			//Directory.Move("./new" , "./new2/new1");

			//获取路径下的所有子文件
			//string[] paths = Directory.GetDirectories("./new2");
			//foreach ( string path in paths ) {
			//             Console.WriteLine(path);
			//         }


			//判断文件夹中 是否存在Directory.Exists(需要查询的路径)
			//  ../		上层目录
			//返回bool	存在返回true	不存在返回false
			//Console.WriteLine(Directory.Exists("../../bin/Debug/new2/new"));
        }
	}
}
