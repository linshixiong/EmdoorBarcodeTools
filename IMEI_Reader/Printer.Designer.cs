namespace IMEI_Reader
{
    partial class Printer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Printer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxAutoPrint = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrintCount = new System.Windows.Forms.TextBox();
            this.linkLabelPrinterConfig = new System.Windows.Forms.LinkLabel();
            this.checkBoxSwVersion = new System.Windows.Forms.CheckBox();
            this.checkBoxBt = new System.Windows.Forms.CheckBox();
            this.checkBoxWifi = new System.Windows.Forms.CheckBox();
            this.checkBoxIMEI = new System.Windows.Forms.CheckBox();
            this.checkBoxSN = new System.Windows.Forms.CheckBox();
            this.textBoxSwVersion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxWifi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxAutoRead = new System.Windows.Forms.CheckBox();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.textBoxIMEI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelUsbConfig = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.panelProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxAutoPrint);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxPrintCount);
            this.groupBox1.Controls.Add(this.linkLabelUsbConfig);
            this.groupBox1.Controls.Add(this.linkLabelPrinterConfig);
            this.groupBox1.Controls.Add(this.checkBoxSwVersion);
            this.groupBox1.Controls.Add(this.checkBoxBt);
            this.groupBox1.Controls.Add(this.checkBoxWifi);
            this.groupBox1.Controls.Add(this.checkBoxIMEI);
            this.groupBox1.Controls.Add(this.checkBoxSN);
            this.groupBox1.Controls.Add(this.textBoxSwVersion);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxBt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxWifi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxAutoRead);
            this.groupBox1.Controls.Add(this.panelProgress);
            this.groupBox1.Controls.Add(this.buttonPrint);
            this.groupBox1.Controls.Add(this.labelMsg);
            this.groupBox1.Controls.Add(this.textBoxSN);
            this.groupBox1.Controls.Add(this.textBoxIMEI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 422);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "打印项";
            // 
            // checkBoxAutoPrint
            // 
            this.checkBoxAutoPrint.AutoSize = true;
            this.checkBoxAutoPrint.Checked = true;
            this.checkBoxAutoPrint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoPrint.Location = new System.Drawing.Point(133, 388);
            this.checkBoxAutoPrint.Name = "checkBoxAutoPrint";
            this.checkBoxAutoPrint.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAutoPrint.TabIndex = 22;
            this.checkBoxAutoPrint.Text = "自动打印";
            this.checkBoxAutoPrint.UseVisualStyleBackColor = true;
            this.checkBoxAutoPrint.CheckedChanged += new System.EventHandler(this.checkBoxAutoPrint_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(278, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "打印数量:";
            // 
            // textBoxPrintCount
            // 
            this.textBoxPrintCount.Location = new System.Drawing.Point(343, 328);
            this.textBoxPrintCount.Name = "textBoxPrintCount";
            this.textBoxPrintCount.Size = new System.Drawing.Size(22, 21);
            this.textBoxPrintCount.TabIndex = 20;
            this.textBoxPrintCount.Text = "3";
            this.textBoxPrintCount.TextChanged += new System.EventHandler(this.textBoxPrintCount_TextChanged);
            this.textBoxPrintCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPrintCount_KeyPress);
            // 
            // linkLabelPrinterConfig
            // 
            this.linkLabelPrinterConfig.AutoSize = true;
            this.linkLabelPrinterConfig.Location = new System.Drawing.Point(393, 314);
            this.linkLabelPrinterConfig.Name = "linkLabelPrinterConfig";
            this.linkLabelPrinterConfig.Size = new System.Drawing.Size(65, 12);
            this.linkLabelPrinterConfig.TabIndex = 19;
            this.linkLabelPrinterConfig.TabStop = true;
            this.linkLabelPrinterConfig.Text = "打印机配置";
            this.linkLabelPrinterConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelPrinterConfig_LinkClicked);
            // 
            // checkBoxSwVersion
            // 
            this.checkBoxSwVersion.AutoSize = true;
            this.checkBoxSwVersion.Location = new System.Drawing.Point(453, 276);
            this.checkBoxSwVersion.Name = "checkBoxSwVersion";
            this.checkBoxSwVersion.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSwVersion.TabIndex = 18;
            this.checkBoxSwVersion.UseVisualStyleBackColor = true;
            this.checkBoxSwVersion.CheckedChanged += new System.EventHandler(this.checkBoxSwVersion_CheckedChanged);
            // 
            // checkBoxBt
            // 
            this.checkBoxBt.AutoSize = true;
            this.checkBoxBt.Location = new System.Drawing.Point(453, 221);
            this.checkBoxBt.Name = "checkBoxBt";
            this.checkBoxBt.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBt.TabIndex = 18;
            this.checkBoxBt.UseVisualStyleBackColor = true;
            this.checkBoxBt.CheckedChanged += new System.EventHandler(this.checkBoxBt_CheckedChanged);
            // 
            // checkBoxWifi
            // 
            this.checkBoxWifi.AutoSize = true;
            this.checkBoxWifi.Location = new System.Drawing.Point(453, 155);
            this.checkBoxWifi.Name = "checkBoxWifi";
            this.checkBoxWifi.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWifi.TabIndex = 18;
            this.checkBoxWifi.UseVisualStyleBackColor = true;
            this.checkBoxWifi.CheckedChanged += new System.EventHandler(this.checkBoxWifi_CheckedChanged);
            // 
            // checkBoxIMEI
            // 
            this.checkBoxIMEI.AutoSize = true;
            this.checkBoxIMEI.Location = new System.Drawing.Point(453, 99);
            this.checkBoxIMEI.Name = "checkBoxIMEI";
            this.checkBoxIMEI.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIMEI.TabIndex = 18;
            this.checkBoxIMEI.UseVisualStyleBackColor = true;
            this.checkBoxIMEI.CheckedChanged += new System.EventHandler(this.checkBoxIMEI_CheckedChanged);
            // 
            // checkBoxSN
            // 
            this.checkBoxSN.AutoSize = true;
            this.checkBoxSN.Location = new System.Drawing.Point(453, 36);
            this.checkBoxSN.Name = "checkBoxSN";
            this.checkBoxSN.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSN.TabIndex = 17;
            this.checkBoxSN.UseVisualStyleBackColor = true;
            this.checkBoxSN.CheckedChanged += new System.EventHandler(this.checkBoxSN_CheckedChanged);
            // 
            // textBoxSwVersion
            // 
            this.textBoxSwVersion.BackColor = System.Drawing.Color.White;
            this.textBoxSwVersion.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSwVersion.Location = new System.Drawing.Point(76, 266);
            this.textBoxSwVersion.Name = "textBoxSwVersion";
            this.textBoxSwVersion.ReadOnly = true;
            this.textBoxSwVersion.Size = new System.Drawing.Size(371, 30);
            this.textBoxSwVersion.TabIndex = 16;
            this.textBoxSwVersion.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(23, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "版本号:";
            // 
            // textBoxBt
            // 
            this.textBoxBt.BackColor = System.Drawing.Color.White;
            this.textBoxBt.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBt.Location = new System.Drawing.Point(76, 211);
            this.textBoxBt.Name = "textBoxBt";
            this.textBoxBt.ReadOnly = true;
            this.textBoxBt.Size = new System.Drawing.Size(371, 30);
            this.textBoxBt.TabIndex = 14;
            this.textBoxBt.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(11, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "蓝牙地址:";
            // 
            // textBoxWifi
            // 
            this.textBoxWifi.BackColor = System.Drawing.Color.White;
            this.textBoxWifi.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxWifi.Location = new System.Drawing.Point(76, 145);
            this.textBoxWifi.Name = "textBoxWifi";
            this.textBoxWifi.ReadOnly = true;
            this.textBoxWifi.Size = new System.Drawing.Size(371, 30);
            this.textBoxWifi.TabIndex = 12;
            this.textBoxWifi.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(11, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "WIFI地址:";
            // 
            // checkBoxAutoRead
            // 
            this.checkBoxAutoRead.AutoSize = true;
            this.checkBoxAutoRead.Checked = true;
            this.checkBoxAutoRead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoRead.Location = new System.Drawing.Point(133, 366);
            this.checkBoxAutoRead.Name = "checkBoxAutoRead";
            this.checkBoxAutoRead.Size = new System.Drawing.Size(72, 16);
            this.checkBoxAutoRead.TabIndex = 1;
            this.checkBoxAutoRead.Text = "自动读取";
            this.checkBoxAutoRead.UseVisualStyleBackColor = true;
            this.checkBoxAutoRead.CheckedChanged += new System.EventHandler(this.checkBoxAuto_CheckedChanged);
            // 
            // panelProgress
            // 
            this.panelProgress.Controls.Add(this.label3);
            this.panelProgress.Controls.Add(this.pictureBox1);
            this.panelProgress.Location = new System.Drawing.Point(81, 314);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(188, 39);
            this.panelProgress.TabIndex = 10;
            this.panelProgress.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "正在读取...";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Enabled = false;
            this.buttonPrint.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPrint.Location = new System.Drawing.Point(343, 361);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(104, 43);
            this.buttonPrint.TabIndex = 3;
            this.buttonPrint.Text = "打印";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMsg.ForeColor = System.Drawing.Color.Black;
            this.labelMsg.Location = new System.Drawing.Point(22, 378);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(56, 16);
            this.labelMsg.TabIndex = 7;
            this.labelMsg.Text = "label3";
            // 
            // textBoxSN
            // 
            this.textBoxSN.BackColor = System.Drawing.Color.White;
            this.textBoxSN.Enabled = false;
            this.textBoxSN.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxSN.Location = new System.Drawing.Point(76, 26);
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.ReadOnly = true;
            this.textBoxSN.Size = new System.Drawing.Size(371, 30);
            this.textBoxSN.TabIndex = 5;
            this.textBoxSN.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxIMEI
            // 
            this.textBoxIMEI.BackColor = System.Drawing.Color.White;
            this.textBoxIMEI.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxIMEI.Location = new System.Drawing.Point(76, 89);
            this.textBoxIMEI.Name = "textBoxIMEI";
            this.textBoxIMEI.ReadOnly = true;
            this.textBoxIMEI.Size = new System.Drawing.Size(371, 30);
            this.textBoxIMEI.TabIndex = 5;
            this.textBoxIMEI.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(41, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "S/N:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(35, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "IMEI:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Enabled = false;
            this.buttonRefresh.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonRefresh.Location = new System.Drawing.Point(211, 361);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(108, 43);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "读取";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelUsbConfig
            // 
            this.linkLabelUsbConfig.AutoSize = true;
            this.linkLabelUsbConfig.Location = new System.Drawing.Point(393, 337);
            this.linkLabelUsbConfig.Name = "linkLabelUsbConfig";
            this.linkLabelUsbConfig.Size = new System.Drawing.Size(71, 12);
            this.linkLabelUsbConfig.TabIndex = 19;
            this.linkLabelUsbConfig.TabStop = true;
            this.linkLabelUsbConfig.Text = "USB连接配置";
            this.linkLabelUsbConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelUsbConfig_LinkClicked);
            // 
            // Printer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 445);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Printer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "条码打印程序";
            this.Load += new System.EventHandler(this.Main_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSN;
        private System.Windows.Forms.TextBox textBoxIMEI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxAutoRead;
        private System.Windows.Forms.TextBox textBoxBt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxWifi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSwVersion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxSwVersion;
        private System.Windows.Forms.CheckBox checkBoxBt;
        private System.Windows.Forms.CheckBox checkBoxWifi;
        private System.Windows.Forms.CheckBox checkBoxIMEI;
        private System.Windows.Forms.CheckBox checkBoxSN;
        private System.Windows.Forms.LinkLabel linkLabelPrinterConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrintCount;
        private System.Windows.Forms.CheckBox checkBoxAutoPrint;
        private System.Windows.Forms.LinkLabel linkLabelUsbConfig;
    }
}

