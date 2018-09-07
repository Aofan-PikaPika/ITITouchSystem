using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;
using System.Threading;

namespace ITITouch.Faculty
{
    /// <summary>
    /// TeacherWebBrowserPage.xaml 的交互逻辑
    /// </summary>
    public partial class TeacherWebBrowserPage : Page
    {
        String uri = null;
        public TeacherWebBrowserPage(String uri)
        {
            InitializeComponent();
            //禁用鼠标右键
            twb.IsWebBrowserContextMenuEnabled = false;
            // 设置浏览器不跳js错误
            twb.ScriptErrorsSuppressed = true;
            // 开始就跳转到给定的教师页面
            this.uri = uri;
            twb.Navigate(uri);
        }

        public string Uri
        {
            get
            {
                return this.uri;
            }
            set
            {
                this.uri = value;
                this.twb.Navigate(uri);     
            }
        }

        public bool IsBusy
        {
            get { return this.twb.IsBusy; }
        }

        private void twb_Navigated(object sender, WebBrowserNavigatedEventArgs e)    //如果不是此地址则转回此地址
        {
            if (!String.Equals(e.Url.ToString(), this.uri))
            {
                twb.Navigate(this.uri);
            }
            twb.Refresh();

        }

        private void twb_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)   //不可以弹新窗口
        {
            e.Cancel = true;
        }

        private void twb_Navigating(object sender, WebBrowserNavigatingEventArgs e)    //介面内不可跳转其他页面
        {
            if (!String.Equals(e.Url.ToString(), this.uri))
            {
                e.Cancel = true;
            }
        }
        
    }
}
