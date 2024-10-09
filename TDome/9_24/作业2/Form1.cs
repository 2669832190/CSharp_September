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

        //Dictionary<省名,字典<市名,List<县名>>>
        Dictionary<string, Dictionary<string, List<string>>> dic = new Dictionary<string, Dictionary<string, List<string>>>
        //dic的范围
        {
            //dic的一个键值对
            {
                "河南省",new Dictionary<string, List<string>>
                {
                    {"郑州市",new List<string>{ "金水区","管城回族区","经开区","二七区"}},
                    {"许昌市",new List<string>{ "襄城县", "许昌县", "鄢陵县" } }
                }
            },
            {
                "江西省",new Dictionary<string, List<string>>
                {
                    {"南昌市",new List<string>{ "进贤县", "安义县", "南昌县" } },
                    {"九江市",new List<string>{ "庐山区", "瑞昌市", "永修县" } }
                }
            }
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            //添加省的下拉框
            foreach(var i in dic)
            {
                province.Items.Add(i.Key);
            }
        }

        //省被选择的时候
        private void province_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空市的内容
            market.Items.Clear();
            foreach(var sheng in dic)
            {
                if(sheng.Key == province.SelectedItem)
                {
                    //直接添加数组
                    //market.Items.AddRange(sheng.Value.Keys.ToArray());

                    //遍历省里的市
                    foreach (var shi in sheng.Value)
                    {
                        market.Items.Add(shi.Key);
                    }
                }
            }
        }

        //市被选中的时候
        private void market_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空县里面的选项
            county.Items.Clear();
            //对应的省
            string sheng = province.SelectedItem.ToString();
            string shi = market.SelectedItem.ToString();
            //dic[sheng]  获取到的是市和县的字典
            //市和县的字典[市] 获取到的是县的List
            //县的List.ToArray() 转换为数组
            county.Items.AddRange(dic[sheng][shi].ToArray());


        }
    }
}
