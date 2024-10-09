using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02重复字符串
{
    //一个结构体表示一个重复的内容
    public struct Item
    {
        //用于保存重复的字符串的下标
        public int _index;
        //用于保存重复的第几次
        public int _num;
    }

    internal class Program
    {
        static void Maina(string[] args)
        {
            //有一个字符串的数组,如["a","b","c","b","d","a"]
            //这个数组里有一些重复的字符串 需要给重复的字符串加上编号 最终变成["a1","b1","c","b2","d","a2"]

            /*
            [
                {_index:0,_num:1},
                {_index:1,_num:1},
                {_index:3,_num:2},
                {_index:5,_num:2}
            ]
            */


            //遍历一遍这个数组 遍历的过程中 需要判断每个字符串是第几次重复 怎么判断?
            //把重复信息保存到结构体里 怎么保存 ? 怎么判断是第几次重复 ?
            //给原有的字符串 添加上是第几次重复 从结构体里找到对应下标 通过对应下标的字符串后面添加上[重复第几次] 怎么实现 ?

            /*
            //List相比结构体数组 有什么好处?
            //List长度不固定
            List<Item> list = new List<Item>();
            Item item;
            item._index = 0;
            item._num = 1;
            //把结构体添加进list
            list.Add(item);
            */

            //重复的字符串数组
            List<string> arr = new List<string>() { "a", "b", "c", "b", "d", "a" };
            //用来保存重复的内容信息
            List<Item> list = new List<Item>();
            //用于记录第几次重复<重复的字符串,重复第几次>
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 0; i < arr.Count; i++)
            {
                //判断元素有没有重复  arr[i]表示当前的元素
                //arr.IndexOf(arr[i]) 查找当前的元素第一次出现的下标
                //arr.LastIndexOf(arr[i]) 查找当前元素最后一次出现的下标
                if (arr.IndexOf(arr[i]) != arr.LastIndexOf(arr[i]))
                {
                    //先判断键值对里有没有保存过这个元素
                    if (dic.ContainsKey(arr[i]))
                    {
                        //已经包含了当前键 说明不是第一次重复了
                        //dic[当前元素]的值+1
                        dic[arr[i]]++;
                    }
                    else
                    {
                        //说明字典里没有包含过这个键 编号为1
                        dic.Add(arr[i], 1);
                    }

                    //重复的信息
                    Item item;
                    item._index = i;
                    item._num = dic[arr[i]];
                    //添加到list里
                    list.Add(item);
                }
            }
            /* 最终list里保存的内容
            [
                {_index:0,_num:1},
                {_index:1,_num:1},
                {_index:3,_num:2},
                {_index:5,_num:2}
            ]
            */
            foreach(Item item in list)
            {
                //重复的字符串数组[重复信息.下标] = 原来的字符串 + 重复的编号
                //arr[0] = arr[0] + 1;    arr[0] = "a" + 1;    arr[0] = "a1";
                //arr[1] = arr[1] + 1;    arr[1] = "b" + 1;    arr[1] = "b1";
                //arr[3] = arr[3] + 2;    arr[3] = "b" + 2;    arr[3] = "b2";
                //arr[5] = arr[5] + 2;    arr[5] = "a" + 2;    arr[5] = "a2";
                arr[item._index] = arr[item._index] + item._num;
            }

            foreach(string s in arr)
            {
                Console.WriteLine(s);
            }
        }
    }
}
