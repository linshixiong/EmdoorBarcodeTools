using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;
using System.Threading;

namespace IMEI_Reader
{
    public partial class Printer : Form
    {

        private MessageHandler mHandler;
        private DeviceDetector detetor;
        private int deviceCount;
        public Printer()
        {
            InitializeComponent();
            mHandler = new MessageHandler(this.HandleMessge);
            detetor = new DeviceDetector(mHandler, this);
            this.UpdateUI();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            checkBoxAutoRead.Checked = Settings.Default.Auto_Read;
            checkBoxAutoPrint.Checked = Settings.Default.AutoPrint;

            this.checkBoxSN.Checked = Settings.Default.SN_Selected;
            textBoxSN.Enabled = checkBoxSN.Checked;
            textBoxSN.BackColor = checkBoxSN.Checked ? Color.White :  System.Drawing.SystemColors.Control;
            
            this.checkBoxIMEI.Checked = Settings.Default.IMEI_Selected;

            textBoxIMEI.Enabled = checkBoxIMEI.Checked;
            textBoxIMEI.BackColor = checkBoxIMEI.Checked ? Color.White :  System.Drawing.SystemColors.Control;
            
            this.checkBoxWifi.Checked = Settings.Default.WIFI_Selected;
            textBoxWifi.Enabled = checkBoxWifi.Checked;
            textBoxWifi.BackColor = checkBoxWifi.Checked ? Color.White :  System.Drawing.SystemColors.Control;
        
            this.checkBoxBt.Checked = Settings.Default.BT_Selected;
            textBoxBt.Enabled = checkBoxBt.Checked;
            textBoxBt.BackColor = checkBoxBt.Checked ? Color.White :  System.Drawing.SystemColors.Control;

            this.checkBoxSwVersion.Checked = Settings.Default.Sw_Version_Selected;
            textBoxSwVersion.Enabled = checkBoxSwVersion.Checked;
            textBoxSwVersion.BackColor = checkBoxSwVersion.Checked ? Color.White :  System.Drawing.SystemColors.Control;

            textBoxPrintCount.Text = Settings.Default.PrintCount.ToString();
        }

