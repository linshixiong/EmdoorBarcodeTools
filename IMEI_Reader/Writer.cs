using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IMEI_Reader
{
    public partial class Writer : Form
    {
        public Writer()
        {
            InitializeComponent();
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
                    Write();
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
                    Write();
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
                    Write();
                }
            }
        }

        private void textBoxBt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Write();
            }
        }



        private void Write()
        {
            MessageBox.Show("write");
        }




        private void checkBoxSN_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSN.Enabled = checkBoxSN.Checked;
            textBoxSN.BackColor = checkBoxSN.Checked ? Color.White : System.Drawing.SystemColors.Control;
        }

        private void checkBoxIMEI_CheckedChanged(object sender, EventArgs e)
        {
            textBoxIMEI.Enabled = checkBoxIMEI.Checked;
            textBoxIMEI.BackColor = checkBoxIMEI.Checked ? Color.White : System.Drawing.SystemColors.Control;
        }

        private void checkBoxWifi_CheckedChanged(object sender, EventArgs e)
        {
            textBoxWifi.Enabled = checkBoxWifi.Checked;
            textBoxWifi.BackColor = checkBoxWifi.Checked ? Color.White : System.Drawing.SystemColors.Control;
        }

        private void checkBoxBt_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBt.Enabled = checkBoxBt.Checked;
            textBoxBt.BackColor = checkBoxBt.Checked ? Color.White : System.Drawing.SystemColors.Control;
        }

 
    }
}
