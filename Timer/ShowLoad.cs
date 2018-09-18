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
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;

namespace Timer
{
    public partial class ShowLoad : Form
    {
        int _x,_y;
        const int WS_EX_NOACTIVATE = 0x08000000;

        //重载Form的CreateParams属性，添加不获取焦点属性值。

        protected override CreateParams CreateParams
        {

            get
            {

                CreateParams cp = base.CreateParams;

                cp.ExStyle |= WS_EX_NOACTIVATE;

                return cp;

            }

        }
        private const uint WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;
        private const int GWL_STYLE = (-16);
        private const int GWL_EXSTYLE = (-20);
        private const int LWA_ALPHA = 0;

        [DllImport("user32", EntryPoint = "SetWindowLong")]
        private static extern uint SetWindowLong(
        IntPtr hwnd,
        int nIndex,
        uint dwNewLong
        );

        [DllImport("user32", EntryPoint = "GetWindowLong")]
        private static extern uint GetWindowLong(
        IntPtr hwnd,
        int nIndex
        );

        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        private static extern int SetLayeredWindowAttributes(
        IntPtr hwnd,
        int crKey,
        int bAlpha,
        int dwFlags
        );

        /// <summary> 
        /// 设置窗体具有鼠标穿透效果 
        /// </summary> 
        public void SetPenetrate()
        {
            this.TopMost = true;
            GetWindowLong(this.Handle, GWL_EXSTYLE);
            SetWindowLong(this.Handle, GWL_EXSTYLE, WS_EX_TRANSPARENT | WS_EX_LAYERED);
            SetLayeredWindowAttributes(this.Handle, 0, 100, LWA_ALPHA);
        } 

        Screen[] sc;
        private Point mouse_offset;
        public ShowLoad(int x,int y)
        {
            InitializeComponent();
            _x = x;
            _y = y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (Main._Trans)
            //{
            //    Graphics gra = this.pbBack.CreateGraphics();

            //    Brush bush = new SolidBrush(Main.fColor);//填充的颜色

            //    pbBack.Refresh();

            //    gra.DrawString((Main._Time / 60).ToString("00") + ":" + (Main._Time % 60).ToString("00"), Main.font, bush, 0, 0); 
                

            //}
            //else
                label1.Text = (Main._Time / 60).ToString("00") + ":" + (Main._Time % 60).ToString("00");
        }

        private void Control_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_offset = new Point(-e.X, -e.Y);
        }

        private void Control_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                if (Main._Trans)
                {
                    this.Location = mousePos;// Control.MousePosition; ;
                }
                else
                {
                    ((Control)sender).Location = ((Control)sender).Parent.PointToClient(mousePos);
                }
            }
        }

        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouse_offset.X, mouse_offset.Y);
                if (Main._Trans)
                {
                    this.Location = mousePos;// Control.MousePosition; ;
                }
                else
                {
                    ((Control)sender).Location = ((Control)sender).Parent.PointToClient(mousePos);
                }
            }
        }

        private void ShowLoad_Load(object sender, EventArgs e)
        {
            label1.Parent = pbBack;

            sc = Screen.AllScreens;
            if (Main._Top)
                SetPenetrate();
            //if (Main._Trans)
            //{
            //    this.Left = 0;
            //    this.Top = 0;
            //}
            //else
            //{
                if (sc.Length != 1)
                {
                    if (Main._Auto == false)
                        this.Size = new Size(_x, _y);
                    else
                    {
                        this.Size = new Size(sc[1].Bounds.Width, sc[1].Bounds.Height);
                    }
                    this.Left = sc[0].Bounds.Width;
                    this.Top = 0;
                }
                else
                {
                    this.Left = 0;
                    this.Top = 0;
                    if (Main._Auto == false)
                        this.Size = new Size(_x, _y);
                    else
                    {
                        this.Size = new Size(sc[0].Bounds.Width, sc[0].Bounds.Height);
                    }
                //}
            }

            this.TransparencyKey = Color.FromArgb(0, 254, 254, 254);
            label1.Font = Main.font;
            label1.ForeColor = Main.fColor;
            try
            {
                this.BackColor = Main.bColor;
            }
            catch { }
            pbBack.BackgroundImage = Main.img;
        }
    }
}
