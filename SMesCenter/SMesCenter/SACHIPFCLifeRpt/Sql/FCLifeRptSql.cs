using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SaUtility;

namespace SACHIPFCLifeRpt.Sql
{
    class FCLifeRptSql
    {
        public static string GetFCLifeSampleData(string sqlTime, List<string> potIDList, List<string> lotSequenceList, List<string> waferIDList, List<string> deviceList)
        {
            string sqlWhere = sqlTime;
            if (potIDList.Count > 0)
            {
                sqlWhere += "AND  " + DataHelper.GetDataTableInSql("PLATINGPOTID", potIDList);
            }

            if (lotSequenceList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("S.LOTSEQUENCE", lotSequenceList);
            }

            if (waferIDList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("S.COMPONENTID", waferIDList);
            }

            if (deviceList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("POT.DEVICE", deviceList);
            }

            string sql = string.Format(@"SELECT PLATINGPOTID 锅次号,
                           S.COMPONENTID 磊晶号,
                           S.LOTSEQUENCE 批片号,
                           POT.OPERATION 锅次产生站点,
                           POT.DEVICE 内部料号,
                           POT.ERPDEVICE 品名,
                              '规则['
                           || LIFERULE
                           || '留'
                           || LIFEQTY
                           || '片,每片取'
                           || PICKQTY
                           || '颗]'
                              RULE,
                           S.OPERATION 留片站点,
                           LOP1_48H_PERCENT 光衰值_48H,
                           LOP1_96H_PERCENT 光衰值_96H,
                           VF1_48H_PERCENT ΔVF1_48H,
                           VF1_96H_PERCENT ΔVF1_96H,
                           IR_48H_DELTA ΔIR_48H,
                           IR_96H_DELTA ΔIR_96H,
                           VF4_48H_DELTA ΔVF4_48H,
                           VF4_96H_DELTA ΔVF4_96H,
                           R.RESULT 老化结果,
                           R.DESCR 描述,
                           R.CONFIRUSERID 老化确认人员,
                           R.CONFIRTIME 老化确认时间,
                           R.CONFIRRULEE 判定规则,
                           POT.UPDATETIME 锅次时间,
                           S.UPDATETIME 留片时间
                      FROM SA_CHIP_FCLIFE_SAMPLE S
                           INNER JOIN MES_WIP_COMP P
                              ON S.COMPONENTID = P.COMPONENTID
                           LEFT JOIN SA_CHIP_PLATINGPOT_BATCH POT
                              ON S.PLATINGPOTID = POT.BATCHID AND S.COMPONENTID = POT.COMPONENTID
                           LEFT JOIN SA_CHIP_FCLIFE_RESULT R
                              ON S.COMPONENTID = R.COMPONENTID WHERE 1=1 {0}", sqlWhere);
            return sql;
        }

        public static string GetFCPotIDDataByPotID(string potID)
        {
            string sql = string.Format(@"SELECT BATCHID 锅次号,
                                         LOT 锅次批,
                                         COMPONENTID 磊晶号,
                                         LOTSEQUENCE 批片号,
                                         OPERATION 站点,
                                         DEVICE 内部料号,
                                         ERPDEVICE 品名,
                                         EQUIPMENT 机台号,
                                         ISSAMPLING 是否取样片,
                                         WAFERSIZE,
                                         PASSDESC,
                                         CALLRESULT,
                                         CALLTIME,
                                         LIFE_DATAFROM 回带片
                                        FROM SA_CHIP_PLATINGPOT_BATCH
                                        WHERE BATCHID='{0}'ORDER BY LOTSEQUENCE", potID);
            return sql;
        }

        public static string GetFCPotIDData(List<string> potIDList, List<string> lotSequenceList, List<string> waferIDList)
        {
            string sqlWhere = "";
            if (potIDList.Count > 0)
            {
                sqlWhere += "AND  " + DataHelper.GetDataTableInSql("BATCHID", potIDList);
            }

            if (lotSequenceList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("LOTSEQUENCE", lotSequenceList);
            }

            if (waferIDList.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("COMPONENTID", waferIDList);
            }

            string sql = string.Format(@"SELECT BATCHID 锅次号,
                                         LOT 锅次批,
                                         COMPONENTID 磊晶号,
                                         LOTSEQUENCE 批片号,
                                         OPERATION 站点,
                                         DEVICE 内部料号,
                                         ERPDEVICE 品名,
                                         EQUIPMENT 机台号,
                                         ISSAMPLING 是否取样片,
                                         WAFERSIZE,
                                         PASSDESC,
                                         CALLRESULT,
                                         CALLTIME
                                        FROM SA_CHIP_PLATINGPOT_BATCH
                                        WHERE BATCHID IN(SELECT DISTINCT BATCHID FROM SA_CHIP_PLATINGPOT_BATCH WHERE 1=1 {0}) ORDER BY BATCHID,LOTSEQUENCE", sqlWhere);
            return sql;
        }

        public static string GetFCLifeFileData(List<string> lotSequenceList, bool is00H, bool is48H, bool is96H)
        {
            string sqlWhere = "";

            List<string> lifeType = new List<string>();

            if (is00H) lifeType.Add("00H");

            if (is48H) lifeType.Add("48H");

            if (is96H) lifeType.Add("96H");

            if (lifeType.Count > 0)
            {
                sqlWhere += @" AND " + DataHelper.GetDataTableInSql("F.LIFETYPE", lifeType);
            }

            if (lotSequenceList.Count > 0)
            {
                sqlWhere += @" AND (" + DataHelper.GetDataTableInSql("F.LOTSEQUENCE", lotSequenceList) + " OR " + DataHelper.GetDataTableInSql("F.COMPONENTID", lotSequenceList) + ")";
            }

            string sql = string.Format(@"SELECT F.COMPONENTID,
                           F.LOTSEQUENCE,
                           F.TESTTIME,
                           F.LOP1,
                           F.WLD1,
                           F.IR,
                           F.WLP1,
                           F.VF1,
                           F.VF4,
                           F.TESTERMODEL,
                           F.COMMPORT,
                           F.TOTALDIES,
                           F.SPECIFICATION,
                           F.OPERATOR,
                           F.MAXIMUMBIN,
                           F.LIFETYPE,
                           F.AGING_PLATE_NUMBER,
                           F.TESTSEQ,
                           F.X1,
                           F.Y1,
                           F.UP,
                           F.ST1,
                           F.VP,
                           F.UPDATETIME,
                           F.ISERROR,
                           F.ERRORDESCR
                      FROM SA_CHIP_FCLIFE_FILEDATA F WHERE 1=1 {0} ORDER BY F.LOTSEQUENCE,F.LIFETYPE,F.TESTSEQ", sqlWhere);
            return sql;
        }
    }
}
