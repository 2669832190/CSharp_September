namespace _9_24_飞行棋_ {
	internal class Program {
		/// <summary>
		/// 场景枚举
		/// </summary>
		enum E_Scene {
			/// <summary>
			/// 开始界面
			/// </summary>
			Begin,
			/// <summary>
			/// 游戏界面
			/// </summary>
			Game,
			/// <summary>
			/// 结束界面
			/// </summary>
			End
		}

		static void Main(string[] args) {
			//初始化
			int width = 50;
			int height = 30;
			initialize(width, height);
			E_Scene scene = E_Scene.Begin;

			while ( true ) {
				switch ( scene ) {
					case E_Scene.Begin:
						Console.Clear();
						BeginOREnd(width, height, ref scene);
						break;
					case E_Scene.Game:
						Console.Clear();
						Game(width,height,ref scene);
						break;
					case E_Scene.End:
						Console.Clear();
						BeginOREnd(width , height , ref scene);
						break;
					
				}
			}
		}
		/// <summary>
		/// 游戏场景
		/// </summary>
		/// <param name="width">窗口宽</param>
		/// <param name="height">窗口高</param>
		/// <param name="scene">程序结束改变场景</param>
		static void Game(int width,int height,ref E_Scene scene) { 
			//不变的红墙
			Map map = new Map(14,3,80);
			map.RedWall(width , height);
			map.Draw();
            Console.ReadKey(true);
            //绘制地图（玩家，道具）

            //掷骰子（改变玩家位置）

            scene = E_Scene.End;
		}



		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="x">窗口宽</param>
		/// <param name="y">窗口高</param>
		static void initialize(int x, int y) {
			Console.CursorVisible = false;
			Console.SetWindowSize(x , y);
			Console.SetBufferSize(x , y);
		}
		/// <summary>
		/// 开始和结束的场景设置
		/// </summary>
		/// <param name="width"></param>
		/// <param name="height"></param>
		/// <param name="scene"></param>
		static void BeginOREnd(int width, int height ,ref E_Scene scene) {
			bool Isexit = false;
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.SetCursorPosition(scene == E_Scene.Begin ? width / 2 - 3 : width / 2 - 4 , 8);
            Console.Write(scene == E_Scene.Begin ? "飞行棋" : "游戏结束");
			int index = 0;
			while ( true ) {
				Console.ForegroundColor = index == 0 ? ConsoleColor.Red : ConsoleColor.White;
				Console.SetCursorPosition(scene == E_Scene.Begin ? width / 2 - 4 : width / 2 - 5 , 13);
				Console.Write(scene == E_Scene.Begin ? "开始游戏" : "回到主界面");
				Console.ForegroundColor = index == 1 ? ConsoleColor.Red : ConsoleColor.White;
				Console.SetCursorPosition(width / 2 - 4 , 15);
				Console.Write("退出游戏");
				switch ( Console.ReadKey(true).Key ) {
					case ConsoleKey.UpArrow:
						if ( index == 0 ) {
							index = 0;
						} else {
							index--;
						}
						break;
					case ConsoleKey.DownArrow:
						if ( index == 1 ) {
							index = 1;
						} else {
							index++;
						}
						break;
					case ConsoleKey.Enter:
						if ( index == 0 ) {
							if ( scene == E_Scene.Begin ) {
								scene = E_Scene.Game;
							} else { 
								scene = E_Scene.Begin;
							}
							Isexit = true;
							break;

						} else {
							Environment.Exit(0);
						}
						break;
				}
				if ( Isexit ) {
					break;
				}
			}
        }
	}
}
