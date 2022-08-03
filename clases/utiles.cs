using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace f2
{
    class utiles
    {
        /// <summary>
        /// devuelve un md5
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static string GetMD5(string str)
        {
            MD5 md5 = MD5CryptoServiceProvider.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = md5.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        /// <summary>
        /// convierte objectos a byte[]
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            return ms.ToArray();
        }
        /// <summary>
        /// convierte byte[] a objeto
        /// </summary>
        /// <param name="arrBytes"></param>
        /// <returns></returns>
        private static Object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Object obj = (Object)binForm.Deserialize(memStream);
            return obj;
        }
        /// <summary>
        /// convierte byte[] a Base64
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static string byteToBase64(byte[] data)
        {
            char[] base64data = new char[(int)(Math.Ceiling((double)data.Length / 3) * 4)];
            Convert.ToBase64CharArray(data, 0, data.Length, base64data, 0);
            return new String(base64data);
        }
        /// <summary>
        /// convierte string a Base64
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static byte[] Base64ToByte(string data)
        {
            return Convert.FromBase64String(data);
        }
    }
}
