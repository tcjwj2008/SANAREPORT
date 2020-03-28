using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAWaferDrawingFromFile.Sql
{
    class WaferDrawingSql
    {
        private static string _sTableName = "MES_WIP_COMP";

        public static string GetCompInfo(string waferId)
        {
            string sql = @"SELECT p.componentid, p.lotsequence, p.erpdevice, p.device,p.ptype,TRIM(FT_SID) SFLAG
                              FROM mes_wip_comp p
                             WHERE (p.componentid = '" + waferId + "' OR p.lotsequence = '" + waferId + @"')";

            return sql;

        }

        public static string GetESDTestTypes(string componentId)
        {
            string sql = @"SELECT H.Attributename,H.Value
                          FROM MES_CHIP_ESD_HIST H
                         WHERE SMP_ESD_SID IN (SELECT MAX(SMP_ESD_SID) FROM MES_CHIP_ESD_HIST WHERE COMPONENTID = '" + componentId + @"')
                         ORDER BY CHIP_ESD_HIST_SID";

            return sql;

        }

        public static string GetWatCorFactoryInfo(string erpDevice,string device)
        {
            string sql = @"SELECT REMARK03,REMARK04  FROM MES_WPC_EXTENDITEM WHERE CLASS='SMP_TUJIAN_XY_SCALE' and  REMARK01 ='" + erpDevice + @"' and  REMARK02 ='" + device + @"'
                              UNION ALL
                            SELECT REMARK03,REMARK04  FROM MES_WPC_EXTENDITEM WHERE CLASS='SMP_TUJIAN_XY_SCALE' and  REMARK01 ='" + erpDevice + @"'";

            return sql;

        }

        public static string GetTapeFileName(string tapeId)
        {
            string sql = @"SELECT BARCODEID FROM MES_CHIP_TAPE_INFO WHERE TAPEID = '" + tapeId + @"'";

            return sql;

        }

        public static string GetUpdateFtRecSql(string waferId)
        {
            string sql = @"UPDATE MES_CHIP_FT_RECORD SET MAP_TJ_FLAG = 'Y'
                                      WHERE FT_SID = (SELECT MAX(FT_SID) FROM MES_CHIP_FT_RECORD WHERE LOTSEQUENCE='" + waferId + "' OR COMPONENTID='" + waferId + @"')";

            return sql;
        }

        public static string GetInsertMapLogSql(string waferId,string userName,string path)
        {
            string sql = @"INSERT INTO DM_MAP_IMAGE_LOG
            (sid, lotsequence, userid, logtime, TYPE, path, mlotsequence, mpath, partition_mon) VALUES
                (GET_SYSID,'" + waferId + @"','" + userName + @"',sysdate,'MAP','" + path + @"','','',SUBSTR(GET_SYSID,5,2))";

            return sql;
        }

        public static string GetSamsungFlagSql(string erpDevice)
        {
            string sql = @"SELECT REMARK01 FROM MES_WPC_EXTENDITEM WHERE CLASS = 'SamSung' AND REMARK01 = '" + erpDevice + @"'";

            return sql;
        }


    }
}
