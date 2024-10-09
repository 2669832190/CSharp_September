using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //窗体加载的时候 默认一张图片
        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = Image.FromFile("imgs\\1.jpg");
            myImage.Image = image;
        }

        string[] imgs = new string[]
        {
            "imgs\\1.jpg",
            "imgs\\2.jpg",
            "imgs\\3.jpg"
        };

        //当前显示的图片对应的数组索引
        int number = 0;
        //点击下一张按钮的时候
        private void next_Click(object sender, EventArgs e)
        {
            number++;
            //判断如果超出了最后一张
            if (number == imgs.Length)
            {
                number = 0;
            }

            //给图片控件 赋值 图片数组的第number张图片
            myImage.Image = Image.FromFile(imgs[number]);
        }

        //点击上一张按钮的时候
        private void previous_Click(object sender, EventArgs e)
        {
            number--;
            //判断如果超出了第一张
            if (number == -1)
            {
                //等于最后一张
                number = imgs.Length - 1;
            }

            //给图片控件 赋值 图片数组的第number张图片
            myImage.Image = Image.FromFile(imgs[number]);
        }

        //每秒运行一次的事件
        private void timer1_Tick(object sender, EventArgs e)
        {
            number++;
            //判断如果超出了最后一张
            if (number == imgs.Length)
            {
                number = 0;
            }

            //给图片控件 赋值 图片数组的第number张图片
            myImage.Image = Image.FromFile(imgs[number]);
        }
    }
}
