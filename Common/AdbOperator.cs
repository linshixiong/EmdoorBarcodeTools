using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using Managed.Adb;
using System.Threading;
using System.IO;

namespace Common
{
    public class AdbOperator
    {
        private static string adbFilePath = string.Format("{0}tools\\adb.exe", AppDomain.CurrentDomain.BaseDirectory);

        public const int CMD_READ_SN = 0x01;
        public const int CMD_READ_IMEI = 0x02;
        public const int CMD_READ_WIFI_MAC = 0x03;
        public const int CMD_READ_BT_MAC = 0x04;
        public const int CMD_READ_SW_VERSION = 0x05;

        private MessageHandler handler;
      
        private Form form;

        private bool isCanceled = false;


        public void CancelThread()
        {
            this.isCanceled = true;
        }

        public bool Canceled
        {

            get
            {
                return isCanceled;
            }
        }


        public AdbOperator(MessageHandler handler, Form form)
        {
            this.handler = handler;
            this.form = form;
        }

        /// <summary>
        ///启动adb进程
        /// </summary>
        public static bool StartAdbProcess()
        {
            bool result = true;
            try
            {
                if (Util.IsProcessOpen("adb"))
                {
                    CleanUpAdbProcess();
                }

                Process p = new Process();
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.FileName = adbFilePath;
                p.StartInfo.Arguments = "devices";
                p.Start();


            }
            catch (Exception e)
            {
                result = false;
            }
            return result;

        }


        public static void CleanUpAdbProcess(object o)
        {
            CleanUpAdbProcess();
        }

        /// <summary>
        /// 结束adb进程
        /// </summary>
        public static void CleanUpAdbProcess()
        {
            Process[] procs = Process.GetProcessesByName("adb");
            foreach (var item in procs)
            {
                try
                {
                    item.Kill();
                }
                catch { }
            }
        }


        /// <summary>
        /// 读取IMEI
        /// </summary>
        /// <param name="o"></param>
        public void StartReadIMEI(object o)
        {
            form.Invoke(handler, Messages.MSG_READ_SN_START, null);
            bool success = true;
            string error_msg = null;
            if (!StartAdbProcess())
            {
                error_msg = "adb进程启动失败";
                success = false;
            }
            if (isCanceled)
            {
                goto END;
            }
            try
            {
                AndroidDebugBridge.Initialize(true);
                AndroidDebugBridge.CreateBridge();
                AndroidDebugBridge.Instance.Start();
            }

            catch (Exception)
            {
                error_msg = "adb服务启动失败";
                success = false;
            }
            if (isCanceled)
            {
                goto END;
            }
            if (success)
            {
                form.Invoke(handler, Messages.MSG_READ_SN_STATE_CHANGE, "正在检查设备...");
                int deviceCount = GetDeviceCount();


                if (isCanceled)
                {
                    goto END;
                }
                if (deviceCount == 0)
                {
                    //无设备
                    error_msg = "未找到adb设备，确保设备已连接并请重试";
                    success = false;
                }
                else if (deviceCount > 1)
                {
                    //太多设备
                    error_msg = "无法对大于1台设备进行烧录，请拔除多余的设备";
                    success = false;

                }
                else
                {
                    form.Invoke(handler, Messages.MSG_READ_SN_STATE_CHANGE, "正在读取序列号...");
                    string cmdResult = null;
                    string snRead = ExcuteIMEIReadCmd(out cmdResult);
                    if (!string.IsNullOrEmpty(snRead))
                    {
                        form.Invoke(handler, Messages.MSG_READ_SN_SUCCESS, snRead);
                    }
                    else
                    {
                        error_msg = "序列号读取失败，序列号可能未烧写";
                        success = false;
                    }
                }
            }

        END:
            if (!success && !isCanceled)
            {
                form.Invoke(handler, Messages.MSG_READ_SN_FAIL, error_msg);
            }

            AndroidDebugBridge.Instance.Stop();
            CleanUpAdbProcess();
        }

     
       


