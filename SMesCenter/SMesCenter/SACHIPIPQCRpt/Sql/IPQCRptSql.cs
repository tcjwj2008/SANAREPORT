using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaUtility;

namespace SACHIPIPQCRpt.Sql
{
    class IPQCRptSql
    {
        public static string GetIPQCRData(string startTime, string endTime, List<string> chkOperationList, List<string> lotSequenceList)
        {
            string sqlWhere = ""; 

            //if (lotSequenceList.Count == 0)
            //{
                if (!string.IsNullOrEmpty(startTime))
                {
                    sqlWhere += " AND  R.UPDATETIME >= '" + startTime + "' ";
                }
                if (!string.IsNullOrEmpty(endTime))
                {
                    sqlWhere += " AND  R.UPDATETIME <= '" + endTime + "' ";
                }
            //}
            if (chkOperationList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("R.OPERATION", chkOperationList);
               // sqlWhere += string.Format(" AND R.OPERATION IN {0}", "('"  + "')");
            }
            if (lotSequenceList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("R.LOTSEQUENCE", lotSequenceList);
            }
            string sql = string.Format(@"SELECT R.COMPONENTID 磊晶号,
                                                R.LOTSEQUENCE 批片号,
                                                R.LOT 批号,
                                                R.LOTQTY 理论值,
                                                R.ERPDEVICE 品名,
                                                R.COMP_SIZE 尺寸,
                                                R.OPERATION 工作站,
                                                R.EXCEPTIONTYPE 异常类型,
                                                R.EXCEPTIONPERCENT 异常比例,
                                                R.EXCEPTIONQTY 异常数量,
                                                CASE WHEN 
                                                R.EXCEPTIONQTY>0 AND R.LOTQTY>0 THEN 
                                                TO_CHAR(ROUND(R.EXCEPTIONQTY/R.LOTQTY,5)*100,'fm9999990.9999')||'%'ELSE '' END 异常比例2,
                                                R.USERID 工号,
                                                UP.USERNAME 姓名,
                                                R.UPDATETIME 更新时间,
                                                R.REMARKS 备注
                                                FROM SA_CHIP_IPQC_RECORD R 
                                                LEFT JOIN  MES_SEC_USER_PRFL  UP
                                                ON R.USERID=UP.SEC_USER_PRFL_SID 
                                                WHERE  OPERATION IN (SELECT OPERATION FROM MES_PRC_OPER O,MES_ATTR_ATTR AT WHERE PRC_OPER_SID=AT.OBJECT_SID 
                                                AND DATACLASS='OperationAttribute'AND ATTRIBUTENAME='CheckIPQCRecord'AND VALUE='Y')  {0} ORDER BY R.UPDATETIME", sqlWhere);
            return sql;
        }
    }
}
