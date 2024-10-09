using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 考试
{
    internal class Car
    {
        public enum Pingpai
        {
            奔驰,
            大众,
            五菱,
            Apollo
        }
        public Pingpai Type { get; set; }
        //车型
        public string Cheming { get; set; }
        //车牌号
        public string Paizhao { get; set; }
        //每日租金
        public double Zujin { get; set; }
        //是否租出
        public bool Zujie { get; set; }
        //租借天数
        public int Tianshu { get; set; }
    }
}
