using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_23作业 {
	public partial class Form1 : Form {
		Dictionary<string,Dictionary<string,string>> provincelist = new Dictionary<string, Dictionary<string, string>>{
				{ "河南省", new Dictionary<string,string>{
					{"郑州市","经济开发区" },
					{"南阳市","方城县" },
					{"新乡市","获嘉县" }
				} },
				{ "湖南省" , new Dictionary<string,string>{
					{"长沙市","岳麓区" },
					{"湘潭市","湘乡市" },
					{"郴州市","桂阳县" }
				} }
			};
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender , EventArgs e) {
			
			foreach ( var item in provincelist ) {
				province.Items.Add(item.Key);
			}
		}
		//省框改变值时
		private void province_SelectedIndexChanged(object sender , EventArgs e) {
			city.Items.Clear();
			string temp = province.SelectedItem.ToString();
			if ( provincelist.ContainsKey(temp)) {
				foreach ( var item in provincelist[temp] ) {
					city.Items.Add(item.Key);

				}
			}
		}

		private void city_SelectedIndexChanged(object sender , EventArgs e) {
			prefecture.Items.Clear();
			string temp = city.SelectedItem.ToString();
			prefecture.Items.Add(provincelist[province.SelectedItem.ToString()][temp]);
        }

		private void button1_Click(object sender , EventArgs e) {
			//((1[0-9][0-9]\.)|(2[0-4][0-9]\.)|(25[0-5]\.)|([1-9][0-9]\.)|([0-9]\.)){3}((1[0-9][0-9])|(2[0-4][0-9])|(25[0-5])|([1-9][0-9])|([0-9]))
			//(((1\d{2})|(2[0-4]\d)|(25[0-5])|(\d{1,2})).){3}(((1\d{2})|(2[0-4]\d)|(25[0-5])|(\d{1,2})))
			//((2[0-4]\d)|(25[0-5])|(1\d{2})|(\d{1,2})).((2[0-4]\d)|(25[0-5])|(1\d{2})|(\d{1,2})).((2[0-4]\d)|(25[0-5])|(1\d{2})|(\d{1,2})).((2[0-4]\d)|(25[0-5])|(1\d{2})|(\d{1,2}))
			Regex regex = new Regex(@"((1[0-9][0-9]\.)|(2[0-4][0-9]\.)|(25[0-5]\.)|([1-9][0-9]\.)|([0-9]\.)){3}((1[0-9][0-9])|(2[0-4][0-9])|(25[0-5])|([1-9][0-9])|([0-9]))");
			if ( regex.IsMatch(Ip.Text) ) {
				MessageBox.Show("true");
			} else {
				MessageBox.Show("false");
			}
		}
	}
}
