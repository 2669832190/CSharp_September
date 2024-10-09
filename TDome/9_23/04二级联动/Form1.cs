using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04二级联动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //键 食物类别
        //值 具体的食物的集合
        Dictionary<string, List<string>> list = new Dictionary<string, List<string>>()
        {
            { "水果",new List<string>{"苹果","西瓜","香蕉","阳光玫瑰"} },
            {"蔬菜",new List<string>{"胡萝卜","白菜","菠菜","青菜"} }
        };
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                foodCategory.Items.Add(item.Key);
            }
        }

        //当食物类别发生改变的时候
        private void foodCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //先清空
            food.Items.Clear();

            //当前选中的项
            string Category = foodCategory.SelectedItem.ToString();
            //判断选择的内容是否存在对应的键
            //为true 说明我们的字典中存在这样的类别
            if (list.ContainsKey(Category))
            {
                //下拉框的name.所有选项的集合.往里面添加一个数组
                //food.Items.AddRange(数组)

                //list[键] 拿到对应键的值  Category 选中的类别
                //得到的值是List类型 .ToArray() 将List类型转换为数组类型
                //list[Category].ToArray()
                food.Items.AddRange(list[Category].ToArray());
            }
        }
    }
}
