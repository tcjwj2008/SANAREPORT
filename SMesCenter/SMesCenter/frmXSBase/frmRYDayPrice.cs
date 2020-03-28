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
	public partial class frmRYDayPrice : Form
	{
		public frmRYDayPrice()
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

		private void button1_Click(object sender, EventArgs e) //查询
		{
			string sFDate1 = Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd");
			string sFDate2 = Convert.ToDateTime(dateTimePicker2.Text).ToString("yyyy-MM-dd");

			string sSQL = string.Empty;

			SqlParameter param1 = new SqlParameter("@BeginDate1", SqlDbType.VarChar);
			param1.Value = sFDate1;
			SqlParameter param2 = new SqlParameter("@EndDate1", SqlDbType.VarChar);
			param2.Value = sFDate2;

			//创建泛型
			List<SqlParameter> parameters = new List<SqlParameter>();
			parameters.Add(param1);
			parameters.Add(param2);

						//把泛型中的元素复制到数组中
			SqlParameter[] inputParameters = parameters.ToArray();
			try
			{
				ds = k3db.GetProcDataSet("sp_yxryCost_czq_new", inputParameters);
				this.dataGridView1.DataSource = ds.Tables[0];
			}
			catch (Exception err)
			{
				WaitFormService.CloseWaitForm();
				MessageBox.Show("操作失败！" + err.ToString());
				
			}

		}

		private void button2_Click(object sender, EventArgs e)
		{
					string sFileName = "肉业公司日成本分析导出";
					if (dataGridView1.Rows.Count > 0)
			{
				CommExcel.ExportExcel(sFileName, dataGridView1, true);
			}
			else
			{
				MessageBox.Show("无数据，无法导出");
				return;
			}
		}





	
	
	}
}
