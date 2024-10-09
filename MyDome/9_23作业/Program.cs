using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_23作业 {
	internal static class Program {
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main() {
            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
        }
		/*
		 * 1.使用正则表达式验证是否为IP地址
		 * 0-255.0-255.0-255.0-255
		 * 
		 * 2.下拉框三级联动（省市县）
		 */
	}
}
