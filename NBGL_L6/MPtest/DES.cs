using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections; //使用Arraylist
using System.Security.Cryptography;//加密解密
using System.IO;
namespace MPtest
{
    public static class DES
    {
        /// <summary>
        /// 固定为 HuLiSoft，请不要修改
        /// </summary>
        private static string sKey = "HuLiSoft";

        /// <summary>
        /// 反转
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string ReverseString(string text)
        {
            return new string(text.ToCharArray().Reverse().ToArray());
        }
        /// <summary>
        /// DES加密
        /// </summary>
        /// <param name="pToEncrypt">加密字符串</param>
        /// <param name="sKey">密钥</param>
        /// <returns></returns>
        public static string string_Encrypt(string pToEncrypt)
        {
            if (pToEncrypt == "") return "";
            if (sKey.Length < 8) sKey = sKey + "dff54E5sdfs";
            if (sKey.Length > 8) sKey = sKey.Substring(0, 8);
            DESCryptoServiceProvider des = new DESCryptoServiceProvider();
            //把字符串放到byte数组中  
            //原来使用的UTF8编码，我改成Unicode编码了，不行  
            byte[] inputByteArray = Encoding.Default.GetBytes(pToEncrypt);
            //建立加密对象的密钥和偏移量  
            //原文使用ASCIIEncoding.ASCII方法的GetBytes方法  
            //使得输入密码必须输入英文文本  
            des.Key = ASCIIEncoding.UTF8.GetBytes(ReverseString(sKey));
            des.IV = ASCIIEncoding.UTF8.GetBytes(sKey);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(), CryptoStreamMode.Write);
            //Write  the  byte  array  into  the  crypto  stream  
            //(It  will  end  up  in  the  memory  stream)  
            cs.Write(inputByteArray, 0, inputByteArray.Length);
            cs.FlushFinalBlock();
            //Get  the  data  back  from  the  memory  stream,  and  into  a  string  
            StringBuilder ret = new StringBuilder();
            foreach (byte b in ms.ToArray())
            {
                //Format  as  hex  
                ret.AppendFormat("{0:X2}", b);
            }
            ret.ToString();

            return ret.ToString();
        }


        /// <summary>
        /// DES解密
        /// </summary>
        /// <param name="pToDecrypt">解密字符串</param>
        /// <param name="sKey">解密密钥</param>
        /// <param name="outstr">返回值</param>
        /// <returns></returns> 
        public static string string_Decrypt(string pToDecrypt)
        {
            string outstr = "";
            if (pToDecrypt == "")
            {

                return outstr;
            };
            if (sKey.Length < 8) sKey = sKey + "dff54E5sdfs";
            if (sKey.Length > 8) sKey = sKey.Substring(0, 8);
            try
            {
                DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                //Put  the  input  string  into  the  byte  array  
                byte[] inputByteArray = new byte[pToDecrypt.Length / 2];
                for (int x = 0; x < pToDecrypt.Length / 2; x++)
                {
                    int i = (Convert.ToInt32(pToDecrypt.Substring(x * 2, 2), 16));
                    inputByteArray[x] = (byte)i;
                }
                //建立加密对象的密钥和偏移量，此值重要，不能修改  
                des.Key = ASCIIEncoding.UTF8.GetBytes(ReverseString(sKey));
                des.IV = ASCIIEncoding.UTF8.GetBytes(sKey);
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(), CryptoStreamMode.Write);
                //Flush  the  data  through  the  crypto  stream  into  the  memory  stream  
                cs.Write(inputByteArray, 0, inputByteArray.Length);
                cs.FlushFinalBlock();
                //Get  the  decrypted  data  back  from  the  memory  stream  
                //建立StringBuild对象，CreateDecrypt使用的是流对象，必须把解密后的文本变成流对象  
                StringBuilder ret = new StringBuilder();
                outstr = System.Text.Encoding.UTF8.GetString(ms.ToArray());
                return outstr;
            }
            catch
            {

                outstr = "";
                return outstr;
            }
        }
    }
}
