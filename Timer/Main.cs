using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Timer
{
    public partial class Main : Form
    {
        public static int[] _Times = new int[5] { 1 * 60, 3 * 60, 5 * 60, 8 * 60, 10 * 60 };

        public static int[,] _HotKeys = new int[9, 4] {
        { (int)131072, (int)262144, (int)83, (int)0 },
        { (int)131072, (int)262144, (int)82, (int)0 },
        { (int)65536, (int)83, (int)0, (int)0 },
        { (int)65536, (int)72, (int)0, (int)0 },
        { (int)262144, (int)49, (int)0, (int)0 },
        { (int)262144, (int)50, (int)0, (int)0 },
        { (int)262144, (int)51, (int)0, (int)0 },
        { (int)262144, (int)52, (int)0, (int)0 },
        { (int)262144, (int)53, (int)0, (int)0 }};
        KeyboardHooks.KeyboardHook kh;

        Form frm;

        public static bool _Auto = false;
        public static bool _Trans = false;
        public static bool _Top = false;
        public static int _Time = 0;
        public static Color fColor, bColor;
        public static Font font;

        public static Image img;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            font = fontDialog1.Font = label1.Font;
            fColor = colorDialog1.Color = label1.ForeColor;
            bColor = colorDialog2.Color = panel2.BackColor;
            rbZheng.Checked = true;
            label2.Text = "当前字体：\r\n" + label1.Font.Name + "," + label1.Font.Size.ToString() + "px";

            KeyboardHooks.SetWindowPos(this.Handle, -1, 0, 0, 0, 0, 1 | 2);

            kh = new KeyboardHooks.KeyboardHook();
            kh.SetHook();
            kh.OnKeyDownEvent += kh_OnKeyDownEvent;
        }

        private void rbDao_AppearanceChanged(object sender, EventArgs e)
        {
            if (rbDao.Checked==true)
            {
                groupBox1.Enabled = true;
                _Time = Convert.ToInt32(txtTime.Text);
            }
            if(rbZheng.Checked==true)
            {
                groupBox1.Enabled = false;
                _Time = 0;
            }
            timer1.Enabled = false;
            btnStart.Tag = 0;
            btnStart.Text = "开始";

            if (rbDao.Checked == true)
            {
                _Time = Convert.ToInt32(txtTime.Text);
            }
            if (rbZheng.Checked == true)
            {
                _Time = 0;
            }
            label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog()==DialogResult.OK)
            {
                font = fontDialog1.Font;
                label1.Font = new System.Drawing.Font(font.Name, 72);
                label2.Text = "当前字体：\r\n" + font.Name + "," + font.Size.ToString() + "px";
            }
        }

        private void btnFColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                fColor = label1.ForeColor = colorDialog1.Color;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rbDao.Checked == true)
            {
                _Time--;
            }
            if (rbZheng.Checked == true)
            {
                _Time++;
            }
            label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
        }

        private void btnBColor_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                bColor = panel2.BackColor = colorDialog2.Color;
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            LoadBackgroundImage();
        }

        private void LoadBackgroundImage()
        {

            OpenFileDialog opnDlg = new OpenFileDialog();
            opnDlg.Filter = "所有图像文件 | *.bmp; *.pcx; *.png; *.jpg; *.gif;" +
                "*.tif; *.ico; *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf|" +
                "位图( *.bmp; *.jpg; *.png;...) | *.bmp; *.pcx; *.png; *.jpg; *.gif; *.tif; *.ico|" +
                "矢量图( *.wmf; *.eps; *.emf;...) | *.dxf; *.cgm; *.cdr; *.wmf; *.eps; *.emf";
            opnDlg.Title = "打开图像文件";
            opnDlg.ShowHelp = true;
            if (opnDlg.ShowDialog() == DialogResult.OK)
            {
                cbtrue.Checked = true;
                panel2.BackgroundImage = Image.FromFile(opnDlg.FileName);
                img = panel2.BackgroundImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnStart.Tag.ToString() == "0")
            {
                timer1.Enabled = true;
                btnStart.Tag = 1;
                btnStart.Text = "暂停";
            }
            else if (btnStart.Tag.ToString() == "1")
            {
                timer1.Enabled = false;
                btnStart.Tag = 0;
                btnStart.Text = "继续";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStart.Tag = 0;
            btnStart.Text = "开始";

            if (rbDao.Checked == true)
            {
                _Time = Convert.ToInt32(txtTime.Text);
            }
            if (rbZheng.Checked == true)
            {
                _Time = 0;
            }
            label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            if (txtTime.Text == "")
                txtTime.Text = "0";
            _Time = Convert.ToInt32(txtTime.Text);
            label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
        }

        private void cbtrue_CheckedChanged(object sender, EventArgs e)
        {
            if (cbtrue.Checked)
            {
                LoadBackgroundImage();
            }
            if (cbtrue.Checked == false)
                img = panel2.BackgroundImage = null;
        }

        void kh_OnKeyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyData == ((Keys)_HotKeys[0, 0] | (Keys)_HotKeys[0, 1] | (Keys)_HotKeys[0, 2] | (Keys)_HotKeys[0, 3]))
            //if (e.KeyData == (Keys.S | Keys.Control | Keys.Alt))
            {
                if (btnStart.Tag.ToString() == "0")
                {
                    timer1.Enabled = true;
                    btnStart.Tag = 1;
                    btnStart.Text = "暂停";
                }
                else if (btnStart.Tag.ToString() == "1")
                {
                    timer1.Enabled = false;
                    btnStart.Tag = 0;
                    btnStart.Text = "继续";
                }
            }//开始/暂停
            if (e.KeyData == ((Keys)_HotKeys[1, 0] | (Keys)_HotKeys[1, 1] | (Keys)_HotKeys[1, 2] | (Keys)_HotKeys[1, 3]))
            {
                timer1.Enabled = false;
                btnStart.Tag = 0;
                btnStart.Text = "开始";

                if (rbDao.Checked == true)
                {
                    _Time = Convert.ToInt32(txtTime.Text);
                }
                if (rbZheng.Checked == true)
                {
                    _Time = 0;
                }
                label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
            }//重置时间
            if (e.KeyData == ((Keys)_HotKeys[2, 0] | (Keys)_HotKeys[2, 1] | (Keys)_HotKeys[2, 2] | (Keys)_HotKeys[2, 3]))
            {
                _Top = cbTop.Checked;

                if (frm != null)
                {
                    frm.Close();
                    frm.Dispose();
                }
                frm = new ShowLoad(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
                frm.Show();
                this.Focus();
            }//显示窗体
            if (e.KeyData == ((Keys)_HotKeys[3, 0] | (Keys)_HotKeys[3, 1] | (Keys)_HotKeys[3, 2] | (Keys)_HotKeys[3, 3]))
            {
                if (frm != null)
                {
                    frm.Close();
                    frm.Dispose();
                }
            }//隐藏窗体
            if (e.KeyData == ((Keys)_HotKeys[4, 0] | (Keys)_HotKeys[4, 1] | (Keys)_HotKeys[4, 2] | (Keys)_HotKeys[4, 3]))
            {
                rbDao.Checked = true;
                _Time = _Times[0];
                txtTime.Text = _Time.ToString();
                label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
            }//常用时间1
            if (e.KeyData == ((Keys)_HotKeys[5, 0] | (Keys)_HotKeys[5, 1] | (Keys)_HotKeys[5, 2] | (Keys)_HotKeys[5, 3]))
            {
                rbDao.Checked = true;
                _Time = _Times[1];
                txtTime.Text = _Time.ToString();
                label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
            }//常用时间2
            if (e.KeyData == ((Keys)_HotKeys[6, 0] | (Keys)_HotKeys[6, 1] | (Keys)_HotKeys[6, 2] | (Keys)_HotKeys[6, 3]))
            {
                rbDao.Checked = true;
                _Time = _Times[2];
                txtTime.Text = _Time.ToString();
                label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
            }//常用时间3
            if (e.KeyData == ((Keys)_HotKeys[7, 0] | (Keys)_HotKeys[7, 1] | (Keys)_HotKeys[7, 2] | (Keys)_HotKeys[7, 3]))
            {
                rbDao.Checked = true;
                _Time = _Times[3];
                txtTime.Text = _Time.ToString();
                label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
            }//常用时间4
            if (e.KeyData == ((Keys)_HotKeys[8, 0] | (Keys)_HotKeys[8, 1] | (Keys)_HotKeys[8, 2] | (Keys)_HotKeys[8, 3]))
            {
                rbDao.Checked = true;
                _Time = _Times[4];
                txtTime.Text = _Time.ToString();
                label1.Text = (_Time / 60).ToString("00") + ":" + (_Time % 60).ToString("00");
            }//常用时间5
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            _Top = cbTop.Checked;

            if (frm != null)
            {
                frm.Close();
                frm.Dispose();
            }
            frm = new ShowLoad(Convert.ToInt32(txtWidth.Text), Convert.ToInt32(txtHeight.Text));
            frm.Show();
            this.Focus();
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }  
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            MessageBox.Show("By Anliex(mailto:admin@anliex.com)");
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            _Auto = cbAuto.Checked;
            if (_Auto)
                txtHeight.Enabled = txtWidth.Enabled = false;
            else
                txtHeight.Enabled = txtWidth.Enabled = true;
        }

        private void cbTrans_CheckedChanged(object sender, EventArgs e)
        {
            _Trans = cbTrans.Checked;
            if (_Trans)
            {
                cbAuto.Enabled = txtHeight.Enabled = txtWidth.Enabled = false;
                bColor = panel2.BackColor = Color.FromArgb(0, 254, 254, 254);
                cbtrue.Checked = false;
            }
            else
                cbAuto.Enabled = txtHeight.Enabled = txtWidth.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (frm != null)
            {
                frm.Close();
                frm.Dispose();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("By Anliex(mailto:admin@anliex.com)");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HotKeySet hks = new HotKeySet();
            hks.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((TextBox)sender).Text) > 59)
                ((TextBox)sender).Text = "59";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Times[0] = Convert.ToInt32(m1.Text) * 60 + Convert.ToInt32(s1.Text);
            _Times[1] = Convert.ToInt32(m2.Text) * 60 + Convert.ToInt32(s2.Text);
            _Times[2] = Convert.ToInt32(m3.Text) * 60 + Convert.ToInt32(s3.Text);
            _Times[3] = Convert.ToInt32(m4.Text) * 60 + Convert.ToInt32(s4.Text);
            _Times[4] = Convert.ToInt32(m5.Text) * 60 + Convert.ToInt32(s5.Text);
        }

        private void button998_Click(object sender, EventArgs e)
        {
        }
    }
}
