using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业飞行棋
{
    //地图类
    internal class Map
    {
        //道具 数组里保存炸弹的坐标
        int[] booms;
        //传送门
        int[] lucks;
        //火箭
        int[] flys;

        //总步数
        int step;
        //行数
        int rowCount;
        //每行步数
        int colCount;

        //两个玩家
        Player p1;
        Player p2;

        //创建地图的同时需要一些信息 地图的配置
        public Map(Player p1, Player p2, int step, int rowCount, int colCount)
        {
            //拿到传进来的数据
            this.p1 = p1;
            this.p2 = p2;
            this.step = step;
            this.rowCount = rowCount;
            this.colCount = colCount;
            //生成道具
            InitProp();
            //绘制地图
            DrawMap();
        }

        //初始化道具
        private void InitProp()
        {
            //任何数除以20都会得到5%
            //就像除以2一定能到50%
            //每个道具的数量
            int count = step / 20;

            //创建道具的数量
            booms = new int[count];
            lucks = new int[count];
            flys = new int[count];

            //随机生成位置
            Random r = new Random();
            for (int i = 0; i < count; i++)
            {
                //第一步和最后一步不能有道具
                booms[i] = r.Next(2, step - 2);
                lucks[i] = r.Next(2, step - 2);
                flys[i] = r.Next(2, step - 2);
            }
        }

        //绘制地图
        private void DrawMap()
        {
            //清空控制台
            Console.Clear();
            //100 - (3 * 30) == 竖着一共多少步
            //竖着一共多少步 / (3-1) == 每列的步数
            //5
            int VerticalSteps = (step - (rowCount * colCount)) / (rowCount - 1);

            //当前正在绘制的步数
            int drawStep = 1;

            //绘制地图 0 1 2
            for (int i = 0; i < rowCount; i++)
            {
                //如果是向左移动的行
                if (i % 2 != 0)
                {
                    drawStep = drawStep + colCount;
                }
                //绘制一行
                for (int j = 0; j < colCount; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(getImgType(drawStep));
                        drawStep++;
                    }
                    else
                    {
                        Console.Write(getImgType(drawStep));
                        drawStep--;
                    }
                }
                //换行
                Console.WriteLine();

                //绘制列之前
                if (i % 2 != 0)
                {
                    //绘制完1号行 3号行 坐标+30
                    drawStep += 30;
                }

                //如果不是最后一行，才绘制竖着的路
                if (i != rowCount - 1)
                {
                    //绘制竖着的路 循环了5次
                    for (int j = 0; j < VerticalSteps; j++)
                    {
                        //第0号行 2号行之后 才输出29个空格 第1号行不需要输出空格
                        if (i % 2 == 0)
                        {
                            //输出29个空格
                            for (int k = 0; k < colCount - 1; k++)
                            {
                                Console.Write("  ");
                            }
                        }
                        //换行
                        Console.WriteLine(getImgType(drawStep));
                        drawStep++;
                    }
                }
            }
        }

        //用来获取格子上应该显示什么 传入一个步数 返回应该显示的图案
        private string getImgType(int pos)
        {
            //玩家在不在这?
            if (p1.pos == pos && p2.pos == pos)
            {
                return "★";
            }
            if (p1.pos == pos)
            {
                return p1.Avatar;
            }
            if (p2.pos == pos)
            {
                return p2.Avatar;
            }

            if (booms.Contains(pos))
            {
                return "☀";
            }
            if (lucks.Contains(pos))
            {
                return "◎";
            }
            if (flys.Contains(pos))
            {
                return "✈";
            }

            return "□";
        }

        //用来移动的方法
        //传入玩家信息 移动几步
        public string PlayerMove(Player p, int pos)
        {
            //玩家移动
            p.pos += pos;

            //重新绘制地图
            DrawMap();

            //判断当前位置的道具 返回给主程序
            if (booms.Contains(p.pos))
            {
                return "☀";
            }
            if (lucks.Contains(p.pos))
            {
                return "◎";
            }
            if (flys.Contains(p.pos))
            {
                return "✈";
            }

            return "□";
        }
    }
}
