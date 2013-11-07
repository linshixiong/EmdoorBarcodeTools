
using System;
using System.Management;

namespace Common
{

    /// <summary>
    /// 监视USB插拔
    /// </summary>
    public partial class WMIUsbQuery
    {
        /// <summary>
        /// USB插入事件监视
        /// </summary>
        private ManagementEventWatcher insertWatcher = null;

        /// <summary>
        /// USB拔出事件监视
        /// </summary>
        private ManagementEventWatcher removeWatcher = null;

        /// <summary>
        /// 添加USB事件监视器
        /// </summary>
        /// <param name="usbInsertHandler">USB插入事件处理器</param>
        /// <param name="usbRemoveHandler">USB拔出事件处理器</param>
        /// <param name="withinInterval">发送通知允许的滞后时间</param>
        public Boolean AddUSBEventWatcher(EventArrivedEventHandler usbInsertHandler, EventArrivedEventHandler usbRemoveHandler, TimeSpan withinInterval)
        {
            try
            {
                ManagementScope Scope = new ManagementScope("root\\CIMV2");
                Scope.Options.EnablePrivileges = true;

                // USB插入监视
                if (usbInsertHandler != null)
                {
                    WqlEventQuery InsertQuery = new WqlEventQuery("__InstanceCreationEvent",
                        withinInterval,
                        "TargetInstance isa 'Win32_USBControllerDevice'");

                    insertWatcher = new ManagementEventWatcher(Scope, InsertQuery);
                    insertWatcher.EventArrived += usbInsertHandler;
                    insertWatcher.Start();
                }

                // USB拔出监视
                if (usbRemoveHandler != null)
                {
                    WqlEventQuery RemoveQuery = new WqlEventQuery("__InstanceDeletionEvent",
                        withinInterval,
                        "TargetInstance isa 'Win32_USBControllerDevice'");

                    removeWatcher = new ManagementEventWatcher(Scope, RemoveQuery);
                    removeWatcher.EventArrived += usbRemoveHandler;
                    removeWatcher.Start();
                }

                return true;
            }

            catch (Exception)
            {
                RemoveUSBEventWatcher();
                return false;
            }
        }

        /// <summary>
        /// 移去USB事件监视器
        /// </summary>
        public void RemoveUSBEventWatcher()
        {
            if (insertWatcher != null)
            {
                insertWatcher.Stop();
                insertWatcher = null;
            }

            if (removeWatcher != null)
            {
                removeWatcher.Stop();
                removeWatcher = null;
            }
        }


        public static int GetDeviceCount()
        {
            string pid = "4E16";// Configurator.Instance.ReadConfig(Configurator.CONFIG_KEY_PID);
            string pid2 = "4E4A";
            string vid = "0BB4";// Configurator.Instance.ReadConfig(Configurator.CONFIG_KEY_VID);
            string VIDPID = "'%VID[_]" + vid + "&PID[_]" + pid + "&MI[_]" + "05" + "%'";
            string VIDPID2 = "'%VID[_]" + vid + "&PID[_]" + pid2 + "&MI[_]" + "05" + "%'";

            ManagementObjectCollection PnPEntityCollection = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE DeviceID LIKE " + VIDPID + " or DeviceID LIKE "+VIDPID2).Get();
            return PnPEntityCollection == null ? 0 : PnPEntityCollection.Count;

        }
    }
}
