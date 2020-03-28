using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace SMes.Core.AppObj
{
    public class SMesDataReader
    {
        public ArrayList buffer;		

		//properties
		public string version;
		public int resultType;
		public int rowNumber;
		public int colNumber;
        public List<string> columnNames;
		private string seprator;
		public Encoding encoding;


		//constant
		public static int RESULT_SUCCESS=0;
		public static int RESULT_APPLICATION_EXECEPTION=1;
		public static int RESULT_SYSTEM_EXECEPTION=2;

		private int cursor=-1;

        private SMesDataReader() 
		{
			buffer = new ArrayList();
		}

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public static SMesDataReader Marshal(string data) 
		{
			int begin, end;

			begin = data.IndexOf("<body>");
			end = data.IndexOf("</body>");

			if ( begin == -1 || end == -1 ) 
			{
                throw new SMesApplicationException(SystemExceptionList.ID_UNKNOWN, "illegal content. Cann't find \"<body>\" or \"</body>\"");
			}

            SMesDataReader instance = new SMesDataReader();

			begin += 6;

			//get version
			instance.version = ""+data[begin];

			//get result type
			switch (data[begin+1]) 
			{
				case '0':
					instance.resultType = RESULT_SUCCESS;
					break;
				case '1':
					instance.resultType = RESULT_APPLICATION_EXECEPTION;
					break;
				case '2':
					instance.resultType = RESULT_SYSTEM_EXECEPTION;
					break;
				default:
                    throw new SMesApplicationException(SystemExceptionList.ID_UNKNOWN, "unknown return type: " + data[begin + 1]);
			}

			//get row number
			instance.rowNumber = Convert.ToInt32(data.Substring(begin + 2, 6));
 
			//get column number
			instance.colNumber = Convert.ToInt32(data.Substring(begin + 8, 6));

			//get seprator
			instance.seprator = data.Substring(begin + 14, 3);

			//get encoding
			string encodingString = data.Substring(begin + 17, 16).Trim();
			try 
			{
				instance.encoding = Encoding.GetEncoding(encodingString);
			} 
			catch  
			{
                throw new SMesApplicationException(SystemExceptionList.ID_UNKNOWN, "unknown encoding: " + encodingString);
			}

			int wordBegin=0, wordEnd=0;
            begin += 33 + instance.seprator.Length;
            int colNameEnd = 0;

            //////到下一个seprator的是列名称
            for (int i = begin; i < end; i++)
            {
                if (i + 2 < end)
                {
                    if (data[i] == instance.seprator[0] && data[i + 1] == instance.seprator[1] && data[i + 2] == instance.seprator[2])
                    {
                        colNameEnd = i;
                        break;
                    }
                }
            }
            String colString = data.Substring(begin, colNameEnd - begin);
            byte[] colByte = Convert.FromBase64String(colString);
            char[] colChars = new char[instance.encoding.GetCharCount(colByte, 0, colByte.Length)];
            instance.encoding.GetChars(colByte, 0, colByte.Length, colChars, 0);
            String colList = new String(colChars);
            string[] splitCol =colList.Split(',');
            instance.columnNames = new List<string>();
            for (int i = 0; i < splitCol.Length; i++)
            {
                instance.columnNames.Add(splitCol[i]);
            }

            begin = colNameEnd;
			
			for (int i=begin; i<end; i++) 
			{
				
				if (data[i] == instance.seprator[0]) 
				{
					//check if seprator is matched
					int j=0;
					for (; j<instance.seprator.Length; j++) 
					{
						if (data[i+j] != instance.seprator[j]) 
						{
							break;
						}
					}

					if (j== instance.seprator.Length)  //match
					{
						if (wordBegin==wordEnd)  //first match
						{
							wordBegin = i+j;
							i += j;
							i--; //
							continue;
						} 
						else 
						{
							wordEnd = i;
                            String segment = data.Substring(wordBegin, wordEnd - wordBegin);
                            if (segment.Length > 0)
                            {
                                byte[] bytes = Convert.FromBase64String(segment);
                                char[] chars = new char[instance.encoding.GetCharCount(bytes, 0, bytes.Length)];
                                instance.encoding.GetChars(bytes, 0, bytes.Length, chars, 0);
                                instance.buffer.Add(new String(chars));
                            }
                            else
                            {
                                instance.buffer.Add("");
                            }

							wordBegin = i +j;
							i += j;
							i--;
							continue;
						}

					}

				}

			}
			

			/*
			instance.buffer = content.Split(instance.seprator.ToCharArray());
			for ( int i =0; i<instance.buffer.Length; i++) 
			{
				instance.buffer[i] = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(instance.buffer[i]));
			}
			*/

			return instance;
		}

		public bool Read() 
		{
            //if (this == null)
            //{
            //    return false;
            //}
			if ( rowNumber > 0 && cursor < rowNumber - 1) 
			{
				cursor++;
				return true;
			}

			return false;
		}

		public string GetString(int i) 
		{
			return getData(i);
		}

		public DateTime GetDateTime(int i) 
		{
			string data = getData(i);
			System.IFormatProvider format =
				new System.Globalization.CultureInfo("en-US", true);

			return DateTime.ParseExact(data, "yyyy-MM-dd HH:mm:ss", format);
		}

        public int GetInt(int i)
        {
            string data = getData(i);

            return Convert.ToInt32(data);
        }

        public long GetLong(int i)
        {
            string data = getData(i);

            return Convert.ToInt64(data);
        }

        public double GetFloat(int i)
        {
            string data = getData(i);

            return Convert.ToDouble(data);
        }


		private string getData(int i) 
		{
			if (cursor>=0 && cursor<rowNumber) 
			{
				return (String)buffer[colNumber*cursor+i];
			}

            throw new SMesApplicationException(SystemExceptionList.ID_UNKNOWN, "invalid cursor.");
		}
		

	}
}
