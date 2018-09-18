using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class HotKeySet : Form
    {
        public static string[] _HotKeysText = new string[9] { "Ctrl+Alt+S", "Ctrl+Alt+R", "Shift+S", "Shift+H", "Alt+1", "Alt+2", "Alt+3", "Alt+4", "Alt+5" };
        
        public HotKeySet()
        {
            InitializeComponent();
        }

        private void keyDown(object sender, KeyEventArgs e)
        {
            StringBuilder keyValue = new StringBuilder();
            keyValue.Length = 0;
            keyValue.Append("");
            if (e.Modifiers != 0)
            {
                if (e.Control)
                {
                    keyValue.Append("Ctrl+");
                }
                if (e.Alt)
                {
                    keyValue.Append("Alt+");
                }
                if (e.Shift)
                {
                    keyValue.Append("Shift+");
                }
            }
            if ((e.KeyValue >= 33 && e.KeyValue <= 40) ||
                (e.KeyValue >= 65 && e.KeyValue <= 90) ||   //a-z/A-Z
                (e.KeyValue >= 112 && e.KeyValue <= 123))   //F1-F12
            {
                keyValue.Append(e.KeyCode);
            }
            else if ((e.KeyValue >= 48 && e.KeyValue <= 57))    //0-9
            {
                keyValue.Append(e.KeyCode.ToString().Substring(1));
            }
            this.ActiveControl.Text = "";
            //设置当前活动控件的文本内容
            this.ActiveControl.Text = keyValue.ToString();
        }

        private void keyUp(object sender, KeyEventArgs e)
        {
            string str = this.ActiveControl.Text.TrimEnd();
            int len = str.Length;
            if (len >= 1 && str.Substring(str.Length - 1) == "+")
            {
                this.ActiveControl.Text = "";
            }
        }

        private void HotKeySet_Load(object sender, EventArgs e)
        {
            foreach (Control con in this.Controls)
            {
                if (con.GetType().ToString() == "System.Windows.Forms.TextBox")
                    con.Text = _HotKeysText[Convert.ToInt32(con.Tag)];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control con in this.Controls)
            {
                int[] Right = new int[4] { 0, 0, 0, 0 };
                if (con.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    string[] temp = con.Text.Split('+');
                    foreach (string str in temp)
                    {
                        if (str == "Ctrl" || str == "Alt" || str == "Shift")
                        {
                            if (str == "Ctrl")
                                Right[0] = 131072;
                            if (str == "Alt")
                                Right[1] = 262144;
                            if (str == "Shift")
                                Right[2] = 65536;
                        }
                        else
                            switch (str)
                            {
                                case "0": Right[3] = 48; break;
                                case "1": Right[3] = 49; break;
                                case "2": Right[3] = 50; break;
                                case "3": Right[3] = 51; break;
                                case "4": Right[3] = 52; break;
                                case "5": Right[3] = 53; break;
                                case "6": Right[3] = 54; break;
                                case "7": Right[3] = 55; break;
                                case "8": Right[3] = 56; break;
                                case "9": Right[3] = 57; break;

                                case "A": Right[3] = 65; break;
                                case "B": Right[3] = 66; break;
                                case "C": Right[3] = 67; break;
                                case "D": Right[3] = 68; break;
                                case "E": Right[3] = 69; break;
                                case "F": Right[3] = 70; break;
                                case "G": Right[3] = 71; break;
                                case "H": Right[3] = 72; break;
                                case "I": Right[3] = 73; break;
                                case "J": Right[3] = 74; break;
                                case "K": Right[3] = 75; break;
                                case "L": Right[3] = 76; break;
                                case "M": Right[3] = 77; break;
                                case "N": Right[3] = 78; break;
                                case "O": Right[3] = 79; break;
                                case "P": Right[3] = 80; break;
                                case "Q": Right[3] = 81; break;
                                case "R": Right[3] = 82; break;
                                case "S": Right[3] = 83; break;
                                case "T": Right[3] = 84; break;
                                case "U": Right[3] = 85; break;
                                case "V": Right[3] = 86; break;
                                case "W": Right[3] = 87; break;
                                case "X": Right[3] = 88; break;
                                case "Y": Right[3] = 89; break;
                                case "Z": Right[3] = 90; break;

                                case "F1": Right[3] = 112; break;
                                case "F2": Right[3] = 113; break;
                                case "F3": Right[3] = 114; break;
                                case "F4": Right[3] = 115; break;
                                case "F5": Right[3] = 116; break;
                                case "F6": Right[3] = 117; break;
                                case "F7": Right[3] = 118; break;
                                case "F8": Right[3] = 119; break;
                                case "F9": Right[3] = 120; break;
                                case "F10": Right[3] = 121; break;
                                case "F11": Right[3] = 122; break;
                                case "F12": Right[3] = 123; break;


                                case "Home": Right[3] = 36; break;
                                case "End": Right[3] = 35; break;
                                case "PageUp": Right[3] = 33; break;
                                case "Next": Right[3] = 34; break;
                            }
                    }
                    _HotKeysText[Convert.ToInt32(con.Tag)] = con.Text;
                    Main._HotKeys[Convert.ToInt32(con.Tag), 0] = Right[0];
                    Main._HotKeys[Convert.ToInt32(con.Tag), 1] = Right[1];
                    Main._HotKeys[Convert.ToInt32(con.Tag), 2] = Right[2];
                    Main._HotKeys[Convert.ToInt32(con.Tag), 3] = Right[3];
                }
            }
            this.DialogResult = DialogResult.OK;
        }
    }
}