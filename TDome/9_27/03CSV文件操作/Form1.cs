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

namespace _03CSV文件操作
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //打开文件的时候 清空原有内容
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            //如果打开对话框 结果为OK
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //openFileDialog1.FileName 要打开的文件名
                //文件流 用于打开文件
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                //字节流读取器 用于读取文件 传入文件流
                StreamReader sr = new StreamReader(fs, Encoding.Default);

                //读取 => 字符串 => DataTable => DataGridView表格
                //sr.ReadLine() 读取一行字符串

                //用来接收一行数据  姓名,年龄,性别
                string line;
                //用来拆分一行信息 保存到数组里
                string[] lines;
                //数据表 用来保存数据
                DataTable dataTable = new DataTable();
                //用来区分是不是表头
                bool isHead = true;

                //读一行数据
                line = sr.ReadLine();
                //读出来的数据不为空
                while (line != null)
                {
                    //姓名 年龄 性别
                    lines = line.Split(',');

                    //处理表头
                    if (isHead)
                    {
                        //遍历数组中的字符串
                        for (int i = 0; i < lines.Length; i++)
                        {
                            //添加到表头
                            //dataTable.Columns 数据中所有列的集合
                            //.Add  添加到列的集合
                            dataTable.Columns.Add(lines[i]);
                        }

                        isHead = false;
                    }
                    else
                    {
                        //如果进入这个否则 说明读取出来的是信息
                        //创建一个行 = 与数据表相同架构的行
                        DataRow datarow = dataTable.NewRow();
                        //保存数据
                        for (int i = 0; i < lines.Length; i++)
                        {
                            datarow[i] = lines[i];
                        }

                        //把数据行添加到数据表
                        dataTable.Rows.Add(datarow);
                    }

                    //读下一行
                    line = sr.ReadLine();
                }

                //如果数据表中没有数据
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("根本就没有数据，你打开了个什么玩意");
                }
                else
                {
                    //把DataTable数据表中的数据转为DataGridView的数据
                    //设置表格控件显示多少列
                    dataGridView1.ColumnCount = dataTable.Columns.Count;
                    //添加表头
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        //控件的第i列表头 = 数据表第i列表头
                        dataGridView1.Columns[i].HeaderText = dataTable.Columns[i].ColumnName;
                    }
                    //添加数据
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        //控件添加一行数据(数据表.一行数据.以数组的形式)
                        dataGridView1.Rows.Add(dataTable.Rows[i].ItemArray);
                    }
                }


                sr.Close();
                fs.Close();
            }




        }
	}
}
