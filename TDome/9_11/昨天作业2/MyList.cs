using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业2
{
    //<T> 表示声明这个类的时候 需要声明T的类型
    public class MyList<T>
    {
        //泛型的数组 根据声明时的类型 决定他的类型
        private T[] values = new T[0];
        //用于记录元素总数量
        public int Count { get; set; }

        //Add方法
        public void Add(T value)
        {
            //数组长度 + 1
            Array.Resize(ref values, values.Length + 1);
            //存入数组最后一位
            values[values.Length - 1] = value;

            //添加一个元素的时候 长度+1
            Count++;
        }

        //删除方法
        public void Remove(T value)
        {
            //遍历
            for (int i = 0; i < values.Length; i++)
            {
                //判断是否相等
                if (values[i].Equals(value))
                {
                    #region 删除一个元素 顺序会改变
                    //赋值为最后一个
                    //values[i] = values[values.Length - 1];
                    //长度 - 1
                    //.Resize(ref values, values.Length - 1);
                    #endregion
                    //复制
                    //(从哪个数组复制,从哪里开始复制,复制到哪个数组,复制到哪个位置 ,复制几个)
                    Array.Copy(values, i + 1, values, i, values.Length - i - 1);
                    //数组长度 - 1
                    Array.Resize(ref values, values.Length - 1);

                    //删除成功的时候 Count - 1
                    Count--;
                    return;
                }
            }
        }

        //查找对应的值 如果存在 返回true  不存在 返回false
        //参数T value 用来查询
        public bool Contains(T value)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i].Equals(value))
                {
                    //找到了 返回true
                    return true;
                }
            }
            //遍历完都没找到 返回false
            return false;
        }

        //清空内容
        public void Clear()
        {
            //等于一个新的长度为0的数组
            values = new T[0];
            //长度
            Count = 0;
        }


        //为了遍历 写个索引器
        public T this[int index]
        {
            get { return values[index]; }
            set { values[index] = value; }
        }
    }
}
