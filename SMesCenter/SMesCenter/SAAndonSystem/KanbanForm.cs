using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Timers;

namespace SAAndonSystem
{
    public partial class KanbanForm : SMes.Controls.ExtendForm.BaseForm
    {
        string Timer = string.Empty;//定义一个变量
        public KanbanForm()
        {
            InitializeComponent();
        }

        private void KanbanForm_Load(object sender, EventArgs e)
        {
            timer1.Interval = 30000; //指定30秒刷新一次
            timer1.Enabled = true;//可用
        }

        private void navigatorEx2_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string se = "";
            if (sender!=null)
            {
                se = sender.ToString();
            }
            if ("AUTO".CompareTo(se)==0)
            {
                this.navigatorEx2.QuerySql = Timer;
            }
            else
            {
                QueryForm2 qf = new QueryForm2();
                qf.ShowDialog();
                if (qf.QueryFlag)
                {
                    Timer = qf.QuerySql;
                    this.navigatorEx2.QuerySql = qf.QuerySql;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.navigatorEx2.tsbQuery_Click("AUTO", null);

        }

        private void navigatorEx1_OnSave(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            
        }

       
    }
}
