using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV文件操作 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender , EventArgs e) {
			openFileDialog.ShowDialog();

			FileStream fileStream = new FileStream(openFileDialog.FileName , FileMode.Open);
			StreamReader streamReader = new StreamReader(fileStream,Encoding.Default);

			string line;
			
			string[] lines;

			bool IsHand = true;

			DataTable dataTable = new DataTable();

			line = streamReader.ReadLine();

			while ( line != null ) {

				lines = line.Split(',');

				//表头数据添加
				if ( IsHand ) {

					for ( int i = 0; i < lines.Length; i++ ) {

						dataTable.Columns.Add(lines[i]);

					}

					IsHand = false;

				} else {

					DataRow dataRow = dataTable.NewRow();

					for ( int i = 0; i < dataTable.Columns.Count; i++ ) {

						dataRow[i] = lines[i];

					}

					dataTable.Rows.Add(dataRow);

					line = streamReader.ReadLine();

				}

			}

			if ( dataTable.Rows.Count != 0 ) {

				dataGridView1.ColumnCount = dataTable.Columns.Count;

				for ( int i = 0; i < dataTable.Columns.Count; i++ ) {

					dataGridView1.Columns[i].HeaderText = dataTable.Columns[i].ColumnName;

				}

				for ( int i = 0;i < dataGridView1.Columns.Count; i++ ) {

					dataGridView1.Rows.Add(dataTable.Rows[i].ItemArray);
				}

			} else {

				MessageBox.Show("您开玩笑呢吧，您打开了个什么玩意？");

			}

			fileStream.Close();

			streamReader.Close();

		}

	}
}
