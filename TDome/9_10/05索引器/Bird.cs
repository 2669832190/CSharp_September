using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05索引器
{
    public class Bird
    {
        //保存鸟的名字
        private string[] list = new string[0];

        //添加鸟的方法
        public void Add(string name)
        {
            Array.Resize(ref list, list.Length + 1);
            //数组中的最后一位 用来保存新的值
            list[list.Length - 1] = name;
        }

        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }

        public string this[string name]
        {
            get
            {
                foreach (var item in list)
                {
                    if(item == name)
                    {
                        return item;
                    }
                }
                return null;
            }
            set
            {
                for(int i =  0; i < list.Length; i++)
                {
                    if (list[i] == name)
                    {
                        list[i] = value;
                    }
                }
            }
        }
    }
}
