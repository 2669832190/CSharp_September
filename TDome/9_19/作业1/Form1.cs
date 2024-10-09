using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //字典 用于保存账号密码信息
        Dictionary<string,string> user = new Dictionary<string,string>();

        //点击注册按钮的事件
        private void button1_Click(object sender, EventArgs e)
        {
            //输入的用户名
            string name = nameText.Text;
            //密码
            string pwd = pwdText.Text;

            //判断第一个字符
            if ((name[0] >= 65 && name[0] <= 90) || (name[0] >= 97 && name[0] <= 122))
            {
                //合格
            }
            else
            {
                MessageBox.Show("首字母格式不正确!");
                return;
            }

            //长度
            //通过取反 true变false false变true
            if(!(name.Length >= 3 && name.Length <= 6))
            {
                MessageBox.Show("账户长度不合格!");
                return;
            }


            //需要判断整个用户名里所有的字符
            for (int i = 0; i < name.Length; i++)
            {
                if ((name[i] >= 65 && name[i] <= 90) || (name[i] >= 97 && name[i] <= 122) 
                    || (name[i] >= '0' && name[i] <= '9') || name[i] == '_')
                {
                    //合格
                }
                else
                {
                    MessageBox.Show("字符不合格!");
                    return;
                }
            }


            //=====================================================
            //密码
            //=====================================================

            //判断第一个字符
            if ((pwd[0] >= 65 && pwd[0] <= 90) || (pwd[0] >= 97 && pwd[0] <= 122))
            {
                //合格
            }
            else
            {
                MessageBox.Show("密码首字母格式不正确!");
                return;
            }

            //长度
            //通过取反 true变false false变true
            if (!(pwd.Length >= 6 && pwd.Length <= 12))
            {
                MessageBox.Show("密码长度不合格!");
                return;
            }


            //需要判断整个用户名里所有的字符
            for (int i = 0; i < pwd.Length; i++)
            {
                if ((pwd[i] >= 65 && pwd[i] <= 90) || (pwd[i] >= 97 && pwd[i] <= 122)
                    || (pwd[i] >= '0' && pwd[i] <= '9') || pwd[i] == '_')
                {
                    //合格
                }
                else
                {
                    MessageBox.Show("密码字符不合格!");
                    return;
                }
            }



            //合格
            user.Add(name, pwd);
            MessageBox.Show("注册成功!");
        }

        //当密码框里的值发生改变时触发
        private void pwdText_TextChanged(object sender, EventArgs e)
        {
            //拿到密码
            string pwd = pwdText.Text;

            //密码强度 1弱 2中 3强
            int strength = 0;

            //是否包含字母
            for(int i = 0;i < pwd.Length;i++)
            {
                //char.IsLetter(字符) 判断一个字符是不是属于字母(a-z A-Z)
                if (char.IsLetter(pwd[i]))
                {
                    strength++;
                    break;
                }
            }

            //是否包含数字
            for(int i = 0;i < pwd.Length; i++)
            {
                //char.IsDigit(字符) 判断这个字符是否属于数字(0-9)
                if (char.IsDigit(pwd[i]))
                {
                    strength++;
                    break;
                }
            }

            //是否包含下划线
            //pwd.IndexOf(字符) 查找这个字符第一次出现的索引 没有找到返回-1
            if (pwd.IndexOf('_') != -1)
            {
                strength++;
            }

            if(strength == 3)
            {
                pwdStrength.Text = "密码强度:强";
            }else if(strength == 2)
            {
                pwdStrength.Text = "密码强度:中";
            }else if( strength == 1)
            {
                pwdStrength.Text = "密码强度:弱";
            }
            else
            {
                pwdStrength.Text = "密码强度:无";
            }
        }
    }
}
