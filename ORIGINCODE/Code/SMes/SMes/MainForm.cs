using SMes.Controls.AppObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMes
{
    public partial class MainForm : SMes.Controls.ExtendForm.BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //QueryForm qf = new QueryForm();
            //qf.ShowDialog();
            //if (qf.QueryFlag)
            //{
            //    this.navigatorEx1.QuerySql = qf.QuerySql;
            //}
            this.navigatorEx1.QuerySql = @"SELECT *
  FROM (SELECT DISTINCT A.LOTSEQUENCE,
                        A.OPERATION,
                        A.STATUS,
                        A.COMPONENTQTY,
                        A.CURRENTRULE,
                        A.ERPDEVICE,
                        CASE
                          WHEN MOVEFILE.WAFERID IS NULL THEN
                           N'END'
                          ELSE
                           MOVEFILE.WAFERID
                        END AS WAFERID,
                        MOVEFILE.EQP,
                        MOVEFILE.TESTTIME,
                        RANK() OVER(PARTITION BY A.LOTSEQUENCE ORDER BY MOVEFILE.EQP, MOVEFILE.TESTTIME DESC) FLAG
          FROM (SELECT LOT.LOT,
                       LOT.OPERATION,
                       COMP.COMPONENTQTY,
                       COMP.GRADE,
                       LOT.CURRENTRULE,
                       LOT.STATUS,
                       COMP.COMPONENTID,
                       COMP.LOTSEQUENCE,
                       COMP.ERPDEVICE
                  FROM MES_WIP_LOT LOT, MES_WIP_COMP COMP
                 WHERE LOT.OPERATION = '测试站-Chip全测'
                   AND LOT.LOT = COMP.CURRENTLOT
                   AND COMP.UNIT = 'PCS') A
          LEFT JOIN (SELECT MOVEFILE.WAFERID, MOVEFILE.EQP, RD.TESTTIME
                      FROM MES_CHIP_MOVEFILE_RECORD MOVEFILE
                      LEFT JOIN MES_CHIP_FT_RECORD RD
                        ON MOVEFILE.WAFERID = RD.LOTSEQUENCE
                     WHERE TYPE = 'FT') MOVEFILE
            ON MOVEFILE.WAFERID = A.LOTSEQUENCE)
 WHERE FLAG = 1";
            
        }

        private void navigatorEx1_OnQuerySuccess(object sender, Controls.AppObject.SysButtonClickedEventArgs e)
        {
            //this.dataGridViewEx1.SetDataSourceTable(this.navigatorEx1.DataTable);
        }

        private void navigatorEx1_OnExport(object sender, Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.navigatorEx1.QuerySql = @"SELECT  ft.ft_sid,ft.componentid,ft.binname,ft.lotsequence,ft.erpdevice,ft.waferqty FROM dm_chip_ft_record ft WHERE ft.ft_sid > '201710120020190976' AND ft.ft_sid < '201710200020190976'";
        }

        private void buttonEx1_Click(object sender, EventArgs e)
        {
            this.dataGridViewEx1.Rows[0].HeaderCell.Style.BackColor = SMes.Core.Utility.ColorMap.DataGridViewErrorLineColor;
            this.dataGridViewEx1.Refresh();
        }

        private void buttonEx2_Click(object sender, EventArgs e)
        {
            this.dataGridViewEx1.Rows[0].HeaderCell.Style.BackColor = System.Drawing.Color.Empty;
            this.dataGridViewEx1.Refresh();
        }

        private void dataGridViewEx1_OnFileUpIconClick(object sender, Controls.AppObject.DataGridViewCustClickEventArgs e)
        {
            MessageBox.Show(e.RowIndex + " " + e.ColumnIndex);
        }

        private void dataGridViewEx1_OnLovIconClick(object sender, Controls.AppObject.DataGridViewCustClickEventArgs e)
        {
            if (e.ColumnIndex == Column5.Index)
            {
                LovFormExParameter lovFormExParameter = new LovFormExParameter();
                lovFormExParameter.QuerySql = "SELECT m.remark01,m.remark02,m.remark03 FROM mes_wpc_extenditem m WHERE m.class = 'STRUCTURE_SUBTYPE' and m.remark01 " + SMes.Core.Utility.StrUtil.SQL_PLACEHOLDER;
                lovFormExParameter.LovFormTitle = "数据查找";
                lovFormExParameter.ColumnsName.Add("ID");
                lovFormExParameter.ColumnsName.Add("名称");
                lovFormExParameter.ColumnsName.Add("备注");
                lovFormExParameter.IsUseInDataGridView = true;
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);
                lovFormExParameter.ColumnVisableList.Add(true);

                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[Column5.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[Column10.Name]);
                lovFormExParameter.CellList.Add(this.dataGridViewEx1.Rows[e.RowIndex].Cells[Column11.Name]);
                ((SMes.Controls.DataGridViewTextBoxExColumn)this.dataGridViewEx1.Columns[Column5.Name]).LovParameter = lovFormExParameter;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.navigatorEx1.tsbQuery_Click(null, null);
        }
    }
}