        /// <summary>
        /// 读取IMEI
        /// </summary>
        /// <param name="o"></param>
        public void StartReadWifiAddress(object o)
        {
            form.Invoke(handler, Messages.MSG_READ_SN_START, null);
            bool success = true;
            string error_msg = null;
            if (!StartAdbProcess())
            {
                error_msg = "adb进程启动失败";
                success = false;
            }
            if (isCanceled)
            {
                goto END;
            }
            try
            {
                AndroidDebugBridge.Initialize(true);
                AndroidDebugBridge.CreateBridge();
                AndroidDebugBridge.Instance.Start();
            }

            catch (Exception)
            {
                error_msg = "adb服务启动失败";
                success = false;
            }
            if (isCanceled)
            {
                goto END;
            }
            if (success)
            {
                form.Invoke(handler, Messages.MSG_READ_SN_STATE_CHANGE, "正在检查设备...");
                int deviceCount = GetDeviceCount();


                if (isCanceled)
                {
                    goto END;
                }
                if (deviceCount == 0)
                {
                    //无设备
                    error_msg = "未找到adb设备，确保设备已连接并请重试";
                    success = false;
                }
                else if (deviceCount > 1)
                {
                    //太多设备
                    error_msg = "无法对大于1台设备进行烧录，请拔除多余的设备";
                    success = false;

                }
                else
                {
                    form.Invoke(handler, Messages.MSG_READ_SN_STATE_CHANGE, "正在读取序列号...");
                    string cmdResult = null;
                    string snRead = ExcuteSWVersionReadCmd(out cmdResult);

                    if (!string.IsNullOrEmpty(snRead))
                    {
                        form.Invoke(handler, Messages.MSG_READ_SN_SUCCESS, snRead);
                    }
                    else
                    {
                        error_msg = "序列号读取失败，序列号可能未烧写";
                        success = false;
                    }
                }
            }

        END:
            if (!success && !isCanceled)
            {
                form.Invoke(handler, Messages.MSG_READ_SN_FAIL, error_msg);
            }

            AndroidDebugBridge.Instance.Stop();
            CleanUpAdbProcess();
        }




        public void StartExcuteReadCmd(object o)
        {
            List<int> cmds = (List<int>)o;
            if (cmds == null || cmds.Count == 0)
            {
                return;
            }
            form.Invoke(handler, Messages.MSG_READ_SN_START, null);



            bool success = true;
            string error_msg = null;
            if (!StartAdbProcess())
            {
                error_msg = "adb进程启动失败";
                success = false;
            }
            if (isCanceled)
            {
                goto END;
            }
            try
            {
                AndroidDebugBridge.Initialize(true);
                AndroidDebugBridge.CreateBridge();
                AndroidDebugBridge.Instance.Start();
            }

            catch (Exception)
            {
                error_msg = "adb服务启动失败";
                success = false;
            }
            if (isCanceled)
            {
                goto END;
            }
            if (success)
            {
                form.Invoke(handler, Messages.MSG_READ_SN_STATE_CHANGE, "正在检查设备...");
                int deviceCount = GetDeviceCount();


                if (isCanceled)
                {
                    goto END;
                }
                if (deviceCount == 0)
                {
                    //无设备
                    error_msg = "未找到adb设备，确保设备已连接并请重试";
                    success = false;
                }
                else if (deviceCount > 1)
                {
                    //太多设备
                    error_msg = "无法对大于1台设备进行烧录，请拔除多余的设备";
                    success = false;

                }
                else
                {
                    form.Invoke(handler, Messages.MSG_READ_SN_STATE_CHANGE, "正在读取序列号...");
                    string cmdResult = null;
                    Dictionary<int, string> results = new Dictionary<int, string>();
                    foreach (int cmd in cmds)
                    {
                        switch (cmd)
                        {
                            case CMD_READ_SN:
                                string sn = ExcuteSNReadCmd(out cmdResult);
                                results.Add(CMD_READ_SN, sn);
                                break;
                            case CMD_READ_IMEI:
                                string imei = ExcuteIMEIReadCmd(out cmdResult);
                                results.Add(CMD_READ_IMEI, imei);
                                break;
                            case CMD_READ_WIFI_MAC:
                                string wifi = ExcuteWifiAddressReadCmd(out cmdResult);
                                results.Add(CMD_READ_WIFI_MAC, wifi);
                                break;
                            case CMD_READ_BT_MAC:
                                string bt = ExcuteBtAddressReadCmd(out cmdResult);
                                results.Add(CMD_READ_BT_MAC, bt);
                                break;
                            case CMD_READ_SW_VERSION:
                                string version = ExcuteSWVersionReadCmd(out cmdResult);
                                results.Add(CMD_READ_SW_VERSION, version);
                                break;
                            default:
                                break;
                        }

                    }

                    if (true)
                    {
                        form.Invoke(handler, Messages.MSG_READ_SN_SUCCESS, results);
                    }
                    else
                    {
                        error_msg = "序列号读取失败，序列号可能未烧写";
                        success = false;
                    }
                }
            }

        END:
            if (!success && !isCanceled)
            {
                form.Invoke(handler, Messages.MSG_READ_SN_FAIL, error_msg);
            }

            AndroidDebugBridge.Instance.Stop();
            CleanUpAdbProcess();

        }



        private string ExcuteIMEIReadCmd(out string error)
        {
            CommandResultReceiver receiver = new CommandResultReceiver();
            receiver.TrimLines = true;
            bool success;
            for (int i = 0; i <= 10; i++)
            {
                if (isCanceled)
                {
                    error = null;
                    return null;
                }
                success = true;
                try
                {
                    AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress)[0].ExecuteShellCommand("tcmd-subcase.sh read-mrd-imei", receiver);
                }
                catch (Exception)
                {
                    success = false;
                    Thread.Sleep(1000);
                }

                if (success)
                {
                    break;
                }

            }

