using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_24_飞行棋_ {
	/// <summary>
	/// 格子的类型
	/// </summary>
	public enum E_GridType {
		/// <summary>
		/// 普通
		/// </summary>
		General,
		/// <summary>
		/// 炸弹
		/// </summary>
		Bombs,
		/// <summary>
		/// 传送门
		/// </summary>
		Portals,
		/// <summary>
		/// 火箭
		/// </summary>
		Rocket
	}
	/// <summary>
	/// 格子的坐标信息
	/// </summary>
	public struct Position {
		public int x;
		public int y;
		public Position(int x , int y) {
			this.x = x;
			this.y = y;
		}
	}
	public struct Grid {
		/// <summary>
		/// 格子的类型
		/// </summary>
		public E_GridType gridType;
		/// <summary>
		/// 格子的位置
		/// </summary>
		public Position position;
		public Grid(int x , int y , E_GridType gridType) {
			this.gridType = gridType;
			position.x = x;
			position.y = y;
			
		}
		/// <summary>
		/// 画格子
		/// </summary>
		public void Draw() {
			Console.SetCursorPosition(position.x , position.y);
			switch ( gridType ) {
				case E_GridType.General:
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("□");
					break;
				case E_GridType.Bombs:
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("●");
					break;
				case E_GridType.Portals:
					Console.ForegroundColor = ConsoleColor.DarkBlue;
					Console.Write("‖");
					break;
				case E_GridType.Rocket:
					Console.ForegroundColor = ConsoleColor.DarkGreen;
					Console.Write("¤");
					break;
			}
		}
	}
	/// <summary>
	/// 地图类
	/// </summary>
	public class Map {
		public Grid[] grids;
		public Map(int x,int y,int num) {
			grids = new Grid[num];
			
			int indexX = 0;
			//表示Y变化的次数
			int indexY = 0;
			//x的步长
			int stepNum = 2;
			int RandomNum;
			Random random = new Random();
			
			for ( int i = 0; i < num; i++ ) {
				
				//类型
				RandomNum = random.Next(1,102);
				if ( RandomNum <= 85 || i == 0 || i == grids.Length - 1 ) {
					grids[i].gridType = E_GridType.General;
				} else if(RandomNum > 85 && RandomNum <= 90 ) { 
					grids[i].gridType = E_GridType.Bombs;
				} else if ( RandomNum > 90 && RandomNum <= 95 ) {
					grids[i].gridType = E_GridType.Rocket;
				} else {
					grids[i].gridType = E_GridType.Portals;
				}

				//坐标
				grids[i].position = new Position(x , y);
				if ( indexX == 10 ) {
					y++;
					indexY++;
					if ( indexY == 2 ) {
						indexX = 0;
						indexY = 0;
						stepNum = -stepNum;
					}
				} else {
					indexX++;
					x += stepNum;
				}
			}
			
		}
		/// <summary>
		/// 画地图
		/// </summary>
		public void Draw() {
			for ( int i = 0; i < grids.Length; i++ ) {
				grids[i].Draw();
			}
		}

		/// <summary>
		/// 不变的红墙及提示信息
		/// </summary>
		/// <param name="width">窗口宽</param>
		/// <param name="height">窗口高</param>
		public void RedWall(int width, int height) {
			Console.ForegroundColor = ConsoleColor.Red;
			for ( int i = 0; i < width; i+=2 ) {
				Console.SetCursorPosition(i , 0);
                Console.Write("■");
				Console.SetCursorPosition(i , height - 1);
				Console.Write("■");
				Console.SetCursorPosition(i , height - 6);
				Console.Write("■");
				Console.SetCursorPosition(i , height - 11);
				Console.Write("■");

			}
			for ( int i = 0; i < height; i++ ) { 
				Console.SetCursorPosition(0 , i);
                Console.Write("■");
				Console.SetCursorPosition(width - 2 , i);
				Console.Write("■");
			}

			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(2 , height - 10);
			Console.Write("□:普通格子");

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.SetCursorPosition(2 , height - 9);
			Console.Write("‖:传送门，再来一次");

			Console.ForegroundColor = ConsoleColor.Red;
			Console.SetCursorPosition(26 , height - 9);
			Console.Write("●:炸弹，倒退5格");

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(2 , height - 8);
			Console.Write("¤:火箭，前进5格");

			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.SetCursorPosition(2 , height - 7);
			Console.Write("★:玩家");

			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.SetCursorPosition(12 , height - 7);
			Console.Write("▲:电脑");

			Console.ForegroundColor = ConsoleColor.DarkGreen;
			Console.SetCursorPosition(22 , height - 7);
			Console.Write("◎:玩家和电脑重合");

			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(2 , height - 5);
			Console.Write("按任意键开始扔色子");
		}
	}
}
