using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Common;

namespace IMEI_Reader
{
    public partial class WriterConfig : Form
    {

        private int source ;
        private int inputType;

        public WriterConfig()
        {
            InitializeComponent();

            

        }

        private void WriterConfig_Load(object sender, EventArgs e)
        {
            this.source = Convert.ToInt32(this.Tag);
            this.inputType = getInputType(source);

            initUI();
        }

        private void initUI()
        {

            switch (inputType)
            {
                case 0:
                    radioButton_0.Checked = true;
                    break;
                case 1:
                    radioButton_1.Checked = true;

                    break;
                case 2:
                    radioButton_2.Checked = true;
                    break;
                default:
                    radioButton_0.Checked = true;
                    break;
            }

        }


        private int getInputType(int source)
        {
            switch (source)
            {
                case CodeType.TYPE_SN:
                    return Settings.Default.InputSNType;
                case CodeType.TYPE_IMEI:
                    return Settings.Default.InputIMEIType;
                case CodeType.TYPE_WIFI_MAC:
                    return Settings.Default.InputWIFIType;
                case CodeType.TYPE_BT_MAC:
                    return Settings.Default.InputBTType;
                default:
                    return Settings.Default.InputSNType;
            }
        }

        private void setInputType(int source, int inputType)
        {
            switch (source)
            {
                case CodeType.TYPE_SN:
                     Settings.Default.InputSNType=inputType;
                     break;
                case CodeType.TYPE_IMEI:
                      Settings.Default.InputIMEIType = inputType;
                      break;
                case CodeType.TYPE_WIFI_MAC:
                      Settings.Default.InputWIFIType = inputType;
                      break;
                case CodeType.TYPE_BT_MAC:
                      Settings.Default.InputBTType = inputType;
                      break;
                default:
                      Settings.Default.InputSNType = inputType;
                      break;
                     

            }
            Settings.Default.Save();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }



        private bool CheckHexInput()
        {
            string min = textBoxMin.Text.Trim();
            string max = textBoxMax.Text.Trim();
            string current = textBoxCurrent.Text.Trim();

            //bool isHex = Util.IsHexString("ABCD123456");
            int length = 12;

            if (min.Length != length)
            {
                MessageBox.Show("最小值必须为"+length+"位","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
            }
            if (max.Length != length )
            {
                MessageBox.Show("最大值必须为" + length + "位", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (current.Length > 0 && current.Length != length)
            {
                MessageBox.Show("当前值必须为" + length + "位", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!Util.IsHexString(min) )
            {
                MessageBox.Show("最小值必须为十六进制格式", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!Util.IsHexString(max))
            {
                MessageBox.Show("最大值必须为十六进制格式", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (current.Length>0&&!Util.IsHexString(current))
            {
                MessageBox.Show("当前值必须为十六进制格式", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (max.CompareTo(min) <= 0)
            {
                MessageBox.Show("最大值必须大于最小值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (current.Length > 0)
            {
                if (current.CompareTo(min) < 0||current.CompareTo(max)>0)
                {
                    MessageBox.Show("当前值必须在最小值与最大值之间", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
            return true;
        }

        private bool CheckSNInput()
        {
            string min = textBoxMin.Text.Trim();
            string max = textBoxMax.Text.Trim();
            string current = textBoxCurrent.Text.Trim();


            if (min.Length == 0 || max.Length == 0)
            {
                MessageBox.Show("最小值与最大值不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            char endChar = min[min.Length - 1];
            if (!Char.IsDigit(endChar))
            {
                MessageBox.Show("最小值必须以数字结尾", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            endChar = max[max.Length - 1];
            if (!Char.IsDigit(endChar))
            {
                MessageBox.Show("最大值必须以数字结尾", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (current.Length > 0)
            {
                endChar = current[current.Length - 1];
                if (!Char.IsDigit(endChar))
                {
                    MessageBox.Show("当前值必须以数字结尾", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }


            if (min.Length != max.Length)
            {
                MessageBox.Show("最小值与最大值长度必须相等", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (current.Length > 0 && current.Length != min.Length)
            {
                MessageBox.Show("当前值长度无效", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (max.CompareTo(min) <= 0)
            {
                MessageBox.Show("最大值必须大于最小值", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (current.Length > 0)
            {
                if (current.CompareTo(min) < 0 || current.CompareTo(max) > 0)
                {
                    MessageBox.Show("当前值必须在最小值与最大值之间", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            }
           

            return true;
        }


        private bool CheckIMEIInput()
        {
            return false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            setInputType(source, inputType);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }



        //private void textBox_TextChanged(object sender, EventArgs e)
        //{

        //    if (!radioButton_1.Checked)
        //    {
        //        return;
        //    }
        //    TextBox textBox = (TextBox)sender;
        //    /*
        //    if (config.ConfigType != DataType.SN)
        //    {

        //        textBox.Text = textBox.Text.Replace(":", "").Trim();

        //        if (!Util.IsHexString(textBox.Text))
        //        {
        //            textBox.Clear();
        //        }
        //    }*/
        //    if (textBoxMax.Text.Length == 0 || textBoxMin.Text.Length == 0)
        //    {
        //        buttonSave.Enabled = false;
        //    }
        //    else
        //    {
        //        buttonSave.Enabled = true;
        //    }

        //}


        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            int maxLength = 12;

            if (source == CodeType.TYPE_IMEI)
            {
                maxLength = 14;
            }
            else if (source == CodeType.TYPE_SN)
            {
                maxLength = 32;
            }


            if (textBox.Text.Length >= maxLength && e.KeyChar != '\b')
            {
                e.Handled = true;
            }

            else if (e.KeyChar != '\b')
            {
                if (source == CodeType.TYPE_IMEI)
                {
                    e.Handled = "0123456789".IndexOf(char.ToUpper(e.KeyChar)) < 0;
                }
                else
                {
                    e.Handled = "0123456789ABCDEF".IndexOf(char.ToUpper(e.KeyChar)) < 0;
                }
               
            }

        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
           


        }


        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            if (radioButton.Checked)
            {
                this.inputType = Convert.ToInt32(radioButton.Tag);

                groupBox1.Visible = inputType == 1;
                groupBox2.Visible = inputType == 2;
                if (inputType == 0)
                {
                    buttonSave.Enabled = true;
                }
                else if (inputType == 1)
                {
                    if (string.IsNullOrEmpty(textBoxMin.Text) || string.IsNullOrEmpty(textBoxMax.Text))
                    {
                        buttonSave.Enabled = false;
                    }
                }

                

            }
        }

        private void textBoxMin_TextChanged(object sender, EventArgs e)
        {
           
            

        }

        private void textBoxMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCurrent_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
