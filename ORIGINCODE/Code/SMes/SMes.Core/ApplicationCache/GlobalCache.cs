using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SMes.Core.ApplicationCache
{
    public static class GlobalCache
    {
        private static SMes.Core.Interface.IApplication _iapplication = null;

        public static SMes.Core.Interface.IApplication Application
        {
            get
            {
                return _iapplication;
            }
            set
            {
                _iapplication = value;
            }
        }

        private static DataTable _vLookUpTable = null;

        public static DataTable VLookUpTable
        {
            set 
            { 
                GlobalCache._vLookUpTable = value;
            }
        }

        /// <summary>
        /// slv.lookup_type_code,
        /// slv.lookup_type_name,
        ///                           slv.lookup_code,
        ///                           slv.lookup_meanning,
        ///                           slv.organization_id,
        ///                           slv.organization_code,
        ///                           slv.organization_name,
        ///                           slv.order_by,
        ///                           slv.attribute_category,
        ///                          slv.attribute1,
        ///                           slv.attribute2,
        ///                           slv.attribute3,
        ///                           slv.attribute4,
        ///                           slv.attribute5,
        ///                           slv.attribute6,
        ///                           slv.attribute7,
        ///                           slv.attribute8,
        ///                           slv.attribute9,
        ///                           slv.attribute10,
        ///                           slv.attribute11,
        ///                           slv.attribute12,
        ///                           slv.attribute13,
        ///                           slv.attribute14,
        ///                           slv.attribute15
        /// </summary>
        /// <param name="lookupCode"></param>
        /// <returns></returns>
        public static DataTable GetCurrentOrgLookUpValue(string lookupCode)
        {
            DataTable newdt = new DataTable();
            if (GlobalCache._vLookUpTable != null && GlobalCache._vLookUpTable.Rows.Count > 0)
            {
                newdt = GlobalCache._vLookUpTable.Clone(); // 克隆dt 的结构，包括所有 dt 架构和约束,并无数据； 
                DataRow[] rows = GlobalCache._vLookUpTable.Select("organization_id = '" + Config.ApplicationConfig.GetProperty("CURRENT_ORG_ID") + "' AND lookup_type_code = '" + lookupCode + "'");
                foreach (DataRow row in rows)  // 将查询的结果添加到dt中； 
                {
                    newdt.Rows.Add(row.ItemArray);
                }
            }
            return newdt;
        }

    }
}
