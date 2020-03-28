using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAAndonSystem.Sql
{
    class AndonSystemSql
    {
        public static string Search_User(string AndonNo, string EQPNO, string AndonStatus, string CallinGuser, string DisposGuser, string ClosingGuser)
        {
            string sql = @"SELECT S.ANDONNO,
                                S.EQPNO,
                                S.ANDONSTATUS,
                                S.ANDONCATEGORY ,
                                S.CALLINGUSER,
                                S.CALLINGTIME,
                                S.CALLINGREMARK,
                                S.DISPOSINGUSER,
                                S.DISPOSINGTIME,
                                S.DISPOSINGREMARK,   
                                S.CLOSINGUSER,
                                S.CLOSINGTIME,        
                                S.CLOSINGREMARK,  
                                B.ENABLED,   
                                S.USERID,
                                S.UPDATETIME
                                FROM DM_CIM_ANDON_STATUS S LEFT JOIN DM_CIM_ANDON_BASIS B ON S.ANDONNO=B.ANDONNO
                                WHERE 1=1";
            if (!string.IsNullOrEmpty(AndonNo))
            {
                sql += @" AND S.ANDONNO='" + AndonNo + @"'";
            }
            if (!string.IsNullOrEmpty(EQPNO))
            {
                sql += @" AND S.EQPNO like '%" + EQPNO + @"%'";
            }
            if (!string.IsNullOrEmpty(AndonStatus))
            {
                sql += @" AND S.ANDONSTATUS = '" + AndonStatus + @"'";
            }
            if (!string.IsNullOrEmpty(CallinGuser))
            {
                sql += @" AND S.CALLINGUSER like '%" + CallinGuser + @"%'";
            }
            if (!string.IsNullOrEmpty(DisposGuser))
            {
                sql += @" AND S.DISPOSINGUSER like '%" + DisposGuser + @"%'";
            }
            if (!string.IsNullOrEmpty(ClosingGuser))
            {
                sql += @" AND S.CLOSINGUSER like '%" + ClosingGuser + @"%'";
            }

            return sql;
        }

        public static string Search_UserKan(string AndonNo)
        {
            string sql = @"SELECT ANDONNO,EQPNO,ANDONSTATUS,CALLINGUSER,DISPOSINGUSER,CALLINGREMARK,USERID,UPDATETIME FROM DM_CIM_ANDON_STATUS WHERE 1=1";
            if (!string.IsNullOrEmpty(AndonNo))
            {
                sql += @" AND S.ANDONNO='" + AndonNo + @"'";
            }
            return sql;
        }

        public static string Insert_Set(string AndonNo, string EQPType, string TriggerGroup, string TreatmentGroup, string ClosingGroup, string AssociatedPM,string Refreshhtime, string Enabled, string Email)
        {
            string sql = @"insert into DM_CIM_ANDON_BASIS(ANDONNO,
                                                          EQPTYPE,
                                                          CALLINGGROUP,
                                                          DISPOSINGGROUP,
                                                          CLOSINGGROUP,
                                                          TOPMSHUTDOWN,
                                                          REFRESHTIME,
                                                          ENABLED,
                                                          TOMAIL) values ('" + AndonNo + @"',
                                                          '" + EQPType + @"',
                                                          '" + TriggerGroup + @"',
                                                          '" + TreatmentGroup + @"',
                                                          '" + ClosingGroup + @"',
                                                          '" + AssociatedPM + @"',
                                                          '" + Refreshhtime + @"',
                                                          '" + Enabled + @"',
                                                          '" + Email + @"'）";
            return sql;
        }
        public static string Insert_Trigger(string AndonNo, string MachineNumbe, string AndonStatus, string CallinGuser, string AndonCateGory, string CallingTime, string CallingRemrak)
        {
            string sql = @"insert into DM_CIM_ANDON_STATUS(ANDONNO,
                                                            EQPNO,
                                                            ANDONSTATUS,
                                                            CALLINGUSER,
                                                            ANDONCATEGORY,
                                                            CALLINGTIME,
                                                            CALLINGREMARK) values ('" + AndonNo + @"',
                                                            '" + MachineNumbe + @"',
                                                            '" + AndonStatus + @"',
                                                            '" + CallinGuser + @"',
                                                            '" + AndonCateGory + @"',
                                                            '" + CallingTime + @"',
                                                            '" + CallingRemrak + @"'）";
            return sql;
        }
        public static string Insert_Processing(string AndonNo, string MachineNumbe, string AndonStatus, string DisposGuser, string DisposTime, string DisposRemrak, string ClosingGuser, string ClosingTime, string ClosingRemrak)
        {
            string sql = @"insert into DM_CIM_ANDON_STATUS(ANDONNO,
                                                            EQPNO,
                                                            ANDONSTATUS,
                                                            DISPOSINGUSER,
                                                            DISPOSINGTIME,
                                                            DISPOSINGREMARK,
                                                            CLOSINGUSER,
                                                            CLOSINGTIME,
                                                            CLOSINGREMARK,
                                                            USERID,
                                                            UPDATETIME) values ('" + AndonNo + @"',
                                                            '" + MachineNumbe + @"',
                                                            '" + AndonStatus + @"',
                                                            '" + DisposGuser + @"',
                                                            '" + DisposTime + @"',
                                                            '" + DisposRemrak + @"',
                                                            '" + ClosingGuser + @"',
                                                            '" + ClosingTime + @"',
                                                            '" + ClosingRemrak + @"')";
            return sql;
        }
    }
}
