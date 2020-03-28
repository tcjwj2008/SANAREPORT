using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SACHIPLifeRpt.Sql
{
    public static class QuerySql
    {
        public static string GetQueryOnlineLifeSql(string sqlWhere, string sqlLhTime)
        {
            string sql = "";
            if (sqlLhTime.Length > 0)
            {
                sql = string.Format(@"SELECT L.LOT 当前批次,P.COMPONENTID 磊晶号,P.LOTSEQUENCE 批片号,L.STATUS 批状态,P.STATUS 片状态,L.OPERATION 当前站点,
                                    L.ROUTE 流程,P.DEVICE 内部料号,P.WO 工单,CASE WHEN VERIFYLIFE = 'Y' THEN '常规'WHEN VERIFYPT = 'Y' THEN '非常规'ELSE '未知老化类型'END 老化类型,
                                    '查看被回带片' LIST,CASE WHEN M.STATUS = 'Y' THEN '已取样'WHEN M.COMPONENTID IS NULL THEN '未到取样站点'ELSE '已取片品管未取样'END 取样状态,P.PTYPE 类型,L.FACTORY 厂区,CL.LASTTRANSTIME 下线时间,CL.USERID 下线人员,
                                    L.HOLDREASON 扣留原因,L.HOLDDESCR 扣留说明,L.RESOURCENAME 机台号,M.CREATEUSERID 划裂人员,M.CREATEDATE AS 划裂时间,M.HANDOVERUSER 品管点交,M.HANDOVERTIME 品管点交时间,
                                    CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.CREATEDATE IS NOT NULL THEN TO_CHAR (ROUND ((TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.CREATEDATE, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管点交周期,M.USERID 品管出站,M.UPDATETIME 品管出站时间,
                                    CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.UPDATETIME IS NOT NULL THEN TO_CHAR (ROUND((TO_DATE (M.UPDATETIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管取样周期,
                                    LH.LIFEGRADE_H24 老化结果,LH.CONFIRMTIME 出老化结果时间48H,
                                    CASE WHEN M.HANDOVERTIME IS NOT NULL AND LH.CONFIRMTIME IS NOT NULL THEN TO_CHAR (ROUND((TO_DATE (LH.CONFIRMTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管打线周期
                                    FROM MES_WIP_COMP P,MES_WIP_LOT L,MES_CHIP_LIFE_RECORD M,MES_WIP_LOT_CREATE CL,
                                    (SELECT COMPONENTID, CONFIRMTIME, LIFEGRADE_H24 FROM (SELECT COMPONENTID,CONFIRMTIME,LIFEGRADE_H24,RANK()OVER (PARTITION BY COMPONENTID ORDER BY CONFIRMTIME DESC)AS FLAG FROM MES_LIFE_CONFIRM_HIST)
                                    WHERE FLAG = 1 AND LIFEGRADE_H24 IS NOT NULL {1}) LH
                                    WHERE P.CURRENTLOT=L.LOT AND P.COMPONENTID = M.COMPONENTID(+)
                                    AND P.CREATELOT = CL.LOT AND P.COMPONENTID = LH.COMPONENTID(+) AND P.WAFER_TYPE = 'V'
                                    AND (P.VERIFYLIFE = 'Y' OR P.VERIFYPT = 'Y'){0}
                                    UNION ALL
                                    SELECT L.LOT 当前批次,P.COMPONENTID 磊晶号,P.LOTSEQUENCE 批片号,L.STATUS 批状态,P.STATUS 片状态,L.OPERATION 当前站点,
                                    L.ROUTE 流程,P.DEVICE 内部料号,P.WO 工单,CASE WHEN VERIFYLIFE = 'Y' THEN '常规'WHEN VERIFYPT = 'Y' THEN '非常规'ELSE '未知老化类型'END 老化类型,
                                    '查看被回带片' LIST,CASE WHEN M.STATUS = 'Y' THEN '已取样'WHEN M.COMPONENTID IS NULL THEN '未到取样站点'ELSE '已取片品管未取样'END 取样状态,P.PTYPE 类型,L.FACTORY 厂区,CL.LASTTRANSTIME 下线时间,CL.USERID 下线人员,
                                    L.HOLDREASON 扣留原因,L.HOLDDESCR 扣留说明,L.RESOURCENAME 机台号,M.CREATEUSERID 划裂人员,M.CREATEDATE AS 划裂时间,M.HANDOVERUSER 品管点交,M.HANDOVERTIME 品管点交时间,
                                    CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.CREATEDATE IS NOT NULL THEN TO_CHAR (ROUND ((TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.CREATEDATE, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管点交周期,M.USERID 品管出站,M.UPDATETIME 品管出站时间,
                                    CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.UPDATETIME IS NOT NULL THEN TO_CHAR (ROUND((TO_DATE (M.UPDATETIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管取样周期,
                                    LH.LIFEGRADE_H24 老化结果,LH.CONFIRMTIME 出老化结果时间48H,
                                    CASE WHEN M.HANDOVERTIME IS NOT NULL AND LH.CONFIRMTIME IS NOT NULL THEN TO_CHAR (ROUND((TO_DATE (LH.CONFIRMTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管打线周期
                                    FROM MES_WIP_COMP P,MES_WIP_LOT_NONACTIVE L,MES_CHIP_LIFE_RECORD M,MES_WIP_LOT_CREATE CL,
                                    (SELECT COMPONENTID, CONFIRMTIME, LIFEGRADE_H24 FROM (SELECT COMPONENTID,CONFIRMTIME,LIFEGRADE_H24,RANK()OVER (PARTITION BY COMPONENTID ORDER BY CONFIRMTIME DESC)AS FLAG FROM MES_LIFE_CONFIRM_HIST)
                                    WHERE FLAG = 1 AND LIFEGRADE_H24 IS NOT NULL {1}) LH
                                    WHERE P.CURRENTLOT=L.LOT AND P.COMPONENTID = M.COMPONENTID(+)
                                    AND P.CREATELOT = CL.LOT AND P.COMPONENTID = LH.COMPONENTID(+) AND P.WAFER_TYPE = 'V'
                                    AND (P.VERIFYLIFE = 'Y' OR P.VERIFYPT = 'Y') {0}", sqlWhere, sqlLhTime);
            }
            else
            {
                sql = string.Format(@"SELECT L.LOT 当前批次,P.COMPONENTID 磊晶号,P.LOTSEQUENCE 批片号,L.STATUS 批状态,P.STATUS 片状态,L.OPERATION 当前站点,
                                        L.ROUTE 流程,P.DEVICE 内部料号,P.WO 工单,CASE WHEN VERIFYLIFE = 'Y' THEN '常规'WHEN VERIFYPT = 'Y' THEN '非常规'ELSE '未知老化类型'END 老化类型,
                                        '查看被回带片' LIST,CASE WHEN M.STATUS = 'Y' THEN '已取样'WHEN M.COMPONENTID IS NULL THEN '未到取样站点'ELSE '已取片品管未取样'END 取样状态,P.PTYPE 类型,L.FACTORY 厂区,CL.LASTTRANSTIME 下线时间,CL.USERID 下线人员,
                                        L.HOLDREASON 扣留原因,L.HOLDDESCR 扣留说明,L.RESOURCENAME 机台号,M.CREATEUSERID 划裂人员,M.CREATEDATE AS 划裂时间,M.HANDOVERUSER 品管点交,M.HANDOVERTIME 品管点交时间,
                                        CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.CREATEDATE IS NOT NULL THEN TO_CHAR (ROUND ((TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.CREATEDATE, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管点交周期,M.USERID 品管出站,M.UPDATETIME 品管出站时间,
                                        CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.UPDATETIME IS NOT NULL THEN TO_CHAR (ROUND((TO_DATE (M.UPDATETIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管取样周期,
                                        LH.LIFEGRADE_H24 老化结果,LH.CONFIRMTIME 出老化结果时间48H,
                                        CASE WHEN M.HANDOVERTIME IS NOT NULL AND LH.CONFIRMTIME IS NOT NULL THEN TO_CHAR (ROUND((TO_DATE (LH.CONFIRMTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管打线周期
                                        FROM MES_WIP_COMP P,MES_WIP_LOT L,MES_CHIP_LIFE_RECORD M,MES_WIP_LOT_CREATE CL,
                                        (SELECT COMPONENTID, CONFIRMTIME, LIFEGRADE_H24 FROM (SELECT COMPONENTID,CONFIRMTIME,LIFEGRADE_H24,RANK()OVER (PARTITION BY COMPONENTID ORDER BY CONFIRMTIME DESC)AS FLAG FROM MES_LIFE_CONFIRM_HIST)
                                        WHERE FLAG = 1 AND LIFEGRADE_H24 IS NOT NULL ) LH
                                        WHERE P.CURRENTLOT=L.LOT AND P.COMPONENTID = M.COMPONENTID(+)
                                        AND P.CREATELOT = CL.LOT AND P.COMPONENTID = LH.COMPONENTID(+) AND P.WAFER_TYPE = 'V'
                                        AND (P.VERIFYLIFE = 'Y' OR P.VERIFYPT = 'Y'){0}
                                        UNION ALL
                                        SELECT L.LOT 当前批次,P.COMPONENTID 磊晶号,P.LOTSEQUENCE 批片号,L.STATUS 批状态,P.STATUS 片状态,L.OPERATION 当前站点,
                                        L.ROUTE 流程,P.DEVICE 内部料号,P.WO 工单,CASE WHEN VERIFYLIFE = 'Y' THEN '常规'WHEN VERIFYPT = 'Y' THEN '非常规'ELSE '未知老化类型'END 老化类型,
                                        '查看被回带片' LIST,CASE WHEN M.STATUS = 'Y' THEN '已取样'WHEN M.COMPONENTID IS NULL THEN '未到取样站点'ELSE '已取片品管未取样'END 取样状态,P.PTYPE 类型,L.FACTORY 厂区,CL.LASTTRANSTIME 下线时间,CL.USERID 下线人员,
                                        L.HOLDREASON 扣留原因,L.HOLDDESCR 扣留说明,L.RESOURCENAME 机台号,M.CREATEUSERID 划裂人员,M.CREATEDATE AS 划裂时间,M.HANDOVERUSER 品管点交,M.HANDOVERTIME 品管点交时间,
                                        CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.CREATEDATE IS NOT NULL THEN TO_CHAR (ROUND ((TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.CREATEDATE, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管点交周期,M.USERID 品管出站,M.UPDATETIME 品管出站时间,
                                        CASE WHEN M.HANDOVERTIME IS NOT NULL AND M.UPDATETIME IS NOT NULL THEN TO_CHAR (ROUND((TO_DATE (M.UPDATETIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管取样周期,
                                        LH.LIFEGRADE_H24 老化结果,LH.CONFIRMTIME 出老化结果时间48H,
                                        CASE WHEN M.HANDOVERTIME IS NOT NULL AND LH.CONFIRMTIME IS NOT NULL THEN TO_CHAR (ROUND((TO_DATE (LH.CONFIRMTIME, 'yyyy/MM/dd HH24:mi:ss')- TO_DATE (M.HANDOVERTIME, 'yyyy/MM/dd HH24:mi:ss'))* 24,2))ELSE TO_CHAR ('')END 品管打线周期
                                        FROM MES_WIP_COMP P,MES_WIP_LOT_NONACTIVE L,MES_CHIP_LIFE_RECORD M,MES_WIP_LOT_CREATE CL,
                                        (SELECT COMPONENTID, CONFIRMTIME, LIFEGRADE_H24 FROM (SELECT COMPONENTID,CONFIRMTIME,LIFEGRADE_H24,RANK()OVER (PARTITION BY COMPONENTID ORDER BY CONFIRMTIME DESC)AS FLAG FROM MES_LIFE_CONFIRM_HIST)
                                        WHERE FLAG = 1 AND LIFEGRADE_H24 IS NOT NULL ) LH
                                        WHERE P.CURRENTLOT=L.LOT AND P.COMPONENTID = M.COMPONENTID(+)
                                        AND P.CREATELOT = CL.LOT AND P.COMPONENTID = LH.COMPONENTID(+) AND P.WAFER_TYPE = 'V'
                                        AND (P.VERIFYLIFE = 'Y' OR P.VERIFYPT = 'Y') {0}", sqlWhere);
            }
            return sql;
        }

        public static string GetQueryLifeSql(string sqlWhere, string factoryCode)
        {
            string sql = "";
            if (factoryCode.Equals("V"))
            {
                sql = @"SELECT EPI.COMPONENTID AS 磊晶号,P.LOTSEQUENCE 批片号,LIFE_DATAFROM AS 对应老化片,
                        (SELECT OPERATION   FROM MES_WIP_LOT L  WHERE L.LOT = P.CURRENTLOT UNION SELECT OPERATION   FROM MES_WIP_LOT_NONACTIVE L  WHERE L.LOT = P.CURRENTLOT) 当前站点,
                        (SELECT OPERATION   FROM MES_WIP_LOT L  WHERE L.LOT = VP.CURRENTLOT UNION SELECT OPERATION   FROM MES_WIP_LOT_NONACTIVE L  WHERE L.LOT = VP.CURRENTLOT) 快测片当前站点,
                        EPI.LIFE_GRADE AS 老化等级,NVL(EPI.VERIFYFLAG,'N') AS 是否快测片,
                                   NVL(EPI.VERIFYLIFE,'N') AS 是否常规老化,NVL(EPI.VERIFYPT,'N') AS 是否非常规老化,NVL(EPI.VERIFYTYPE,'N') AS 投快测类型
                                   FROM MES_EPI_WIP_COMP_V EPI
                                   LEFT JOIN MES_WIP_COMP P ON EPI.COMPONENTID=P.COMPONENTID 
                                   LEFT JOIN MES_WIP_COMP VP ON EPI.LIFE_DATAFROM=VP.COMPONENTID WHERE 1=1 " + sqlWhere;
            }
            if (factoryCode.Equals("X"))
            {
                sql = (sql.Length > 0 ? sql + "  UNION ALL " : "") + @"SELECT EPI.COMPONENTID AS 磊晶号,P.LOTSEQUENCE 批片号,LIFE_DATAFROM AS 对应老化片,
                                    (SELECT OPERATION   FROM MES_WIP_LOT L  WHERE L.LOT = P.CURRENTLOT UNION SELECT OPERATION   FROM MES_WIP_LOT_NONACTIVE L  WHERE L.LOT = P.CURRENTLOT) 当前站点,
                                    (SELECT OPERATION   FROM MES_WIP_LOT L  WHERE L.LOT = VP.CURRENTLOT UNION SELECT OPERATION   FROM MES_WIP_LOT_NONACTIVE L  WHERE L.LOT = VP.CURRENTLOT) 快测片当前站点,
                                    EPI.LIFE_GRADE AS 老化等级,NVL(EPI.VERIFYFLAG,'N') AS 是否快测片,
                                   NVL(EPI.VERIFYLIFE,'N') AS 是否常规老化,NVL(EPI.VERIFYPT,'N') AS 是否非常规老化,NVL(EPI.VERIFYTYPE,'N') AS 投快测类型
                                   FROM MES_EPI_WIP_COMP_X EPI
                                   LEFT JOIN MES_WIP_COMP P ON EPI.COMPONENTID=P.COMPONENTID
                                   LEFT JOIN MES_WIP_COMP VP ON EPI.LIFE_DATAFROM=VP.COMPONENTID WHERE 1=1 " + sqlWhere;
            }
            if (factoryCode.Equals("T"))
            {
                sql = (sql.Length > 0 ? sql + "  UNION ALL " : "") + @"SELECT EPI.COMPONENTID AS 磊晶号,P.LOTSEQUENCE 批片号,LIFE_DATAFROM AS 对应老化片,
                                    (SELECT OPERATION   FROM MES_WIP_LOT L  WHERE L.LOT = P.CURRENTLOT UNION SELECT OPERATION   FROM MES_WIP_LOT_NONACTIVE L  WHERE L.LOT = P.CURRENTLOT) 当前站点,
                                    (SELECT OPERATION   FROM MES_WIP_LOT L  WHERE L.LOT = VP.CURRENTLOT UNION SELECT OPERATION   FROM MES_WIP_LOT_NONACTIVE L  WHERE L.LOT = VP.CURRENTLOT) 快测片当前站点,
                                    EPI.LIFE_GRADE AS 老化等级,NVL(EPI.VERIFYFLAG,'N') AS 是否快测片,
                                   NVL(EPI.VERIFYLIFE,'N') AS 是否常规老化,NVL(EPI.VERIFYPT,'N') AS 是否非常规老化,NVL(EPI.VERIFYTYPE,'N') AS 投快测类型
                                   FROM MES_EPI_WIP_COMP_T EPI
                                   LEFT JOIN MES_WIP_COMP P ON EPI.COMPONENTID=P.COMPONENTID 
                                   LEFT JOIN MES_WIP_COMP VP ON EPI.LIFE_DATAFROM=VP.COMPONENTID WHERE 1=1 " + sqlWhere;
            }
            if (factoryCode.Equals("A"))
            {
                sql = (sql.Length > 0 ? sql + "  UNION ALL " : "") + @"SELECT EPI.COMPONENTID AS 磊晶号,P.LOTSEQUENCE 批片号,LIFE_DATAFROM AS 对应老化片,
                                    (SELECT OPERATION   FROM MES_WIP_LOT L  WHERE L.LOT = P.CURRENTLOT UNION SELECT OPERATION   FROM MES_WIP_LOT_NONACTIVE L  WHERE L.LOT = P.CURRENTLOT) 当前站点,
                                    (SELECT OPERATION   FROM MES_WIP_LOT L  WHERE L.LOT = VP.CURRENTLOT UNION SELECT OPERATION   FROM MES_WIP_LOT_NONACTIVE L  WHERE L.LOT = VP.CURRENTLOT) 快测片当前站点,
                                    EPI.LIFE_GRADE AS 老化等级,NVL(EPI.VERIFYFLAG,'N') AS 是否快测片,
                                   NVL(EPI.VERIFYLIFE,'N') AS 是否常规老化,NVL(EPI.VERIFYPT,'N') AS 是否非常规老化,NVL(EPI.VERIFYTYPE,'N') AS 投快测类型
                                   FROM MES_EPI_WIP_COMP_A EPI
                                   LEFT JOIN MES_WIP_COMP P ON EPI.COMPONENTID=P.COMPONENTID 
                                   LEFT JOIN MES_WIP_COMP VP ON EPI.LIFE_DATAFROM=VP.COMPONENTID WHERE 1=1 " + sqlWhere;
            }
            return sql;
        }

        public static string GetAllLifeDataByDataFromSql(string dataFrom)
        {
            string sql = @"SELECT COMPONENTID 磊晶号,LIFE_DATAFROM 回带片 FROM MES_EPI_WIP_COMP 
                        WHERE LIFE_DATAFROM ='" + dataFrom + "' ORDER BY WIP_COMP_SID";
            return sql;
        }
    }
}
