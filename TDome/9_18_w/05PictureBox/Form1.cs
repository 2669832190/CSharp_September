using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //窗体加载时发生
        private void Form1_Load(object sender, EventArgs e)
        {
            //当前项目\bin\Debug
            Image image = Image.FromFile("imgs\\1.jpg");
            //赋值给图片控件
            pictureBox1.Image = image;
        }


        //字符串数组，用于保存图片的相对路径
        string[] imgs = new string[]
        {
            "imgs\\1.jpg",
            "imgs\\2.jpg",
            "imgs\\3.jpg"
        };
        //用来保存当前是第几张图片
        int number = 0;


        //点击切换图片的时候
        private void button1_Click(object sender, EventArgs e)
        {
            //索引+1
            number++;

            //Image.FromFile("路径")  加载一张图片 返回Image类型
            Image image = Image.FromFile(imgs[number]);
            //改变图片控件的值
            pictureBox1.Image = image;
        }

		private void pictureBox1_Click(object sender , EventArgs e) {

		}
	}
}
