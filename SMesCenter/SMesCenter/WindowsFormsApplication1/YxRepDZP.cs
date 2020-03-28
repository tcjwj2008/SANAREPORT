using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
	public partial class YxRepDZP : SMes.Controls.ExtendForm.BaseForm
	{
		public YxRepDZP()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
		{
//      string sqlStr = @"SET ANSI_NULLS ON
//											set nocount on
//											set ansi_warnings on
//											exec yx_SaleReport '*SELdate*'";
//      DataTable dt = SqlHelper.ExecuteDataTable(sqlStr, CommandType.Text);
//      dataGridViewEx1.datasource = dt;
		}

		private void buttonEx1_Click(object sender, EventArgs e)
		{
			if (textBoxEx1.Text.Length!=10 )
			{
				MessageBox.Show("值不对");
				return;
			}
			string sqlStr = string.Format(@"SET ANSI_NULLS ON
											set nocount on
											set ansi_warnings on
											exec yx_SaleReport '{0}'",textBoxEx1.Text.Substring(0,10));
			DataTable dt = SqlHelper.ExecuteDataTable(sqlStr, CommandType.Text);
			dataGridViewEx2.DataSource = dt;
		}
	}
}
