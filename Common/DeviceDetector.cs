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


               // Form form = this.form;

                if (mbo != null && mbo.ClassPath.ClassName == "Win32_USBControllerDevice")
                {
                    String dependent = (mbo["Dependent"] as String).Split(new Char[] { '=' })[1];
                    string pid ="4E16";//  Configurator.Instance.ReadConfig(Configurator.CONFIG_KEY_PID);
                    string pid2 = "4E4A";
                    string vid ="0BB4";// Configurator.Instance.ReadConfig(Configurator.CONFIG_KEY_VID);

                    //"USB\\VID_0BB4&PID_4E4A&MI_00\\7&10C8569B&0&0000"

                    string VIDPID = "VID_" + vid + "&PID_" + pid+ "&MI_" + "05";

                    String VIDPID2 = "VID_" + vid + "&PID_" + pid2 + "&MI_" + "05";

                    if (!dependent.Contains(VIDPID) && !dependent.Contains(VIDPID2))
                    {
                        return;
                    }

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
