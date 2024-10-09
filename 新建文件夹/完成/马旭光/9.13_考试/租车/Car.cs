using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 租车
{
    internal class Car
    {
        //品牌
        public CarBrand Brand { get; set; }
        //车型
        public string Model { get; set; }
        //车牌号
        public string Lic_Num { get; set; }
        //每日租金
        public double DailyRent { get; set; }
        //是否已租
        public bool IsRented { get; set; }
        //出租天数
        public int RentDays { get; set; }
        //public Dictionary<Type, double> RentRecord { get; set; }

        //车辆列表
        //public Dictionary<CarBrand, List<Type>> CarList = new Dictionary<CarBrand, List<Type>>();
    }
    public enum CarBrand
    {
        奔驰,
        宝马,
        奥迪,
        大众,
        保时捷,
        比亚迪
    }
    //public enum 宝马
    //{
    //    宝马三系,
    //    宝马五系,
    //    宝马X3,
    //    宝马X5
    //}
    //public enum 奔驰
    //{
    //    奔驰C级,
    //    奔驰E级,
    //    奔驰S级,
    //    奔驰A级
    //}
    //public enum 奥迪
    //{
    //    奥迪A6,
    //    奥迪A8,
    //    奥迪A10,
    //    奥迪A12
    //}
    //public enum 大众
    //{
    //    大众S,
    //    大众X,
    //    大众C,
    //    大众CLS
    //}
    //public enum 保时捷
    //{
    //    保时捷Cayenne,
    //    保时捷Civic,
    //    保时捷Cruze,
    //    保时捷S2000
    //}
    //public enum 比亚迪
    //{
    //    比亚迪秦,
    //    比亚迪A8,
    //    比亚迪A10
    //}
}
