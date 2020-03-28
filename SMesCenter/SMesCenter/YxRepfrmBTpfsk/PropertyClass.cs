using System;
using System.Collections.Generic;
//using System.Linq;
using System.Text;

namespace YxRepfrmBTpfsk
{
	/// <summary>
	/// 表示若干属性的类
	/// </summary>
	public class PropertyClass
	{
		//食品帐套链接
		//public static string con_yxsp = "Data Source=188.188.1.11;Initial Catalog=AIS_YXSP2;User ID=sa;Password=Asd123";

		public static string con_yxsp = "Data Source=188.188.1.4;Initial Catalog=AIS_YXSP2;User ID=sa;Password=Asd123;Connect Timeout=0";
		// public static string con_yxsp = "Data Source=188.188.1.8;Initial Catalog=食品测试201405;User ID=sa;Password=xmkingdee";
		//门店销售
		public static string con_rymd = "Data Source=188.188.1.190;Initial Catalog=Waste;User ID=sa;Password=123456";

		public static string con_ry = "Data Source=188.188.1.4;Initial Catalog=AIS_YXRY2;User ID=sa;Password=Asd123;Connect Timeout=0";

		public static string con_ry_test = "Data Source=188.188.1.4;Initial Catalog=Test_yxry;User ID=sa;Password=Asd123;Connect Timeout=0";
		public static string con_rzp_test = "Data Source=188.188.1.4;Initial Catalog=Test_yxrzp;User ID=sa;Password=Asd123;Connect Timeout=0";

		private static int m_OperatorID;
		/// <summary>
		/// 操作员ID
		/// </summary>
		public static int OperatorID
		{
			get
			{
				return m_OperatorID;
			}
			set
			{
				m_OperatorID = value;
			}
		}

		private static string m_OperatorName;
		/// <summary>
		/// 操作员名称
		/// </summary>
		public static string OperatorName
		{
			get
			{
				return m_OperatorName;
			}
			set
			{
				m_OperatorName = value;
			}
		}

		private static string m_PassWord;
		/// <summary>
		/// 操作员密码
		/// </summary>
		public static string PassWord
		{
			get
			{
				return m_PassWord;
			}
			set
			{
				m_PassWord = value;
			}
		}

		private static string m_IsAdmin;
		/// <summary>
		/// 是否系统管理员标记
		/// </summary>
		public static string IsAdmin
		{
			get
			{
				return m_IsAdmin;
			}
			set
			{
				m_IsAdmin = value;
			}
		}

		private string m_InvenCode;
		/// <summary>
		/// 存货代码
		/// </summary>
		public string InvenCode
		{
			get
			{
				return m_InvenCode;
			}
			set
			{
				m_InvenCode = value;
			}
		}

		private string m_InvenName;
		/// <summary>
		/// 存货名称
		/// </summary>
		public string InvenName
		{
			get
			{
				return m_InvenName;
			}
			set
			{
				m_InvenName = value;
			}
		}

		private string m_SpecsModel;
		/// <summary>
		/// 规格型号
		/// </summary>
		public string SpecsModel
		{
			get
			{
				return m_SpecsModel;
			}
			set
			{
				m_SpecsModel = value;
			}
		}

		private string m_ProInvenCode;
		/// <summary>
		/// Bom中母件的代码
		/// </summary>
		public string ProInvenCode
		{
			get
			{
				return m_ProInvenCode;
			}
			set
			{
				m_ProInvenCode = value;
			}
		}

		private string m_MatInvenCode;
		/// <summary>
		/// Bom中子件的代码
		/// </summary>
		public string MatInvenCode
		{
			get
			{
				return m_MatInvenCode;
			}
			set
			{
				m_MatInvenCode = value;
			}
		}
	}
}
