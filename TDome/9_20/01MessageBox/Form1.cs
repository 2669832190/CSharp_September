using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //没有标题 的 提示框 只有一个确定按钮
            //MessageBox.Show("弹出的消息");

            //有标题的提示框
            //MessageBox.Show("弹出的消息", "验证提示");

            /*
             * MessageBoxButtons.OK 确定按钮
             * MessageBoxButtons.YesNo 是 否 两个按钮     x不能点
             * MessageBoxButtons.OKCancel 确定 取消 两个按钮
             * MessageBoxButtons.RetryCancel 重试 取消
             * MessageBoxButtons.YesNoCancel 是 否 取消
             * MessageBoxButtons.AbortRetryIgnore 中止 重试 忽略  x不能点
            */
            //MessageBox.Show("消息", "标题", MessageBoxButtons.AbortRetryIgnore);



            /*
             * 4个参数的时候 最后一个参数是图标
             * MessageBoxIcon.Question 圆圈问号
             * MessageBoxIcon.Exclamation 黄色三角感叹号
             * MessageBoxIcon.Information 蓝色i
             * MessageBoxIcon.Warning 警告
             * MessageBoxIcon.Error 错误
             */
            //MessageBox.Show("消息", "标题", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);


            //第5个参数 默认选中的按钮
            //MessageBox.Show("消息","标题",MessageBoxButtons.AbortRetryIgnore,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);

            //第6个参数 样式
            //MessageBox.Show("消息", "标题", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,MessageBoxOptions.RightAlign);

            //第7个参数 布尔类型 表示是否有"帮助"
            //MessageBox.Show("消息", "标题", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign,true);

            //运行之后 有返回值 返回的是点击的按钮的枚举
            DialogResult x = MessageBox.Show("消息", "标题", MessageBoxButtons.YesNoCancel);
            
            if(x == DialogResult.Yes)
            {
                MessageBox.Show("你点的是Yes");
            }else if(x == DialogResult.No)
            {
                MessageBox.Show("你点的是NO");
            }
        }
    }
}
