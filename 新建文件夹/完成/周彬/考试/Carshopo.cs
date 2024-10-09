using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace 考试
{
    internal class Carshop
    {
        private List<Car> list = new List<Car>();
        public Carshop()
        {
            Car car1 = new Car() { Paizhao = "ASD12356", Cheming = "奔驰300", Type = Car.Pingpai.奔驰, Zujin = 500 };
            Car car2 = new Car() { Paizhao = "ZXC88888", Cheming = "五菱神车", Type = Car.Pingpai.五菱, Zujin = 1000 };
            Car car3 = new Car() { Paizhao = "QWE99999", Cheming = "大众辉腾", Type = Car.Pingpai.大众, Zujin = 5000 };
            Car car4 = new Car() { Paizhao = "QAZ66666", Cheming = "阿太阳神", Type = Car.Pingpai.Apollo, Zujin = 10000 };
            list.Add(car1);
            list.Add(car2);
            list.Add(car3);
            list.Add(car4);
        }
        public void che()
        {
            foreach (Car car in list)
            {
                Console.WriteLine($"品牌：{car.Type}  车名：{car.Cheming}  车牌号：{car.Paizhao}  每日租金：{car.Zujin}  是否租出：{car.Zujie}  租借天数：{car.Tianshu}");
            }
        }

        public (bool,double) JieChe(string Carname, int day)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Cheming == Carname && !list[i].Zujie)
                {
                    double money = day * list[i].Zujin;
                    list[i].Zujie = true; 
                    return (true, money);
                }
            }
            return (false, 0);
        } 
    }
}
