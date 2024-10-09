using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06索引器练习
{
    //鸟群类
    public class Birds
    {
        private Bird[] birds = new Bird[0];

        //添加一只鸟
        public void AddBird(Bird bird)
        {
            //数组长度+1
            Array.Resize(ref birds, birds.Length + 1);
            //数组中最后一位 = 我们准备添加的鸟
            birds[birds.Length - 1] = bird;
        }

        //通过写一个索引器
        //功能：通过名字作为索引 查询到对应的鸟
        public Bird this[string name]
        {
            get
            {
                foreach (Bird b in birds)
                {
                    if(b.Name == name)
                    {
                        return b;
                    }
                }
                return null;
            }
        }
    }
}
