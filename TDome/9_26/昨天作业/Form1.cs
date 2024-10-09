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

namespace 昨天作业
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //挂载右键菜单
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void 打开JSON文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建一个打开文件对话框
            OpenFileDialog open = new OpenFileDialog();
            //标题
            open.Title = "请选择要打开的文件";
            //初始目录
            open.InitialDirectory = "./";
            //文件筛选器
            open.Filter = "json文件|*.json";
            //打开对话框
            open.ShowDialog();

            //获取到刚才选择的json文件的路径
            string path = open.FileName;
            //反序列化
            //文件流
            FileStream fs = new FileStream(path, FileMode.Open);
            //json序列化器
            DataContractJsonSerializer jsonSer = new DataContractJsonSerializer(typeof(string));
            //读文件并反序列化
            string str = (string)jsonSer.ReadObject(fs);

            MessageBox.Show(str);

            //释放文件流
            fs.Close();
        }
    }
}
