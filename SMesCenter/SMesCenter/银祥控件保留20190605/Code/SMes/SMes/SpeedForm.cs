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
    public partial class SpeedForm : SMes.Controls.ExtendForm.BaseForm
    {
        public SpeedForm()
        {
            InitializeComponent();
        }

        private void navigatorEx1_OnQuery(object sender, Controls.AppObject.SysButtonClickedEventArgs e)
        {
            this.lableEx1.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
//            this.navigatorEx1.QuerySql = @"SELECT *
//  FROM dm_pvd_pvdtomocvd p
// WHERE p.PVD建档时间 >= '2018/01/15 00:00:00'
//   AND p.PVD建档时间 <= '2018/02/04 00:00:00'";
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
            this.lableEx2.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

            this.lableEx3.Text = (DateTime.Parse(this.lableEx2.Text) - DateTime.Parse(this.lableEx1.Text)).TotalSeconds.ToString();
        }

        private void navigatorEx1_OnExport(object sender, Controls.AppObject.SysButtonClickedEventArgs e)
        {
//            this.navigatorEx1.QuerySql = @"SELECT *
//  FROM dm_pvd_pvdtomocvd p
// WHERE p.PVD建档时间 >= '2018/01/15 00:00:00'
//   AND p.PVD建档时间 <= '2018/02/04 00:00:00'";
        }
    }
}
