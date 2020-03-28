using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SACHIPEQPMoveRpt
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        private string _querySql = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
          
        }

        private void navigatorEx1_OnQuery(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            _querySql = SACHIPEQPMoveRpt.SQL.SqlData.SerachData();
            this.navigatorEx1.QuerySql = _querySql; 
        }

        private void navigatorEx1_OnQuerySuccess(object sender, SMes.Controls.AppObject.SysButtonClickedEventArgs e)
        {
            string Movetime;
            DateTime currentTime = new DateTime();
            int sumMinutes;
            currentTime = System.DateTime.Now;
            for (int i = 0; i < dataGridViewEx1.Rows.Count; i++)
            {
                Movetime = dataGridViewEx1.Rows[i].Cells[3].Value.ToString();
                DateTime Time = DateTime.Parse(Movetime);
                TimeSpan midTime = currentTime - Time;
                sumMinutes = midTime.Minutes + midTime.Hours * 60 + midTime.Days * 24 * 60;
                if ((sumMinutes)>5)
                {
                    dataGridViewEx1.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.navigatorEx1.tsbQuery_Click(null, null);
            
        }


    }
}

