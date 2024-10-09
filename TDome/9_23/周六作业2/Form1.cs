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

namespace 周六作业2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //窗体加载的时候，需要把文本文件中的菜名加载进左边的多选框
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadMenu();
        }

        //加载的方法，用于把菜名加载进左边的多选框
        private void LoadMenu()
        {
            using(StreamReader sr = new StreamReader("./menu.txt", Encoding.UTF8))
            {
                //清除原来列表里的内容
                notSelectMenu.Items.Clear();
                //遍历文本文件中每一行，添加到列表里
                while (!sr.EndOfStream)
                {
                    notSelectMenu.Items.Add(sr.ReadLine());
                }
            }
        }

        //向右的按钮，被点击的时候，把左侧多选框里已经选中的元素添加到右边，然后删除左侧已经选中的元素
        private void addDish_Click(object sender, EventArgs e)
        {
            foreach(string item in notSelectMenu.CheckedItems)
            {
                SelectMenu.Items.Add(item);
            }

            //当选中的数量大于0，进行循环
            while(notSelectMenu.CheckedItems.Count > 0)
            {
                //删除(选中的第0项)
                notSelectMenu.Items.Remove(notSelectMenu.CheckedItems[0]);
            }
            
        }

        private void delDish_Click(object sender, EventArgs e)
        {
            foreach (string item in SelectMenu.CheckedItems)
            {
                notSelectMenu.Items.Add(item);
            }

            //当选中的数量大于0，进行循环
            while (SelectMenu.CheckedItems.Count > 0)
            {
                //删除(选中的第0项)
                SelectMenu.Items.Remove(SelectMenu.CheckedItems[0]);
            }
        }

        //还原按钮
        private void reInit_Click(object sender, EventArgs e)
        {
            notSelectMenu.Items.Clear();
            SelectMenu.Items.Clear();
            LoadMenu();
        }
    }
}