        public void HandleMessge(int msgId, object obj)
        {
            string errorMsg = null;
            switch (msgId)
            {
                case Messages.MSG_UPDATE_DEVICE_COUNT:
                    this.deviceCount = Convert.ToInt32(obj);

                    this.UpdateUI();
                    break;

                case Messages.MSG_READ_START:

                    panelProgress.Visible = true;
                    buttonRefresh.Enabled = false;

                    checkBoxSN.Enabled = false;
                    checkBoxIMEI.Enabled = false;
                    checkBoxWifi.Enabled = false;
                    checkBoxBt.Enabled = false;
                    checkBoxSwVersion.Enabled = false;
                  
                    break;
                case Messages.MSG_READ_STATE_CHANGE:
                   
                    break;
                case Messages.MSG_READ_SUCCESS:

                    Dictionary<int, string> result = (Dictionary<int,string>)obj;

                    if (checkBoxSN.Checked)
                    {
                        textBoxSN.Text = result[CodeType.TYPE_SN];
                    }
                    if (checkBoxIMEI.Checked)
                    {
                        textBoxIMEI.Text = result[CodeType.TYPE_IMEI];
                    }

                    if (checkBoxWifi.Checked)
                    {
                        textBoxWifi.Text = result[CodeType.TYPE_WIFI_MAC];
                    }
                    if (checkBoxBt.Checked)
                    {
                        textBoxBt.Text = result[CodeType.TYPE_BT_MAC];
                    }
                    if (checkBoxSwVersion.Checked)
                    {
                        textBoxSwVersion.Text = result[CodeType.TYPE_SW_VERSION];

                    }
                    panelProgress.Visible = false;
                    buttonRefresh.Enabled = true;

                    checkBoxSN.Enabled = true;
                    checkBoxIMEI.Enabled = true;
                    checkBoxWifi.Enabled = true;
                    checkBoxBt.Enabled = true;
                    checkBoxSwVersion.Enabled = true;

                    if (checkBoxAutoPrint.Checked)
                    {

                        CheckAndStartPrint();
                    }

                    break;
                case Messages.MSG_READ_FAIL:
                    panelProgress.Visible = false;
                    buttonRefresh.Enabled = true;
                    checkBoxSN.Enabled = true;
                    checkBoxIMEI.Enabled = true;
                    checkBoxWifi.Enabled = true;
                    checkBoxBt.Enabled = true;
                    checkBoxSwVersion.Enabled = true;
                    errorMsg=obj.ToString();
                    MessageBox.Show(errorMsg,"错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                default :
                    break;
            }
        }


        private void UpdateUI()
        {
            textBoxSN.Clear();
            textBoxIMEI.Clear();
            textBoxWifi.Clear();
            textBoxBt.Clear();
            textBoxSwVersion.Clear();
            if (deviceCount <= 0)
            {
                labelMsg.Text = "请连接设备";
                labelMsg.ForeColor = Color.Red;
              
                buttonRefresh.Enabled = false;
            }
            else if (deviceCount == 1)
            {
                labelMsg.Text = "设备已连接";
                labelMsg.ForeColor = Color.Green;
                buttonRefresh.Enabled = true;
                if (checkBoxAutoRead.Checked)
                {
                    ReadAll(true);
                }
            }
            else
            {
                labelMsg.Text = "连接设备过多";
                labelMsg.ForeColor = Color.Red;

                buttonRefresh.Enabled = false;
            }

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            detetor.RemoveUSBEventWatcher();
            AdbOperator.CleanUpAdbProcess();
            this.Dispose();
            Environment.Exit(0);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            ReadAll(false);
        }




        private void ReadAll(bool auto)
        {
            textBoxSN.Clear();
            textBoxIMEI.Clear();
            textBoxWifi.Clear();
            textBoxBt.Clear();
            textBoxSwVersion.Clear();


            List<int> cmds = new List<int>();
            if (checkBoxSN.Checked)
            {
                cmds.Add(CodeType.TYPE_SN);
            }
            if (checkBoxIMEI.Checked)
            {
                cmds.Add(CodeType.TYPE_IMEI);
            }
            if (checkBoxWifi.Checked)
            {
                cmds.Add(CodeType.TYPE_WIFI_MAC);
            }
            if (checkBoxBt.Checked)
            {
                cmds.Add(CodeType.TYPE_BT_MAC);
            }
            if (checkBoxSwVersion.Checked)
            {
                cmds.Add(CodeType.TYPE_SW_VERSION);
            }

            if (cmds.Count == 0)
            {

                if (!auto)
                {
                    MessageBox.Show("请至少选择上面的一项以便进行读取操作！", "无效操作", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }
            AdbOperator ao = new AdbOperator(mHandler, this);
            Thread thread = new Thread(new ParameterizedThreadStart(ao.StartExcuteReadCmd));
            thread.Start(cmds);
        }


        private void CheckAndStartPrint()
        {
            List<KeyValuePair<int, string>> codes = new List<KeyValuePair<int, string>>();
            int count = Settings.Default.PrintCount;
            if (checkBoxSN.Checked)
            {
                if (string.IsNullOrEmpty(textBoxSN.Text.Trim()))
                {
                    goto ERROR;
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        codes.Add(new KeyValuePair<int, string>(CodeType.TYPE_SN, textBoxSN.Text.Trim()));
                    }

                }
            }
            if (checkBoxIMEI.Checked)
            {
                if (string.IsNullOrEmpty(textBoxIMEI.Text.Trim()))
                {
                    goto ERROR;
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        codes.Add(new KeyValuePair<int, string>(CodeType.TYPE_IMEI, textBoxIMEI.Text.Trim()));
                    }
                }
            }

            if (checkBoxWifi.Checked)
            {
                if (string.IsNullOrEmpty(textBoxWifi.Text.Trim()))
                {
                    goto ERROR;
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        codes.Add(new KeyValuePair<int, string>(CodeType.TYPE_WIFI_MAC, textBoxWifi.Text.Trim()));
                    }
                }
            }

            if (checkBoxBt.Checked)
            {
                if (string.IsNullOrEmpty(textBoxBt.Text.Trim()))
                {
                    goto ERROR;
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        codes.Add(new KeyValuePair<int, string>(CodeType.TYPE_BT_MAC, textBoxBt.Text.Trim()));
                    }
                }
            }

            if (checkBoxSwVersion.Checked)
            {
                if (string.IsNullOrEmpty(textBoxSwVersion.Text.Trim()))
                {
                    goto ERROR;
                }
                else
                {
                    for (int i = 0; i < count; i++)
                    {
                        codes.Add(new KeyValuePair<int, string>(CodeType.TYPE_SW_VERSION, textBoxSwVersion.Text.Trim()));
                    }
                }
            }

