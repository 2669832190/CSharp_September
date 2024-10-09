using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_24_飞行棋_ {
	/// <summary>
	/// 玩家类型枚举
	/// </summary>
	public enum E_player { 
		/// <summary>
		/// 玩家
		/// </summary>
		player,
		/// <summary>
		/// 电脑
		/// </summary>
		computer
	}
 	/// <summary>
	/// 玩家类
	/// </summary>
	public class Player {
		public E_player player;
		int index;
		
	}
}
