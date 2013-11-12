using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;

namespace IMEI_Reader
{
    public partial class UsbConfig : Form
    {
        public UsbConfig()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*
            if (MessageBox.Show("是否保存设置的参数？", "保存参数", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK)
            {
                return;
            }*/
            Settings.Default.USB_VID = Convert.ToInt32(textBoxVID.Text.Trim(), 16);
            Settings.Default.USB_PID = Convert.ToInt32(textBoxPID.Text.Trim(), 16);
            Settings.Default.USB_MI = Convert.ToInt32(textBoxMI.Text.Trim(), 16);
            Settings.Default.Save();
            DeviceDetector.vid = Settings.Default.USB_VID;
            DeviceDetector.pid = Settings.Default.USB_PID;
            DeviceDetector.mi = Settings.Default.USB_MI;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否将参数复位到默认值？", "复位", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.OK)
            {
                return;
            }

            Settings.Default.USB_VID = 0x0BB4;
            Settings.Default.USB_PID = 0x4E4A;
            Settings.Default.USB_MI =5;
            DeviceDetector.vid = Settings.Default.USB_VID;
            DeviceDetector.pid = Settings.Default.USB_PID;
            DeviceDetector.mi = Settings.Default.USB_MI;
            textBoxVID.Text = Settings.Default.USB_VID.ToString("X4");
            textBoxPID.Text = Settings.Default.USB_PID.ToString("X4");
            textBoxMI.Text = Settings.Default.USB_MI.ToString("X2");
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (e.KeyChar == '\b')
            {
                return;
            }
            
            else
            {
                e.Handled = "0123456789ABCDEF".IndexOf(char.ToUpper(e.KeyChar)) < 0;
            }
        }

        private void UsbConfig_Load(object sender, EventArgs e)
        {
            textBoxVID.Text = Settings.Default.USB_VID.ToString("X4");
            textBoxPID.Text = Settings.Default.USB_PID.ToString("X4");
            textBoxMI.Text = Settings.Default.USB_MI.ToString("X2");
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVID.Text.Length == 4 && textBoxPID.Text.Length == 4 && textBoxMI.Text.Length == 2)
            {
                buttonSave.Enabled = true;
            }
            else
            {

                buttonSave.Enabled = false;
            }
        }

       

   
    }
}