            if (codes.Count == 0)
            {
                goto ERROR;
            }

            print(codes);
            return;

        ERROR:
            {
                MessageBox.Show("请确保选择的项中包含有效的数据！", "无效的数据", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {

            CheckAndStartPrint();

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

            TextBox textBox = (TextBox)sender;



            if (string.IsNullOrEmpty(textBox.Text.Trim()) || string.IsNullOrEmpty(textBox.Text.Trim()))
            {
                buttonPrint.Enabled = false;

            }
            else
            {
                buttonPrint.Enabled = true;
            }
        }

 


        private void checkBoxSN_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.SN_Selected = checkBoxSN.Checked;
            Settings.Default.Save();

            textBoxSN.Enabled = checkBoxSN.Checked;
            textBoxSN.BackColor = checkBoxSN.Checked ? Color.White :  System.Drawing.SystemColors.Control;
            

        }

        private void checkBoxIMEI_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.IMEI_Selected = checkBoxIMEI.Checked;
            Settings.Default.Save();

            textBoxIMEI.Enabled = checkBoxIMEI.Checked;
            textBoxIMEI.BackColor = checkBoxIMEI.Checked ? Color.White :  System.Drawing.SystemColors.Control;
        }

        private void checkBoxWifi_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.WIFI_Selected = checkBoxWifi.Checked;
            Settings.Default.Save();
            textBoxWifi.Enabled = checkBoxWifi.Checked;
            textBoxWifi.BackColor = checkBoxWifi.Checked ? Color.White :  System.Drawing.SystemColors.Control;
        }

