using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Collections;
using System.Drawing;

namespace SAWaferDrawingFromFile
{
    class WaferDrawingUtil
    {
        /// <summary>
        /// 芯粒信息的行数
        /// </summary>
        public static int RangeDataGridRows = 23;

        /// <summary>
        /// 在OPmode中分成30份颜色,比如WLD1
        /// </summary>
        public static Hashtable SplitColors = new Hashtable();

        public static void InitSplitColor()
        {
            SplitColors.Clear();

            //////设置第二列的颜色
            SplitColors.Add(0, Color.FromArgb(0, 0, 139));
            SplitColors.Add(1, Color.FromArgb(0, 128, 0));
            SplitColors.Add(2, Color.FromArgb(102, 205, 170));
            SplitColors.Add(3, Color.FromArgb(47, 7, 79));
            SplitColors.Add(4, Color.FromArgb(255, 0, 255));
            SplitColors.Add(5, Color.FromArgb(148, 0, 211));
            SplitColors.Add(6, Color.FromArgb(106, 90, 205));
            SplitColors.Add(7, Color.FromArgb(184, 134, 11));
            SplitColors.Add(8, Color.FromArgb(255, 255, 0));
            SplitColors.Add(9, Color.FromArgb(255, 228, 181));
            SplitColors.Add(10, Color.FromArgb(221, 160, 221));
            SplitColors.Add(11, Color.FromArgb(144, 238, 144));
            SplitColors.Add(12, Color.FromArgb(240, 230, 140));
            SplitColors.Add(13, Color.FromArgb(127, 255, 212));
            SplitColors.Add(14, Color.FromArgb(0, 139, 139));
            SplitColors.Add(15, Color.FromArgb(0, 0, 139));
            SplitColors.Add(16, Color.FromArgb(0, 128, 0));
            SplitColors.Add(17, Color.FromArgb(102, 205, 170));
            SplitColors.Add(18, Color.FromArgb(47, 7, 79));
            SplitColors.Add(19, Color.FromArgb(255, 0, 255));
            SplitColors.Add(20, Color.FromArgb(148, 0, 211));
            SplitColors.Add(21, Color.FromArgb(106, 90, 205));
            SplitColors.Add(22, Color.FromArgb(184, 134, 11));
            SplitColors.Add(23, Color.FromArgb(255, 255, 0));
            SplitColors.Add(24, Color.FromArgb(255, 228, 181));
            SplitColors.Add(25, Color.FromArgb(221, 160, 221));
            SplitColors.Add(26, Color.FromArgb(144, 238, 144));
            SplitColors.Add(27, Color.FromArgb(240, 230, 140));
            SplitColors.Add(28, Color.FromArgb(127, 255, 212));
            SplitColors.Add(29, Color.FromArgb(0, 139, 139));
        }

        /// <summary>
        /// 本地路径
        /// </summary>
        public static string OperationFilePath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "MappingFile";

        /// <summary>
        /// 获取到系统设置的信息
        /// </summary>
        /// <param name="lookupType"></param>
        /// <param name="waferType"></param>
        /// <param name="prePath"></param>
        /// <param name="typeDir"></param>
        /// <param name="fileFix"></param>
        /// <param name="secondPathIp"></param>
        /// <param name="fileTypeFix"></param>
        public static void GetPathInfoByType(string lookupType, string waferType, out string prePath, out string typeDir, out string fileFix, out string secondPathIp, out string fileTypeFix, out string bakPrePath)
        {
            prePath = typeDir = fileFix = secondPathIp = fileTypeFix = bakPrePath = string.Empty;
            DataTable ret = SMes.Core.ApplicationCache.GlobalCache.GetCurrentOrgLookUpValue(lookupType);
            DataRow[] rows = ret.Select("lookup_code = '" + waferType + "'");
            foreach (DataRow row in rows)  // 将查询的结果添加到dt中； 
            {
                prePath = SMes.Core.Utility.StrUtil.ValueToString(row["attribute1"]);
                typeDir = SMes.Core.Utility.StrUtil.ValueToString(row["attribute2"]);
                fileFix = SMes.Core.Utility.StrUtil.ValueToString(row["attribute3"]);
                secondPathIp = SMes.Core.Utility.StrUtil.ValueToString(row["attribute4"]);
                fileTypeFix = SMes.Core.Utility.StrUtil.ValueToString(row["attribute5"]);
                bakPrePath = SMes.Core.Utility.StrUtil.ValueToString(row["attribute6"]);
            }
        }

        /// <summary>
        /// 校验是否数字
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static bool isNumber(string str)
        {
            double x = 0;
            try
            {
                x = double.Parse(str);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
