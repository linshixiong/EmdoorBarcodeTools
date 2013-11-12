using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using System.Windows.Forms;
using System.Management;

namespace Common
{
    public class DeviceDetector
    {

        public static int pid=0x4E4A;
        public static int vid = 0x0BB4;
        public static int mi = 5;

        private int deviceCount;

        private WMIUsbQuery usbQuery;
        private MessageHandler handler;
        private Form form;

        public DeviceDetector(MessageHandler handler,Form form)
        {   
            this.handler = handler;
            this.form = form;
            usbQuery = new WMIUsbQuery();

            usbQuery.AddUSBEventWatcher(USBEventHandler, USBEventHandler, new TimeSpan(0, 0, 3));

            Thread thread = new Thread(new ParameterizedThreadStart(this.updateDeviceCount));
            thread.Start(null);


        }

        public void updateDeviceCount()
        {
            Thread thread = new Thread(new ParameterizedThreadStart(this.updateDeviceCount));
            thread.Start(null);
        }

        private void updateDeviceCount(object o)
        {
            deviceCount = WMIUsbQuery.GetDeviceCount();
            form.Invoke(handler, Messages.MSG_UPDATE_DEVICE_COUNT, deviceCount);
        }


        private void USBEventHandler(Object sender, EventArrivedEventArgs e)
        {
            if (e.NewEvent.ClassPath.ClassName == "__InstanceCreationEvent" || e.NewEvent.ClassPath.ClassName == "__InstanceDeletionEvent")
            {

                ManagementBaseObject mbo = e.NewEvent["TargetInstance"] as ManagementBaseObject;

                if (mbo != null && mbo.ClassPath.ClassName == "Win32_USBControllerDevice")
                {
                    String dependent = (mbo["Dependent"] as String).Split(new Char[] { '=' })[1];

                   // string VIDPID = "VID_" + vid.ToString("X4") + "&PID_" + pid.ToString("X4") + "&MI_" + mi.ToString("D2");

    
                    deviceCount = WMIUsbQuery.GetDeviceCount();
                    
                    form.Invoke(handler, Messages.MSG_UPDATE_DEVICE_COUNT, deviceCount);

                }
            }
        }
             
        public int DeviceCount
        {
            get
            {
                return deviceCount;

            }
        }



        public void RemoveUSBEventWatcher()
        {
            usbQuery.RemoveUSBEventWatcher();
        }

    }
}
