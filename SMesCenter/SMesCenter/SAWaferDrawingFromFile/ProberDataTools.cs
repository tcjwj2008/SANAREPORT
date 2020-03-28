using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAWaferDrawingFromFile.AppObjs;
using System.IO;
using System.Collections;
using System.Drawing;

namespace SAWaferDrawingFromFile
{
    public class ProberDataTools
    {
        public static Color ColorIrFail = System.Drawing.Color.Gray;
        public static Color ColorHBM_2000Fail = System.Drawing.Color.Red;
        public static Color ColorHBM2000Fail = System.Drawing.Color.FromArgb(255, 128, 64);
        public static Color ColorHBM_4000Fail = System.Drawing.Color.Yellow;
        public static Color ColorHBM4000Fail = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(179)))), ((int)(((byte)(9)))));
        public static Color ColorHBM_6000Fail = System.Drawing.Color.Aqua;
        public static Color ColorHBM6000Fail = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(217)))), ((int)(((byte)(0)))));
        public static Color ColorHBM_8000Fail = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
        public static Color ColorHBM8000Fail = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
        public static Color ColorMM300Fail = System.Drawing.Color.Red;
        public static Color ColorMM_300Fail = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
        public static Color ColorMM_350Fail = System.Drawing.Color.Yellow;
        public static Color ColorMM_400Fail = System.Drawing.Color.Lime;
        public static Color ColorOkDies = System.Drawing.Color.Blue;

        public static int xMidRec = 0;
        public static int yMidRec = 0;

        private MappingType _drawingMapType = MappingType.MAP;
        /// <summary>
        /// 当前载入文档的画图模式
        /// </summary>
        public MappingType DrawingMapType
        {
            get { return _drawingMapType; }
            set { _drawingMapType = value; }
        }

        ////////一些界面光电特性的卡控
        private bool _irLimitFlag = false;/////IR<1
        private bool _lop1LimitFlag = false;  ////LOP1>0.5
        private bool _vf1LimitFlag = false;   ////VF1<4

        public bool Lop1LimitFlag
        {
            get { return _lop1LimitFlag; }
            set { _lop1LimitFlag = value; }
        }
        public bool IrLimitFlag
        {
            get { return _irLimitFlag; }
            set { _irLimitFlag = value; }
        }
        public bool Vf1LimitFlag
        {
            get { return _vf1LimitFlag; }
            set { _vf1LimitFlag = value; }
        }






        /// <summary>
        /// 芯粒的间隔
        /// </summary>
        public static int SplitWidth = 1;

        public int CurSplitWidth = 1;

        private string _waferId = string.Empty;

        public string WaferId
        {
            get { return _waferId; }
            set { _waferId = value; }
        }
        private string _waferPath = string.Empty;

        public string WaferPath
        {
            get { return _waferPath; }
            set { _waferPath = value; }
        }

        private List<ProberData> _proberDataList = new List<ProberData>();

        public List<ProberData> ProberDataList
        {
            get { return _proberDataList; }
            set { _proberDataList = value; }
        }

        private Hashtable _esdHeader = new Hashtable();

        private Hashtable _header = new Hashtable();
        private int _testSeqIndex = 0;
        private int _binIndex = 0;
        private int _posXIndex = 0;
        private int _posYIndex = 0;
        private int _tapeWaferIdIndex = -1; //////方片文档有
        private List<string> _tapeWaferInfo = new List<string>();
        /// <summary>
        /// 方片match使用的圆片信息，格式：圆片,坐标1,坐标2
        /// </summary>
        public List<string> TapeWaferInfo
        {
            get { return _tapeWaferInfo; }
            set { _tapeWaferInfo = value; }
        }


        private int _zoomRate = 1;

        private int _curMapDataIndex = -1;

        private double _curMapValueAvg = 0;
        
        private double _curMapValueU = 0;
        
        private double _curMapValueL = 0;

        private int xFactory = 1;
        private int yFactory = 1;

        /// <summary>
        /// 快测片的因素
        /// </summary>
        public int XFactory
        {
            get { return xFactory; }
            set { xFactory = value; }
        }
        /// <summary>
        /// 快测片的因素
        /// </summary>
        public int YFactory
        {
            get { return yFactory; }
            set { yFactory = value; }
        }

        /// <summary>
        /// 缩放倍数
        /// </summary>
        public int ZoomRate
        {
            get { return _zoomRate; }
            set { _zoomRate = value; }
        }
        /// <summary>
        /// 当前光电特性的值index
        /// </summary>
        public int CurMapDataIndex
        {
            get { return _curMapDataIndex; }
            set { _curMapDataIndex = value; }
        }
        /// <summary>
        /// 光电特性的均值
        /// </summary>
        public double CurMapValueAvg
        {
            get { return _curMapValueAvg; }
            set { _curMapValueAvg = value; }
        }
        /// <summary>
        /// 上限值
        /// </summary>
        public double CurMapValueU
        {
            get { return _curMapValueU; }
            set { _curMapValueU = value; }
        }
        /// <summary>
        /// 下限值
        /// </summary>
        public double CurMapValueL
        {
            get { return _curMapValueL; }
            set { _curMapValueL = value; }
        }

        

        /// <summary>
        /// 存入，如果为空，建议不要存
        /// </summary>
        /// <param name="proKey"></param>
        /// <param name="value"></param>
        private void SetHeaderPosValue(string colName, int index)
        {
            if (!_header.Contains(colName))
            {
                _header.Add(colName, index);
            }
            else
            {
                _header[colName] = index;
            }
        }

        
        private int GetHeaderPosValue(string key)
        {
            int val = -1;

            if (_header.Contains(key))
            {
                val = SMes.Core.Utility.StrUtil.ValueToInt(_header[key]);
            }

            return val;
        }
        public int GetDataIndexByKey(string key)
        {
            int val = -1;
            int i = 0;
            foreach (string item in _header.Keys)
            {
                if (key.CompareTo(item) == 0)
                {
                    val = i;
                    break;
                }
                i++;
            }

            return val;
        }

        public int GetDataIndexByValue(int value)
        {
            int val = -1;
            int i = 0;
            foreach (string item in _header.Keys)
            {
                if (SMes.Core.Utility.StrUtil.ValueToInt(_header[item]) == value)
                {
                    val = i;
                    break;
                }
                i++;
            }

            return val;
        }

        /// <summary>
        /// 方片文档读取
        /// </summary>
        /// <param name="path"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool ReadAOIFile(string path, out string msg)
        {
            bool ret = true;
            msg = "成功";
            bool dataRowStart = false;
            string[] temp;
            _header.Clear();
            _esdHeader.Clear();
            _proberDataList.Clear();
            _tapeWaferInfo.Clear();
            //string[] Lines = File.ReadAllLines(path);

            try
            {
                StreamReader sr = new StreamReader(path, Encoding.Default);

                try
                {
                    string ln;
                    while ((ln = sr.ReadLine()) != null)
                    {
                        if (dataRowStart)
                        {
                            temp = ln.Split(',');
                            ProberData pd = new ProberData();
                            if (_posXIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_posXIndex]))
                                {
                                    pd.PosX = 0;
                                }
                                else
                                {
                                    pd.PosX = Int32.Parse(temp[_posXIndex]);
                                }
                            }
                            if (_posYIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_posYIndex]))
                                {
                                    pd.PosY = 0;
                                }
                                else
                                {
                                    pd.PosY = Int32.Parse(temp[_posYIndex]);
                                }
                            }
                            if (_binIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_binIndex]))
                                {
                                    pd.Bin = 0;
                                }
                                else
                                {
                                    pd.Bin = Int32.Parse(temp[_binIndex]);
                                }
                            }

                            pd.Data = new double[_header.Count];
                            int i = 0;
                            foreach (string item in _header.Keys)
                            {
                                if ((int)_header[item] < temp.Length)
                                {
                                    if (string.IsNullOrEmpty(temp[(int)_header[item]]))
                                    {
                                        pd.Data[i] = 0;
                                    }
                                    else
                                    {
                                        pd.Data[i] = double.Parse(temp[(int)_header[item]]);
                                    }
                                }

                                i++;
                            }
                            _proberDataList.Add(pd);
                        }

                        if (ln.StartsWith("map data"))
                        {
                            dataRowStart = true;
                            //////设置键值
                            string[] header = ln.Split(',');
                            for (int i = 0; i < header.Length; i++)
                            {

                                _binIndex = 2;
                                _posXIndex = 0;
                                _posYIndex = 1;
                                
                                SetHeaderPosValue("VF1", 5);
                                SetHeaderPosValue("IF", 7);
                                SetHeaderPosValue("LOP1", 9);
                                SetHeaderPosValue("WLD1", 10);
                                SetHeaderPosValue("WLP1", 11);
                            }
                        }

                    }

                }
                catch (Exception e)
                {
                    msg = e.Message;
                    ret = false;
                }
                finally
                {
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                ret = false;
            }

            return ret;
        }

        /// <summary>
        /// 方片文档读取
        /// </summary>
        /// <param name="path"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool ReadPapeFile(string path, out string msg)
        {
            bool ret = true;
            msg = "成功";
            string[] temp;
            _header.Clear();
            _esdHeader.Clear();
            _proberDataList.Clear();
            _tapeWaferInfo.Clear();

            //string[] Lines = File.ReadAllLines(path);

            try
            {
                StreamReader sr = new StreamReader(path, Encoding.Default);

                int rowIndex = 0;
                try
                {
                    string ln;
                    while ((ln = sr.ReadLine()) != null)
                    {
                        rowIndex++;
                        if (rowIndex >= 3)
                        {
                            temp = ln.Split(',');
                            ProberData pd = new ProberData();
                            if (_posXIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_posXIndex]))
                                {
                                    pd.PosX = 0;
                                }
                                else
                                {
                                    pd.PosX = Int32.Parse(temp[_posXIndex]);
                                }
                            }
                            if (_posYIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_posYIndex]))
                                {
                                    pd.PosY = 0;
                                }
                                else
                                {
                                    pd.PosY = Int32.Parse(temp[_posYIndex]);
                                }
                            }
                            if (_tapeWaferIdIndex < temp.Length)
                            {
                                pd.TapeWaferId = temp[_tapeWaferIdIndex];
                                if (!string.IsNullOrEmpty(pd.TapeWaferId) && !_tapeWaferInfo.Contains(pd.TapeWaferId))
                                {
                                    _tapeWaferInfo.Add(pd.TapeWaferId);
                                }
                            }
                            if (_binIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_binIndex]))
                                {
                                    pd.Bin = 0;
                                }
                                else
                                {
                                    pd.Bin = Int32.Parse(temp[_binIndex]);
                                }
                            }

                            pd.Data = new double[_header.Count];
                            int i = 0;
                            foreach (string item in _header.Keys)
                            {
                                if ((int)_header[item] < temp.Length)
                                {
                                    if (string.IsNullOrEmpty(temp[(int)_header[item]]))
                                    {
                                        pd.Data[i] = 0;
                                    }
                                    else
                                    {
                                        pd.Data[i] = double.Parse(temp[(int)_header[item]]);
                                    }
                                }

                                i++;
                            }
                            _proberDataList.Add(pd);
                        }

                        if (rowIndex == 1)
                        {
                            //////设置键值,第一列不要，最后一列不要
                            string[] header = ln.Split(',');
                            for (int i = 0; i < header.Length - 1; i++)
                            {
                                if ("WAFERID".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _tapeWaferIdIndex = i;
                                }
                                else if ("GRADE".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _binIndex = i;
                                }
                                else if ("BIN X".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _posXIndex = i;
                                }
                                else if ("BIN Y".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _posYIndex = i;
                                }
                                else
                                {
                                    SetHeaderPosValue(header[i].ToUpper(), i);
                                }

                            }
                        }

                    }

                }
                catch (Exception e)
                {
                    msg = e.Message;
                    ret = false;
                }
                finally
                {
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                ret = false;
            }

            return ret;
        }

        private bool calTapeWaferInfo()
        {
            bool ret = true;


            for (int i = 0; i < _tapeWaferInfo.Count; i++)
            {
                _tapeWaferInfo[i] = _tapeWaferInfo[i] + "," + Int32.MaxValue + "," + Int32.MinValue;
            }

            for (int j = 0; j < _proberDataList.Count; j++)
            {
                for (int i = 0; i < _tapeWaferInfo.Count; i++)
                {
                    string[] split = _tapeWaferInfo[i].Split(',');
                    if (_proberDataList[j].TapeWaferId.CompareTo(split[0]) == 0)
                    {
                        if (_proberDataList[j].PosY < Int32.Parse(split[1]))
                        {
                            split[1] = _proberDataList[j].PosY.ToString();
                        }
                        if (_proberDataList[j].PosY > Int32.Parse(split[2]))
                        {
                            split[2] = _proberDataList[j].PosY.ToString();
                        }
                        _tapeWaferInfo[i] = split[0] + "," + split[1] + "," + split[2];
                    }
                }
            }

            return ret;
        }


        /// <summary>
        /// 正常片子，抽测，全测，P8
        /// </summary>
        /// <param name="path"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        private bool ReadNormalProberFile(string path, out string msg)
        {
            bool ret = true;
            msg = "成功";
            bool dataRowStart = false;
            string[] temp;
            _header.Clear();
            _esdHeader.Clear();
            _proberDataList.Clear();
            _tapeWaferInfo.Clear();

            //string[] Lines = File.ReadAllLines(path);

            try
            {
                StreamReader sr = new StreamReader(path, Encoding.Default);

                try
                {
                    string ln;
                    while ((ln = sr.ReadLine()) != null)
                    {
                        if (dataRowStart)
                        {
                            temp = ln.Split(',');
                            ProberData pd = new ProberData();
                            if (_posXIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_posXIndex]))
                                {
                                    pd.PosX = 0;
                                }
                                else
                                {
                                    pd.PosX = Int32.Parse(temp[_posXIndex]);
                                }
                            }
                            if (_posYIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_posYIndex]))
                                {
                                    pd.PosY = 0;
                                }
                                else
                                {
                                    pd.PosY = Int32.Parse(temp[_posYIndex]);
                                }
                            }
                            if (_testSeqIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_testSeqIndex]))
                                {
                                    pd.TestSeq = 0;
                                }
                                else
                                {
                                    pd.TestSeq = Int32.Parse(temp[_testSeqIndex]);
                                }
                            }
                            if (_binIndex < temp.Length)
                            {
                                if (string.IsNullOrEmpty(temp[_binIndex]))
                                {
                                    pd.Bin = 0;
                                }
                                else
                                {
                                    pd.Bin = Int32.Parse(temp[_binIndex]);
                                }
                            }

                            pd.Data = new double[_header.Count];
                            int i = 0;
                            foreach (string item in _header.Keys)
                            {
                                if ((int)_header[item] < temp.Length)
                                {
                                    if (string.IsNullOrEmpty(temp[(int)_header[item]]))
                                    {
                                        pd.Data[i] = 0;
                                    }
                                    else
                                    {
                                        pd.Data[i] = double.Parse(temp[(int)_header[item]]);
                                    }
                                }

                                i++;
                            }
                            //////做一些卡控，IRValue < 1，LOPValue > 0.5,VF1<4，才要进行添加
                            bool isIn = true;
                            int irIndex = GetDataIndexByKey("IR");
                            int lop1Index = GetDataIndexByKey("LOP1");
                            int vf1Index = GetDataIndexByKey("VF1");
                            if (irIndex >= 0 && _irLimitFlag && pd.Data[irIndex] >= 1)
                            {
                                isIn = false;
                            }
                            if (lop1Index >= 0 && _lop1LimitFlag && (pd.Data[lop1Index] > 0 && pd.Data[lop1Index] <= 0.5))
                            {
                                isIn = false;
                            }
                            if (vf1Index >= 0 && _vf1LimitFlag && pd.Data[vf1Index] >= 4)
                            {
                                isIn = false;
                            }
                            if (isIn)
                            {
                                _proberDataList.Add(pd);
                            }
                        }

                        if (ln.StartsWith("TEST,"))
                        {
                            dataRowStart = true;
                            //////设置键值
                            string[] header = ln.Split(',');
                            for (int i = 0; i < header.Length; i++)
                            {
                                if ("TEST".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _testSeqIndex = i;
                                }
                                else if ("BIN".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _binIndex = i;
                                }
                                else if ("POSX".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _posXIndex = i;
                                }
                                else if ("POSY".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _posYIndex = i;
                                }
                                else
                                {
                                    SetHeaderPosValue(header[i].ToUpper(), i);
                                }

                            }
                        }

                    }

                }
                catch (Exception e)
                {
                    msg = e.Message;
                    ret = false;
                }
                finally
                {
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                ret = false;
            }

            return ret;
        }

        /// <summary>
        /// 载入正常的片子，抽测，全测
        /// </summary>
        /// <param name="path"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool LoadProberFromFile(string path,string waferType,out string msg)
        {
            bool ret = true;
            msg = "成功";
            if (!File.Exists(path))
            {
                msg = "找不到档案!";
                ret = false;
                return ret;
            }
            _drawingMapType = MappingType.MAP;

            if ("TAPE".CompareTo(waferType) == 0)
            {
                /////读取方片文档
                ret = ReadPapeFile(path, out msg);
            }
            else if ("AOI".CompareTo(waferType) == 0)
            {
                ret = ReadAOIFile(path, out msg);
            }
            else if ("TAPE MATCH".CompareTo(waferType) == 0)
            {
                ret = ReadPapeFile(path, out msg);
                if (!ret)
                {
                    return ret;
                }
                //////方片与圆片关系有一些数据要处理
                ret = calTapeWaferInfo();
            }
            else
            {
                ret = ReadNormalProberFile(path, out msg);
            }

            return ret;
        }


        /// <summary>
        /// 存入ESD的头
        /// </summary>
        /// <param name="proKey"></param>
        /// <param name="value"></param>
        private void SetESDHeaderPosValue(string colName, int index)
        {
            string key = colName + "@" + index;
            if (!_esdHeader.Contains(key))
            {
                _esdHeader.Add(key, index);
            }
            else
            {
                _esdHeader[key] = index;
            }
        }
        /// <summary>
        /// 更新ESD重要标记的键与值
        /// </summary>
        /// <param name="colName"></param>
        /// <param name="index"></param>
        /// <param name="newColNmae"></param>
        private void UpdateESDHeaderPos(string colName, int index, string newColNmae)
        {
            _esdHeader.Remove(colName);
            _esdHeader.Add(newColNmae, index);
        }

        /// <summary>
        /// 载入ESD
        /// </summary>
        /// <param name="path"></param>
        /// <param name="msg"></param>
        /// <returns></returns>
        public bool LoadESDProberFromFile(string path, out string msg)
        {
            bool ret = true;
            msg = "成功";
            if (!File.Exists(path))
            {
                msg = "找不到档案!";
                ret = false;
                return ret;
            }
            _drawingMapType = MappingType.ESD;
            int startDataRow = 999999;
            int currentRow = 0;
            string[] temp;
            _header.Clear();
            _proberDataList.Clear();
            _tapeWaferInfo.Clear();
            _esdHeader.Clear();

            try
            {
                StreamReader sr = new StreamReader(path, Encoding.Default);
                try
                {
                    string ln;
                    while ((ln = sr.ReadLine()) != null)
                    {
                        currentRow++;

                        if (currentRow == startDataRow + 1)
                        {
                            string[] header = ln.Split(',');

                            int i = 0;
                            foreach (string item in _header.Keys)
                            {
                                string type = header[(int)_header[item]];

                                if ("HBM".CompareTo(type) == 0 || "MM".CompareTo(type) == 0)
                                {
                                    SetESDHeaderPosValue(type, (int)_header[item]);
                                }
                            }
                        }
                        
                        if (currentRow > startDataRow + 1)
                        {
                            temp = ln.Split(',');
                            if (temp.Length > 1)
                            {
                                ArrayList akeys = new ArrayList(_esdHeader.Keys);
                                for (int p = 0; p < akeys.Count; p++)
                                {
                                    string item = SMes.Core.Utility.StrUtil.ValueToString(akeys[p]);
                                    if (item.Contains('@') && !string.IsNullOrEmpty(temp[(int)_esdHeader[item]]))
                                    {
                                        UpdateESDHeaderPos(item, (int)_esdHeader[item], item.Split('@')[0] + " " + temp[(int)_esdHeader[item]]);
                                    }
                                }


                                ProberData pd = new ProberData();
                                if (_posXIndex < temp.Length)
                                {
                                    if (string.IsNullOrEmpty(temp[_posXIndex]))
                                    {
                                        pd.PosX = 0;
                                    }
                                    else
                                    {
                                        pd.PosX = Int32.Parse(temp[_posXIndex]);
                                    }
                                }
                                if (_posYIndex < temp.Length)
                                {
                                    if (string.IsNullOrEmpty(temp[_posYIndex]))
                                    {
                                        pd.PosY = 0;
                                    }
                                    else
                                    {
                                        pd.PosY = Int32.Parse(temp[_posYIndex]);
                                    }
                                }
                                if (_testSeqIndex < temp.Length)
                                {
                                    if (string.IsNullOrEmpty(temp[_testSeqIndex]))
                                    {
                                        pd.TestSeq = 0;
                                    }
                                    else
                                    {
                                        pd.TestSeq = Int32.Parse(temp[_testSeqIndex]);
                                    }
                                }

                                pd.Data = new double[_header.Count];
                                int i = 0;
                                foreach (string item in _header.Keys)
                                {
                                    if ((int)_header[item] < temp.Length)
                                    {
                                        if (string.IsNullOrEmpty(temp[(int)_header[item]]))
                                        {
                                            pd.Data[i] = -99999;//////////////////为空，暂时用这个数字代替
                                        }
                                        else
                                        {
                                            pd.Data[i] = double.Parse(temp[(int)_header[item]]);
                                        }
                                    }
                                    i++;
                                }
                                _proberDataList.Add(pd);
                            }
                        }

                        if (ln.StartsWith("TEST,"))
                        {
                            startDataRow = currentRow;
                            //////设置键值
                            string[] header = ln.Split(',');
                            for (int i = 0; i < header.Length; i++)
                            {
                                if ("TEST".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _testSeqIndex = i;
                                }
                                else if ("X".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _posXIndex = i;
                                }
                                else if ("Y".CompareTo(header[i].ToUpper()) == 0)
                                {
                                    _posYIndex = i;
                                }
                                else
                                {
                                    if (header[i].ToUpper().CompareTo("IR0") == 0)
                                    {
                                        SetHeaderPosValue("IR", i);
                                    }
                                    else
                                    {
                                        SetHeaderPosValue(header[i].ToUpper(), i);
                                    }
                                }

                            }
                        }

                    }
                }
                catch (Exception e)
                {
                    msg = e.Message;
                    ret = false;
                }
                finally
                {
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                ret = false;
            }

            return ret;
        }

        /// <summary>
        /// 画出图片
        /// </summary>
        /// <param name="waferType"></param>
        /// <param name="mapProperty"></param>
        /// <param name="rangeType"></param>
        /// <param name="percent"></param>
        /// <param name="upValue"></param>
        /// <param name="downValue"></param>
        /// <param name="scaleRate"></param>
        /// <param name="isAutoScale"></param>
        /// <param name="autoScale"></param>
        /// <param name="bgWidth"></param>
        /// <param name="widthOnly">true 为宽度，false为宽度高度取最大值</param>
        /// <param name="curTapeWaferId"></param>
        /// <param name="showXMin"></param>
        /// <param name="showYMin"></param>
        /// <returns></returns>
        public Bitmap PrepareMappingBitmap(string waferType, string mapProperty, string rangeType, double percent, double upValue, double downValue, int scaleRate,bool isAutoScale,out int autoScale,int bgWidth,int bgHeigth,string curTapeWaferId,out int showXMin,out int showYMin,bool splitColorRange,bool opMode,string factoryCode,bool overLapCheck)
        {
            /////先计算均值，以及最大值，最小值
            _curMapDataIndex = GetDataIndexByKey(mapProperty);

            CurSplitWidth = SplitWidth;

            double allVal = 0;
            int xMin = int.MaxValue;
            int xMax = int.MinValue;
            int yMin = int.MaxValue;
            int yMax = int.MinValue;

            showXMin = Int32.MaxValue;
            showYMin = Int32.MaxValue;
            int showXMax = Int32.MinValue;
            int showYMax = Int32.MinValue;

            if ("AOI".CompareTo(waferType) == 0 || "TAPE MATCH".CompareTo(waferType) == 0)
            {
                /////AOI根据BIN画图，TAPE MATCH根据圆片数量比例画图
                for (int i = 0; i < this._proberDataList.Count; i++)
                {
                    /////计算x，y最大最小值
                    if (this._proberDataList[i].PosX < xMin)
                    {
                        xMin = this._proberDataList[i].PosX;
                    }
                    if (this._proberDataList[i].PosX > xMax)
                    {
                        xMax = this._proberDataList[i].PosX;
                    }
                    if (this._proberDataList[i].PosY < yMin)
                    {
                        yMin = this._proberDataList[i].PosY;
                    }
                    if (this._proberDataList[i].PosY > yMax)
                    {
                        yMax = this._proberDataList[i].PosY;
                    }
                }
            }
            else
            {
                if (_curMapDataIndex < 0)
                {
                    autoScale = 1;
                    return null;
                }
                for (int i = 0; i < this._proberDataList.Count; i++)
                {
                    allVal += this._proberDataList[i].Data[_curMapDataIndex];
                    /////计算x，y最大最小值
                    if (this._proberDataList[i].PosX < xMin)
                    {
                        xMin = this._proberDataList[i].PosX;
                    }
                    if (this._proberDataList[i].PosX > xMax)
                    {
                        xMax = this._proberDataList[i].PosX;
                    }
                    if (this._proberDataList[i].PosY < yMin)
                    {
                        yMin = this._proberDataList[i].PosY;
                    }
                    if (this._proberDataList[i].PosY > yMax)
                    {
                        yMax = this._proberDataList[i].PosY;
                    }
                }
                _curMapValueAvg = Math.Round(allVal / this.ProberDataList.Count, 4);

                if (rangeType.CompareTo("RATE") == 0)
                {
                    _curMapValueU = Math.Round(_curMapValueAvg * (1 + (percent / 100)), 4);
                    _curMapValueL = Math.Round(_curMapValueAvg * (1 - (percent / 100)), 4);
                }
                else
                {
                    _curMapValueU = upValue;
                    _curMapValueL = downValue;
                }
            }

            /////根据X轴，Y轴，放大比例，确定图片的长宽
            double fac1 = 1;
            double fac2 = 1;
            fac1 = (xMax - xMin + 1)/2 / xFactory + 1;
            //基于高度缩放
            fac2 = (yMax - yMin + 1)/2 / xFactory + 1;
            if (isAutoScale)
            {
                /////自动缩放比例
                double scaleX = ((bgWidth - 5) / 2 / fac1) - CurSplitWidth;
                double scaleY = ((bgHeigth - 5) / 2 / fac2) - CurSplitWidth;
                double curScale = Math.Min(scaleX, scaleY);
                if (curScale < 1)
                {
                    CurSplitWidth = 0;
                    autoScale = 1;
                }
                else
                {
                    autoScale = (int)curScale;
                }
                //autoScale = Math.Min(Math.Max((int)((bgWidth - 5) / 2 / fac1) - curSplitWidth, 1), Math.Max((int)((bgHeigth - 5) / 2 / fac2) - curSplitWidth, 1));
                _zoomRate = autoScale;
            }
            else
            {
                _zoomRate = scaleRate;
                autoScale = _zoomRate;
            }
            int zoomRateX = _zoomRate;
            int zoomRateY = _zoomRate;

            if (opMode&& autoScale == 1)
            {
                /////在OPmode下，进行拉伸
                if ("V".CompareTo(factoryCode) == 0 || "X".CompareTo(factoryCode) == 0)
                {
                    if (xMax - xMin > yMax - yMin)
                    {
                        zoomRateX = 1;
                        if (yMax - yMin == 0)
                        {
                            zoomRateY = 1;
                        }
                        else
                        {
                            double rate = (double)(xMax - xMin) / (double)(yMax - yMin);
                            zoomRateY = (int)Math.Round(rate);
                        }
                    }
                    else
                    {
                        zoomRateY = 1;
                        if (xMax - xMin == 0)
                        {
                            zoomRateX = 1;
                        }
                        else
                        {
                            double rate = (double)(yMax - yMin) / (double)(xMax - xMin);
                            zoomRateX = (int)Math.Round(rate);
                        }
                    }
                }
            }


            double fac = Math.Max(fac1, fac2);
            fac = Math.Max(Math.Abs(xMax), Math.Abs(xMin)) / xFactory + 1;
            double width = Math.Ceiling(fac) * (zoomRateX + CurSplitWidth) * 2 + 20;
            fac = Math.Max(Math.Abs(yMax), Math.Abs(yMin)) / yFactory + 1;
            double height = Math.Ceiling(fac) * (zoomRateY + CurSplitWidth) * 2 + 20;

            int xMid = (int)(width / 2);
            int yMid = (int)(height / 2);
            xMidRec = xMid;
            yMidRec = yMid;

            ////////画出图
            Bitmap bitMap = new Bitmap(xMid * 2, yMid * 2);

            Graphics g = Graphics.FromImage(bitMap);

            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, bitMap.Width, bitMap.Height));  //底色涂成黑色

            List<string> hasXY = new List<string>();
            for (int i = 0; i < _proberDataList.Count; i++)
            {
                Color color;
                if ("AOI".CompareTo(waferType) == 0)
                {
                    color = DetermindBINColor(_proberDataList[i].Bin);
                }
                else if ("TAPE MATCH".CompareTo(waferType) == 0)
                {
                    color = DetermindWaferSeqColor(_proberDataList[i].TapeWaferId, curTapeWaferId);
                }
                else if (splitColorRange)
                {
                    color = DetermindWaferSplitRangeColor(_proberDataList[i].Data[_curMapDataIndex], _curMapValueAvg);
                }
                else
                {
                    color = DetermindColor(10 * (_curMapValueU - _proberDataList[i].Data[_curMapDataIndex]) / (_curMapValueU - _curMapValueL));
                }
                
                Brush brush = new SolidBrush(color);

                //////实际显示坐标换算
                double txPos = _proberDataList[i].PosX / xFactory;
                double tyPos = _proberDataList[i].PosY / yFactory;

                int changeX = (int)Math.Round(txPos);
                int changeY = (int)Math.Round(tyPos);
                //////避免有重复的情况
                if (overLapCheck)
                {
                    if (xFactory != 1 || yFactory != 1)
                    {
                        string dir = "X";
                        if (Math.Abs(txPos - changeX) > Math.Abs(tyPos - changeY))
                        {
                            dir = "X";
                        }
                        else
                        {
                            dir = "Y";
                        }
                        CheckSamePos(dir, ref changeX, ref changeY, ref hasXY);

                    }
                }

                _proberDataList[i].ShowPosX = changeX * zoomRateX + CurSplitWidth * changeX;
                //_proberDataList[i].ShowPosX = Math.Round(_proberDataList[i].ShowPosX / xFactory);
                _proberDataList[i].ShowPosX += xMid;


                _proberDataList[i].ShowPosY = changeY * zoomRateY + CurSplitWidth * changeY;
                //_proberDataList[i].ShowPosY = Math.Round(_proberDataList[i].ShowPosY / yFactory);
                _proberDataList[i].ShowPosY = (_proberDataList[i].ShowPosY) + yMid;

                ////////界面显示的左上角坐标,并记录最大值
                if (_proberDataList[i].ShowPosY < showYMin)
                {
                    showYMin = _proberDataList[i].ShowPosY;
                }
                if (_proberDataList[i].ShowPosX < showXMin)
                {
                    showXMin = _proberDataList[i].ShowPosX;
                }
                if (_proberDataList[i].ShowPosY > showYMax)
                {
                    showYMax = _proberDataList[i].ShowPosY;
                }
                if (_proberDataList[i].ShowPosX > showXMax)
                {
                    showXMax = _proberDataList[i].ShowPosX;
                }

                g.FillRectangle(brush, _proberDataList[i].ShowPosX, _proberDataList[i].ShowPosY, zoomRateX, zoomRateY);
            }
            ///////切边到其他颜色
            Color bgCor = Color.FromArgb(169, 187, 210);
            Brush bgBrush = new SolidBrush(bgCor);
            g.FillRectangle(bgBrush, 0, 0, bitMap.Width, showYMin);
            g.FillRectangle(bgBrush, 0, 0, showXMin, bitMap.Height);
            g.FillRectangle(bgBrush, showXMax + zoomRateX, 0, bitMap.Width - (showXMax + zoomRateX), bitMap.Height);
            g.FillRectangle(bgBrush, 0, showYMax + zoomRateY, bitMap.Width, bitMap.Height - (showYMax + zoomRateY));

            return bitMap;
        }

        public Bitmap PrepareESDMappingBitmap(string esdType, string mapProperty, string rangeType, double percent, double upValue, double downValue, int scaleRate, bool isAutoScale, out int autoScale, int bgWidth, out int showXMin, out int showYMin)
        {
            /////先计算均值，以及最大值，最小值
            _curMapDataIndex = GetDataIndexByKey(mapProperty);
            double allVal = 0;
            int xMin = int.MaxValue;
            int xMax = int.MinValue;
            int yMin = int.MaxValue;
            int yMax = int.MinValue;

            showXMin = Int32.MaxValue;
            showYMin = Int32.MaxValue;
            int showXMax = Int32.MinValue;
            int showYMax = Int32.MinValue;

            for (int i = 0; i < this._proberDataList.Count; i++)
            {
                allVal += this._proberDataList[i].Data[_curMapDataIndex];
                /////计算x，y最大最小值
                if (this._proberDataList[i].PosX < xMin)
                {
                    xMin = this._proberDataList[i].PosX;
                }
                if (this._proberDataList[i].PosX > xMax)
                {
                    xMax = this._proberDataList[i].PosX;
                }
                if (this._proberDataList[i].PosY < yMin)
                {
                    yMin = this._proberDataList[i].PosY;
                }
                if (this._proberDataList[i].PosY > yMax)
                {
                    yMax = this._proberDataList[i].PosY;
                }
            }
            _curMapValueAvg = Math.Round(allVal / this.ProberDataList.Count, 4);

            if (rangeType.CompareTo("RATE") == 0)
            {
                _curMapValueU = Math.Round(_curMapValueAvg * (1 + (percent / 100)), 4);
                _curMapValueL = Math.Round(_curMapValueAvg * (1 - (percent / 100)), 4);
            }
            else
            {
                _curMapValueU = upValue;
                _curMapValueL = downValue;
            }

            /////根据X轴，Y轴，放大比例，确定图片的长宽
            double fac = Math.Max(Math.Abs(xMax), Math.Abs(xMin)) / xFactory + 1;
            if (isAutoScale)
            {
                /////自动缩放比例
                autoScale = Math.Max((int)((bgWidth - 5) / 2 / fac) - SplitWidth, 1);
                _zoomRate = autoScale;
            }
            else
            {
                _zoomRate = scaleRate;
                autoScale = _zoomRate;
            }

            //double fac = Math.Max(Math.Abs(xMax), Math.Abs(xMin)) / xFactory + 1;
            double width = Math.Ceiling(fac) * (_zoomRate + SplitWidth) * 2 + 20;
            fac = Math.Max(Math.Abs(yMax), Math.Abs(yMin)) / yFactory + 1;
            double height = Math.Ceiling(fac) * (_zoomRate + SplitWidth) * 2 + 20;

            int xMid = (int)(width / 2);
            int yMid = (int)(height / 2);

            ////////画出图
            Bitmap bitMap = new Bitmap(xMid * 2, yMid * 2);

            Graphics g = Graphics.FromImage(bitMap);

            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, bitMap.Width, bitMap.Height));  //底色涂成黑色

            List<string> hasXY = new List<string>();
            for (int i = 0; i < _proberDataList.Count; i++)
            {
                Color color = DetermindESDColor(_proberDataList[i].Data[_curMapDataIndex],esdType,_proberDataList[i].Data);
                Brush brush = new SolidBrush(color);

                //////实际显示坐标换算
                double txPos = _proberDataList[i].PosX / xFactory;
                double tyPos = _proberDataList[i].PosY / yFactory;

                int changeX = (int)Math.Round(txPos);
                int changeY = (int)Math.Round(tyPos);
                //////避免有重复的情况
                if (xFactory != 1 || yFactory != 1)
                {
                    string dir = "X";
                    if (Math.Abs(txPos - changeX) > Math.Abs(tyPos - changeY))
                    {
                        dir = "X";
                    }
                    else
                    {
                        dir = "Y";
                    }
                    CheckSamePos(dir, ref changeX, ref changeY, ref hasXY);

                }

                _proberDataList[i].ShowPosX = changeX * _zoomRate + SplitWidth * changeX;
                //_proberDataList[i].ShowPosX = Math.Round(_proberDataList[i].ShowPosX / xFactory);
                _proberDataList[i].ShowPosX += xMid;


                _proberDataList[i].ShowPosY = changeY * _zoomRate + SplitWidth * changeY;
                //_proberDataList[i].ShowPosY = Math.Round(_proberDataList[i].ShowPosY / yFactory);
                _proberDataList[i].ShowPosY = (_proberDataList[i].ShowPosY) + yMid;

                ////////界面显示的左上角坐标
                if (_proberDataList[i].ShowPosY < showYMin)
                {
                    showYMin = _proberDataList[i].ShowPosY;
                }
                if (_proberDataList[i].ShowPosX < showXMin)
                {
                    showXMin = _proberDataList[i].ShowPosX;
                }
                if (_proberDataList[i].ShowPosY > showYMax)
                {
                    showYMax = _proberDataList[i].ShowPosY;
                }
                if (_proberDataList[i].ShowPosX > showXMax)
                {
                    showXMax = _proberDataList[i].ShowPosX;
                }

                g.FillRectangle(brush, _proberDataList[i].ShowPosX, _proberDataList[i].ShowPosY, _zoomRate, _zoomRate);
            }
            ///////切边到其他颜色
            Color bgCor = Color.FromArgb(169, 187, 210);
            Brush bgBrush = new SolidBrush(bgCor);
            g.FillRectangle(bgBrush, 0, 0, bitMap.Width, showYMin);
            g.FillRectangle(bgBrush, 0, 0, showXMin, bitMap.Height);
            g.FillRectangle(bgBrush, showXMax + _zoomRate, 0, bitMap.Width - (showXMax + _zoomRate), bitMap.Height);
            g.FillRectangle(bgBrush, 0, showYMax + _zoomRate, bitMap.Width, bitMap.Height - (showYMax + _zoomRate));

            return bitMap;
        }

        /// <summary>
        /// 递归校验是否有重复，有重复x，y加减1
        /// </summary>
        /// <param name="dir"></param>
        /// <param name="changeX"></param>
        /// <param name="changeY"></param>
        /// <param name="hasXY"></param>
        private void CheckSamePos(string dir, ref int changeX, ref int changeY, ref List<string> hasXY)
        {
            ////如果不等于1，
            string changeXy = changeX.ToString() + "," + changeY.ToString();
            if (hasXY.Contains(changeXy))
            {
                /////确定是x变化
                if (dir == "X")
                {
                    if (changeX >= 0)
                    {
                        changeX++;
                    }
                    else
                    {
                        changeX--;
                    }
                }
                else
                {
                    if (changeY >= 0)
                    {
                        changeY++;
                    }
                    else
                    {
                        changeY--;
                    }
                }
                CheckSamePos(dir, ref changeX, ref changeY, ref hasXY);
            }
            else
            {
                hasXY.Add(changeXy);
            }
        }

        /// <summary>
        /// 根据值，得到颜色
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        private System.Drawing.Color DetermindWaferSplitRangeColor(double curVal, double avgVal)
        {
            int curV = (int)curVal;
            int avgV = (int)avgVal;

            Color cl = Color.Blue;

            int min = avgV - 14;
            int max = avgV + 15;

            if (curV < min)
            {
                cl = Color.Blue;
            }
            else if (curV > max)
            {
                cl = Color.Red;
            }
            else
            {
                cl = (Color)WaferDrawingUtil.SplitColors[curV - min];
            }

            return cl;
        }

        /// <summary>
        /// 根据值，得到颜色
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        private System.Drawing.Color DetermindWaferSeqColor(string waferId,string curWaferId)
        {
            Color cor = Color.Black;
            int idr = 0;

            if (!string.IsNullOrEmpty(curWaferId))
            {
                if (waferId.CompareTo(curWaferId) == 0)
                {
                    return Color.Green;
                }
                else
                {
                    return Color.White;
                }
            }


            for (int i = 0; i < this._tapeWaferInfo.Count; i++)
            {
                if (_tapeWaferInfo[i].StartsWith(waferId))
                {
                    idr = i;
                    break;
                }
            }
            double rate = (double)idr / (double)this._tapeWaferInfo.Count;
            cor = DetermindColor(10 * rate);
            ///旧Delphi的方式，感觉不太对
            //switch (idr)
            //{
            //    case 0:
            //        cor = Color.Red;
            //        break;
            //    case 1:
            //        cor = Color.Yellow;
            //        break;
            //    case 2:
            //        cor = Color.Green;
            //        break;
            //    case 3:
            //        cor = Color.Fuchsia;
            //        break;
            //    case 4:
            //        cor = Color.Lime;
            //        break;
            //    case 5:
            //        cor = Color.SkyBlue;
            //        break;
            //    case 6:
            //        cor = Color.Aqua;
            //        break;
            //    case 7:
            //        cor = Color.FromArgb(51, 153, 255);
            //        break;
            //    case 8:
            //        cor = Color.Olive;
            //        break;
            //    case 9:
            //        cor = Color.FromArgb(255, 128, 0);
            //        break;
            //    case 10:
            //        cor = Color.FromArgb(0, 171, 171);
            //        break;
            //    case 11:
            //        cor = Color.FromArgb(0, 192, 248);
            //        break;
            //    default:
            //        cor = Color.White;
            //        break;
            //}

            return cor;
        }

        /// <summary>
        /// 根据值，得到颜色
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        private System.Drawing.Color DetermindBINColor(int binVal)
        {
            Color cor = Color.Black;
            int idr = binVal % 12;

            switch (idr)
            {
                case 0:
                    cor = Color.Red;
                    break;
                case 1:
                    cor = Color.Yellow;
                    break;
                case 2:
                    cor = Color.Green;
                    break;
                case 3:
                    cor = Color.Fuchsia;
                    break;
                case 4:
                    cor = Color.Lime;
                    break;
                case 5:
                    cor = Color.SkyBlue;
                    break;
                case 6:
                    cor = Color.Aqua;
                    break;
                case 7:
                    cor = Color.FromArgb(51, 153, 255);
                    break;
                case 8:
                    cor = Color.Olive;
                    break;
                case 9:
                    cor = Color.FromArgb(255, 128, 0);
                    break;
                case 10:
                    cor = Color.FromArgb(0, 171, 171);
                    break;
                case 11:
                    cor = Color.White;
                    break;
                default:
                    cor = Color.Black;
                    break;
            }

            return cor;
        }

        /// <summary>
        /// 根据值，得到颜色
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        private System.Drawing.Color DetermindColor(double idx)
        {
            int ValR, ValG, ValB;
            double space = 76.5765766;
            if (idx < 0)
            {
                ValR = 255;
                ValG = 0;
                ValB = 0;
            }
            else if (idx < 3.333)
            {
                ValR = 255;
                double temp = space * idx;
                ValG = (int)Math.Round(temp, 0);
                ValB = 0;
            }
            else if (idx < 6.667)
            {
                ValR = (int)Math.Round(space * (6.667 - idx), 0);
                ValG = 255;
                ValB = 0;
            }
            else if (idx < 10)
            {
                ValR = 0;
                ValG = 255;
                ValB = (int)Math.Round(space * (idx - 6.667), 0);
            }
            else
            {
                ValR = 0;
                ValG = 0;
                ValB = 255;
            }

            return System.Drawing.Color.FromArgb(ValR, ValG, ValB);
        }

        /// <summary>
        /// 根据IR，HBM，MM，然后再具体的值
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        private System.Drawing.Color DetermindESDColor(double ir,string esdType,double[] data)
        {
            Color cor = Color.White;
            //先判断IR，大于5，就是IRfail
            if (ir > 5)
            {
                return ColorIrFail;
            }
            if ("HBM MAPPING".CompareTo(esdType) == 0)
            {
                foreach (string item in _esdHeader.Keys)
                {
                    if (item.StartsWith("HBM"))
                    {
                        int seq = SMes.Core.Utility.StrUtil.ValueToInt(_esdHeader[item]) + 2;
                        int index = GetDataIndexByValue(seq);
                        if (data[index] == 0)
                        {
                            return GetFailColorByEsdType(item);
                        }
                        else if(data[index] == 1)
                        {
                            cor = ColorOkDies;
                        }
                    }
                }
            }
            else if ("MM MAPPING".CompareTo(esdType) == 0)
            {
                foreach (string item in _esdHeader.Keys)
                {
                    if (item.StartsWith("MM"))
                    {
                        int seq = SMes.Core.Utility.StrUtil.ValueToInt(_esdHeader[item]) + 2;
                        int index = GetDataIndexByValue(seq);
                        if (data[index] == 0)
                        {
                            return GetFailColorByEsdType(item);
                        }
                        else if (data[index] == 1)
                        {
                            cor = ColorOkDies;
                        }
                    }
                }
            }
            else
            {
                if (_esdHeader.Contains(esdType))
                {
                    int seq = SMes.Core.Utility.StrUtil.ValueToInt(_esdHeader[esdType]) + 2;
                    int index = GetDataIndexByValue(seq);
                    if (data[index] == 0)
                    {
                        return GetFailColorByEsdType(esdType);
                    }
                    else if (data[index] == 1)
                    {
                        cor = ColorOkDies;
                    }
                }
            }

            return cor;
        }

        /// <summary>
        /// 根据类型得到颜色
        /// </summary>
        /// <param name="esdType"></param>
        /// <returns></returns>
        private Color GetFailColorByEsdType(string esdType)
        {
            if ("HBM -2000".CompareTo(esdType) == 0)
            {
                return ColorHBM_2000Fail;
            }
            else if ("HBM 2000".CompareTo(esdType) == 0)
            {
                return ColorHBM_2000Fail;
            }
            else if ("HBM -4000".CompareTo(esdType) == 0)
            {
                return ColorHBM_4000Fail;
            }
            else if ("HBM 4000".CompareTo(esdType) == 0)
            {
                return ColorHBM4000Fail;
            }
            else if ("HBM -6000".CompareTo(esdType) == 0)
            {
                return ColorHBM_6000Fail;
            }
            else if ("HBM 6000".CompareTo(esdType) == 0)
            {
                return ColorHBM6000Fail;
            }
            else if ("HBM -8000".CompareTo(esdType) == 0)
            {
                return ColorHBM_8000Fail;
            }
            else if ("HBM 8000".CompareTo(esdType) == 0)
            {
                return ColorHBM8000Fail;
            }
            else if ("MM -300".CompareTo(esdType) == 0)
            {
                return ColorMM_300Fail;
            }
            else if ("MM 300".CompareTo(esdType) == 0)
            {
                return ColorMM300Fail;
            }
            else if ("MM -350".CompareTo(esdType) == 0)
            {
                return ColorMM_350Fail;
            }
            else if ("MM -400".CompareTo(esdType) == 0)
            {
                return ColorMM_400Fail;
            }
            else
            {
                return Color.White;
            }
        }

        /// <summary>
        /// 根据界面上的x轴，y轴得到哪一颗
        /// </summary>
        /// <param name="showX"></param>
        /// <param name="showY"></param>
        /// <returns></returns>
        public int GetChipInfoIndexByPoint(int showX, int showY)
        {
            int index = -1;

            //在点的X轴，X轴+缩放比例 //在点的Y轴，Y轴+缩放比例
            for (int i = 0; i < this._proberDataList.Count; i++)
            {
                if (showX >= this._proberDataList[i].ShowPosX && showX <= this._proberDataList[i].ShowPosX + _zoomRate
                    && showY >= this._proberDataList[i].ShowPosY && showY <= this._proberDataList[i].ShowPosY + _zoomRate)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

    }
}
