using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using mshtml;
using System.Windows.Forms;

namespace ITITouch.Website
{
    /// <summary>
    /// WebSiteWindow.xaml 的交互逻辑
    /// </summary>
    public partial class WebSiteWindow : Window
    {
        private System.Drawing.Point p = new System.Drawing.Point(0, 0);
        public WebSiteWindow()
        {
            InitializeComponent();
            //禁用鼠标右键
            wb.IsWebBrowserContextMenuEnabled = false;
            //开始就跳转至学院官网
            wb.Navigate("http://ai.hebut.edu.cn/");
            // 设置浏览器不跳js错误
            wb.ScriptErrorsSuppressed = true;

        }
        public void newsNavigate(string newsUrl)
        {
            wb.Navigate(newsUrl);
        }

        private void wb_NewWindow(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //禁止开启新窗口
            e.Cancel = true;
        }
        //跳转时检测网页是不是计算机学院
        private void wb_Navigated(object sender, System.Windows.Forms.WebBrowserNavigatedEventArgs e)
        {
            if (this.wb.Url != null)
            {
                string uri = this.wb.Url.ToString();

                Regex testOutUri = new Regex(@"ai.hebut.edu.cn");
                Match m = testOutUri.Match(uri);
                if (!m.Success)
                {
                    wb.Navigate("http://ai.hebut.edu.cn/");
                }
            }

        }


        private void back_MouseUp(object sender, MouseButtonEventArgs e)
        {
            wb.GoBack();
        }

        private void home_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void forward_MouseUp(object sender, MouseButtonEventArgs e)
        {
            wb.GoForward();
        }

    }
}
