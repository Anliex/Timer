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
    public class KeyboardHooks
    {
        #region 常数和结构
        public const int WM_KEYDOWN = 0x100;
        public const int WM_KEYUP = 0x101;
        public const int WM_SYSKEYDOWN = 0x104;
        public const int WM_SYSKEYUP = 0x105;
        public const int WH_KEYBOARD_LL = 13;

        ///         
        /// 窗体嵌入桌面        
        ///          
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        [DllImport("user32")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
        ///         
        /// 窗体嵌入桌面       
        ///          

        ///         
        /// 设置窗体具有鼠标穿透效果        
        ///          
        public const uint WS_EX_LAYERED = 0x80000;
        public const int WS_EX_TRANSPARENT = 0x20;
        public const int GWL_STYLE = (-16);
        public const int GWL_EXSTYLE = (-20);
        public const int LWA_ALPHA = 0;
        [DllImport("user32", EntryPoint = "SetWindowLong")]
        public static extern uint SetWindowLong(IntPtr hwnd, int nIndex, uint dwNewLong);
        [DllImport("user32", EntryPoint = "GetWindowLong")]
        public static extern uint GetWindowLong(IntPtr hwnd, int nIndex);
        [DllImport("user32", EntryPoint = "SetLayeredWindowAttributes")]
        public static extern int SetLayeredWindowAttributes(IntPtr hwnd, int crKey, int bAlpha, int dwFlags);
        ///         
        /// 设置窗体具有鼠标穿透效果        
        ///    

        ///         
        /// 窗体置顶        
        ///    
        [DllImport("user32.dll", CharSet = CharSet.Auto)]//窗体置顶
        public static extern int SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int y, int Width, int Height, int flags);
        /// <summary>
        /// 得到当前活动的窗口
        /// </summary>
        /// <returns></returns>
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern System.IntPtr GetForegroundWindow();
        ///         
        /// 窗体置顶        
        ///    

        [StructLayout(LayoutKind.Sequential)] //声明键盘钩子的封送结构类型 
        public class KeyboardHookStruct
        {
            public int vkCode; //表示一个在1到254间的虚似键盘码 
            public int scanCode; //表示硬件扫描码 
            public int flags;
            public int time;
            public int dwExtraInfo;
        }
        #endregion
        #region Api
        public delegate int HookProc(int nCode, Int32 wParam, IntPtr lParam);
        //安装钩子的函数 
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hInstance, int threadId);
        //卸下钩子的函数 
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool UnhookWindowsHookEx(int idHook);
        //下一个钩挂的函数 
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern int CallNextHookEx(int idHook, int nCode, Int32 wParam, IntPtr lParam);
        [DllImport("user32")]
        public static extern int ToAscii(int uVirtKey, int uScanCode, byte[] lpbKeyState, byte[] lpwTransKey, int fuState);
        [DllImport("user32")]
        public static extern int GetKeyboardState(byte[] pbKeyState);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);
        #endregion
        //添加新建类KeyboardHook，封装键盘钩子，代码如下：

        public class KeyboardHook
        {
            int hHook;
            KeyboardHooks.HookProc KeyboardHookDelegate;
            public event KeyEventHandler OnKeyDownEvent;
            public event KeyEventHandler OnKeyUpEvent;
            public event KeyPressEventHandler OnKeyPressEvent;
            public KeyboardHook() { }
            public void SetHook()
            {
                KeyboardHookDelegate = new KeyboardHooks.HookProc(KeyboardHookProc);
                Process cProcess = Process.GetCurrentProcess();
                ProcessModule cModule = cProcess.MainModule;
                var mh = KeyboardHooks.GetModuleHandle(cModule.ModuleName);
                hHook = KeyboardHooks.SetWindowsHookEx(KeyboardHooks.WH_KEYBOARD_LL, KeyboardHookDelegate, mh, 0);
            }
            public void UnHook()
            {
                KeyboardHooks.UnhookWindowsHookEx(hHook);
            }
            private List<Keys> preKeysList = new List<Keys>();//存放被按下的控制键，用来生成具体的键
            private int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
            {
                //如果该消息被丢弃（nCode<0）或者没有事件绑定处理程序则不会触发事件
                if ((nCode >= 0) && (OnKeyDownEvent != null || OnKeyUpEvent != null || OnKeyPressEvent != null))
                {
                    KeyboardHooks.KeyboardHookStruct KeyDataFromHook = (KeyboardHooks.KeyboardHookStruct)Marshal.PtrToStructure(lParam, typeof(KeyboardHooks.KeyboardHookStruct));
                    Keys keyData = (Keys)KeyDataFromHook.vkCode;
                    //按下控制键
                    if ((OnKeyDownEvent != null || OnKeyPressEvent != null) && (wParam == KeyboardHooks.WM_KEYDOWN || wParam == KeyboardHooks.WM_SYSKEYDOWN))
                    {
                        if (IsCtrlAltShiftKeys(keyData) && preKeysList.IndexOf(keyData) == -1)
                        {
                            preKeysList.Add(keyData);
                        }
                    }
                    //WM_KEYDOWN和WM_SYSKEYDOWN消息，将会引发OnKeyDownEvent事件
                    if (OnKeyDownEvent != null && (wParam == KeyboardHooks.WM_KEYDOWN || wParam == KeyboardHooks.WM_SYSKEYDOWN))
                    {
                        KeyEventArgs e = new KeyEventArgs(GetDownKeys(keyData));

                        OnKeyDownEvent(this, e);
                    }
                    //WM_KEYDOWN消息将引发OnKeyPressEvent 
                    if (OnKeyPressEvent != null && wParam == KeyboardHooks.WM_KEYDOWN)
                    {
                        byte[] keyState = new byte[256];
                        KeyboardHooks.GetKeyboardState(keyState);
                        byte[] inBuffer = new byte[2];
                        if (KeyboardHooks.ToAscii(KeyDataFromHook.vkCode, KeyDataFromHook.scanCode, keyState, inBuffer, KeyDataFromHook.flags) == 1)
                        {
                            KeyPressEventArgs e = new KeyPressEventArgs((char)inBuffer[0]);
                            OnKeyPressEvent(this, e);
                        }
                    }
                    //松开控制键
                    if ((OnKeyDownEvent != null || OnKeyPressEvent != null) && (wParam == KeyboardHooks.WM_KEYUP || wParam == KeyboardHooks.WM_SYSKEYUP))
                    {
                        if (IsCtrlAltShiftKeys(keyData))
                        {
                            for (int i = preKeysList.Count - 1; i >= 0; i--)
                            {
                                if (preKeysList[i] == keyData) { preKeysList.RemoveAt(i); }
                            }
                        }
                    }
                    //WM_KEYUP和WM_SYSKEYUP消息，将引发OnKeyUpEvent事件 
                    if (OnKeyUpEvent != null && (wParam == KeyboardHooks.WM_KEYUP || wParam == KeyboardHooks.WM_SYSKEYUP))
                    {
                        KeyEventArgs e = new KeyEventArgs(GetDownKeys(keyData));
                        OnKeyUpEvent(this, e);
                    }
                }
                return KeyboardHooks.CallNextHookEx(hHook, nCode, wParam, lParam);
            }
            //根据已经按下的控制键生成key
            private Keys GetDownKeys(Keys key)
            {
                Keys rtnKey = Keys.None;
                foreach (Keys i in preKeysList)
                {
                    if (i == Keys.LControlKey || i == Keys.RControlKey) { rtnKey = rtnKey | Keys.Control; }
                    if (i == Keys.LMenu || i == Keys.RMenu) { rtnKey = rtnKey | Keys.Alt; }
                    if (i == Keys.LShiftKey || i == Keys.RShiftKey) { rtnKey = rtnKey | Keys.Shift; }
                }
                return rtnKey | key;
            }
            private Boolean IsCtrlAltShiftKeys(Keys key)
            {
                if (key == Keys.LControlKey || key == Keys.RControlKey || key == Keys.LMenu || key == Keys.RMenu || key == Keys.LShiftKey || key == Keys.RShiftKey) { return true; }
                return false;
            }
        }
    }
}
