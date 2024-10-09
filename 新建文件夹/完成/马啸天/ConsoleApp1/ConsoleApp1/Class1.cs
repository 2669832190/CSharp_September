using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public enum Pin
    {
        宝马,
        奔驰,
        大众,
        奥迪,
        丰田

    }
    // 车辆信息
    public class Class1
    {
        // 品牌
        public Pin Pin { get; set; }
        // 车型
        public string Che { get; set; }
        // 车牌号
        public string Hao { get; set; }
        // 每日租金
        public double Zujin { get; set; }
        // 是否租出
        public bool Tf { get; set; }
        // 租借天数
        public int Tian { get; set; }
        
        public  Class1(Pin pin,string che,string hao,double zujin,bool tf,int tian)
        {
            this.Pin = pin;
            this.Che = che;
            this.Hao = hao;
            this.Zujin = zujin;
            this.Tf = tf;
            this.Tian = tian;
        }
        
    }
}
