using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SADailyVerifySampling.Sql
{
    class DailyVerifySamplingSql
    {
        public static string GetDataSpr(string sqlWhere)
        {
            //查询这个品名放入query的数据  ,LOP3,WLP3,WLD3,HW3
            string sql = string.Format(@"SELECT SPRODUCT,X,Y,VF1,VF2,VF3,VF4,VZ1,IR,LOP1,LOP2,WLP1,WLP2,WLD1,WLD2,ST1,HW1,HW2,PURITY1,PURITY2,INT1,SGROUP,COUNTSN AS SN,VF5,VF6,LOP3,WLP3,WLD3,HW3
                                         FROM  DATA_VERIFY_SPEC_COMPARISON
                                         WHERE SPEC_SID = (SELECT MAX(SPEC_SID) 
                                                           FROM DATA_VERIFY_SPEC_COMPARISON 
                                                           WHERE SPRODUCT='{0}') ORDER BY SCOUNT, TO_NUMBER(COUNTSN), TO_NUMBER(SGROUP)",sqlWhere);
            return sql;
        }

        public static string GetDataSpr1(string sqlWhere)
        {
            //查询Query后的普通的两道卡控
            string sql = string.Format(@"SELECT * 
                                         FROM  DATA_VERIFY_SPEC_COMPARISON
                                         WHERE SUBSTR(SPEC_SID,1,17) = (SELECT SUBSTR(MAX(SPEC_SID),1,17) 
                                                           FROM DATA_VERIFY_SPEC_COMPARISON 
                                                           WHERE SPRODUCT='{0}') ORDER BY SCOUNT, TO_NUMBER(COUNTSN), TO_NUMBER(SGROUP)",sqlWhere);
            return sql;
        }

        public static string GetDataSpr2(string sqlWhere)
        {
            //查询query后的全部数据
            string sql = string.Format(@"SELECT * 
                                         FROM  DATA_VERIFY_SPEC_COMPARISON
                                         WHERE SPEC_SID = (SELECT MAX(SPEC_SID) 
                                                           FROM DATA_VERIFY_SPEC_COMPARISON 
                                                           WHERE SPRODUCT='{0}') ORDER BY SCOUNT, TO_NUMBER(COUNTSN), TO_NUMBER(SGROUP)", sqlWhere);
            return sql;
        }

        public static string GetDataCon(string sproduct,string vgroup )
        {
            //查询是否有两道卡控
            string sql = string.Format(@"SELECT MAX(SPEC_SID) AS ASID, SPEC_VALUE 
                                         FROM DATA_VERIFY_SPEC_COMPARISON
                                         WHERE SUBSTR(SPEC_SID,1,17) IN 
                                              (SELECT SUBSTR(MAX(SPEC_SID),1,17) FROM DATA_VERIFY_SPEC_COMPARISON                                 
                                               WHERE SPRODUCT = '{0}' AND VERIFY_GROUP = '{1}' AND STYPE = 'VERIFY_SPEC') AND TRIM(SPEC_VALUE) IS NOT NULL GROUP BY SPEC_VALUE ",sproduct,vgroup );
            return sql;    
        }

        public static string GetDataSpr3(string sqlWhere1,string sqlWhere2)
        {
            //加了SID后的卡控
            string sql = string.Format(@"SELECT *
                                         FROM  DATA_VERIFY_SPEC_COMPARISON
                                         WHERE SUBSTR(SPEC_SID,1,17) = (SELECT SUBSTR(MAX(SPEC_SID),1,17)  
                                                           FROM DATA_VERIFY_SPEC_COMPARISON 
                                                           WHERE SPRODUCT='{0}' AND VERIFY_GROUP = '{1}') ORDER BY SCOUNT, TO_NUMBER(COUNTSN), TO_NUMBER(SGROUP)", sqlWhere1, sqlWhere2);
            return sql;
        }

        public static string GetDataSpr33(string sqlWhere1, string sqlWhere2)
        {
            //加了SID后的卡控
            string sql = string.Format(@"SELECT *
                                         FROM  DATA_VERIFY_SPEC_COMPARISON
                                         WHERE SUBSTR(SPEC_SID,18,1) = '0' and SUBSTR(SPEC_SID,1,17) = (SELECT SUBSTR(MAX(SPEC_SID),1,17)  
                                                           FROM DATA_VERIFY_SPEC_COMPARISON 
                                                           WHERE SPRODUCT='{0}' AND VERIFY_GROUP = '{1}') ORDER BY SCOUNT, TO_NUMBER(COUNTSN), TO_NUMBER(SGROUP)", sqlWhere1, sqlWhere2);
            return sql;
        }

        public static string GetDataSpr4(string sqlWhere1, string sqlWhere2)
        {
            //查询这一片的放入query的数据   --,LOP3,WLP3,WLD3,HW3 
            string sql = string.Format(@"SELECT SPRODUCT AS Product,X,Y,VF1,VF2,VF3,VF4,VZ1,IR,LOP1,LOP2,WLP1,WLP2,WLD1,WLD2,ST1,HW1,HW2,PURITY1,PURITY2,INT1,SGROUP,COUNTSN AS SN,VF5,VF6,LOP3,WLP3,WLD3,HW3
                                         FROM  DATA_VERIFY_SPEC_COMPARISON
                                        WHERE SPEC_SID = (SELECT MAX(SPEC_SID) 
                                                           FROM DATA_VERIFY_SPEC_COMPARISON 
                                                           WHERE SPRODUCT='{0}' AND VERIFY_GROUP = '{1}') ORDER BY SCOUNT, TO_NUMBER(COUNTSN), TO_NUMBER(SGROUP)", sqlWhere1, sqlWhere2);
            return sql;
        }

        public static string GetDataRaw(string sqlWhere)
        {
            //查询已经对比好的次数
            string sql = string.Format(@"SELECT *
                                         FROM DATA_VERIFY_RAW_WAFERCOUNT
                                         WHERE WAFERID = '{0}'", sqlWhere);
            return sql;
        
        }

        public static string GetDatamppv( )
        {
            //查询品名集合
            string sql = string.Format(@"SELECT * FROM MES_PRC_PROD_VER
                                         WHERE REVSTATE = 'ACTIVE'
                                         ORDER BY PRODUCT");
            return sql; 

        }

        public static string InsertData_spec1(string rowsname1,string specsid, string values1)
        {
            string sql =string.Format(@"INSERT INTO DATA_VERIFY_SPEC_COMPARISON (SPEC_SID,SPRODUCT,STYPE,COUNTSN,VERIFY_GROUP{0}) VALUES('{1}'{2})", rowsname1, specsid, values1);

            return sql;
        }

        public static string InsertData_count(string csid,string waferid,string lasttime,string rawsid)
        {
            string sql = string.Format(@"INSERT  INTO DATA_VERIFY_RAW_WAFERCOUNT
                                         VALUES('{0}','{1}',{2},'1','{3}')",csid,waferid,lasttime,rawsid);

            return sql;
        }


        public static string InsertData_RAWCOMPARISON(string rname,string rvalue,string rrvalue)
        {
            string sql = string.Format(@"INSERT INTO DATA_VERIFY_RAW_COMPARISON (RAW_SID,SPEC_SID,SPRODUCT,SNID,GANTESTNO,LODER_TIME,X,Y,ERPDEVICE,SGROUP,WAFERID,PARTITIONMON{0})
                                         VALUES({1}{2})",rname,rvalue,rrvalue);

            return sql;
        }
                                            

    }
}