        private void checkBoxBt_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.BT_Selected = checkBoxBt.Checked;
            Settings.Default.Save();
            textBoxBt.Enabled = checkBoxBt.Checked;
            textBoxBt.BackColor = checkBoxBt.Checked ? Color.White :  System.Drawing.SystemColors.Control;
        }

        private void checkBoxSwVersion_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Sw_Version_Selected = checkBoxSwVersion.Checked;
            Settings.Default.Save();

            textBoxSwVersion.Enabled = checkBoxSwVersion.Checked;
            textBoxSwVersion.BackColor = checkBoxSwVersion.Checked ? Color.White :  System.Drawing.SystemColors.Control;
        }



        private void linkLabelPrinterConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrinterConfig config = new PrinterConfig();
            config.ShowDialog();
        }





        private void print(List<KeyValuePair<int, string>> codes)
        {

            int count = Convert.ToInt32(textBoxPrintCount.Text);
            int labelColumnCount = Settings.Default.LabelColumn;
            float labelGap = Settings.Default.LabelGap;
            int row_count = count / labelColumnCount;
            int remainder = count % labelColumnCount;


            TSCLib.openport(Settings.Default.Printer);


            //打印机参数
            string l_width = (Settings.Default.LabelWidth * labelColumnCount + labelGap * (labelColumnCount - 1)).ToString();
            string l_height = (Settings.Default.LabelHeight + labelGap).ToString();
            string p_speed = Settings.Default.PrintSpeed.ToString();
            string p_density = Settings.Default.PrintDensity.ToString();
            string p_sensor = Settings.Default.Sensor.ToString();
            string p_vertical = Settings.Default.Vertical.ToString();
            string p_offset = Settings.Default.Offset.ToString();

            //设置打印机

            TSCLib.setup(l_width, l_height, p_speed, p_density, p_sensor, p_vertical, p_offset);
            TSCLib.clearbuffer();


            for (int i = 0; i < codes.Count; i++)
            {

                KeyValuePair<int, string> item = codes[i];
                int key = item.Key;
                string code = item.Value;
                string label = getBarcodeLabel(key) + code;

                //字体样式
                int t_x = Settings.Default.T_X;

                //计算打印位置
                int labelIndex = i % labelColumnCount;

                if (labelIndex > 0)
                {
                    t_x = 30 * 12 * labelIndex + 2 * 12 * labelIndex + t_x;
                }

                int t_y = Settings.Default.T_Y;
                int t_height = Settings.Default.T_H;
                int t_rotation = Settings.Default.T_R;
                int t_font_style = Settings.Default.T_S;
                int t_under_line = Settings.Default.T_L;

                //条码样式
                string b_y = (t_y + t_height + Settings.Default.Gap1).ToString();
                string b_height = Settings.Default.B_Height.ToString();
                string b_readable = Settings.Default.B_Readable.ToString();
                string b_rotation = Settings.Default.B_Rotation.ToString();
                string b_narrow = Settings.Default.B_Narrow.ToString();
                string b_wide = Settings.Default.B_Wide.ToString();


                //打印字符    
                TSCLib.windowsfont(t_x, t_y, t_height, 0, t_font_style, t_under_line, "Times new Roman", label);

                //打印条码
                TSCLib.barcode(t_x.ToString(), b_y, "128", b_height, b_readable, "0", b_narrow, b_wide, code);

                if (labelIndex + 1 == labelColumnCount || i == codes.Count - 1)
                {
                    TSCLib.printlabel("1", "1");
                    TSCLib.clearbuffer();
                }

            }



            //for (int index = 0; index < count; index++)
            //{
            //    //字体样式
            //    int t_x = Settings.Default.T_X;
            //    int t_y = Settings.Default.T_Y;
            //    int t_height = Settings.Default.T_H;
            //    int t_rotation = Settings.Default.T_R;
            //    int t_font_style = Settings.Default.T_S;
            //    int t_under_line = Settings.Default.T_L;

            //    //条码样式
            //    string b_y = (t_y + t_height + Settings.Default.Gap1).ToString();
            //    string b_height = Settings.Default.B_Height.ToString();
            //    string b_readable = Settings.Default.B_Readable.ToString();
            //    string b_rotation = Settings.Default.B_Rotation.ToString();
            //    string b_narrow = Settings.Default.B_Narrow.ToString();
            //    string b_wide = Settings.Default.B_Wide.ToString();

            //    /*
            //    if (index > 0)
            //    {
            //        t_x = 30 * 12 * index + 2 * 12 * index + t_x;
            //    }*/

            //    string sn = textBoxSN.Text;


            //    //打印SN字符    
            //    TSCLib.windowsfont(t_x, t_y, t_height, 0, t_font_style, t_under_line, "Times new Roman", "S/N:" + sn);


            //    //打印SN条码
            //    TSCLib.barcode(t_x.ToString(), b_y, "128", b_height, b_readable, "0", b_narrow, b_wide, sn);

            //    TSCLib.printlabel("1", "1");
            //    /*
            //    string imei = textBoxIMEI.Text;

            //    //打印IMEI字符
            //    t_y = Convert.ToInt32(b_y) + Settings.Default.B_Height + Settings.Default.Gap2;
            //    TSCLib.windowsfont(t_x, t_y, t_height, 0, t_font_style, t_under_line, "Times new Roman", "IMEI:" + imei);
            //    b_y = (t_y + t_height + Settings.Default.Gap1).ToString();
            //    TSCLib.barcode(t_x.ToString(), b_y, "128", b_height, b_readable, "0", b_narrow, b_wide, imei);*/
            //}



            TSCLib.closeport();
            TSCLib.formfeed();
        }

        private void checkBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.Auto_Read = checkBoxAutoRead.Checked;
            Settings.Default.Save();
        }

        private void textBoxPrintCount_TextChanged(object sender, EventArgs e)
        {
            Settings.Default.PrintCount = Convert.ToInt32(textBoxPrintCount.Text);
            Settings.Default.Save();
        }

        private void textBoxPrintCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字键，也不是回车键、Backspace键，则取消该输入
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            } 
        }

        private void checkBoxAutoPrint_CheckedChanged(object sender, EventArgs e)
        {
            Settings.Default.AutoPrint = checkBoxAutoPrint.Checked;
            Settings.Default.Save();
        }


        private string getBarcodeLabel(int codeType)
        {
            switch (codeType)
            {
                
                case CodeType.TYPE_SN:
                    return "S/N:";
                case CodeType.TYPE_IMEI:
                    return "IMEI:";
                case CodeType.TYPE_WIFI_MAC:
                    return "WIFI MAC:";
                case CodeType.TYPE_BT_MAC:
                    return "Bluetooth MAC:";
                case CodeType.TYPE_SW_VERSION:
                    return "SW Version:";
                default:
                    return "Unknown:";
                    
            }
        }

        private void linkLabelUsbConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsbConfig usbConfig = new UsbConfig();
            if (usbConfig.ShowDialog() == DialogResult.OK)
            {
                detetor.updateDeviceCount();
            }
        }

    }
}
