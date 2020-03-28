using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SACHIPEQPMoveRpt.SQL
{
    class SqlData
    {
        public static string SerachData()
        {
            string sql = @"select EQPCODE,EQPIP,MOVETIME,MSG 
                           from SA_EQP_PROBER_FILE_MOVE_LOG t order by EQPCODE";
            return sql;
        }
    }
    }

