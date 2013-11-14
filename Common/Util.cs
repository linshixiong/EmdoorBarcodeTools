#region License

// Droid Manager - An Android Phone Tools Suite
// Copyright (C) 2011
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

#endregion

using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace Common
{
    public static class Util
    {

        /// <summary>
        /// 运行CMD命令
        /// </summary>
        /// <param name="cmd">命令</param>
        /// <returns></returns>
        public static string Cmd(string cmd, string param)
        {
            Process proc = new Process();
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false; //此属性必须设置成false 
            proc.StartInfo.RedirectStandardOutput = true;// 此属性必须设置成true 

            proc.StartInfo.FileName = cmd;
            proc.StartInfo.Arguments = param;

            proc.Start();

            string output = proc.StandardOutput.ReadToEnd();
            return output;
        }

        public static bool IsVenderSupport(int vid)
        {

            string str_vids = "0x18d1,0x04e8".ToUpper();// Settings.Default.vid_list.ToUpper();
            string [] array =str_vids.Split(',');
            if (array != null && array.Length > 0)
            {
                List<string>  vid_list = new List<string>(array);
                string str_vid ="0X"+ vid.ToString("X4").ToUpper();
                return vid_list.Contains(str_vid);
            }
            return false;
        }

        public static bool IsProcessOpen(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsHexString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }
            string pstr = "^[0-9a-fA-F]*$";
            bool match = Regex.IsMatch(str, pstr);
            return match;

        }
        public static string[] GetResult(string str)
        {
            if (str != null&&str.Contains("[")&&str.Contains("]"))
            {
                string [] result = new string[2];

                string value = str.Substring(1,str.IndexOf("]")-1);
                string msg=str.Substring(str.IndexOf("]")+1);
                result[0] = value;
                result[1] = msg;
                return result;
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// 将字符串转换成ASCII编码，16进制表示
        /// </summary>
        /// <returns></returns>
        public static string ConvertStringToASCII(string source, bool addSeparator)
        {
            if (string.IsNullOrEmpty(source))
            {
                return null;
            }
            byte[] ba = System.Text.ASCIIEncoding.Default.GetBytes(source);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in ba)
            {
                if (addSeparator)
                {
                    sb.Append(b.ToString("X") + ":");
                }
                else
                {
                    sb.Append(b.ToString("X")); 
                }
            }
            if (addSeparator)
            {
                return sb.ToString().Trim(':');
            }
            else
            {
                return sb.ToString();
            }

        }

        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="source"></param>
        /// <param name="trimLastChar"></param>
        /// <returns></returns>
        public static string ConvertASCIIToString(string source, bool containSeparator)
        {
            if (string.IsNullOrEmpty(source))
            {
                return null;
            }

            if (containSeparator)
            {

                string[] temp = source.Split(':');
                if (temp != null)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (string s in temp)
                    {
                        if (s.Length == 2)
                        {
                            byte b = Convert.ToByte(s, 16);
                            char c = (char)b;
                            if (c != '\0')
                            {
                                sb.Append(c);
                            }
                        }
                    }
                    return sb.ToString();
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                byte[] data = new byte[source.Length % 2];

                try
                {
                    for (int index = 0; index < source.Length; index += 2)
                    {
                        String s= source.Substring(index, 2);
                        byte b = Convert.ToByte(s, 16);
                        char c = (char)b;
                        if (c != '\0')
                        {
                            sb.Append(c);
                        }

                    }
                }
                catch (Exception ex)
                {
                }
                return sb.ToString();

            }
            return null;
        }

        /// <summary>
        /// 判断输入的字符串是否符合格式（XX:XX:XX）
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool IsResultString(string result)
        {
           
            if (string.IsNullOrEmpty(result))
            {
                return false;
            }
            string[] temp = result.Split(':');
            string pstr = "^[0-9a-fA-F]{2,2}$";
           
            foreach (string s in temp)
            {
               
                bool match = Regex.IsMatch(s, pstr);
                if (!match)
                {
                    return false;
                }

            }

            return true;
        }

        //默认密钥向量
        private static byte[] Keys = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xAB, 0xCD, 0xEF };

        private static string encryptKey = "xrt87_?>";

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        public static string EncryptDES(string encryptString)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey);
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Convert.FromBase64String(decryptString);
                DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Encoding.UTF8.GetString(mStream.ToArray());
            }
            catch
            {
                return decryptString;
            }
        }

        public static string GetStringFromMixData(byte[] buff)
        {
            if (buff == null)
            {
                return null;
            }
            for (int index = 0; index < buff.Length; index++)
            {
                byte b = buff[index];

                buff[index] = b -= 128;  
            }
            string str = Encoding.ASCII.GetString(buff);
            return str;
        }

        public static byte[] GetDataAfterMix(string input)
        {
            byte[] buff = Encoding.ASCII.GetBytes(input);

            for (int index = 0; index < buff.Length; index++)
            {
                byte b = buff[index];
               
                buff[index] = b += 128;
                char c = (char)buff[index];
            }
            return buff;
        }

        public static String CalculateIMEI(String header, String sn)
        {
            String imeiString = header + sn;

            return imeiString + GetIMEICheckDigit(imeiString);
        }



        public static char GetIMEICheckDigit(String imei)
        {
            int i;
            int sum1 = 0, sum2 = 0, total = 0;
            int temp = 0;

            for (i = 0; i < 14; i++)
            {
                if ((i % 2) == 0)
                {
                    sum1 = sum1 + imei[i] - '0';
                }
                else
                {
                    temp = (imei[i] - '0') * 2;
                    if (temp < 10)
                    {
                        sum2 = sum2 + temp;
                    }
                    else
                    {
                        sum2 = sum2 + 1 + temp - 10;
                    }
                }
            }

            total = sum1 + sum2;

            if ((total % 10) == 0)
            {
                return '0';
            }
            else
            {
                return (char)(((total / 10) * 10) + 10 - total + '0');
            }
        }

    }
}