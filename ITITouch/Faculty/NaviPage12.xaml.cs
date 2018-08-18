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

namespace ITITouch.Faculty
{
    public delegate void showUpHandle();
    public delegate void showBt1Handle();
    public delegate void showBt2Handle();
    public delegate void showBt3Handle();
    public delegate void showBt4Handle();
    public delegate void showBt5Handle();
    public delegate void showBt6Handle();
    public delegate void showBt7Handle();
    public delegate void showBt8Handle();
    public delegate void showBt9Handle();

    /// <summary>
    /// NaviPage12.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage12 : Page
    {
        public showUpHandle showUpFunction;
       

        public showBt1Handle showBt1Function;
        public showBt2Handle showBt2Function;
        public showBt3Handle showBt3Function;
        public showBt4Handle showBt4Function;
        public showBt5Handle showBt5Function;
        public showBt6Handle showBt6Function;
        public showBt7Handle showBt7Function;
        public showBt8Handle showBt8Function;
        public showBt9Handle showBt9Function;

        public NaviPage12()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            showBt9Function();
            w9.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w1.Background = oldbrush;

        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            showBt8Function();
            w8.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w1.Background = oldbrush;
            w9.Background = oldbrush;

        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            showBt7Function();
            w7.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w1.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;

        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            showBt6Function();
            w6.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w1.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;

        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            showBt5Function();
            w5.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w1.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;

        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            showBt4Function();
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;

        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            showBt3Function();
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;

        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            showBt2Function();
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;

        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            showBt1Function();
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;

        }

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            showUpFunction();
        }
    }
}
