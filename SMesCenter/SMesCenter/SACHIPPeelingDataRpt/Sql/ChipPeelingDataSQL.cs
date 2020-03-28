using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SACHIPPeelingDataRpt.Sql
{
    public static class ChipPeelingDataSQL
    {
        public static string GetPeelingListSql(string peelingSD)
        {
            string sqlWhere = string.Empty;
            string sql = @"SELECT  PEELING_RULE_SID,SPHEREDIAMETER,PEELINGWAY,SDAVGMIN,SDAVGMAX,SDMIN,SDMAX,THRUSTMIN,THRUSTAVGMIN,PULLMIN,SPHEREHEIGHT,SHAVGMIN,SHAVGMAX,SHMIN,SHMAX,USERID,UPDATETIME 
                           FROM  DC_Peeling_Rule  WHERE 1=1";
           
                if (!string.IsNullOrEmpty(peelingSD))
                {
                    sqlWhere += " AND SphereDiameter LIKE'%" + peelingSD + "%'";
                }
                sql += sqlWhere;
           
            return sql;
        }
       
        public static string GetAddPeelingListSql(string newSId, string peelingSd, string peelingPW, string peelingSDMin, string peelingSDMax,string peelingSDAvgMin,
            string peelingSDAvgMax, string peelingSH, string peelingSHMin, string peelingSHMax, string peelingSHAvgMin, string peelingSHAvgMax, string peelingThrustMin, 
            string peelingThrustAvgMin,string peelingPullMin, string userid, string updateTime)
        {
            string sql = string.Format(@"INSERT INTO DC_Peeling_Rule (Peeling_Rule_SID,
                                   SphereDiameter,
                                   PeelingWay,
                                   SDAvgMin,
                                   SDAvgMax,
                                   SDMin,
                                   SDMax,
                                   ThrustMin,
                                   ThrustAvgMin,
                                   PullMin,
                                   SphereHeight,
                                   SHAvgMin,
                                   SHAvgMax,
                                   SHMin,
                                   SHMax,
                                   UserID,
                                   UpdateTime)
                                   VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}')",
                                   newSId, peelingSd, peelingPW, peelingSDMin, peelingSDMax, peelingSDAvgMin, peelingSDAvgMax,peelingSH,peelingSHMin,peelingSHMax,peelingSHAvgMin,
                                   peelingSHAvgMax, peelingThrustMin, peelingThrustAvgMin, peelingPullMin,userid, updateTime);
            return sql;
        }

        public static string GetUpdatePeelingListSql(string newSId, string peelingSd, string peelingPW, string peelingSDAvgMin, string peelingSDAvgMax, string peelingSDMin,
            string peelingSDMax, string peelingThrustMin, string peelingThrustAvgMin, string peelingPullMin, string peelingSH, string peelingSHAvgMin, string peelingSHAvgMax,
            string peelingSHMin, string peelingSHMax, string userid, string updateTime)
        {
            string sql = string.Format(@"UPDATE DC_Peeling_Rule SET
                                   Peeling_Rule_SID='" + newSId + @"',
                                   SphereDiameter='" + peelingSd + @"',
                                   PeelingWay='" + peelingPW + @"',
                                   SDAvgMin='" + peelingSDAvgMin + @"',
                                   SDAvgMax='" + peelingSDAvgMax + @"',
                                   SDMin='" + peelingSDMin + @"',
                                   SDMax='" + peelingSDMax + @"',
                                   ThrustMin='" + peelingThrustMin + @"',
                                   ThrustAvgMin='" + peelingThrustAvgMin + @"',
                                   PullMin='" + peelingPullMin + @"',
                                   SphereHeight='" + peelingSH + @"',
                                   SHAvgMin='" + peelingSHAvgMin + @"',
                                   SHAvgMax='" + peelingSHAvgMax + @"',
                                   SHMin='" + peelingSHMin + @"',
                                   SHMax='" + peelingSHMax + @"',
                                   UserID='" + userid + @"',
                                   UpdateTime='" + updateTime + @"'
                                   WHERE Peeling_Rule_SID='" + newSId + @"'"
                                   );
            return sql;
        }
        
        public static string GetPeelingItemsSql(string peelingSd)
        {
            string sql = string.Format(@"SELECT  PEELING_RULE_SID,
                                                 SphereDiameter,
                                                 PeelingWay,
                                                 SDAvgMin,
                                                 SDAvgMax,
                                                 SDMin,
                                                 SDMax,
                                                 ThrustMin,
                                                 ThrustAvgMin,
                                                 PullMin,
                                                 SphereHeight,
                                                 SHAvgMin,
                                                 SHAvgMax,
                                                 SHMin,
                                                 SHMax,       
                                                 USERID,
                                                 UPDATETIME 
                                                 FROM  DC_Peeling_Rule WHERE 1=1 ORDER BY PEELING_RULE_SID", peelingSd);
            return sql;
        }

        public static string GetInitSqlForFactory()
        {
            string sql = @"SELECT 'XA'CODE,'XA'NAME FROM DUAL UNION SELECT 'XM'CODE,'XM'NAME FROM DUAL UNION SELECT 'WH'CODE,'WH'NAME FROM DUAL UNION SELECT 'TJ'CODE,'TJ'NAME FROM DUAL";
            return sql;
        }

        public static string GetInsertPeelingHistSql(string peelingSd, string peelingPW, string peelingSDMin, string peelingSDMax, string peelingSDAvgMin,
            string peelingSDAvgMax, string peelingSH, string peelingSHMin, string peelingSHMax, string peelingSHAvgMin, string peelingSHAvgMax, string peelingThrustMin,
            string peelingThrustAvgMin, string peelingPullMin, string userid, string updateTime, string Peeling_Rule_SID, string UpdateUser)
        {
            string sql = string.Format(@"INSERT INTO DC_Peeling_Rule_HIST (PEELING_RULE_HIST_SID,
                                   SphereDiameter,
                                   PeelingWay,
                                   SDAvgMin,
                                   SDAvgMax,
                                   SDMin,
                                   SDMax,
                                   ThrustMin,
                                   SHAvgMin,
                                   PullMin,
                                   SphereHeight,
                                   SHAvgMax,
                                   ThrustAvgMin,
                                   SHMin,
                                   SHMax,
                                   UserID,
                                   UpdateTime,
                                   PEELING_RULE_SID,
                                   UPDATEUSER,
                                   RECTIME)
                                   VALUES (GET_DC_SYSID,'{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}',to_char(sysdate,'YYYY/MM/DD HH24:MI:SS'))",
                                      peelingSd, peelingPW, peelingSDMin, peelingSDMax, peelingSDAvgMin, peelingSDAvgMax, peelingSH, peelingSHMin, peelingSHMax, peelingSHAvgMin,
                                      peelingSHAvgMax, peelingThrustMin, peelingThrustAvgMin, peelingPullMin, userid, updateTime,Peeling_Rule_SID,UpdateUser);
            return sql;
        
        }

        public static string GetDeletePeelingInfoSql(string peelingSd)
        {
             string delteSql;
            delteSql=(string.Format("DELETE DC_Peeling_Rule WHERE SPHEREDIAMETER='{0}'", peelingSd));
            return delteSql;
        }

        public static string GetPeelingRoutineSql(string tbOpenBoxTimeFrom, string tbOpenBoxTimeTo, string cmbFactory, string tbErpdevice, string tbLotse, string tbSD, string tbPeelingNo,
            string tbLot, string tbEVAPORATEEQP, string tbPeelingWay, string tbPushEQP, string tbPeelingEQP, string tbFacadeChecker, string tbThrustUser, string tbAbnormalChecker)
        {
            string sql = @"select   Routine.FACTORY,
                                    Routine.ERPDEVICE,
                                    Routine.LOTSEQUENCE,
                                    Routine.THRUSTDATE,
                                    Routine.TESTQTY,
                                    Routine.NGQTY,
                                    Routine.RESULT,
                                    Routine.BOILERBATCHID,
                                    COMP.COMPONENTID,
                                    Routine.EVAPORATELOT,
                                    Routine.EVAPORATEEQP,
                                    Routine.EVAPORATETIME,
                                    Routine.STANDNUMBER,
                                    Routine.PEELINGWAY,
                                    Routine.THRUSTEQP,
                                    Routine.PEELINGEQP,
                                    Routine.FACADECHECKER,
                                    Routine.THRUSTUSER,
                                    Routine.ABNORMALCHECKER,
                                    Routine.SPHEREDIAMETER,
                                    Routine.SHEARHEIGHT,
                                    Routine.THRUSTMIN,
                                    Routine.THRUSTAVGMIN,
                                    Routine.THRUSTAVG,
                                    Routine.HBSQTY,
                                    Routine.DAQTY,
                                    Routine.XHQTY,
                                    Routine.SINGLENGQTY,
                                    Routine.HNCBQTY,
                                    Routine.HNDQTY,
                                    Routine.HWCBXQTY,
                                    Routine.HWDXQTY,
                                    Routine.HWCBDQTY,
                                    Routine.HWDDQTY, 
                                    Routine.KDQTY,
                                    Routine.DDJQTY,
                                    Routine.DWYQTY,
                                    Routine.THRUST_1P,
                                    Routine.ABNORMAL_1P,
                                    Routine.RGGRADE_1P,
                                    Routine.THRUST_2P,
                                    Routine.ABNORMAL_2P,
                                    Routine.RGGRADE_2P,
                                    Routine.THRUST_3P,
                                    Routine.ABNORMAL_3P,
                                    Routine.RGGRADE_3P,
                                    Routine.THRUST_4P,
                                    Routine.ABNORMAL_4P,
                                    Routine.RGGRADE_4P,
                                    Routine.THRUST_5P,
                                    Routine.ABNORMAL_5P,
                                    Routine.RGGRADE_5P,
                                    Routine.THRUST_6P,
                                    Routine.ABNORMAL_6P,
                                    Routine.RGGRADE_6P,
                                    Routine.THRUST_7P,
                                    Routine.ABNORMAL_7P,
                                    Routine.RGGRADE_7P,
                                    Routine.THRUST_8P,
                                    Routine.ABNORMAL_8P,
                                    Routine.RGGRADE_8P,  
                                    Routine.THRUST_9P,
                                    Routine.ABNORMAL_9P,
                                    Routine.RGGRADE_9P,
                                    Routine.THRUST_10P,
                                    Routine.ABNORMAL_10P,
                                    Routine.RGGRADE_10P,
                                    Routine.THRUST_1N,
                                    Routine.ABNORMAL_1N,
                                    Routine.RGGRADE_1N,
                                    Routine.THRUST_2N,
                                    Routine.ABNORMAL_2N,
                                    Routine.RGGRADE_2N,
                                    Routine.THRUST_3N,
                                    Routine.ABNORMAL_3N,
                                    Routine.RGGRADE_3N,
                                    Routine.THRUST_4N,
                                    Routine.ABNORMAL_4N,
                                    Routine.RGGRADE_4N,
                                    Routine.THRUST_5N,
                                    Routine.ABNORMAL_5N,
                                    Routine.RGGRADE_5N,
                                    Routine.THRUST_6N,
                                    Routine.ABNORMAL_6N,
                                    Routine.RGGRADE_6N,
                                    Routine.THRUST_7N,
                                    Routine.ABNORMAL_7N,
                                    Routine.RGGRADE_7N,
                                    Routine.THRUST_8N,
                                    Routine.ABNORMAL_8N,
                                    Routine.RGGRADE_8N,
                                    Routine.THRUST_9N,
                                    Routine.ABNORMAL_9N,
                                    Routine.RGGRADE_9N,
                                    Routine.THRUST_10N,
                                    Routine.ABNORMAL_10N,
                                    Routine.RGGRADE_10N  from  DC_Peeling_Routine  Routine,mes_wip_comp comp where Routine.lotsequence=COMP.LOTSEQUENCE";
            if (!string.IsNullOrEmpty(tbOpenBoxTimeFrom))
            {
                sql += " AND Routine.THRUSTDATE >= '" + tbOpenBoxTimeFrom + @"'";
            }
            if (!string.IsNullOrEmpty(tbOpenBoxTimeTo))
            {
                sql += " AND Routine.THRUSTDATE <= '" + tbOpenBoxTimeTo + @"'";
            }
            if (!string.IsNullOrEmpty(cmbFactory))
            {
                sql += " AND Routine.FACTORY like '%" + cmbFactory + @"%'";
            }
            if (!string.IsNullOrEmpty(tbErpdevice))
            {
                sql += " AND Routine.ERPDEVICE like '%" + tbErpdevice + @"%'";
            }
            if (!string.IsNullOrEmpty(tbLotse))
            {
                sql += " AND Routine.LOTSEQUENCE LIKE'%" + tbLotse + "%'";
            }
            if (!string.IsNullOrEmpty(tbSD))
            {
                sql += " AND Routine.SPHEREDIAMETER like '%" + tbSD + @"%'";
            }
            if (!string.IsNullOrEmpty(tbPeelingNo))
            {
                sql += " AND Routine.BOILERBATCHID like '%" + tbPeelingNo + @"%'";
            }
            if (!string.IsNullOrEmpty(tbLot))
            {
                sql += " AND Routine.EVAPORATELOT like '%" + tbLot + @"%'";
            }
            if (!string.IsNullOrEmpty(tbEVAPORATEEQP))
            {
                sql += " AND Routine.EVAPORATEEQP like '%" + tbEVAPORATEEQP + @"%'";
            }
            if (!string.IsNullOrEmpty(tbPeelingWay))
            {
                sql += " AND Routine.PEELINGWAY like '%" + tbPeelingWay + @"%'";
            }
            if (!string.IsNullOrEmpty(tbPushEQP))
            {
                sql += " AND Routine.THRUSTEQP like '%" + tbPushEQP + @"%'";
            }
            if (!string.IsNullOrEmpty(tbPeelingEQP))
            {
                sql += " AND Routine.PEELINGEQP like '%" + tbPeelingEQP + @"%'";
            }
            if (!string.IsNullOrEmpty(tbFacadeChecker))
            {
                sql += " AND Routine.FACADECHECKER like '%" + tbFacadeChecker + @"%'";
            }
            if (!string.IsNullOrEmpty(tbThrustUser))
            {
                sql += " AND Routine.THRUSTUSER like '%" + tbThrustUser + @"%'";
            }
            if (!string.IsNullOrEmpty(tbAbnormalChecker))
            {
                sql += " AND Routine.ABNORMALCHECKER like '%" + tbAbnormalChecker + @"%'";
            }

            return sql;
        
        }

        public static string GetPeelingMonitorSql(string tbThrustTimeFrom, string tbThrustTimeTo, string cmbFa, string tbProduct)
        {
            string sql = @" select M.FACTORY,
                                   M.LOTSEQUENCE,
                                   M.ERPDEVICE,
                                   M.PEELINGWAY,
                                   M.THRUSTDATE,
                                   M.THRUSTEQP,
                                   M.PEELINGEQP,
                                   M.FACADECHECKER,
                                   M.THRUSTUSER,
                                   M.RGCHECKER,
                                   M.SPHEREDIAMETER,
                                   R.SPHEREHEIGHT,
                                   M.SHEARHEIGHT,
                                   R.PULLMIN,
                                   R.THRUSTMIN,
                                   R.THRUSTAVGMIN,
                                   M.SDAVG_P,
                                   M.SDAVG_N,
                                   M.SHAVG_P,
                                   M.SHAVG_N,
                                   M.THRUSTAVG_P,
                                   M.THRUSTAVG_N,
                                   M.SD_1P,
                                   M.SH_1P,
                                   M.Thrust_1P,
                                   M.Pull_1P,
                                   M.RGGrade_1P,
                                   M.SD_2P,
                                   M.SH_2P,
                                   M.Thrust_2P,
                                   M.Pull_2P,
                                   M.RGGrade_2P,
                                   M.SD_3P,
                                   M.SH_3P,
                                   M.Thrust_3P,
                                   M.Pull_3P,
                                   M.RGGrade_3P,
                                   M.SD_4P,
                                   M.SH_4P, 
                                   M.Thrust_4P,
                                   M.Pull_4P,
                                   M.RGGrade_4P,
                                   M.SD_5P,
                                   M.SH_5P,
                                   M.Thrust_5P,
                                   M.Pull_5P,
                                   M.RGGrade_5P,
                                   M.SD_6P,
                                   M.SH_6P,
                                   M.Thrust_6P,
                                   M.Pull_6P,
                                   M.RGGrade_6P,
                                   M.SD_7P,
                                   M.SH_7P,
                                   M.Thrust_7P,
                                   M.Pull_7P,
                                   M.RGGrade_7P,
                                   M.SD_8P,
                                   M.SH_8P,
                                   M.Thrust_8P,
                                   M.Pull_8P,
                                   M.RGGrade_8P,
                                   M.SD_9P,
                                   M.SH_9P,
                                   M.Thrust_9P,
                                   M.Pull_9P,
                                   M.RGGrade_9P,
                                   M.SD_10P,
                                   M.SH_10P,
                                   M.Thrust_10P,
                                   M.Pull_10P,
                                   M.RGGrade_10P,
                                   M.SD_1N,
                                   M.SH_1N,
                                   M.Thrust_1N,
                                   M.Pull_1N,
                                   M.RGGrade_1N,
                                   M.SD_2N,
                                   M.SH_2N,
                                   M.Thrust_2N,
                                   M.Pull_2N,
                                   M.RGGrade_2N,
                                   M.SD_3N,
                                   M.SH_3N,
                                   M.Thrust_3N,
                                   M.Pull_3N,
                                   M.RGGrade_3N,
                                   M.SD_4N,
                                   M.SH_4N,
                                   M.Thrust_4N,
                                   M.Pull_4N,
                                   M.RGGrade_4N,
                                   M.SD_5N,
                                   M.SH_5N,
                                   M.Thrust_5N,
                                   M.Pull_5N,
                                   M.RGGrade_5N,
                                   M.SD_6N,
                                   M.SH_6N,
                                   M.Thrust_6N,
                                   M.Pull_6N,
                                   M.RGGrade_6N,
                                   M.SD_7N,
                                   M.SH_7N,
                                   M.Thrust_7N,
                                   M.Pull_7N,
                                   M.RGGrade_7N,
                                   M.SD_8N,
                                   M.SH_8N,
                                   M.Thrust_8N,
                                   M.Pull_8N,
                                   M.RGGrade_8N,
                                   M.SD_9N,
                                   M.SH_9N,
                                   M.Thrust_9N,
                                   M.Pull_9N,
                                   M.RGGrade_9N,
                                   M.SD_10N,
                                   M.SH_10N,
                                   M.Thrust_10N,
                                   M.Pull_10N,
                                   M.RGGrade_10N
                                   from DC_Peeling_FirstMonitoring M,DC_Peeling_Rule R  where M.PEELINGWAY=R.PEELINGWAY  AND M.SPHEREDIAMETER=R.SPHEREDIAMETER";

            if (!string.IsNullOrEmpty(tbThrustTimeFrom))
            {
                sql += " AND M.THRUSTDATE >= '" + tbThrustTimeFrom + @"'";
            }
            if (!string.IsNullOrEmpty(tbThrustTimeTo))
            {
                sql += " AND M.THRUSTDATE <= '" + tbThrustTimeTo + @"'";
            }
            if (!string.IsNullOrEmpty(cmbFa))
            {
                sql += " AND M.FACTORY like '%" + cmbFa + @"%'";
            }
            if (!string.IsNullOrEmpty(tbProduct))
            {
                sql += " AND M.ERPDEVICE like '%" + tbProduct + @"%'";
            }
            return sql;

        }

        public static string GetPeelingParameterSql(string tbParameterTimeFrom, string tbParameterTimeTo, string cmbFaParameter, string tbProdParameter, string tbSDParameter, string tbPWParameter)
        {
            string sql = @" select   FACTORY,
                                     ERPDEVICE,
                                     CHANGEDATE,
                                     SPHEREDIAMETER,
                                     PEELINGMODE,
                                     PEELINGWAY,
                                     PORCELAINMOUTH,
                                     PARAMMODE,
                                     WIC_DIRECT,
                                     WIC_POWER,
                                     WIC_DYNAMICS,
                                     PBALL_TAILFIBERLENTH,
                                     PBALL_EFOELECTRICITY,
                                     PBALL_EFOTIME,
                                     PBALL_BALLSIZE,
                                     PBALL_BALLTHICKNESS,
                                     NBALL_TAILFIBERLENTH,
                                     NBALL_EFOELECTRICITY,
                                     NBALL_EFOTIME,
                                     NBALL_BALLSIZE,
                                     NBALL_BALLTHICKNESS,
                                     P1WIRE_TAILFIBERLENTH,
                                     P1WIRE_EFOELECTRICITY,
                                     P1WIRE_EFOTIME,
                                     P1WIRE_BALLSIZE,
                                     P1WIRE_BALLTHICKNESS,
                                     N1WIRE_TAILFIBERLENTH,
                                     N1WIRE_EFOELECTRICITY,
                                     N1WIRE_EFOTIME,
                                     N1WIRE_BALLSIZE,
                                     N1WIRE_BALLTHICKNESS,
                                     PBALL_WAITPOWER,
                                     PBALL_TOUCHPOWER,
                                     PBALL_TOUCHTIME,
                                     PBALL_TOUCHSTRESS,
                                     PBALL_POWERDELAY,
                                     PBALL_BONDINGWIRETIME,
                                     PBALL_BONDINGWIREPOWER,
                                     PBALL_WELDINGSTRESS,
                                     NBALL_WAITPOWER,
                                     NBALL_TOUCHPOWER,
                                     NBALL_TOUCHTIME,
                                     NBALL_TOUCHSTRESS,
                                     NBALL_POWERDELAY,
                                     NBALL_BONDINGWIRETIME,
                                     NBALL_BONDINGWIREPOWER,
                                     NBALL_WELDINGSTRESS, 
                                     P1WIRE_WAITPOWER,
                                     P1WIRE_TOUCHPOWER,
                                     P1WIRE_TOUCHTIME,
                                     P1WIRE_TOUCHSTRESS,
                                     P1WIRE_POWERDELAY,
                                     P1WIRE_BONDINGWIRETIME,
                                     P1WIRE_BONDINGWIREPOWER,
                                     P1WIRE_WELDINGSTRESS,
                                     N1WIRE_WAITPOWER,
                                     N1WIRE_TOUCHPOWER,
                                     N1WIRE_TOUCHTIME,
                                     N1WIRE_TOUCHSTRESS,
                                     N1WIRE_POWERDELAY,
                                     N1WIRE_BONDINGWIRETIME,
                                     N1WIRE_BONDINGWIREPOWER,
                                     N1WIRE_WELDINGSTRESS,
                                     P2WIRE_WAITPOWER,
                                     P2WIRE_TOUCHPOWER,
                                     P2WIRE_TOUCHTIME,
                                     P2WIRE_TOUCHSTRESS,
                                     P2WIRE_POWERDELAY,
                                     P2WIRE_BONDINGWIRETIME,
                                     P2WIRE_BONDINGWIREPOWER,
                                     P2WIRE_WELDINGSTRESS,
                                     N2WIRE_WAITPOWER,
                                     N2WIRE_TOUCHPOWER,
                                     N2WIRE_TOUCHTIME,
                                     N2WIRE_TOUCHSTRESS,
                                     N2WIRE_POWERDELAY,
                                     N2WIRE_BONDINGWIRETIME,
                                     N2WIRE_BONDINGWIREPOWER,
                                     N2WIRE_WELDINGSTRESS   from DC_Peeling_Parameter  where 1=1 ";

            if (!string.IsNullOrEmpty(tbParameterTimeFrom))
            {
                sql += " AND THRUSTDATE >= '" + tbParameterTimeFrom + @"'";
            }
            if (!string.IsNullOrEmpty(tbParameterTimeTo))
            {
                sql += " AND THRUSTDATE <= '" + tbParameterTimeTo + @"'";
            }
            if (!string.IsNullOrEmpty(cmbFaParameter))
            {
                sql += " AND FACTORY like '%" + cmbFaParameter + @"%'";
            }
            if (!string.IsNullOrEmpty(tbProdParameter))
            {
                sql += " AND ERPDEVICE like '%" + tbProdParameter + @"%'";
            }
            if (!string.IsNullOrEmpty(tbSDParameter))
            {
                sql += " AND SPHEREDIAMETER like '%" + tbSDParameter + @"%'";
            }
            if (!string.IsNullOrEmpty(tbPWParameter))
            {
                sql += " AND PEELINGWAY like '%" + tbPWParameter + @"%'";
            }
            return sql;
        
        }

    }
}
