using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YXPSMX
{
	public partial class Form2 : SMes.Controls.ExtendForm.BaseForm
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}

		private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
		{
			string sqlStr = @"SET ANSI_NULLS ON
											set nocount on
											set ansi_warnings on
											exec yx_SaleReport '*SELdate*'";
			DataTable dt = SqlHelper.ExecuteDataTable(sqlStr, CommandType.Text);
			dataGridViewEx1.datasource = dt;
		}
	}
}
