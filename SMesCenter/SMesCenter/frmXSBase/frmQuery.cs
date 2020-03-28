using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using YXK3FZ.DataClass;
using YXK3FZ.ComClass;

namespace YXK3FZ.RYGL
{
	public partial class frmQuery : Form
	{
		public frmQuery()
		{
			InitializeComponent();

			ds = db.GetDataSet("SELECT Fdbstr  FROM dbo.YXZTLIST WHERE ID=2", "con");
			DataRow dr = ds.Tables[0].Rows[0];
			ZtRyconstring = dr["Fdbstr"].ToString(); //获取K3账套连接字符串
			k3db = new DataBase(ZtRyconstring);

		}

		DataBase db = new DataBase();
		DataSet ds = null;
		DataBase k3db = null;
		CommonUse commUse = new CommonUse();

		string ZtRyconstring = string.Empty; //获取K3账套连接字符串

		//查询
		private void button1_Click(object sender, EventArgs e)
		{
			string sFDate1 = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");
			string sFDate2 = Convert.ToDateTime(dateTimePicker2.Text).ToString("yyyy-MM-dd");

			string sSQL = string.Empty;
			sSQL += " select A,B,C,D,E,F,G, 	";
			sSQL += " CAST(SUM(R) as decimal(18,2)) R, 	";
			sSQL += " CAST(SUM(S) as decimal(18,2)) S, 	";
			sSQL += " CAST(SUM(T) as decimal(18,2)) T, 	";
			sSQL += " CAST(SUM(U) as decimal(18,2)) U, 	";
			sSQL += " CAST(SUM(V) as decimal(18,2)) V, 	";
			sSQL += " CAST(SUM(W) as decimal(18,2)) W, 	";
			sSQL += " CAST(SUM(X) as decimal(18,2)) X, 	";
			sSQL += " CAST(SUM(Y) as decimal(18,2)) Y, 	";
			sSQL += " CAST(SUM(Z) as decimal(18,2)) Z,  	";
			sSQL += " CAST(SUM(AA) as decimal(18,2)) AA, 	";
			sSQL += " CAST(SUM(AB) as decimal(18,2)) AB, ";
			sSQL += " SUM(FOrderBy)/COUNT(*) FOrderBy FROM  AIS_YXRY2.dbo.t_yxryCost t  	";
			sSQL += " Where FFDate>='" + sFDate1 + "' and FFDate<='" + sFDate2 + "' and A='屠宰车间'  AND B<>'合计' 	";
			sSQL += " GROUP BY A,B,C,D,E,F,G 	";
			sSQL += " order by FOrderBy 	";		
			bdsTuZai.DataSource = k3db.GetDataSet(sSQL, "sel").Tables[0].DefaultView;

			sSQL = string.Empty;
			sSQL += " select A,B,C,D,E,F,G, 	";
			sSQL += " CAST(SUM(R) as decimal(18,2)) R, 	";
			sSQL += " CAST(SUM(S) as decimal(18,2)) S, 	";
			sSQL += " CAST(SUM(T) as decimal(18,2)) T, 	";
			sSQL += " CAST(SUM(U) as decimal(18,2)) U, 	";
			sSQL += " CAST(SUM(V) as decimal(18,2)) V, 	";
			sSQL += " CAST(SUM(W) as decimal(18,2)) W, 	";
			sSQL += " CAST(SUM(X) as decimal(18,2)) X, 	";
			sSQL += " CAST(SUM(Y) as decimal(18,2)) Y, 	";
			sSQL += " CAST(SUM(Z) as decimal(18,2)) Z,  	";
			sSQL += " CAST(SUM(AA) as decimal(18,2)) AA, 	";
			sSQL += " CAST(SUM(AB) as decimal(18,2)) AB, ";
			sSQL += " SUM(FOrderBy)/COUNT(*) FOrderBy FROM  AIS_YXRY2.dbo.t_yxryCost t  	";
			sSQL += " Where FFDate>='" + sFDate1 + "' and FFDate<='" + sFDate2 + "' and A='排酸车间'  AND B<>'合计' 	";
			sSQL += " GROUP BY A,B,C,D,E,F,G 	";
			sSQL += " order by FOrderBy 	";
			bdsPaiSuan.DataSource = k3db.GetDataSet(sSQL, "sel").Tables[0].DefaultView;

			sSQL = string.Empty;
			sSQL += " select A,B,C,D,E,F,G, 	";
			sSQL += " CAST(SUM(R) as decimal(18,2)) R, 	";
			sSQL += " CAST(SUM(S) as decimal(18,2)) S, 	";
			sSQL += " CAST(SUM(T) as decimal(18,2)) T, 	";
			sSQL += " CAST(SUM(U) as decimal(18,2)) U, 	";
			sSQL += " CAST(SUM(V) as decimal(18,2)) V, 	";
			sSQL += " CAST(SUM(W) as decimal(18,2)) W, 	";
			sSQL += " CAST(SUM(X) as decimal(18,2)) X, 	";
			sSQL += " CAST(SUM(Y) as decimal(18,2)) Y, 	";
			sSQL += " CAST(SUM(Z) as decimal(18,2)) Z,  	";
			sSQL += " CAST(SUM(AA) as decimal(18,2)) AA, 	";
			sSQL += " CAST(SUM(AB) as decimal(18,2)) AB, ";
			sSQL += " SUM(FOrderBy)/COUNT(*) FOrderBy FROM  AIS_YXRY2.dbo.t_yxryCost t  	";
			sSQL += " Where FFDate>='" + sFDate1 + "' and FFDate<='" + sFDate2 + "' and A='分割车间'  AND B<>'合计' 	";
			sSQL += " GROUP BY A,B,C,D,E,F,G 	";
			sSQL += " order by FOrderBy 	";
			bdsFengGe.DataSource = k3db.GetDataSet(sSQL, "sel").Tables[0].DefaultView;



		}

		private void button2_Click(object sender, EventArgs e) //导出
		{
			string sFileName = tabControl1.SelectedTab.Text + Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");
			if (tabControl1.SelectedIndex == 0)
			{
				if (bdsTuZai.Count > 0)
				{
					CommExcel.ExportExcel(sFileName, dataGridView1, true);
				}
				else
				{
					MessageBox.Show("无数据，无法导出");
					return;
				}

			}
			else if (tabControl1.SelectedIndex == 2)
			{
				if (bdsFengGe.Count > 0)
				{
					CommExcel.ExportExcel(sFileName, dataGridView3, true);
				}
				else
				{
					MessageBox.Show("无数据，无法导出");
					return;
				}
			}
			else if (tabControl1.SelectedIndex == 1)
			{
				if (bdsPaiSuan.Count > 0)
				{
					CommExcel.ExportExcel(sFileName, dataGridView2, true);
				}
				else
				{
					MessageBox.Show("无数据，无法导出");
					return;
				}
			}
		}

	}
}
