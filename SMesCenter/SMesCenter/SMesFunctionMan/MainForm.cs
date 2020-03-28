using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace SMesFunctionMan
{
    public partial class MainForm :SMes.Controls.ExtendForm.BaseForm
    {
        private string _userId = "qiu";
       // private string _userId = SMes.Core.Config.ApplicationConfig.GetCurrentUser().UserId;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
   
            this.navigatorEx1.AddCustButton("新增", Function_OnAdd);
            this.navigatorEx1.AddCustButton("编辑", Function_OnEdit);
           
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            QueryForm qf = new QueryForm();
            qf.ShowDialog();
            if (qf.QueryFlag)
            {
                this.navigatorEx1.QuerySql = qf.QuerySql;
              
            }
        }

        private void Function_OnEdit(object sender, EventArgs e)
        {
            if (this.dataGridViewEx1.CurrentRow != null)
            {
                string function_id = SMes.Core.Utility.StrUtil.ValueToString(this.dataGridViewEx1.CurrentRow.Cells[this.ColFunctionCode.Name].Value);
							ManageForm mf = new ManageForm(_userId, function_id);
							mf.ShowDialog();
            }
            
        }

        private void Function_OnAdd(object sender, EventArgs e)
        {
            ManageForm mf = new ManageForm(_userId);
            mf.ShowDialog();
        }

        private void navigatorEx1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewEx1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