            if (receiver.ResultLines != null && receiver.ResultLines.Length > 0)
            {
                string result = receiver.ResultLines[receiver.ResultLines.Length - 1];
                string imei = null;
                if (result.Contains("ret"))
                {
                    if (result.Contains("0"))
                    {
                        imei = receiver.ResultLines[0] ;
                    }
                }

                error = null;
                return imei;

            }

            else
            {
                error = null;
                return null;
            }

        }




        private string ExcuteWifiAddressReadCmd(out string error)
        {
            CommandResultReceiver receiver = new CommandResultReceiver();
            receiver.TrimLines = true;
            bool success;
            for (int i = 0; i <= 10; i++)
            {
                if (isCanceled)
                {
                    error = null;
                    return null;
                }
                success = true;
                try
                {
                    AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress)[0].ExecuteShellCommand("tcmd-subcase.sh  wifi-get-mac", receiver);
                }
                catch (Exception)
                {
                    success = false;
                    Thread.Sleep(1000);
                }

                if (success)
                {
                    break;
                }

            }

            if (receiver.ResultLines != null && receiver.ResultLines.Length > 0)
            {
                string result = receiver.ResultLines[receiver.ResultLines.Length - 1];
                string wifi = null;
                if (result.Contains("ret"))
                {
                    if (result.Contains("0"))
                    {
                        wifi = receiver.ResultLines[0].Replace(":", "").ToUpper(); ;
                    }
                }

                error = null;
                return wifi;
            }

            else
            {
                error = null;
                return null;
            }

        }



        private string ExcuteBtAddressReadCmd(out string error)
        {
            CommandResultReceiver receiver = new CommandResultReceiver();
            receiver.TrimLines = true;
            bool success;
            for (int i = 0; i <= 10; i++)
            {
                if (isCanceled)
                {
                    error = null;
                    return null;
                }
                success = true;
                try
                {
                    AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress)[0].ExecuteShellCommand("tcmd-subcase.sh  bt-get-mac", receiver);
                }
                catch (Exception)
                {
                    success = false;
                    Thread.Sleep(1000);
                }

                if (success)
                {
                    break;
                }

            }

            if (receiver.ResultLines != null && receiver.ResultLines.Length > 0)
            {
                string result = receiver.ResultLines[receiver.ResultLines.Length-1];
                string bt = null;
                if (result.Contains("ret"))
                {
                    if (result.Contains("0"))
                    {
                        bt = receiver.ResultLines[0].Replace(":", "").ToUpper(); ;
                    }
                }
      
                error = null;
                return bt;

            }

            else
            {
                error = null;
                return null;
            }

        }



        private string ExcuteSNReadCmd(out string error)
        {
            CommandResultReceiver receiver = new CommandResultReceiver();
            receiver.TrimLines = true;
            bool success;
            for (int i = 0; i <= 10; i++)
            {
                if (isCanceled)
                {
                    error = null;
                    return null;
                }
                success = true;
                try
                {
                    AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress)[0].ExecuteShellCommand("tcmd-subcase.sh   read-mrd-sn", receiver);
                }
                catch (Exception)
                {
                    success = false;
                    Thread.Sleep(1000);
                }

                if (success)
                {
                    break;
                }

            }

            if (receiver.ResultLines != null && receiver.ResultLines.Length > 1)
            {

                string result = receiver.ResultLines[receiver.ResultLines.Length-1];
                string sn = null;
                if (result.Contains("ret"))
                {
                    if (result.Contains("0"))
                    {
                        sn = receiver.ResultLines[1].Substring(receiver.ResultLines[1].LastIndexOf(',') + 1);
                    }
                }
                error = null;
                return sn;

            }

            else
            {
                error = null;
                return null;
            }

        }



        private string ExcuteSWVersionReadCmd(out string error)
        {
            CommandResultReceiver receiver = new CommandResultReceiver();
            receiver.TrimLines = true;
            bool success;
            for (int i = 0; i <= 10; i++)
            {
                if (isCanceled)
                {
                    error = null;
                    return null;
                }
                success = true;
                try
                {
                    AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress)[0].ExecuteShellCommand("getprop ro.build.display.id", receiver);
                }
                catch (Exception)
                {
                    success = false;
                    Thread.Sleep(1000);
                }

                if (success)
                {
                    break;
                }

            }

            if (receiver.ResultLines != null && receiver.ResultLines.Length > 0)
            {
                string result = receiver.ResultLines[0];


                String vesion = result;

                error = null;
                return vesion;

            }

            else
            {
                error = null;
                return null;
            }

        }


        private int GetDeviceCount()
        {
            bool success;
            int count = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (isCanceled)
                {
                    return 0;
                }
                success = true;
                try
                {

                    count = AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress).Count;
                }
                catch (Exception)
                {
                    success = false;
                    Thread.Sleep(1000);
                }
                if (success)
                {
                    break;
                }

            }

            return count;
        }

        
    }



}
