using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业1
{
    //超市类
    public class Supermarket
    {
        public Commodity[] Stock = new Commodity[0];

        //进货(添加新的商品)
        public void AddCommodity(Commodity commodity)
        {
            //数组长度 + 1
            Array.Resize(ref Stock, Stock.Length + 1);
            //保存新商品
            Stock[Stock.Length - 1] = commodity;
        }

        //出货(删除商品)
        public void RemoveCommodity(int ID)
        {
            //遍历仓库的所有商品
            for (int i = 0; i < Stock.Length; i++)
            {
                //找到了商品
                if (Stock[i].ID == ID)
                {
                    //Stock[i] 商品不要了 赋值为最后一个
                    Stock[i] = Stock[Stock.Length - 1];
                    //最后一个商品不要了
                    Array.Resize(ref Stock, Stock.Length - 1);
                }
            }
        }

        //收银(计算总价格)
        public double Cashier(int ID, int num)
        {
            //找到对应ID的商品
            for(int i = 0;i < Stock.Length;i++)
            {
                if(Stock[i].ID == ID)
                {
                    double price = Stock[i].Price * num;
                    return price;
                }
            }
            //没有找到商品
            Console.WriteLine("没有此商品");
            return 0;
        }
    }
}
