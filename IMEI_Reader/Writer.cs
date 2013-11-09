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
    public partial class Writer : Form
    {
        private MessageHandler mHandler;
        private DeviceDetector detetor;
        private int deviceCount;

        public Writer()
        {
            InitializeComponent();
            mHandler = new MessageHandler(this.HandleMessge);
            detetor = new DeviceDetector(mHandler, this);
            this.UpdateUI();
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
                case Messages.MSG_WRITE_START:


                    checkBoxSN.Enabled = false;
                    checkBoxIMEI.Enabled = false;
                    checkBoxWifi.Enabled = false;
                    checkBoxBt.Enabled = false;
                    buttonWrite.Enabled = false;


                    break;
                case Messages.MSG_WRITE_STATE_CHANGE:

                    break;
                case Messages.MSG_WRITE_SUCCESS:
                    checkBoxSN.Enabled = true;
                    checkBoxIMEI.Enabled = true;
                    checkBoxWifi.Enabled = true;
                    checkBoxBt.Enabled = true;
                    buttonWrite.Enabled = true;
                    MessageBox.Show("烧写成功！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case Messages.MSG_WRITE_FAIL:
                    
                    checkBoxSN.Enabled = true;
                    checkBoxIMEI.Enabled = true;
                    checkBoxWifi.Enabled = true;
                    checkBoxBt.Enabled = true;
                    buttonWrite.Enabled = true;
                    errorMsg = obj.ToString();
                    MessageBox.Show(errorMsg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    break;
            }
        }


        private void UpdateUI()
        {
            textBoxSN.Clear();
            textBoxIMEI.Clear();
            textBoxWifi.Clear();
            textBoxBt.Clear();
           
            if (deviceCount <= 0)
            {
                labelMsg.Text = "请连接设备";
                labelMsg.ForeColor = Color.Red;

                buttonWrite.Enabled = false;
            }
            else if (deviceCount == 1)
            {
                labelMsg.Text = "设备已连接";
                labelMsg.ForeColor = Color.Green;
                buttonWrite.Enabled = true;
               
            }
            else
            {
                labelMsg.Text = "连接设备过多";
                labelMsg.ForeColor = Color.Red;

                buttonWrite.Enabled = false;
            }

        }

        private void textBoxSN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxIMEI.Enabled)
                {
                    textBoxIMEI.Focus();
                }
                else if (textBoxWifi.Enabled)
                {
                    textBoxWifi.Focus();
                }
                else if (textBoxBt.Enabled)
                {
                    textBoxBt.Focus();
                }
                else
                {
                    CheckAndStartWrite();
                }


            }
        }

        private void textBoxIMEI_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 if (textBoxWifi.Enabled)
                {
                    textBoxWifi.Focus();
                }
                else if (textBoxBt.Enabled)
                {
                    textBoxBt.Focus();
                }
                else
                {
                    CheckAndStartWrite();
                }
            }
        }

        private void textBoxWifi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBoxBt.Enabled)
                {
                    textBoxBt.Focus();
                }
                else
                {
                    CheckAndStartWrite();
                }
            }
        }

        private void textBoxBt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAndStartWrite();
            }
        }



        private void CheckAndStartWrite()
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

           
            Write(codes);
            return;

        ERROR:
            {
                MessageBox.Show("请确保选择的项中包含有效的数据！", "无效的数据", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Write(List<KeyValuePair<int, string>> codes)
        {
            AdbOperator ao = new AdbOperator(mHandler, this);
            Thread thread = new Thread(new ParameterizedThreadStart(ao.StartExcuteWriteCmd));
            thread.Start(codes);
        }




        private void checkBoxSN_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSN.Enabled = checkBoxSN.Checked;
            textBoxSN.BackColor = checkBoxSN.Checked ? Color.White : System.Drawing.SystemColors.Control;
            linkLabelSN.Visible = checkBoxSN.Checked;
        }

        private void checkBoxIMEI_CheckedChanged(object sender, EventArgs e)
        {
            textBoxIMEI.Enabled = checkBoxIMEI.Checked;
            textBoxIMEI.BackColor = checkBoxIMEI.Checked ? Color.White : System.Drawing.SystemColors.Control;
            linkLabelIMEI.Visible = checkBoxIMEI.Checked;
        }

        private void checkBoxWifi_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWifi.Enabled = checkBoxWifi.Checked;
            textBoxWifi.BackColor = checkBoxWifi.Checked ? Color.White : System.Drawing.SystemColors.Control;
            linkLabelWifi.Visible = checkBoxWifi.Checked;
        }

        private void checkBoxBt_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBt.Enabled = checkBoxBt.Checked;
            textBoxBt.BackColor = checkBoxBt.Checked ? Color.White : System.Drawing.SystemColors.Control;
            linkLabelBt.Visible = checkBoxBt.Checked;
        }

        private void Writer_FormClosed(object sender, FormClosedEventArgs e)
        {
            detetor.RemoveUSBEventWatcher();

            this.Dispose();
            Environment.Exit(0);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int tag =Convert.ToInt32( ((LinkLabel)sender).Tag);

            WriterConfig config = new WriterConfig();
            config.Tag = tag;
            config.ShowDialog();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            this.CheckAndStartWrite();
        }

 
    }
}
