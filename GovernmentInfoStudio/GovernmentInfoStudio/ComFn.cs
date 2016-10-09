namespace BaseCommon.Common
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Drawing.Imaging;
    using System.Globalization;
    using System.IO;
    using System.Management;
    using System.Net.Mail;
    using System.Runtime.InteropServices;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Security.Cryptography;
    using System.Text;
    using System.Windows.Forms;
    using System.Net;
    using System.Diagnostics;
    using System.Text.RegularExpressions;
    using System.IO.Compression;
    using System.Drawing.Drawing2D;
    using System.Security.AccessControl;
    using BaseCommon.Common.Session;
    using System.Xml;
    using BaseCommon.Common.DB;

    public class ComFn
    {
        /// <summary>  
        /// 汉字转换为Unicode编码  
        /// </summary>  
        /// <param name="str">要编码的汉字字符串</param>  
        /// <returns>Unicode编码的的字符串</returns>  
        public static string ToUnicode(string str)
        {
            byte[] bts = Encoding.Unicode.GetBytes(str);
            string r = "";
            for (int i = 0; i < bts.Length; i += 2) r += "\\u" + bts[i + 1].ToString("x").PadLeft(2, '0') + bts[i].ToString("x").PadLeft(2, '0');
            return r;
        }
        /// <summary>  
        /// 将Unicode编码转换为汉字字符串  
        /// </summary>  
        /// <param name="str">Unicode编码字符串</param>  
        /// <returns>汉字字符串</returns>  
        public static string ToGB2312(string str)
        {
            string r = "";
            if (string.IsNullOrEmpty(str)) return r;
            MatchCollection mc = Regex.Matches(str, @"\\u([\w]{2})([\w]{2})", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            byte[] bts = new byte[2];
            foreach (Match m in mc)
            {
                bts[0] = (byte)int.Parse(m.Groups[2].Value, NumberStyles.HexNumber);
                bts[1] = (byte)int.Parse(m.Groups[1].Value, NumberStyles.HexNumber);
                r += Encoding.Unicode.GetString(bts);
            }
            return r;
        }

        /// 将字符串编码为Base64字符串 
        /// </summary> 
        /// <param name="estr">要编码的字符串</param> 
        public static string Base64Encode(string str)
        {
            byte[] barray;
            barray = Encoding.GetEncoding("gb2312").GetBytes(str);
            return Convert.ToBase64String(barray);
        }


        /// <summary> 
        /// 将Base64字符串解码为普通字符串 
        /// </summary> 
        /// <param name="dstr">要解码的字符串</param> 
        public static string Base64Decode(string str)
        {
            byte[] barray;
            barray = Convert.FromBase64String(str);
            return Encoding.GetEncoding("gb2312").GetString(barray);
        }


        public static byte[] Base64ByteDecode(string str)
        {
            byte[] barray;
            barray = Convert.FromBase64String(str);
            return barray;
        }

        public static string AppendBegin(string s, int len, char appendChar)
        {
            int count = len - s.Length;
            if (count <= 0)
            {
                return s;
            }
            return (new string(appendChar, count) + s);
        }

        public static string AppendEnd(string s, int len, char appendChar)
        {
            int count = len - s.Length;
            if (count <= 0)
            {
                return s;
            }
            return (s + new string(appendChar, count));
        }

        public static void ArrayCompare<Array1, Array2>(Array1[] list1, Array2[] list2, Compare<Array1, Array2> compare, OnSuccess<Array1, Array2> success, OnNotMatch<Array1> notMatch)
        {
            int index = 0;
            int num2 = 0;
            while (index < list1.Length)
            {
                if (num2 >= list2.Length)
                {
                    if (notMatch != null)
                    {
                        notMatch(list1[index]);
                    }
                    index++;
                }
                else
                {
                    int num3 = compare(list1[index], list2[num2]);
                    if (num3 == 0)
                    {
                        do
                        {
                            success(list1[index], list2[num2]);
                            num2++;
                        }
                        while ((num2 < list2.Length) && (compare(list1[index], list2[num2]) == 0));
                        index++;
                        continue;
                    }
                    if (num3 < 0)
                    {
                        if (notMatch != null)
                        {
                            notMatch(list1[index]);
                        }
                        index++;
                        continue;
                    }
                    if (num3 > 0)
                    {
                        num2++;
                    }
                }
            }
        }

        public static void ArrayMerge<Array1, Array2>(Array1[] list1, Array2[] list2, Compare<Array1, Array2> compare, OnSuccess<Array1, Array2> success)
        {
            ArrayCompare<Array1, Array2>(list1, list2, compare, success, null);
        }

        public static bool ByteToImage(byte[] byteDatas, ref Image img, ref string errMsg)
        {
            try
            {
                MemoryStream stream = new MemoryStream(byteDatas);
                img = new Bitmap(stream);
                img.Tag = stream;
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool ByteToImage(MemoryStream ms, ref Image img, ref string errMsg)
        {
            try
            {
                img = new Bitmap(ms);
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool CheckDateFormatIsValid(ref string fromat)
        {
            fromat = fromat.Replace("m", "M");
            fromat = fromat.Replace("D", "d");
            fromat = fromat.Replace("Y", "y");
            char[] chArray = fromat.ToCharArray();
            for (int i = 0; i < chArray.Length; i++)
            {
                if ((((chArray[i] != 'd') && (chArray[i] != 'M')) && ((chArray[i] != 'y') && (chArray[i] != '-'))) && (chArray[i] != '/'))
                {
                    return false;
                }
            }
            DateTime time = new DateTime(0x7d9, 9, 0x12);
            string s = time.ToString(fromat);
            DateTime now = DateTime.Now;
            try
            {
                now = DateTime.ParseExact(s, fromat, CultureInfo.CurrentCulture);
            }
            catch
            {
                return false;
            }
            if ((fromat.IndexOf("y") > -1) && (time.Date.Year != now.Date.Year))
            {
                return false;
            }
            if ((fromat.IndexOf("M") > -1) && (time.Date.Month != now.Date.Month))
            {
                return false;
            }
            if ((fromat.IndexOf("d") > -1) && (time.Date.Day != now.Date.Day))
            {
                return false;
            }
            return true;
        }

        //public static bool CheckRSLicenseNumber(string info, string licenseNumber)
        //{
        //    return (ISSec.ISCheckLicenseNumber(info, licenseNumber, 1) == 0);
        //}

        //public static bool CheckRSLicenseNumber(string companyName, string address1, string phone, int licenseCount, string licenseNumber)
        //{
        //    return CheckRSLicenseNumber(string.Concat(new object[] { licenseCount, companyName, address1, phone, "RS" }), licenseNumber);
        //}

        public static object[] ConvertIntAryToObjAry(int[] list)
        {
            object[] objArray = new object[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                objArray[i] = list[i];
            }
            return objArray;
        }

        public static bool CreateDirectory(string filePath, ref string errMsg)
        {
            try
            {
                string directoryName = Path.GetDirectoryName(filePath);
                if (!Directory.Exists(directoryName))
                {
                    Directory.CreateDirectory(directoryName);
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        //public static DateTime DateTimeAddWeeksToFirstDay(DateTime from, int weeks)
        //{
        //    return from.AddDays((double) (from.DayOfWeek * ~DayOfWeek.Sunday)).AddDays((double) (weeks * 7));
        //}

        public static DateTime DateTimeToDate(DateTime dt)
        {
            return new DateTime(dt.Year, dt.Month, dt.Day);
        }

        public static string DateTimeToString(DateTime dt, string format)
        {
            try
            {
                if (dt == DateTime.MinValue)
                {
                    return "";
                }
                return dt.ToString(format);
            }
            catch (Exception)
            {
                return "";
            }
        }

        //解密
        public static string DecryptDBPassword(string text)
        {
            try
            {
                //return ISSec.DecryptPassword(text, "ConsoleClientdbpASSWORD");
                //return ISSec.Decode(text);
                return ISSec.Decode(text, "fuluwang");
            }
            catch
            {
                return "";
            }

        }

        //加密
        public static string EncryptDBPassword(string text)
        {
            // return ISSec.EncryptPassword(text, "ConsoleClientdbpASSWORD");
            //return ISSec.Encode(text);
            return ISSec.Encode(text, "fuluwang");
        }

        public static string EncryptDBPassword(string text, string key)
        {
            return ISSec.Encode(text, key);
        }

        public static string DecryptDBPassword(string text, string key)
        {
            try
            {
                return ISSec.Decode(text, key);
            }
            catch
            {
                return "";
            }

        }

        //解密
        public static string DecryptDBPasswordOld(string text)
        {
            try
            {
                //return ISSec.DecryptPassword(text, "ConsoleClientdbpASSWORD");
                return ISSec.Decode(text);
                //return ISSec.Decode(text, "fuluwang");
            }
            catch
            {
                return "";
            }

        }

        public static string DecryptString(string text)
        {
            try
            {
                return ISSec.DecryptPassword(text, "InfoSpec");
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static object DeepClone(object src)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, src);
                stream.Seek(0L, SeekOrigin.Begin);
                return formatter.Deserialize(stream);
            }
        }

        public static bool DeleteFileSale(string path, ref string errMsg)
        {
            try
            {
                File.Delete(path);
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.ToString();
                return false;
            }
        }

        //public static string EncryptDBPasswordNew(string text)
        //{
        //    return ISSec.Encode(text);
        //}

        public static string EncryptString(string text)
        {
            try
            {
                return ISSec.EncryptPassword(text, "InfoSpec");
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string FormatString(string s, params object[] args)
        {
            try
            {
                return string.Format(s, args);
            }
            catch (Exception)
            {
                return s;
            }
        }

        public static string GetAfterText(string s, string key)
        {
            int index = s.IndexOf(key);
            if (index < 0)
            {
                return "";
            }
            return s.Substring(index + 1);
        }

        public static Color GetAlphaColor(Color fromColor, int alpha)
        {
            if (alpha < 0)
            {
                alpha = 0;
            }
            if (alpha > 100)
            {
                alpha = 100;
            }
            Color white;
            int num = (int)(((fromColor.R * 0.3) + (fromColor.G * 0.59)) + (fromColor.B * 0.11));
            if (num > 0x7f)
                white = Color.Black;
            else
                white = Color.White;
            int red = ((fromColor.R * (100 - alpha)) + (white.R * alpha)) / 100;
            int green = ((fromColor.G * (100 - alpha)) + (white.G * alpha)) / 100;
            int blue = ((fromColor.B * (100 - alpha)) + (white.B * alpha)) / 100;
            return Color.FromArgb(red, green, blue);
        }

        public static string GetAppExePath()
        {
            try
            {
                if (AppInfo.AppType == AppTypeEnum.Exe)
                {
                    string safeString = GetSafeString(Application.StartupPath);
                    if ((safeString.Length > 0) && !safeString.EndsWith(@"\"))
                    {
                        safeString = safeString + @"\";
                    }
                    return safeString;
                }
                AppTypeEnum appType = AppInfo.AppType;
                return "";
            }
            catch (Exception)
            {
                return "";
            }
            //return "";
        }

        public static string GetAppSecretPath()
        {
            return (GetAppPath() + @"Secret\");
        }

        public static string GetAppImagePath()
        {
            return (GetAppPath() + @"Image\");
        }

        public static string GetAntiVCPath()
        {
            return (GetAppPath() + @"AntiVC\");
        }

        public static string GetAppPath()
        {
            try
            {
                string safeString = "";
                if (AppInfo.AppType == AppTypeEnum.Exe)
                {
                    safeString = GetSafeString(Application.StartupPath);
                    //if (safeString.ToUpper().EndsWith(@"BIN\RELEASE"))
                    //{
                    //    safeString = GetParentDirectory(GetParentDirectory(safeString));
                    //}
                    //else
                    //{
                    //    safeString = GetParentDirectory(safeString);
                    //}
                    if ((safeString.Length > 0) && !safeString.EndsWith(@"\"))
                    {
                        safeString = safeString + @"\";
                    }
                    return safeString;
                }
                if (AppInfo.AppType == AppTypeEnum.Web)
                {

                }
                AppTypeEnum appType = AppInfo.AppType;
                return "";
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string GetCodeFCPath()
        {
            return (GetAppPath() + @"CodeFC\");
        }

        public static string GetVoicePath()
        {
            return (GetAppPath() + @"Voice\");
        }

        public static string GetCodeDLLPath()
        {
            return (GetAppPath() + @"CodeDLL\");
        }

        public static string GetCodeImagePath()
        {
            return (GetAppPath() + @"CodeImage\");
        }

        public static string GetCodeOtherPath()
        {
            return (GetAppPath() + @"CodeOther\");
        }

        public static string GetCodeCiteDLLPath()
        {
            return (GetAppPath() + @"CiteDLL\");
        }

        public static string GetRegDLLPath()
        {
            return (GetAppPath() + @"RegDLL\");
        }

        public static bool GetAppReourceImage(string fileName, ref Bitmap bmp, ref string errMsg)
        {
            try
            {
                bmp = new Bitmap(GetAppImagePath() + fileName);
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static Bitmap GetAppReourceImageSafe(string fileName)
        {
            try
            {
                return new Bitmap(GetAppImagePath() + fileName);
            }
            catch (Exception)
            {
                return new Bitmap(1, 1);
            }
        }

        public static string GetAppReportPath()
        {
            return (GetAppSettingPath() + @"Report\");
        }

        public static string GetAppSettingPath()
        {
            return (GetAppExePath() + @"Setting\");
        }

        public static string GetAppUserDataPath()
        {
            return (GetAppSettingPath() + @"UserData\");
        }

        public static string GetBatchSql(List<string> batchSqlList)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < batchSqlList.Count; i++)
            {
                builder.Append(batchSqlList[i]);
                builder.Append(Environment.NewLine);
            }
            return builder.ToString();
        }

        public static string GetBeforeText(string s, string key)
        {
            int index = s.IndexOf(key);
            if (index < 0)
            {
                return "";
            }
            return s.Substring(0, index);
        }

        public static byte[] GetDBFieldBinary(object v)
        {
            if (v == DBNull.Value)
            {
                return null;
            }
            if (v == null)
            {
                return null;
            }
            return (byte[])v;
        }

        public static bool GetDBFieldBool(object v)
        {
            return (((v != DBNull.Value) && (v != null)) && Convert.ToBoolean(v));
        }

        public static DateTime GetDBFieldDateTime(object v)
        {
            if (v == DBNull.Value)
            {
                return DateTime.MinValue;
            }
            if (v == null)
            {
                return DateTime.MinValue;
            }
            if (Convert.ToDateTime(v).CompareTo(new DateTime(0x76d, 1, 1)) < 0)
            {
                return DateTime.MinValue;
            }
            return Convert.ToDateTime(v);
        }

        public static decimal GetDBFieldDecimal(object v)
        {
            if (v == DBNull.Value)
            {
                return 0M;
            }
            if (v == null)
            {
                return 0M;
            }
            return Convert.ToDecimal(v);
        }

        public static int GetDBFieldInt(object v)
        {
            if (v == DBNull.Value)
            {
                return 0;
            }
            if (v == null)
            {
                return 0;
            }
            return Convert.ToInt32(v);
        }

        public static long GetDBFieldLong(object v)
        {
            if (v == DBNull.Value)
            {
                return 0;
            }
            if (v == null)
            {
                return 0;
            }
            return Convert.ToInt64(v);
        }

        public static string GetDBFieldString(object v)
        {
            if (v == DBNull.Value)
            {
                return "";
            }
            if (v == null)
            {
                return "";
            }
            return Convert.ToString(v).TrimEnd(new char[0]);
        }

        public static float GetDBFieldFloat(object v)
        {
            if (v == DBNull.Value)
            {
                return 0;
            }
            if (v == null)
            {
                return 0;
            }
            float result = 0f;
            float.TryParse(v.ToString(), out result);
            return result;
        }

        public static string GetDirectoryFromFullPath(string fullPath)
        {
            int num = fullPath.LastIndexOf(@"\");
            if (num >= 0)
            {
                return fullPath.Substring(0, num + 1);
            }
            return fullPath;
        }

        public static string GetFileNameFromFullPath(string fullPath)
        {
            int num = fullPath.LastIndexOf(@"\");
            if (num >= 0)
            {
                return fullPath.Substring(num + 1);
            }
            return fullPath;
        }

        public static string GetGuidString()
        {
            try
            {
                return Guid.NewGuid().ToString();
            }
            catch (Exception)
            {
                return "InvalidKey";
            }
        }

        /**/
        /// <summary>
        /// 转全角的函数(SBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>全角字符串</returns>
        ///<remarks>
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>        
        public static string ToSBC(string input)
        {
            //半角转全角：
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new string(c);
        }

        /**/
        /// <summary>
        /// 转半角的函数(DBC case)
        /// </summary>
        /// <param name="input">任意字符串</param>
        /// <returns>半角字符串</returns>
        ///<remarks>
        ///全角空格为12288，半角空格为32
        ///其他字符半角(33-126)与全角(65281-65374)的对应关系是：均相差65248
        ///</remarks>
        public static string ToDBC(string input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 12288)
                {
                    c[i] = (char)32;
                    continue;
                }
                if (c[i] > 65280 && c[i] < 65375)
                    c[i] = (char)(c[i] - 65248);
            }
            return new string(c);
        }

        /// <summary>
        /// 得到机器名
        /// </summary>
        /// <returns></returns>
        public static string GetHostName()
        {
            try
            {
                return Dns.GetHostName();
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string GetParentDirectory(string directory)
        {
            directory = directory.Trim();
            if (directory.EndsWith(@"\"))
            {
                directory = directory.Substring(0, directory.Length - 1);
            }
            int num = directory.LastIndexOf(@"\");
            if (num < 0)
            {
                return directory;
            }
            return directory.Substring(0, num + 1);
        }

        public static string GetSafeDirectory(string directory)
        {
            directory = directory.Trim();
            if (!directory.EndsWith(@"\"))
            {
                return (directory + @"\");
            }
            return directory;
        }

        public static string GetSafeSql(string sql)
        {
            if (string.IsNullOrEmpty(sql))
            {
                sql = "";
            }
            return sql.Replace("'", "''");
        }

        public static string GetSafeString(string s)
        {
            if (s == null)
            {
                return "";
            }
            return s;
        }

        public static bool ImageToByte(Image img, ref byte[] byteDatas, ref string errMsg)
        {
            try
            {
                if (img == null)
                {
                    byteDatas = new byte[0];
                    return true;
                }
                using (MemoryStream stream = new MemoryStream())
                {
                    img.Save(stream, ImageFormat.Jpeg);
                    stream.Flush();
                    byteDatas = stream.GetBuffer();
                    stream.Close();
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        //public static bool IsAdminPassword(string text)
        //{
        //    return (ISSec.ISCheckAdminPassword(text) == 0);
        //}

        public static bool IsOnlyNumericString()
        {
            return false;
        }

        public static decimal MyRound(decimal value, int digts)
        {
            decimal num = value;
            value = Math.Abs(value);
            decimal num2 = 1M / ((decimal)Math.Pow(10.0, (double)digts));
            decimal num3 = decimal.Multiply(value, num2);
            decimal num4 = value - num3;
            decimal num5 = 0M;
            if (num3 >= (num2 / 2M))
            {
                num5 = num4 + num2;
            }
            else
            {
                num5 = num4;
            }
            if (num < 0M)
            {
                return (num5 * -1M);
            }
            return num5;
        }

        public static decimal ObjectToDecimal(object s)
        {
            return StringToDecimal(ObjectToString(s));
        }

        public static int ObjectToInt(object s)
        {
            return StringToInt(ObjectToString(s));
        }

        public static long ObjectToLong(object s)
        {
            return StringToLong(ObjectToString(s));
        }

        public static string ObjectToString(object s)
        {
            if (s == null)
            {
                return "";
            }
            return s.ToString();
        }

        public static T QuickFind<T>(List<T> list, QuickFindCompare<T> compare)
        {
            int num = 0;
            int num2 = list.Count - 1;
            while (((num >= 0) && (num2 < list.Count)) && (num <= num2))
            {
                int num3 = (num + num2) / 2;
                switch (compare(list[num3]))
                {
                    case 0:
                        return list[num3];

                    case 1:
                        {
                            num2 = num3 - 1;
                            continue;
                        }
                    case -1:
                        num = num3 + 1;
                        break;
                }
            }
            return default(T);
        }

        public static bool ReadTextFile(string path, ref string[] fileLineList, ref string errMsg)
        {
            return ReadTextFile(path, Encoding.UTF8, ref fileLineList, ref errMsg);
        }

        public static bool ReadTextFile(string path, Encoding encoding, ref string fileText, ref string errMsg)
        {
            string[] fileLineList = null;
            if (!ReadTextFile(path, encoding, ref fileLineList, ref errMsg))
            {
                return false;
            }
            StringBuilder builder = new StringBuilder();
            foreach (string str in fileLineList)
            {
                builder.Append(str);
                builder.Append(Environment.NewLine);
            }
            fileText = builder.ToString();
            return true;
        }

        public static bool ReadTextFile(string path, Encoding encoding, ref string[] fileLineList, ref string errMsg)
        {
            try
            {
                ArrayList list = new ArrayList();
                using (StreamReader reader = new StreamReader(path, encoding))
                {
                    for (string str = reader.ReadLine(); str != null; str = reader.ReadLine())
                    {
                        list.Add(str);
                    }
                    reader.Close();
                }
                fileLineList = new string[list.Count];
                Array.Copy(list.ToArray(), 0, fileLineList, 0, fileLineList.Length);
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static decimal StringToDecimal(string s)
        {
            try
            {
                if (string.IsNullOrEmpty(s))
                {
                    return 0M;
                }

                decimal delS = 0M;

                decimal.TryParse(s, out delS);

                return delS;
            }
            catch (Exception)
            {
                return 0M;
            }
        }

        public static bool StringToDecimalUnSafe(string s, ref decimal v)
        {
            try
            {
                decimal dels = 0M;

                if (!decimal.TryParse(s, out dels))
                {
                    v = dels;
                    return false;
                }

                v = dels;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int StringToInt(string s)
        {
            try
            {
                int inS = 0;

                int.TryParse(s, out inS);

                return inS;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static long StringToLong(string s)
        {
            try
            {
                long inS = 0;

                long.TryParse(s, out inS);

                return inS;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static bool StringToIntUnSafe(string s, ref int v)
        {
            try
            {
                v = Convert.ToInt32(s);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool WrithTextFile(string path, string[] fileLineList, ref string errMsg)
        {
            return WrithTextFile(path, Encoding.UTF8, fileLineList, ref errMsg);
        }

        public static bool WrithTextFile(string path, Encoding encoding, string[] fileLineList, ref string errMsg)
        {
            try
            {
                string directoryFromFullPath = GetDirectoryFromFullPath(path);
                if (!Directory.Exists(directoryFromFullPath))
                {
                    Directory.CreateDirectory(directoryFromFullPath);
                }
                using (StreamWriter writer = new StreamWriter(path, false, encoding))
                {
                    foreach (string str2 in fileLineList)
                    {
                        writer.WriteLine(str2);
                    }
                    writer.Flush();
                    writer.Close();
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public static bool WrithTextFile(string path, Encoding encoding, string text, ref string errMsg)
        {
            try
            {
                string directoryFromFullPath = GetDirectoryFromFullPath(path);
                if (!Directory.Exists(directoryFromFullPath))
                {
                    Directory.CreateDirectory(directoryFromFullPath);
                }
                using (StreamWriter writer = new StreamWriter(path, false, encoding))
                {
                    writer.Write(text);
                    writer.Close();
                }
                return true;
            }
            catch (Exception exception)
            {
                errMsg = exception.Message;
                return false;
            }
        }

        public delegate int Compare<T, T1>(T t, T1 t1);

        private class ISSec
        {
            const string KEY_64 = "VavicApp";//注意了，是8个字符，64位

            const string IV_64 = "VavicApp";

            public static string Encode(string data)
            {
                byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(KEY_64);
                byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV_64);

                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                int i = cryptoProvider.KeySize;
                MemoryStream ms = new MemoryStream();
                CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateEncryptor(byKey, byIV), CryptoStreamMode.Write);

                StreamWriter sw = new StreamWriter(cst);
                sw.Write(data);
                sw.Flush();
                cst.FlushFinalBlock();
                sw.Flush();
                return Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);

            }

            public static string Decode(string data)
            {
                byte[] byKey = System.Text.ASCIIEncoding.ASCII.GetBytes(KEY_64);
                byte[] byIV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV_64);

                byte[] byEnc;
                try
                {
                    byEnc = Convert.FromBase64String(data);
                }
                catch
                {

                    return "";
                }

                DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
                MemoryStream ms = new MemoryStream(byEnc);
                CryptoStream cst = new CryptoStream(ms, cryptoProvider.CreateDecryptor(byKey, byIV), CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(cst);
                return sr.ReadToEnd();

            }

            public static byte[] ComputeHash(byte[] data)
            {
                using (MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider())
                {
                    return provider.ComputeHash(data);
                }
            }

            public static string DecryptPassword(string text)
            {
                return DecryptPassword(text, "AZBYCXDWEQ");
            }

            public static string DecryptPassword(string text, string key)
            {
                if (text.Length == 0)
                {
                    return "";
                }
                char ch = (char)((ushort)Convert.ToInt16(text.Substring(text.Length - 2, 2), 0x10));
                string str = "";
                //int length = key.Length;
                int length = (text.Length - 2) / 2;
                if (key.Length < length)
                {
                    for (int i = key.Length; i < length; i++)
                    {
                        key = key + " ";
                    }
                }
                for (int i = 0; i < length; i++)
                {
                    char ch2 = (char)((ushort)Convert.ToInt16(text.Substring(i * 2, 2), 0x10));
                    ch2 = (char)(ch2 ^ ch);
                    ch2 = (char)(ch2 ^ key[i]);
                    str = str + ch2;
                }
                return str.Trim();
            }

            public static string EncryptPassword(string password)
            {
                return EncryptPassword(password, "AZBYCXDWEQ");
            }

            public static string EncryptPassword(string password, string key)
            {
                string str = "";
                char lRC = GetLRC(key + password);
                password = password + "                                     ";
                if (key.Length < password.Length)
                {
                    for (int i = key.Length; i < password.Length; i++)
                    {
                        key = key + " ";
                    }
                }
                for (int i = 0; i < key.Length; i++)
                {
                    str = str + ((int)((password[i] ^ key[i]) ^ lRC)).ToString("X02");
                }
                return (str + ((int)lRC).ToString("X02"));
            }

            private static char GetLRC(string text)
            {
                char ch = '\0';
                for (int i = 0; i < text.Length; i++)
                {
                    ch = (char)(ch ^ text[i]);
                }
                return ch;
            }


            public static string Encode(string str, string key)
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.Key = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                provider.IV = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                byte[] bytes = Encoding.GetEncoding("GB2312").GetBytes(str);
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateEncryptor(), CryptoStreamMode.Write);
                stream2.Write(bytes, 0, bytes.Length);
                stream2.FlushFinalBlock();
                StringBuilder builder = new StringBuilder();
                foreach (byte num in stream.ToArray())
                {
                    builder.AppendFormat("{0:X2}", num);
                }
                stream.Close();
                return builder.ToString();
            }


            public static string Decode(string str, string key)
            {
                DESCryptoServiceProvider provider = new DESCryptoServiceProvider();
                provider.Key = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                provider.IV = Encoding.ASCII.GetBytes(key.Substring(0, 8));
                byte[] buffer = new byte[str.Length / 2];
                for (int i = 0; i < (str.Length / 2); i++)
                {
                    int num2 = Convert.ToInt32(str.Substring(i * 2, 2), 0x10);
                    buffer[i] = (byte)num2;
                }
                MemoryStream stream = new MemoryStream();
                CryptoStream stream2 = new CryptoStream(stream, provider.CreateDecryptor(), CryptoStreamMode.Write);
                stream2.Write(buffer, 0, buffer.Length);
                stream2.FlushFinalBlock();
                stream.Close();
                return Encoding.GetEncoding("GB2312").GetString(stream.ToArray());
            }


            //public static bool ValidateISSec()
            //{
            //    return (ISDecrypt(@"xURkAiTjSM}\`\hhMN]HKc}{GMtrhjDisfbSA@o[zHP", "2688 Shell Road") == "InfoSpec Systems Inc.");
            //}
        }

        public delegate void OnNotMatch<T>(T t);

        public delegate void OnSuccess<T, T1>(T t, T1 t1);

        public delegate int QuickFindCompare<T>(T t);

        //调用Dos
        public static string RunProcessCmd(string command)
        {
            //Process application = new Process();
            //application.StartInfo.FileName = @"cmd.exe";
            //application.StartInfo.Arguments = "/c" + command;
            //application.StartInfo.RedirectStandardInput = true;
            //application.StartInfo.RedirectStandardOutput = true;
            //application.StartInfo.UseShellExecute = false;
            //application.StartInfo.CreateNoWindow = true;
            //application.Start();
            //application.StandardInput.WriteLine("exit");
            //string str = application.StandardOutput.ReadToEnd();
            //application.Close();

            return RunProcessCmd(command, "/C");
        }

        public static string RunProcessCmd(string command, string type)
        {
            try
            {

                //ProcessStartInfo startInfo = new ProcessStartInfo();
                //startInfo.FileName = "cmd.exe";
                //startInfo.Arguments = "/c C:\\Windows\\System32\\cmd.exe";
                //startInfo.RedirectStandardInput = true;
                //startInfo.RedirectStandardOutput = true;
                //startInfo.RedirectStandardError = true;
                //startInfo.UseShellExecute = false;
                //startInfo.Verb = "RunAs";

                Process application = new Process();
                application.StartInfo.FileName = @"cmd.exe";
                application.StartInfo.Arguments = type + " " + command;
                application.StartInfo.RedirectStandardInput = true;
                application.StartInfo.RedirectStandardOutput = true;
                application.StartInfo.UseShellExecute = false;
                application.StartInfo.CreateNoWindow = true;
                application.StartInfo.Verb = "RunAs";
                application.Start();
                application.StandardInput.WriteLine("exit");
                string str = application.StandardOutput.ReadToEnd();
                application.Close();
                application.Dispose();
                return str;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string RunProcessCmdReg(string command, string type)
        {
            try
            {
                Process application = new Process();
                application.StartInfo.FileName = @"Regsvr32.exe";
                application.StartInfo.Arguments = type + " " + command;
                application.StartInfo.RedirectStandardInput = true;
                application.StartInfo.RedirectStandardOutput = true;
                application.StartInfo.UseShellExecute = false;
                application.StartInfo.CreateNoWindow = true;
                application.Start();
                application.StandardInput.WriteLine("exit");
                string str = application.StandardOutput.ReadToEnd();
                application.Close();
                return str;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string EncryptMd5(string encryptStr)
        {
            byte[] result = Encoding.Default.GetBytes(encryptStr.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "").ToLower();
        }

        public static string EncryptMd5(Encoding encoding, string encryptStr)
        {
            byte[] result = encoding.GetBytes(encryptStr.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "").ToLower();
        }

        public static string EncryptMd5Gb2312(string encryptStr)
        {
            byte[] result = Encoding.GetEncoding("utf-8").GetBytes(encryptStr.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "").ToLower();

        }

        public static string EncryptMd5Utf8(string encryptStr)
        {
            byte[] result = Encoding.GetEncoding("Gb2312").GetBytes(encryptStr.Trim());
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            return BitConverter.ToString(output).Replace("-", "").ToLower();

        }

        public static string taokaMd5(string str)
        {
            if (str == null) return "";
            byte[] bs = System.Text.Encoding.ASCII.GetBytes(str);
            bs = new System.Security.Cryptography.MD5CryptoServiceProvider().ComputeHash(bs);
            string result = "";
            for (int i = 0; i < bs.Length; i++)
                result += bs[i].ToString("x").PadLeft(2, '0');
            return result;
        }

        /// <summary>
        /// MD5加密方法
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string Md5(string str)
        {
            MD5 md = new MD5CryptoServiceProvider();
            byte[] data = System.Text.Encoding.Default.GetBytes(str);//将字符串编码为一个字符序列
            byte[] md5Data = md.ComputeHash(data);//计算data的字节数组的hash值
            md.Clear();
            string s = "";
            for (int i = 0; i < md5Data.Length; i++)
            {
                s += md5Data[i].ToString("X").PadLeft(2, '0');
            }
            return s;
        }

        /// <summary>
        /// MD5 16位加密
        /// </summary>
        /// <param name="ConvertString"></param>
        /// <returns></returns>
        public static string GetMd516(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string t2 = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(str)), 4, 8);
            t2 = t2.Replace("-", "");
            return t2;
        }

        /// <summary>   
        /// 计算某日起始日期（礼拜一的日期）   
        /// </summary>   
        /// <param name="someDate">该周中任意一天</param>   
        /// <returns>返回礼拜一日期，后面的具体时、分、秒和传入值相等</returns>   
        public static DateTime GetMondayDate(DateTime someDate)
        {
            int i = someDate.DayOfWeek - DayOfWeek.Monday;
            if (i == -1) i = 6;// i值 > = 0 ，因为枚举原因，Sunday排在最前，此时Sunday-Monday=-1，必须+7=6。   
            TimeSpan ts = new TimeSpan(i, 0, 0, 0);
            return someDate.Subtract(ts);
        }
        /// <summary>   
        /// 计算某日结束日期（礼拜日的日期）   
        /// </summary>   
        /// <param name="someDate">该周中任意一天</param>   
        /// <returns>返回礼拜日日期，后面的具体时、分、秒和传入值相等</returns>   
        public static DateTime GetSundayDate(DateTime someDate)
        {
            int i = someDate.DayOfWeek - DayOfWeek.Sunday;
            if (i != 0) i = 7 - i;// 因为枚举原因，Sunday排在最前，相减间隔要被7减。   
            TimeSpan ts = new TimeSpan(i, 0, 0, 0);
            return someDate.Add(ts);
        }

        /// <summary>
        /// 根据年月计算该年月的第一天
        /// </summary>
        /// <param name="Year">年</param>
        /// <param name="Month">月</param>
        /// <returns>返回该年月的第一天</returns>
        public static DateTime GetFirstDayOfMonth(int Year, int Month)
        {
            //你见过不是从1号开始的月份么？没有
            //那么，直接返回给调用者吧！
            return Convert.ToDateTime(Year.ToString() + "-" + Month.ToString() + "-1");
        }

        /// <summary>
        /// 根据年月计算该年月的最后一天
        /// </summary>
        /// <param name="Year">年</param>
        /// <param name="Month">月</param>
        /// <returns>返回该年月的最后一天</returns>
        public static DateTime GetLastDayOfMonth(int Year, int Month)
        {
            //这里的关键就是 DateTime.DaysInMonth 获得一个月中的天数
            int Days = DateTime.DaysInMonth(Year, Month);
            return Convert.ToDateTime(Year.ToString() + "-" + Month.ToString() + "-" + Days.ToString());
        }

        /// <summary>
        /// 压缩文件
        /// </summary>
        /// <param name="fileFullName">需要压缩的文件的完整路径（包含文件名）</param>
        /// <param name="GZipFileName">压缩之后的文件名</param>
        /// <returns></returns>
        public static bool GZipCompression(string fileFullName, string GZipFileName)
        {

            byte[] myByte = null;
            FileStream myStream = null;
            FileStream myDesStream = null;
            GZipStream myComStream = null;
            GZipFileName += ".gz";
            try
            {
                myStream = new FileStream(fileFullName, FileMode.Open, FileAccess.Read, FileShare.Read);
                myByte = new byte[myStream.Length];
                myStream.Read(myByte, 0, myByte.Length);
                myDesStream = new FileStream(GZipFileName, FileMode.OpenOrCreate, FileAccess.Write);
                myComStream = new GZipStream(myDesStream, CompressionMode.Compress, true);
                myComStream.Write(myByte, 0, myByte.Length);
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                myStream.Close();
                myComStream.Close();
                myDesStream.Close();
            }
        }

        /// <summary>
        /// 解压文件
        /// </summary>
        /// <param name="GZipFileName">压缩文件名</param>
        /// <param name="fileFullName">解压之后的文件名</param>
        /// <returns></returns>
        public static bool Decompression(string GZipFileName, string fileFullName)
        {
            byte[] myByte = null;
            FileStream myStream = null;
            FileStream myDesStream = null;
            GZipStream myDeComStream = null;
            try
            {
                myStream = new FileStream(GZipFileName, FileMode.Open);
                myDeComStream = new GZipStream(myStream, CompressionMode.Decompress, true);
                myByte = new byte[4];
                int myPosition = (int)myStream.Length - 4;
                myStream.Position = myPosition;
                myStream.Read(myByte, 0, 4);
                myStream.Position = 0;
                int myLength = BitConverter.ToInt32(myByte, 0);
                byte[] myData = new byte[myLength + 100];
                int myOffset = 0;
                int myTotal = 0;
                while (true)
                {
                    int myBytesRead = myDeComStream.Read(myData, myOffset, 100);
                    if (myBytesRead == 0)
                        break;
                    myOffset += myBytesRead;
                    myTotal += myBytesRead;
                }
                myDesStream = new FileStream(fileFullName, FileMode.Create);
                myDesStream.Write(myData, 0, myTotal);
                myDesStream.Flush();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                myStream.Close();
                myDeComStream.Close();
                myDesStream.Close();
            }
        }

        /// <summary>
        /// 无损图片缩放
        /// </summary>
        /// <param name="sImage">原始图片</param>
        /// <param name="ms">缩放后图片流</param>
        /// <param name="dHeight">缩放后图片的高度</param>
        /// <param name="dWidth">缩放后图片的宽度</param>
        /// <returns></returns>
        public static bool GetPicThumbnail(Image sImage, int dHeight, int dWidth, ref MemoryStream ms)
        {
            Image iSource = sImage;
            ImageFormat tFormat = iSource.RawFormat;
            int sW = 0, sH = 0;
            // 按比例缩放
            Size tem_size = new Size(iSource.Width, iSource.Height);
            if (tem_size.Height > dHeight || tem_size.Width > dWidth)
            {
                if ((tem_size.Width * dHeight) > (tem_size.Height * dWidth))
                {
                    sW = dWidth;
                    sH = (dWidth * tem_size.Height) / tem_size.Width;
                }
                else
                {
                    sH = dHeight;
                    sW = (tem_size.Width * dHeight) / tem_size.Height;
                }
            }
            else
            {
                sW = tem_size.Width;
                sH = tem_size.Height;
            }
            Bitmap oB = new Bitmap(sW, sH);
            Graphics g = Graphics.FromImage(oB);
            g.Clear(Color.WhiteSmoke);
            // 设置画布的描绘质量
            g.CompositingQuality = CompositingQuality.HighSpeed;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(iSource, new Rectangle((dWidth - sW) / 2, (dHeight - sH) / 2, sW, sH), 0, 0, iSource.Width, iSource.Height, GraphicsUnit.Pixel);
            g.Dispose();
            // 以下代码为保存图片时，设置压缩质量
            EncoderParameters eP = new EncoderParameters();
            long[] qy = new long[1];
            qy[0] = 100;
            EncoderParameter eParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, qy);
            eP.Param[0] = eParam;
            try
            {
                //获得包含有关内置图像编码解码器的信息的ImageCodecInfo对象。
                ImageCodecInfo[] arrayICI = ImageCodecInfo.GetImageEncoders();
                ImageCodecInfo jpegICIinfo = null;
                for (int x = 0; x < arrayICI.Length; x++)
                {
                    if (arrayICI[x].FormatDescription.Equals("JPEG"))
                    {
                        jpegICIinfo = arrayICI[x];//设置JPEG编码
                        break;
                    }
                }
                if (jpegICIinfo != null)
                {
                    oB.Save(ms, jpegICIinfo, eP);
                }
                else
                {
                    oB.Save(ms, jpegICIinfo, eP);
                }
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                iSource.Dispose();
                oB.Dispose();
            }
        }


        ///<summary>
        /// 从指定的字符串中获取整数
        ///</summary>
        ///<param name="origin">原始的字符串</param>
        ///<param name="fullMatch">是否完全匹配，若为false，则返回字符串中的第一个整数数字</param>
        ///<returns>整数数字</returns>
        private static int GetInt(string origin, bool fullMatch)
        {
            if (string.IsNullOrEmpty(origin))
            {
                return 0;
            }
            origin = origin.Trim();
            if (!fullMatch)
            {
                string pat = @"-?\d+";
                Regex reg = new Regex(pat);
                origin = reg.Match(origin.Trim()).Value;
            }
            int res = 0;
            int.TryParse(origin, out res);
            return res;
        }


        ///<summary>
        /// 获取标准北京时间2,发生异常取本地时间返回
        ///</summary>
        ///<returns></returns>
        public static DateTime GetBeijingTime()
        {
            DateTime dt;
            WebRequest wrt = null;
            WebResponse wrp = null;
            try
            {
                wrt = WebRequest.Create("http://www.beijing-time.org/time.asp");
                wrp = wrt.GetResponse();

                string html = string.Empty;
                using (Stream stream = wrp.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(stream, Encoding.UTF8))
                    {
                        html = sr.ReadToEnd();
                    }
                }

                string[] tempArray = html.Split(';');
                for (int i = 0; i < tempArray.Length; i++)
                {
                    tempArray[i] = tempArray[i].Replace("\r\n", "");
                }

                string year = tempArray[1].Substring(tempArray[1].IndexOf("nyear=") + 6);
                string month = tempArray[2].Substring(tempArray[2].IndexOf("nmonth=") + 7);
                string day = tempArray[3].Substring(tempArray[3].IndexOf("nday=") + 5);
                string hour = tempArray[5].Substring(tempArray[5].IndexOf("nhrs=") + 5);
                string minite = tempArray[6].Substring(tempArray[6].IndexOf("nmin=") + 5);
                string second = tempArray[7].Substring(tempArray[7].IndexOf("nsec=") + 5);
                dt = DateTime.Parse(year + "-" + month + "-" + day + " " + hour + ":" + minite + ":" + second);
            }
            catch
            {
                return DateTime.MinValue;
            }
            finally
            {
                if (wrp != null)
                    wrp.Close();
                if (wrt != null)
                    wrt.Abort();
            }
            return dt;
        }

        /// <summary>
        /// 获取中文首字母
        ///</summary>  
        /// <param name="ChineseStr">中文字符串</param>     
        /// <returns>首字母</returns>       
        public static string GB2Spell(string ChineseStr)
        {
            string Capstr = string.Empty;
            byte[] ZW = new byte[2];
            long ChineseStr_int;
            string CharStr, ChinaStr = "";
            for (int i = 0; i <= ChineseStr.Length - 1; i++)
            {
                CharStr = ChineseStr.Substring(i, 1).ToString();
                ZW = System.Text.Encoding.Default.GetBytes(CharStr);                 // 得到汉字符的字节数组        
                if (ZW.Length == 2)
                {
                    int i1 = (short)(ZW[0]);
                    int i2 = (short)(ZW[1]);
                    ChineseStr_int = i1 * 256 + i2;
                    if ((ChineseStr_int >= 45217) && (ChineseStr_int <= 45252)) { ChinaStr = "A"; }
                    else if ((ChineseStr_int >= 45253) && (ChineseStr_int <= 45760)) { ChinaStr = "B"; }
                    else if ((ChineseStr_int >= 45761) && (ChineseStr_int <= 46317)) { ChinaStr = "C"; }
                    else if ((ChineseStr_int >= 46318) && (ChineseStr_int <= 46825)) { ChinaStr = "D"; }
                    else if ((ChineseStr_int >= 46826) && (ChineseStr_int <= 47009)) { ChinaStr = "E"; }
                    else if ((ChineseStr_int >= 47010) && (ChineseStr_int <= 47296)) { ChinaStr = "F"; }
                    else if ((ChineseStr_int >= 47297) && (ChineseStr_int <= 47613)) { ChinaStr = "G"; }
                    else if ((ChineseStr_int >= 47614) && (ChineseStr_int <= 48118)) { ChinaStr = "H"; }
                    else if ((ChineseStr_int >= 48119) && (ChineseStr_int <= 49061)) { ChinaStr = "J"; }
                    else if ((ChineseStr_int >= 49062) && (ChineseStr_int <= 49323)) { ChinaStr = "K"; }
                    else if ((ChineseStr_int >= 49324) && (ChineseStr_int <= 49895)) { ChinaStr = "L"; }
                    else if ((ChineseStr_int >= 49896) && (ChineseStr_int <= 50370)) { ChinaStr = "M"; }
                    else if ((ChineseStr_int >= 50371) && (ChineseStr_int <= 50613)) { ChinaStr = "N"; }
                    else if ((ChineseStr_int >= 50614) && (ChineseStr_int <= 50621)) { ChinaStr = "O"; }
                    else if ((ChineseStr_int >= 50622) && (ChineseStr_int <= 50905)) { ChinaStr = "P"; }
                    else if ((ChineseStr_int >= 50906) && (ChineseStr_int <= 51386)) { ChinaStr = "Q"; }
                    else if ((ChineseStr_int >= 51387) && (ChineseStr_int <= 51445)) { ChinaStr = "R"; }
                    else if ((ChineseStr_int >= 51446) && (ChineseStr_int <= 52217)) { ChinaStr = "S"; }
                    else if ((ChineseStr_int >= 52218) && (ChineseStr_int <= 52697)) { ChinaStr = "T"; }
                    else if ((ChineseStr_int >= 52698) && (ChineseStr_int <= 52979)) { ChinaStr = "W"; }
                    else if ((ChineseStr_int >= 52980) && (ChineseStr_int <= 53640)) { ChinaStr = "X"; }
                    else if ((ChineseStr_int >= 53689) && (ChineseStr_int <= 54480)) { ChinaStr = "Y"; }
                    else if ((ChineseStr_int >= 54481) && (ChineseStr_int <= 55289)) { ChinaStr = "Z"; }
                }
                else
                    Capstr += CharStr;
                Capstr += ChinaStr;
            }
            return Capstr;
        }


        /// <summary>
        /// 设置文件的读写权限
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="errMsg"></param>
        /// <returns></returns>
        public static bool SetFileOwned(string filePath, string account, FileSystemRights rccessRules, AccessControlType rccessPower, ref string errMsg)
        {
            try
            {
                DirectoryInfo dirinfo = new DirectoryInfo(filePath);

                if ((dirinfo.Attributes & FileAttributes.ReadOnly) != 0)
                {
                    dirinfo.Attributes = FileAttributes.Normal;
                }

                //取得访问控制列表
                DirectorySecurity dirsecurity = dirinfo.GetAccessControl();

                //添加完全控制权限
                FileSystemAccessRule addRule = new FileSystemAccessRule(account, FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow);
                dirsecurity.AddAccessRule(addRule);

                //删除拒绝权限
                FileSystemAccessRule removeRule = new FileSystemAccessRule(account, FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny);
                dirsecurity.RemoveAccessRule(removeRule);

                dirinfo.SetAccessControl(dirsecurity);
                return true;
            }
            catch (Exception ex)
            {
                errMsg = ex.Message;
                return false;
            }
        }

        /// <summary>
        /// 获取本周周一
        /// </summary>
        /// <returns></returns>
        public static DateTime GetThisStartWeek()
        {
            return DateTime.Now.AddDays(1 - Convert.ToInt32(DateTime.Now.DayOfWeek.ToString("d")));
        }

        /// <summary>
        /// 获取本周周末
        /// </summary>
        /// <param name="days">一周5天或七天;五天则days=4,7天则days=6</param>
        /// <returns></returns>
        public static DateTime GetThisEndWeek(int days)
        {
            return DateTime.Now.AddDays(1 - Convert.ToInt32(DateTime.Now.DayOfWeek.ToString("d"))).AddDays(days);
        }

        /// <summary>
        /// 获取输入待计算日期的周一
        /// </summary>
        /// <param name="dateTime">待计算日期</param>
        /// <returns></returns>
        public static DateTime GetDataStartWeek(DateTime dateTime)
        {
            return dateTime.AddDays(1 - Convert.ToInt32(dateTime.DayOfWeek.ToString("d")));
        }

        /// <summary>
        /// 获取待计算日期的周末
        /// </summary>
        /// <param name="dateTime">待计算日期</param>
        /// <param name="days">一周五天或七天,五天则Days==4;七天则Days=6</param>
        /// <returns></returns>
        public static DateTime GetDataEndWeek(DateTime dateTime, int days)
        {
            return dateTime.AddDays(1 - Convert.ToInt32(dateTime.DayOfWeek.ToString("d"))).AddDays(days);
        }

        /// <summary>
        /// 获得序列化时的最小时间
        /// </summary>
        /// <returns></returns>
        public static DateTime GetSerializeDateTimeMinValue()
        {
            DateTime dt = DateTime.Now;
            DateTime.TryParse("1990-01-01 0:00:00", out dt);
            return dt;
        }

        /// <summary>
        /// 得到菜单数量
        /// </summary>
        /// <param name="minNum"></param>
        /// <param name="maxNum"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        public static List<int> GetNum(int minNum, int maxNum, int num)
        {
            //int maxNum = 100;

            //int minNum = 10;

            //int num = ComFn.StringToInt(c_txtAccount.Text);


            List<int> list = new List<int>();

            if (maxNum == 0)
            {
                list.Add(num);
                return list;
            }

            if (num < minNum)
            {

            }
            else if (num >= minNum && num <= maxNum)
            {
                list.Add(num);
            }
            else if (num > maxNum)
            {

                //取余数
                int mod = num % maxNum;

                //向下取整
                int iCount = (int)Math.Floor((decimal)num / (decimal)maxNum);

                for (int i = 0; i < iCount - 1; i++)
                {
                    list.Add(maxNum);
                }

                //大于最下值
                if (mod > minNum)
                {
                    list.Add(maxNum);
                    list.Add(num - iCount * maxNum);
                }
                else
                {
                    list.Add(maxNum - minNum);
                    if (minNum + mod > 0)
                    {
                        list.Add(minNum + mod);
                    }
                }
            }
            return list;
        }

        /// <summary>
        /// 得到每个面值的个数
        /// </summary>
        /// <param name="map">key: 面值， value: 个数</param>
        /// <param name="num">输入面值</param>
        /// <returns></returns>
        public static Dictionary<int, int> SplitPerpainCard(Dictionary<int, int> map, int num)
        {
            Dictionary<int, int> dicRe = new Dictionary<int, int>();

            int[] Base_Number = new int[map.Count];

            int[] Count_Number = new int[map.Count];

            int[] Result = new int[map.Count];

            int i = 0;

            int totleMoney = 0;

            int min_Number = 1000000;

            foreach (var item in map)
            {
                Count_Number[i] = item.Value;
                Base_Number[i] = item.Key;
                Result[i] = 0;
                totleMoney = totleMoney + Count_Number[i] * Base_Number[i];
                i = i + 1;
                if (item.Key < min_Number)
                {
                    min_Number = item.Key;
                }
            }

            if (num % 10 != 0)
            {
                return null;
            }
            if (totleMoney > num && num >= min_Number)
            {
                splitMoney(Base_Number, Result, Count_Number, num, num, 0);
            }
            else if (totleMoney == num)
            {
                for (int j = 0; j < Count_Number.Length; j++)
                {
                    Result[i] = Count_Number[i];
                }
            }
            else
            {
                return null;
            }

            for (int j = 0; j < Result.Length; j++)
            {
                if (Result[j] > 0)
                {
                    dicRe.Add(Base_Number[j], Result[j]);
                }
            }

            return dicRe;
        }

        public static bool splitMoney(int[] Base_Number, int[] Result, int[] Count_Number, int src, int nowSrc, int level)
        {
            // 计算当前充值卡使用总额 
            int sum = 0;
            for (int i = 0; i < Base_Number.Length; i++)
            {
                sum += Base_Number[i] * Result[i];
            }
            // 如果当前充值卡使用总额等于目标总额,是拆分完成 
            if (src == sum)
            {
                return true;
            }
            // 如果当前搜索深度大于最大深度,退出 
            if (level >= Base_Number.Length)
            {
                return false;
            }

            // 计算本层使用充值卡最大数量 
            Result[level] = nowSrc / Base_Number[level];
            if (Result[level] > Count_Number[level])
            {
                // 使用数量大于库存,则最大使用量等于库存 
                Result[level] = Count_Number[level];
            }
            int k = Result[level];
            for (; k >= 0; k--)
            {
                Result[level] = k;
                // 本次搜索后余额 
                int nosplit = nowSrc - Base_Number[level] * Result[level];
                if (nosplit >= Base_Number[Base_Number.Length - 1])
                {
                    // 本次搜索后余额大于最低面值,进入下一层搜索 
                    if (splitMoney(Base_Number, Result, Count_Number, src, nosplit, level + 1))
                    {
                        return true;
                    }
                }
                else if (nosplit == 0)
                {
                    // // 本次搜索后无余额,停止搜索 
                    return true;
                }
                else
                {
                    // 本次搜索后余额小于最低面值,回溯 
                }
            }

            return false;
        }

        /// <summary>
        /// 时间戳转为C#格式时间
        /// </summary>
        /// <param name="timeStamp">Unix时间戳格式</param>
        /// <returns>C#格式时间</returns>
        public static DateTime GetTime(string timeStamp)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(timeStamp + "0000000");
            TimeSpan toNow = new TimeSpan(lTime);
            return dtStart.Add(toNow);
        }

        /// <summary>
        /// DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time"> DateTime时间格式</param>
        /// <returns>Unix时间戳格式</returns>
        public static int ConvertDateTimeInt(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (int)(time - startTime).TotalSeconds;
        }

        public static string GetTimeGreetings(DateTime dt)
        {
            if (dt.Hour >= 5 && dt.Hour < 11)
                return "上午好";
            else if (dt.Hour >= 11 && dt.Hour < 13)
                return "中午好";
            else if (dt.Hour >= 13 && dt.Hour < 18)
                return "下午好";
            return "晚上好";
        }

        /// <summary>
        /// 获取时间戳
        /// </summary>
        /// <returns></returns>
        public static string GetTimeStamp()
        {
            Int64 retval = 0;
            DateTime st = new DateTime(1970, 1, 1);
            TimeSpan t = (DateTime.Now.ToUniversalTime() - st);
            retval = (Int64)(t.TotalMilliseconds + 0.5);
            return retval.ToString();
        }

        public static DateTime GetTimeFromTimeStamp(string timeStamp)
        {
            double retval = double.Parse(timeStamp);
            DateTime st = new DateTime(1970, 1, 1);
            return st.AddMilliseconds(retval).ToLocalTime();
        }

        public static DateTime GetMinTime()
        {
            return new DateTime(1970, 1, 1);
        }

        /// <summary>
        /// 提取正则匹配结果
        /// </summary>
        /// <param name="source"></param>
        /// <param name="reg"></param>
        /// <returns></returns>
        public static string RegexValue(string source, string reg)
        {
            return Regex.Match(source, reg).Groups[1].Value.Trim();
        }

        public static string GuidTo16String()
        {
            long i = 1;
            foreach (byte b in Guid.NewGuid().ToByteArray())
                i *= ((int)b + 1);
            return string.Format("{0:x}", i - DateTime.Now.Ticks);
        }

        public static string CmycurD(decimal num)
        {
            try
            {
                string str1 = "零壹贰叁肆伍陆柒捌玖";            //0-9所对应的汉字 
                string str2 = "万仟佰拾亿仟佰拾万仟佰拾元角分"; //数字位所对应的汉字 
                string str3 = "";    //从原num值中取出的值 
                string str4 = "";    //数字的字符串形式 
                string str5 = "";  //人民币大写金额形式 
                int i;    //循环变量 
                int j;    //num的值乘以100的字符串长度 
                string ch1 = "";    //数字的汉语读法 
                string ch2 = "";    //数字位的汉字读法 
                int nzero = 0;  //用来计算连续的零值是几个 
                int temp;            //从原num值中取出的值 

                num = Math.Round(Math.Abs(num), 2);    //将num取绝对值并四舍五入取2位小数 
                str4 = ((long)(num * 100)).ToString();        //将num乘100并转换成字符串形式 
                j = str4.Length;      //找出最高位 
                if (j > 15) { return "溢出"; }
                str2 = str2.Substring(15 - j);   //取出对应位数的str2的值。如：200.55,j为5所以str2=佰拾元角分 

                //循环取出每一位需要转换的值 
                for (i = 0; i < j; i++)
                {
                    str3 = str4.Substring(i, 1);          //取出需转换的某一位的值 
                    temp = Convert.ToInt32(str3);      //转换为数字 
                    if (i != (j - 3) && i != (j - 7) && i != (j - 11) && i != (j - 15))
                    {
                        //当所取位数不为元、万、亿、万亿上的数字时 
                        if (str3 == "0")
                        {
                            ch1 = "";
                            ch2 = "";
                            nzero = nzero + 1;
                        }
                        else
                        {
                            if (str3 != "0" && nzero != 0)
                            {
                                ch1 = "零" + str1.Substring(temp * 1, 1);
                                ch2 = str2.Substring(i, 1);
                                nzero = 0;
                            }
                            else
                            {
                                ch1 = str1.Substring(temp * 1, 1);
                                ch2 = str2.Substring(i, 1);
                                nzero = 0;
                            }
                        }
                    }
                    else
                    {
                        //该位是万亿，亿，万，元位等关键位 
                        if (str3 != "0" && nzero != 0)
                        {
                            ch1 = "零" + str1.Substring(temp * 1, 1);
                            ch2 = str2.Substring(i, 1);
                            nzero = 0;
                        }
                        else
                        {
                            if (str3 != "0" && nzero == 0)
                            {
                                ch1 = str1.Substring(temp * 1, 1);
                                ch2 = str2.Substring(i, 1);
                                nzero = 0;
                            }
                            else
                            {
                                if (str3 == "0" && nzero >= 3)
                                {
                                    ch1 = "";
                                    ch2 = "";
                                    nzero = nzero + 1;
                                }
                                else
                                {
                                    if (j >= 11)
                                    {
                                        ch1 = "";
                                        nzero = nzero + 1;
                                    }
                                    else
                                    {
                                        ch1 = "";
                                        ch2 = str2.Substring(i, 1);
                                        nzero = nzero + 1;
                                    }
                                }
                            }
                        }
                    }
                    if (i == (j - 11) || i == (j - 3))
                    {
                        //如果该位是亿位或元位，则必须写上 
                        ch2 = str2.Substring(i, 1);
                    }
                    str5 = str5 + ch1 + ch2;

                    if (i == j - 1 && str3 == "0")
                    {
                        //最后一位（分）为0时，加上“整” 
                        str5 = str5 + '整';
                    }
                }
                if (num == 0)
                {
                    str5 = "零元整";
                }
                return str5;
            }
            catch (Exception)
            {

                return "";
            }
        }
    }
}

