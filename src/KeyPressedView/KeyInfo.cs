using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;


namespace KeyPressedView
{
    public partial class KeyInfo : Form
    {
        private const string SoftWareName = "Raink.KeyPressedView";
        private IKeyboardMouseEvents m_GlobalHook;
        private int _screenWidth;
        private int _screenHeight;
        private DateTime _timeShow;
        private bool _isRuning;
        public KeyInfo()
        {
            InitializeComponent();
            _isRuning = true;
            this.ShowInTaskbar = false;
            _screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            _screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            this.Location = new Point(_screenWidth - 270, _screenHeight - 70);
            this.Visible = false;
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyDown += M_GlobalHook_KeyDown;
            ShowThread();
        }

        private void M_GlobalHook_KeyDown(object sender, KeyEventArgs e)
        {
            this.label.Text = e.KeyData.ToString();
            _timeShow = DateTime.Now;
            this.Visible = true;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            m_GlobalHook.KeyDown -= M_GlobalHook_KeyDown;
            m_GlobalHook.Dispose();
        }

        private async Task ShowThread()
        {
            await Task.Run(() =>
            {
                while (_isRuning)
                {
                    if (this.Visible == true)
                    {
                        var timeSpan = DateTime.Now - _timeShow;
                        if (timeSpan.TotalMilliseconds > 1000)
                        {
                            this.Invoke(new Action(() =>
                            {
                                this.Visible = false;
                            }));
                        }
                    }
                }
            });
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isRuning = false;
        }

        private void menuItem_Quit_Click(object sender, EventArgs e)
        {
            _isRuning = false;
            this.Close();
        }

        private void SetStartWithStartUp()
        {
            string path = Application.ExecutablePath;
            RegistryKey rk = Registry.CurrentUser; // 添加到 当前登陆用户的 注册表启动项     
            try
            {
                //SetValue:存储值的名称   
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");

                // 检测是否之前有设置自启动了，如果设置了，就看值是否一样
                string old_path = (string)rk2.GetValue(SoftWareName);

                if (!path.Equals(old_path))
                {
                    rk2.SetValue(SoftWareName, path);
                    MessageBox.Show("设置开机自启成功", "KeyPressedView");
                }
                else
                {
                    MessageBox.Show("已设置过开机自启", "KeyPressedView");
                }

                rk2.Close();
                rk.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show($"开机自启动设置失败:{e}", "KeyPressedView");
            }
        }

        private void CancelStartWithStartUp()
        {
            string path = Application.ExecutablePath;
            RegistryKey rk = Registry.CurrentUser;
            try
            {
                // SetValue: 存储值的名称
                RegistryKey rk2 = rk.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run");

                string old_path = (string)rk2.GetValue(SoftWareName);

                rk2.DeleteValue(SoftWareName, false);
                MessageBox.Show("已取消开启自启", "KeyPressedView");
                rk2.Close();
                rk.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show($"未能正常取消开机自启:{e}", "KeyPressedView");
            }
        }

        private void menuItemSetStart_Click(object sender, EventArgs e)
        {
            SetStartWithStartUp();
        }

        private void menuItemCancelStart_Click(object sender, EventArgs e)
        {
            CancelStartWithStartUp();
        }
    }
}
