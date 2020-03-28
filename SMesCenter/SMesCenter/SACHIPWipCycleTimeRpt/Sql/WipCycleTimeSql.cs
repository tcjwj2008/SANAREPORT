using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SACHIPWipCycleTimeRpt.Sql
{
    class WipCycleTimeSql
    {
        public static string GetWIPCycleTimeData()
        {
           
            string sql = string.Format(@"SELECT c.lotsequence 批片号, c.componentid 磊晶号,
                                         CASE
                                             WHEN SUBSTR (c.lotsequence, 1, 1) = 'X' THEN '厦门厂'
                                             WHEN SUBSTR (c.lotsequence, 1, 1) = 'V' THEN '翔安厂'
                                             WHEN SUBSTR (c.lotsequence, 1, 1) = 'A' THEN '芜湖厂'
                                             WHEN SUBSTR (c.lotsequence, 1, 1) = 'T' THEN '天津厂'
                                             ELSE  NULL  END   厂区 , 
                                         CASE
                                             WHEN SUBSTR (l.device, 9, 1) = 'A' THEN '2寸'
                                             WHEN SUBSTR (l.device, 9, 1) = 'D' THEN '4寸'
                                             WHEN SUBSTR (l.device, 9, 1) = 'E' THEN '6寸'
                                             ELSE NULL  END 尺寸, 
                          l.device  内部料号, l.lot 批次 , l.operation 工作站, l.status 状态, l.createtime 下线时间, 
                          SYSDATE 当前时间, ROUND ((SYSDATE - TO_DATE (l.createtime, 'yyyy/MM/dd HH24:mi:ss')), 2) AS 下线周期, 
                          ROUND ((TO_DATE (oemc.oemtime_in, 'yyyy/MM/dd HH24:mi:ss') - TO_DATE (oemc.oemtime_out, 'yyyy/MM/dd HH24:mi:ss')), 2) AS 代工周期, 
                          l.quantity 面积, l.unit 单位, c.erpdevice 品名, pt.VALUE 类型 FROM mes_wip_lot l , mes_wip_comp c, sa_chip_oem_comp oemc, 
                         (SELECT a.VALUE, p.product FROM mes_attr_attr a, mes_prc_prod_ver p  
                         WHERE a.dataclass = 'ProductAttribute' AND a.attributename = 'ProdType' AND a.object_sid = p.prc_prod_ver_sid) pt
                         WHERE pt.product = l.product AND l.lot = c.currentlot AND oemc.lotsequence = c.lotsequence");

            return sql;
        }
    }
}
