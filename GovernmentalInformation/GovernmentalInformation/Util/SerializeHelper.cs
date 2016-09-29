using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace GovernmentalInformation.Utils
{
    public class SerializeHelper
    {
        public static string GetSerDir()
       {
            return GetCurProcessDir() + "data\\";
        }

        /// <summary>
        /// 序列化并压缩
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static byte[] Serializer(object obj)
        {
            IFormatter formatter = new BinaryFormatter();//定义BinaryFormatter以序列化object对象  
            MemoryStream ms = new MemoryStream();//创建内存流对象  
            formatter.Serialize(ms, obj);//把object对象序列化到内存流  
            byte[] buffer = ms.ToArray();//把内存流对象写入字节数组  
            ms.Close();//关闭内存流对象  
            ms.Dispose();//释放资源  
            MemoryStream msNew = new MemoryStream();
            GZipStream gzipStream = new GZipStream(msNew, CompressionMode.Compress, true);//创建压缩对象  
            gzipStream.Write(buffer, 0, buffer.Length);//把压缩后的数据写入文件  
            gzipStream.Close();//关闭压缩流,这里要注意：一定要关闭，要不然解压缩的时候会出现小于4K的文件读取不到数据，大于4K的文件读取不完整              
            gzipStream.Dispose();//释放对象  
            msNew.Close();
            msNew.Dispose();
            return msNew.ToArray();
        }

        public static byte[] SerializerStream(MemoryStream ms)
        {
            byte[] buffer = ms.GetBuffer();
            using (MemoryStream msNew = new MemoryStream())
            using (GZipStream gz = new GZipStream(msNew, CompressionMode.Compress, true))  //创建压缩对象  
            {
                gz.Write(buffer, 0, buffer.Length);//把压缩后的数据写入文件  
                //gz.Close();//关闭压缩流,这里要注意：一定要关闭，要不然解压缩的时候会出现小于4K的文件读取不到数据，大于4K的文件读取不完整              
                //gz.Dispose();//释放对象  
                return msNew.GetBuffer();
            }
        }

        /// <summary>
        /// 解压缩并反序列化
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static object Deserialize(byte[] bytes)
        {
            MemoryStream msNew = new MemoryStream(bytes);
            msNew.Position = 0;
            GZipStream gzipStream = new GZipStream(msNew, CompressionMode.Decompress);//创建解压对象  
            byte[] buffer = new byte[4096];//定义数据缓冲  
            int offset = 0;//定义读取位置  
            MemoryStream ms = new MemoryStream();//定义内存流  
            while ((offset = gzipStream.Read(buffer, 0, buffer.Length)) != 0)
            {
                ms.Write(buffer, 0, offset);//解压后的数据写入内存流  
            }
            BinaryFormatter sfFormatter = new BinaryFormatter();//定义BinaryFormatter以反序列化object对象  
            ms.Position = 0;//设置内存流的位置  
            object obj;

            try
            {
                obj = (object)sfFormatter.Deserialize(ms);//反序列化  
            }
            catch
            {
                throw;
            }
            finally
            {
                ms.Close();//关闭内存流  
                ms.Dispose();//释放资源  
            }

            gzipStream.Close();//关闭解压缩流  
            gzipStream.Dispose();//释放资源  
            msNew.Close();
            msNew.Dispose();
            return obj;
        }

        public static MemoryStream DeserializeStream(byte[] bytes)
        {
            int offset = 0;
            byte[] buffer = new byte[4096];
            MemoryStream ms = new MemoryStream();
            using (MemoryStream msNew = new MemoryStream(bytes))
            using (GZipStream gzipStream = new GZipStream(msNew, CompressionMode.Decompress))
            {
                msNew.Position = 0;
                while ((offset = gzipStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    ms.Write(buffer, 0, offset);//解压后的数据写入内存流  
                }
            }
            return ms;
        }

        /// <summary>    
        /// 将对象序列化并压缩后保存到磁盘    
        /// </summary>    
        public static void SaveToDisk(object obj,string fileName = "data.bin")
        {
            string pathName = GetSerDir();
            string fullPath = pathName + fileName;
            FileStream fs = null;
            try
            {
                if (!Directory.Exists(pathName))
                    Directory.CreateDirectory(pathName);
                byte[] bytes = Serializer(obj);
                fs = new FileStream(fullPath, FileMode.Create);
                fs.Write(bytes, 0, bytes.Length);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        /// <summary>    
        /// 从磁盘加载Cookie    
        /// </summary>    
        public static object LoadFromDisk(string fileName = "data.bin")
        {
            object obj;

            string pathName = GetSerDir() + fileName;

            if (!File.Exists(pathName))
                return null;
            FileStream fs = null;
            try
            {
                fs = new FileStream(pathName, FileMode.Open, FileAccess.Read, FileShare.Read);
                byte[] buffer = new byte[4096];//定义数据缓冲  
                int offset = 0;//定义读取位置  
                MemoryStream ms = new MemoryStream();//定义内存流  
                while ((offset = fs.Read(buffer, 0, buffer.Length)) != 0)
                {
                    ms.Write(buffer, 0, offset);//解压后的数据写入内存流  
                }
                byte[] bytes = ms.ToArray();
                ms.Close();//关闭内存流  
                ms.Dispose();//释放资源  
                obj = Deserialize(bytes);
                return obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fs != null) fs.Close(); fs.Dispose();
            }
        }

        public static string ZipString(string unCompressedString)
        {
            byte[] bytData = System.Text.Encoding.UTF8.GetBytes(unCompressedString);
            MemoryStream ms = new MemoryStream();
            Stream s = new GZipStream(ms, CompressionMode.Compress);
            s.Write(bytData, 0, bytData.Length);
            s.Close();
            byte[] compressedData = (byte[])ms.ToArray();
            return System.Convert.ToBase64String(compressedData, 0, compressedData.Length);
        }

        public static string UnzipString(string unCompressedString)
        {
            System.Text.StringBuilder uncompressedString = new System.Text.StringBuilder();
            byte[] writeData = new byte[4096];

            byte[] bytData = System.Convert.FromBase64String(unCompressedString);
            int totalLength = 0;
            int size = 0;

            Stream s = new GZipStream(new MemoryStream(bytData), CompressionMode.Decompress);
            while (true)
            {
                size = s.Read(writeData, 0, writeData.Length);
                if (size > 0)
                {
                    totalLength += size;
                    uncompressedString.Append(System.Text.Encoding.UTF8.GetString(writeData, 0, size));
                }
                else
                {
                    break;
                }
            }
            s.Close();
            return uncompressedString.ToString();
        }

        public static string GetCurProcessDir()
        {
            string path = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            int index = path.LastIndexOf("\\");
            path = path.Substring(0, index);
            return path + "\\";
        }
    }

}
