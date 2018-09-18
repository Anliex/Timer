namespace Timer
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTime = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.rbZheng = new System.Windows.Forms.RadioButton();
            this.rbDao = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbAuto = new System.Windows.Forms.CheckBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTop = new System.Windows.Forms.CheckBox();
            this.cbTrans = new System.Windows.Forms.CheckBox();
            this.cbtrue = new System.Windows.Forms.CheckBox();
            this.btnBColor = new System.Windows.Forms.Button();
            this.btnFColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.s5 = new System.Windows.Forms.TextBox();
            this.s4 = new System.Windows.Forms.TextBox();
            this.s3 = new System.Windows.Forms.TextBox();
            this.s2 = new System.Windows.Forms.TextBox();
            this.s1 = new System.Windows.Forms.TextBox();
            this.m5 = new System.Windows.Forms.TextBox();
            this.m1 = new System.Windows.Forms.TextBox();
            this.m4 = new System.Windows.Forms.TextBox();
            this.m2 = new System.Windows.Forms.TextBox();
            this.m3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.rbZheng);
            this.panel1.Controls.Add(this.rbDao);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(842, 77);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(427, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 52);
            this.button2.TabIndex = 4;
            this.button2.Text = "热键设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTime);
            this.groupBox1.Controls.Add(this.txtTime);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(642, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 77);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "倒计时时间设置(秒)";
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(128, 30);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(68, 29);
            this.btnTime.TabIndex = 1;
            this.btnTime.Text = "确定";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(23, 30);
            this.txtTime.Margin = new System.Windows.Forms.Padding(5);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(92, 29);
            this.txtTime.TabIndex = 0;
            this.txtTime.Text = "0";
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // rbZheng
            // 
            this.rbZheng.AutoSize = true;
            this.rbZheng.Location = new System.Drawing.Point(543, 12);
            this.rbZheng.Name = "rbZheng";
            this.rbZheng.Size = new System.Drawing.Size(76, 25);
            this.rbZheng.TabIndex = 5;
            this.rbZheng.Text = "正计时";
            this.rbZheng.UseVisualStyleBackColor = true;
            this.rbZheng.CheckedChanged += new System.EventHandler(this.rbDao_AppearanceChanged);
            // 
            // rbDao
            // 
            this.rbDao.AutoSize = true;
            this.rbDao.Location = new System.Drawing.Point(543, 43);
            this.rbDao.Name = "rbDao";
            this.rbDao.Size = new System.Drawing.Size(76, 25);
            this.rbDao.TabIndex = 5;
            this.rbDao.Text = "倒计时";
            this.rbDao.UseVisualStyleBackColor = true;
            this.rbDao.AppearanceChanged += new System.EventHandler(this.rbDao_AppearanceChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 14);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "隐藏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(218, 14);
            this.btnShow.Margin = new System.Windows.Forms.Padding(5);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 52);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "显示";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(116, 14);
            this.btnReset.Margin = new System.Windows.Forms.Padding(5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 52);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 14);
            this.btnStart.Margin = new System.Windows.Forms.Padding(5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(86, 52);
            this.btnStart.TabIndex = 0;
            this.btnStart.Tag = "0";
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbAuto
            // 
            this.cbAuto.AutoSize = true;
            this.cbAuto.Location = new System.Drawing.Point(207, 37);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Size = new System.Drawing.Size(93, 25);
            this.cbAuto.TabIndex = 2;
            this.cbAuto.Text = "自动适应";
            this.cbAuto.UseVisualStyleBackColor = true;
            this.cbAuto.CheckedChanged += new System.EventHandler(this.cbAuto_CheckedChanged);
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(143, 35);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(58, 29);
            this.txtHeight.TabIndex = 1;
            this.txtHeight.Text = "120";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(52, 35);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(58, 29);
            this.txtWidth.TabIndex = 0;
            this.txtWidth.Text = "300";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "宽               高";
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 276);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 72F);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 276);
            this.label1.TabIndex = 999;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(323, 77);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(519, 276);
            this.panel3.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbAuto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.cbTop);
            this.groupBox2.Controls.Add(this.txtHeight);
            this.groupBox2.Controls.Add(this.cbTrans);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbtrue);
            this.groupBox2.Controls.Add(this.btnBColor);
            this.groupBox2.Controls.Add(this.btnFColor);
            this.groupBox2.Controls.Add(this.btnFont);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 276);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "显示设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "当前字体：";
            // 
            // cbTop
            // 
            this.cbTop.AutoSize = true;
            this.cbTop.Checked = true;
            this.cbTop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTop.Location = new System.Drawing.Point(217, 133);
            this.cbTop.Name = "cbTop";
            this.cbTop.Size = new System.Drawing.Size(93, 25);
            this.cbTop.TabIndex = 8;
            this.cbTop.Text = "窗体置顶";
            this.cbTop.UseVisualStyleBackColor = true;
            // 
            // cbTrans
            // 
            this.cbTrans.AutoSize = true;
            this.cbTrans.Location = new System.Drawing.Point(124, 133);
            this.cbTrans.Name = "cbTrans";
            this.cbTrans.Size = new System.Drawing.Size(93, 25);
            this.cbTrans.TabIndex = 7;
            this.cbTrans.Text = "背景透明";
            this.cbTrans.UseVisualStyleBackColor = true;
            this.cbTrans.CheckedChanged += new System.EventHandler(this.cbTrans_CheckedChanged);
            // 
            // cbtrue
            // 
            this.cbtrue.AutoSize = true;
            this.cbtrue.Location = new System.Drawing.Point(9, 133);
            this.cbtrue.Name = "cbtrue";
            this.cbtrue.Size = new System.Drawing.Size(109, 25);
            this.cbtrue.TabIndex = 6;
            this.cbtrue.Text = "加载背景图";
            this.cbtrue.UseVisualStyleBackColor = true;
            this.cbtrue.CheckedChanged += new System.EventHandler(this.cbtrue_CheckedChanged);
            // 
            // btnBColor
            // 
            this.btnBColor.Location = new System.Drawing.Point(218, 77);
            this.btnBColor.Name = "btnBColor";
            this.btnBColor.Size = new System.Drawing.Size(86, 41);
            this.btnBColor.TabIndex = 5;
            this.btnBColor.Text = "背景颜色";
            this.btnBColor.UseVisualStyleBackColor = true;
            this.btnBColor.Click += new System.EventHandler(this.btnBColor_Click);
            // 
            // btnFColor
            // 
            this.btnFColor.Location = new System.Drawing.Point(116, 77);
            this.btnFColor.Name = "btnFColor";
            this.btnFColor.Size = new System.Drawing.Size(86, 41);
            this.btnFColor.TabIndex = 4;
            this.btnFColor.Text = "字体颜色";
            this.btnFColor.UseVisualStyleBackColor = true;
            this.btnFColor.Click += new System.EventHandler(this.btnFColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(14, 77);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(86, 41);
            this.btnFont.TabIndex = 3;
            this.btnFont.Text = "字体设置";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.groupBox3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(319, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 276);
            this.panel5.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.s5);
            this.groupBox3.Controls.Add(this.s4);
            this.groupBox3.Controls.Add(this.s3);
            this.groupBox3.Controls.Add(this.s2);
            this.groupBox3.Controls.Add(this.s1);
            this.groupBox3.Controls.Add(this.m5);
            this.groupBox3.Controls.Add(this.m1);
            this.groupBox3.Controls.Add(this.m4);
            this.groupBox3.Controls.Add(this.m2);
            this.groupBox3.Controls.Add(this.m3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 276);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "常用时间";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(48, 223);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 40);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // s5
            // 
            this.s5.Location = new System.Drawing.Point(119, 179);
            this.s5.Name = "s5";
            this.s5.Size = new System.Drawing.Size(37, 29);
            this.s5.TabIndex = 9;
            this.s5.Text = "00";
            this.s5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.s5.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.s5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // s4
            // 
            this.s4.Location = new System.Drawing.Point(119, 142);
            this.s4.Name = "s4";
            this.s4.Size = new System.Drawing.Size(37, 29);
            this.s4.TabIndex = 7;
            this.s4.Text = "00";
            this.s4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.s4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.s4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // s3
            // 
            this.s3.Location = new System.Drawing.Point(119, 105);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(37, 29);
            this.s3.TabIndex = 5;
            this.s3.Text = "00";
            this.s3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.s3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.s3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // s2
            // 
            this.s2.Location = new System.Drawing.Point(119, 68);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(37, 29);
            this.s2.TabIndex = 3;
            this.s2.Text = "00";
            this.s2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.s2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.s2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // s1
            // 
            this.s1.Location = new System.Drawing.Point(119, 31);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(37, 29);
            this.s1.TabIndex = 1;
            this.s1.Text = "00";
            this.s1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.s1.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.s1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // m5
            // 
            this.m5.Location = new System.Drawing.Point(52, 179);
            this.m5.Name = "m5";
            this.m5.Size = new System.Drawing.Size(39, 29);
            this.m5.TabIndex = 8;
            this.m5.Text = "10";
            this.m5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // m1
            // 
            this.m1.Location = new System.Drawing.Point(52, 31);
            this.m1.Name = "m1";
            this.m1.Size = new System.Drawing.Size(39, 29);
            this.m1.TabIndex = 0;
            this.m1.Text = "1";
            this.m1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // m4
            // 
            this.m4.Location = new System.Drawing.Point(52, 142);
            this.m4.Name = "m4";
            this.m4.Size = new System.Drawing.Size(39, 29);
            this.m4.TabIndex = 6;
            this.m4.Text = "8";
            this.m4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // m2
            // 
            this.m2.Location = new System.Drawing.Point(52, 68);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(39, 29);
            this.m2.TabIndex = 2;
            this.m2.Text = "3";
            this.m2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // m3
            // 
            this.m3.Location = new System.Drawing.Point(52, 105);
            this.m3.Name = "m3";
            this.m3.Size = new System.Drawing.Size(39, 29);
            this.m3.TabIndex = 4;
            this.m3.Text = "5";
            this.m3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.m3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "1　　　　分　　　秒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "2　　　　分　　　秒";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 21);
            this.label6.TabIndex = 0;
            this.label6.Text = "3　　　　分　　　秒";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 21);
            this.label7.TabIndex = 0;
            this.label7.Text = "4　　　　分　　　秒";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 21);
            this.label8.TabIndex = 0;
            this.label8.Text = "5　　　　分　　　秒";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 353);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(547, 391);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDao;
        private System.Windows.Forms.RadioButton rbZheng;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbtrue;
        private System.Windows.Forms.Button btnBColor;
        private System.Windows.Forms.Button btnFColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.CheckBox cbAuto;
        private System.Windows.Forms.CheckBox cbTrans;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox s1;
        private System.Windows.Forms.TextBox m1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox s5;
        private System.Windows.Forms.TextBox s4;
        private System.Windows.Forms.TextBox s3;
        private System.Windows.Forms.TextBox s2;
        private System.Windows.Forms.TextBox m5;
        private System.Windows.Forms.TextBox m4;
        private System.Windows.Forms.TextBox m3;
        private System.Windows.Forms.TextBox m2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox cbTop;
    }
}

