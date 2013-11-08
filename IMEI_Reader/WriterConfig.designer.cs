namespace IMEI_Reader
{
    partial class WriterConfig
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.textBoxMax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_1 = new System.Windows.Forms.RadioButton();
            this.radioButton_0 = new System.Windows.Forms.RadioButton();
            this.radioButton_2 = new System.Windows.Forms.RadioButton();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxTop.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCurrent);
            this.groupBox1.Controls.Add(this.textBoxMax);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxMin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 145);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "配置范围";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 5;
            this.label7.Text = "当前值：";
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxCurrent.Location = new System.Drawing.Point(88, 108);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.Size = new System.Drawing.Size(261, 21);
            this.textBoxCurrent.TabIndex = 2;
            this.textBoxCurrent.TextChanged += new System.EventHandler(this.textBoxCurrent_TextChanged);
            this.textBoxCurrent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // textBoxMax
            // 
            this.textBoxMax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMax.Location = new System.Drawing.Point(88, 69);
            this.textBoxMax.Name = "textBoxMax";
            this.textBoxMax.Size = new System.Drawing.Size(261, 21);
            this.textBoxMax.TabIndex = 2;
            this.textBoxMax.TextChanged += new System.EventHandler(this.textBoxMax_TextChanged);
            this.textBoxMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "最大值：";
            // 
            // textBoxMin
            // 
            this.textBoxMin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxMin.Location = new System.Drawing.Point(88, 28);
            this.textBoxMin.Name = "textBoxMin";
            this.textBoxMin.Size = new System.Drawing.Size(261, 21);
            this.textBoxMin.TabIndex = 1;
            this.textBoxMin.TextChanged += new System.EventHandler(this.textBoxMin_TextChanged);
            this.textBoxMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "最小值：";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(230, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(311, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "取消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(294, 91);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(75, 23);
            this.buttonImport.TabIndex = 9;
            this.buttonImport.Text = "导入";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonImport);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(5, 208);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(389, 127);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导入";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.Window;
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(88, 93);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(193, 21);
            this.textBox3.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "当前值：";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(88, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(193, 21);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "已使用：";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(88, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(193, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "数量：";
            // 
            // radioButton_1
            // 
            this.radioButton_1.AutoSize = true;
            this.radioButton_1.Location = new System.Drawing.Point(137, 16);
            this.radioButton_1.Name = "radioButton_1";
            this.radioButton_1.Size = new System.Drawing.Size(71, 16);
            this.radioButton_1.TabIndex = 10;
            this.radioButton_1.TabStop = true;
            this.radioButton_1.Tag = "1";
            this.radioButton_1.Text = "顺序递增";
            this.radioButton_1.UseVisualStyleBackColor = true;
            this.radioButton_1.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_0
            // 
            this.radioButton_0.AutoSize = true;
            this.radioButton_0.Location = new System.Drawing.Point(8, 16);
            this.radioButton_0.Name = "radioButton_0";
            this.radioButton_0.Size = new System.Drawing.Size(71, 16);
            this.radioButton_0.TabIndex = 10;
            this.radioButton_0.TabStop = true;
            this.radioButton_0.Tag = "0";
            this.radioButton_0.Text = "手动输入";
            this.radioButton_0.UseVisualStyleBackColor = true;
            this.radioButton_0.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // radioButton_2
            // 
            this.radioButton_2.AutoSize = true;
            this.radioButton_2.Enabled = false;
            this.radioButton_2.Location = new System.Drawing.Point(278, 16);
            this.radioButton_2.Name = "radioButton_2";
            this.radioButton_2.Size = new System.Drawing.Size(71, 16);
            this.radioButton_2.TabIndex = 10;
            this.radioButton_2.TabStop = true;
            this.radioButton_2.Tag = "2";
            this.radioButton_2.Text = "外部导入";
            this.radioButton_2.UseVisualStyleBackColor = true;
            this.radioButton_2.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.radioButton_0);
            this.groupBoxTop.Controls.Add(this.radioButton_2);
            this.groupBoxTop.Controls.Add(this.radioButton_1);
            this.groupBoxTop.Location = new System.Drawing.Point(5, 5);
            this.groupBoxTop.Margin = new System.Windows.Forms.Padding(5);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(388, 38);
            this.groupBoxTop.TabIndex = 11;
            this.groupBoxTop.TabStop = false;
            this.groupBoxTop.Text = "输入方式";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.groupBoxTop);
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(431, 484);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Location = new System.Drawing.Point(3, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 33);
            this.panel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IMEI_Reader.Properties.Resources.Warning;
            this.pictureBox1.Location = new System.Drawing.Point(355, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::IMEI_Reader.Properties.Resources.Warning;
            this.pictureBox2.Location = new System.Drawing.Point(355, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::IMEI_Reader.Properties.Resources.Warning;
            this.pictureBox3.Location = new System.Drawing.Point(355, 108);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // WriterConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(431, 484);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WriterConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "输入配置";
            this.Load += new System.EventHandler(this.WriterConfig_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxTop.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxMax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton_1;
        private System.Windows.Forms.RadioButton radioButton_0;
        private System.Windows.Forms.RadioButton radioButton_2;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCurrent;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}