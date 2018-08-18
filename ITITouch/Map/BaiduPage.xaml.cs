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

namespace ITITouch.Map
{
    /// <summary>
    /// BaiduPage.xaml 的交互逻辑
    /// </summary>
    public partial class BaiduPage : Page
    {
        System.Windows.Forms.Integration.WindowsFormsHost host = new System.Windows.Forms.Integration.WindowsFormsHost();
        System.Windows.Forms.WebBrowser webBrowser = new System.Windows.Forms.WebBrowser();
        public BaiduPage()
        {
            InitializeComponent();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string proj = System.IO.Path.Combine(path, @"..\..\");
            webBrowser.Url = new Uri(proj + "Map\\BMap.html", UriKind.Absolute);
            webBrowser.ScriptErrorsSuppressed = true;
            host.Child = webBrowser;
            Grid.SetRow(host, 1);
            this.grid.Children.Add(host);
        }
    }
}
