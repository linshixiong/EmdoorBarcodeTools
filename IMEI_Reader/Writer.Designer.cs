namespace IMEI_Reader
{
    partial class Writer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Writer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabelBt = new System.Windows.Forms.LinkLabel();
            this.linkLabelWifi = new System.Windows.Forms.LinkLabel();
            this.linkLabelIMEI = new System.Windows.Forms.LinkLabel();
            this.linkLabelSN = new System.Windows.Forms.LinkLabel();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxBt = new System.Windows.Forms.CheckBox();
            this.checkBoxWifi = new System.Windows.Forms.CheckBox();
            this.checkBoxIMEI = new System.Windows.Forms.CheckBox();
            this.checkBoxSN = new System.Windows.Forms.CheckBox();
            this.textBoxBt = new System.Windows.Forms.TextBox();
            this.textBoxWifi = new System.Windows.Forms.TextBox();
            this.textBoxIMEI = new System.Windows.Forms.TextBox();
            this.textBoxSN = new System.Windows.Forms.TextBox();
            this.buttonWrite = new System.Windows.Forms.Button();
            this.labelMsg = new System.Windows.Forms.Label();
            this.panelProgress = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panelProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelProgress);
            this.groupBox1.Controls.Add(this.linkLabelBt);
            this.groupBox1.Controls.Add(this.linkLabelWifi);
            this.groupBox1.Controls.Add(this.linkLabelIMEI);
            this.groupBox1.Controls.Add(this.linkLabelSN);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.checkBoxBt);
            this.groupBox1.Controls.Add(this.checkBoxWifi);
            this.groupBox1.Controls.Add(this.checkBoxIMEI);
            this.groupBox1.Controls.Add(this.checkBoxSN);
            this.groupBox1.Controls.Add(this.textBoxBt);
            this.groupBox1.Controls.Add(this.textBoxWifi);
            this.groupBox1.Controls.Add(this.textBoxIMEI);
            this.groupBox1.Controls.Add(this.textBoxSN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "烧写项";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // linkLabelBt
            // 
            this.linkLabelBt.AutoSize = true;
            this.linkLabelBt.Location = new System.Drawing.Point(371, 206);
            this.linkLabelBt.Name = "linkLabelBt";
            this.linkLabelBt.Size = new System.Drawing.Size(29, 12);
            this.linkLabelBt.TabIndex = 5;
            this.linkLabelBt.TabStop = true;
            this.linkLabelBt.Tag = "4";
            this.linkLabelBt.Text = "配置";
            this.linkLabelBt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelWifi
            // 
            this.linkLabelWifi.AutoSize = true;
            this.linkLabelWifi.Location = new System.Drawing.Point(371, 147);
            this.linkLabelWifi.Name = "linkLabelWifi";
            this.linkLabelWifi.Size = new System.Drawing.Size(29, 12);
            this.linkLabelWifi.TabIndex = 5;
            this.linkLabelWifi.TabStop = true;
            this.linkLabelWifi.Tag = "3";
            this.linkLabelWifi.Text = "配置";
            this.linkLabelWifi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelIMEI
            // 
            this.linkLabelIMEI.AutoSize = true;
            this.linkLabelIMEI.Location = new System.Drawing.Point(371, 92);
            this.linkLabelIMEI.Name = "linkLabelIMEI";
            this.linkLabelIMEI.Size = new System.Drawing.Size(29, 12);
            this.linkLabelIMEI.TabIndex = 5;
            this.linkLabelIMEI.TabStop = true;
            this.linkLabelIMEI.Tag = "2";
            this.linkLabelIMEI.Text = "配置";
            this.linkLabelIMEI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // linkLabelSN
            // 
            this.linkLabelSN.AutoSize = true;
            this.linkLabelSN.Location = new System.Drawing.Point(371, 32);
            this.linkLabelSN.Name = "linkLabelSN";
            this.linkLabelSN.Size = new System.Drawing.Size(29, 12);
            this.linkLabelSN.TabIndex = 5;
            this.linkLabelSN.TabStop = true;
            this.linkLabelSN.Tag = "1";
            this.linkLabelSN.Text = "配置";
            this.linkLabelSN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(32, 280);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(72, 16);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.Text = "自动烧写";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "BT MAC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "WIFI MAC:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "IMEI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "S/N:";
            // 
            // checkBoxBt
            // 
            this.checkBoxBt.AutoSize = true;
            this.checkBoxBt.Checked = true;
            this.checkBoxBt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBt.Location = new System.Drawing.Point(350, 206);
            this.checkBoxBt.Name = "checkBoxBt";
            this.checkBoxBt.Size = new System.Drawing.Size(15, 14);
            this.checkBoxBt.TabIndex = 2;
            this.checkBoxBt.UseVisualStyleBackColor = true;
            this.checkBoxBt.CheckedChanged += new System.EventHandler(this.checkBoxBt_CheckedChanged);
            // 
            // checkBoxWifi
            // 
            this.checkBoxWifi.AutoSize = true;
            this.checkBoxWifi.Checked = true;
            this.checkBoxWifi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxWifi.Location = new System.Drawing.Point(350, 147);
            this.checkBoxWifi.Name = "checkBoxWifi";
            this.checkBoxWifi.Size = new System.Drawing.Size(15, 14);
            this.checkBoxWifi.TabIndex = 2;
            this.checkBoxWifi.UseVisualStyleBackColor = true;
            this.checkBoxWifi.CheckedChanged += new System.EventHandler(this.checkBoxWifi_CheckedChanged);
            // 
            // checkBoxIMEI
            // 
            this.checkBoxIMEI.AutoSize = true;
            this.checkBoxIMEI.Checked = true;
            this.checkBoxIMEI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIMEI.Location = new System.Drawing.Point(350, 92);
            this.checkBoxIMEI.Name = "checkBoxIMEI";
            this.checkBoxIMEI.Size = new System.Drawing.Size(15, 14);
            this.checkBoxIMEI.TabIndex = 2;
            this.checkBoxIMEI.UseVisualStyleBackColor = true;
            this.checkBoxIMEI.CheckedChanged += new System.EventHandler(this.checkBoxIMEI_CheckedChanged);
            // 
            // checkBoxSN
            // 
            this.checkBoxSN.AutoSize = true;
            this.checkBoxSN.Checked = true;
            this.checkBoxSN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSN.Location = new System.Drawing.Point(350, 32);
            this.checkBoxSN.Name = "checkBoxSN";
            this.checkBoxSN.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSN.TabIndex = 2;
            this.checkBoxSN.UseVisualStyleBackColor = true;
            this.checkBoxSN.CheckedChanged += new System.EventHandler(this.checkBoxSN_CheckedChanged);
            // 
            // textBoxBt
            // 
            this.textBoxBt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxBt.Location = new System.Drawing.Point(83, 203);
            this.textBoxBt.MaxLength = 120;
            this.textBoxBt.Name = "textBoxBt";
            this.textBoxBt.Size = new System.Drawing.Size(260, 21);
            this.textBoxBt.TabIndex = 1;
            this.textBoxBt.TextChanged += new System.EventHandler(this.textBoxWifi_TextChanged);
            this.textBoxBt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxBt_KeyDown);
            this.textBoxBt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWifi_KeyPress);
            // 
            // textBoxWifi
            // 
            this.textBoxWifi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxWifi.Location = new System.Drawing.Point(83, 144);
            this.textBoxWifi.MaxLength = 120;
            this.textBoxWifi.Name = "textBoxWifi";
            this.textBoxWifi.Size = new System.Drawing.Size(260, 21);
            this.textBoxWifi.TabIndex = 1;
            this.textBoxWifi.TextChanged += new System.EventHandler(this.textBoxWifi_TextChanged);
            this.textBoxWifi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxWifi_KeyDown);
            this.textBoxWifi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWifi_KeyPress);
            // 
            // textBoxIMEI
            // 
            this.textBoxIMEI.Location = new System.Drawing.Point(83, 89);
            this.textBoxIMEI.MaxLength = 15;
            this.textBoxIMEI.Name = "textBoxIMEI";
            this.textBoxIMEI.Size = new System.Drawing.Size(260, 21);
            this.textBoxIMEI.TabIndex = 1;
            this.textBoxIMEI.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxIMEI_KeyDown);
            // 
            // textBoxSN
            // 
            this.textBoxSN.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxSN.Location = new System.Drawing.Point(83, 29);
            this.textBoxSN.MaxLength = 32;
            this.textBoxSN.Name = "textBoxSN";
            this.textBoxSN.Size = new System.Drawing.Size(260, 21);
            this.textBoxSN.TabIndex = 0;
            this.textBoxSN.TextChanged += new System.EventHandler(this.textBoxSN_TextChanged);
            this.textBoxSN.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSN_KeyDown);
            this.textBoxSN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSN_KeyPress);
            // 
            // buttonWrite
            // 
            this.buttonWrite.Location = new System.Drawing.Point(362, 340);
            this.buttonWrite.Name = "buttonWrite";
            this.buttonWrite.Size = new System.Drawing.Size(75, 23);
            this.buttonWrite.TabIndex = 1;
            this.buttonWrite.Text = "烧写";
            this.buttonWrite.UseVisualStyleBackColor = true;
            this.buttonWrite.Click += new System.EventHandler(this.buttonWrite_Click);
            // 
            // labelMsg
            // 
            this.labelMsg.AutoSize = true;
            this.labelMsg.Location = new System.Drawing.Point(12, 351);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(41, 12);
            this.labelMsg.TabIndex = 2;
            this.labelMsg.Text = "label5";
            // 
            // panelProgress
            // 
            this.panelProgress.Controls.Add(this.label5);
            this.panelProgress.Controls.Add(this.pictureBox1);
            this.panelProgress.Location = new System.Drawing.Point(212, 257);
            this.panelProgress.Name = "panelProgress";
            this.panelProgress.Size = new System.Drawing.Size(188, 39);
            this.panelProgress.TabIndex = 11;
            this.panelProgress.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "正在写入...";
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
            // Writer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 375);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.buttonWrite);
            this.Controls.Add(this.groupBox1);
            this.Name = "Writer";
            this.Text = "串号烧录器";
            this.Load += new System.EventHandler(this.Writer_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Writer_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelProgress.ResumeLayout(false);
            this.panelProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxBt;
        private System.Windows.Forms.CheckBox checkBoxWifi;
        private System.Windows.Forms.CheckBox checkBoxIMEI;
        private System.Windows.Forms.CheckBox checkBoxSN;
        private System.Windows.Forms.TextBox textBoxBt;
        private System.Windows.Forms.TextBox textBoxWifi;
        private System.Windows.Forms.TextBox textBoxIMEI;
        private System.Windows.Forms.TextBox textBoxSN;
        private System.Windows.Forms.Button buttonWrite;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.LinkLabel linkLabelBt;
        private System.Windows.Forms.LinkLabel linkLabelWifi;
        private System.Windows.Forms.LinkLabel linkLabelIMEI;
        private System.Windows.Forms.LinkLabel linkLabelSN;
        private System.Windows.Forms.Panel panelProgress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}