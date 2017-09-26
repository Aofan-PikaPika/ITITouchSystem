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
using System.Windows.Shapes;

namespace ITITouch.WechatQRCode
{
    /// <summary>
    /// WechatWindow.xaml 的交互逻辑
    /// </summary>
    public partial class WechatWindow : Window
    {
        public WechatWindow()
        {
            InitializeComponent();
            QRCodePage qr = new QRCodePage();
            this.frameShow.Content = qr;
        }

        private void bt_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
