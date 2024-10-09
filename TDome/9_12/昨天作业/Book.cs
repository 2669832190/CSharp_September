using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业
{
    //图书
    public class Book
    {
        //ID
        public int ID {  get; set; }
        //书名
        public string Name { get; set; }
        //分类
        public string Classification { get; set; }
        //每天价格
        public double DayPrice { get; set; }
        //总价
        public double Price { get; set; }
        //是否借出
        public bool IsLend { get; set; }
        //借出日期
        public DateTime LendDate { get; set; }
        //借出天数
        public int LendDays { get; set; }
    }
}
