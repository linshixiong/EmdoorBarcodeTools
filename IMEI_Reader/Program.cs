using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Common;

namespace IMEI_Reader
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DeviceDetector.vid = Settings.Default.USB_VID;
            DeviceDetector.pid = Settings.Default.USB_PID;
            DeviceDetector.mi = Settings.Default.USB_MI;

            if (args != null && args.Length > 0)
            {
                if ("write".Equals(args[0]))
                {
                    Application.Run(new Writer());
                    return;
                }
                if ("usb_config".Equals(args[0]))
                {
                    Application.Run(new UsbConfig());
                    return;
                }
            }

            Application.Run(new Printer());
        }
    }
}
