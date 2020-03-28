using EquipmentRecord.AppObj;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EquipmentRecord
{
    class EqpLogic
    {
        /// <summary>
        /// 获得用户的权限
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static UserRight GetUserRightById(string userId)
        {
            UserRight ur = new UserRight();
            
            string sql = Sql.EqpRecordSql.GetRightQuerySql(userId);

            DataTable dt = SMes.Core.Service.DataBaseAccess.GetQueryData(sql);

            if (dt.Rows.Count > 0)
            {
                ur.UserId = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][1]);
                ur.UserName = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][2]);
                ur.Factory = SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][4]);
                if ("Y".CompareTo(SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][3])) == 0)
                {
                    ur.RightCtrlFlag = true;
                }
                if ("Y".CompareTo(SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][5])) == 0)
                {
                    ur.AddFlag = true;
                }
                if ("Y".CompareTo(SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][6])) == 0)
                {
                    ur.UpdateFlag = true;
                }
                if ("Y".CompareTo(SMes.Core.Utility.StrUtil.ValueToString(dt.Rows[0][7])) == 0)
                {
                    ur.DeleteFlag = true;
                }
            }

            return ur;

        }
    }
}
