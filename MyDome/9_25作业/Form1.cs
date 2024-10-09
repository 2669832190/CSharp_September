using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;

namespace _9_25作业 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		private void Form1_Load(object sender , EventArgs e) {
			this.ContextMenuStrip = RightMenuOne;
		}
		private void ToolStripMenuItem_Click(object sender , EventArgs e) {
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Title = "请选择一个文件";
			openFileDialog.InitialDirectory = @"./";
			openFileDialog.Filter = "Json文件|*.json";
			openFileDialog.Multiselect = false;
			openFileDialog.ShowDialog();
			string path = openFileDialog.FileName;
			poem poem = new poem("  静夜思\r\n床前明月光，\r\n疑是地上霜。\r\n举头望明月，\r\n低头思故乡。");
			//Write(poem);
			Student student = new Student() { Name = "张三", age = 18, gender = "女" };
			//Write(student);

			if ( path.Contains("静夜思") ) {
				Read(path , poem);
			} else {
				Read(path , student);
			}
			//Read(path);
		}
		private static void Write(poem poem) {
			FileStream fs = new FileStream("./静夜思.json",FileMode.Create);
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(poem));
			json.WriteObject(fs,poem);
			fs.Close();
		}
		private void Read(string path , poem poem) {
			FileStream fileStream = new FileStream(path,FileMode.Open);
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(poem));
			poem poemone = (poem)json.ReadObject(fileStream);
			fileStream.Close();
			MessageBox.Show(poemone.str);
			FileContent.Text = poemone.str;
		}
		private static void Write(Student student) {
			FileStream fs = new FileStream("./studentInfo.json",FileMode.Create);
			DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Student));
			jsonSer.WriteObject(fs , student);
			fs.Close();
		}
		private void Read(string path , Student student) {
			FileStream fs = new FileStream(path,FileMode.Open);
			DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(Student));
			Student stu1 = (Student)jsonSer.ReadObject(fs);
			fs.Close();
			string studentinof = "学生姓名是:" + stu1.Name + "\r\n年龄是:" + stu1.age + "\r\n性别是:" + stu1.gender;
			MessageBox.Show(studentinof);
			FileContent.Text = studentinof;
		}
		private void Read(string path) {
			FileStream fileStream = new FileStream(path,FileMode.Open);
			DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(string));
			string poemone = (string)json.ReadObject(fileStream);
			fileStream.Close();
			//MessageBox.Show(poemone);
			FileContent.Text = poemone;
		}
	}
}
