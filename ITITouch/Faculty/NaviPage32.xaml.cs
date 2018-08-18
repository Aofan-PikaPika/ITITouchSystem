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
    public delegate void showLecturerUpHandle();
    public delegate void showLecBt1Handle();
    public delegate void showLecBt2Handle();
    public delegate void showLecBt3Handle();
    public delegate void showLecBt4Handle();
    public delegate void showLecBt5Handle();
    public delegate void showLecBt6Handle();
    public delegate void showLecBt7Handle();
    public delegate void showLecBt8Handle();
    public delegate void showLecBt9Handle();
    public delegate void showLecBt10Handle();
    public delegate void showLecBt11Handle();
    public delegate void showLecBt12Handle();
    public delegate void showLecBt13Handle();
    public delegate void showLecBt14Handle();
    /// <summary>
    /// NaviPage32.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage32 : Page
    {
        public showLecturerUpHandle showLecturerUpFunction;
        public showLecBt1Handle showLecBt1Function;
        public showLecBt2Handle showLecBt2Function;
        public showLecBt3Handle showLecBt3Function;
        public showLecBt4Handle showLecBt4Function;
        public showLecBt5Handle showLecBt5Function;
        public showLecBt6Handle showLecBt6Function;
        public showLecBt7Handle showLecBt7Function;
        public showLecBt8Handle showLecBt8Function;
        public showLecBt9Handle showLecBt9Function;
        public showLecBt10Handle showLecBt10Function;
        public showLecBt11Handle showLecBt11Function;
        public showLecBt12Handle showLecBt12Function;
        public showLecBt13Handle showLecBt13Function;
        public showLecBt14Handle showLecBt14Function;
        public NaviPage32()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            showLecturerUpFunction();
           
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            showLecBt1Function();
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;

        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            showLecBt2Function();
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            showLecBt3Function();
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            showLecBt4Function();
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            showLecBt5Function();
            w5.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w1.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            showLecBt6Function();
            w6.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w1.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            showLecBt7Function();
            w7.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w1.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt8_Click(object sender, RoutedEventArgs e)
        {
            showLecBt8Function();
            w8.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w1.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt9_Click(object sender, RoutedEventArgs e)
        {
            showLecBt9Function();
            w9.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w1.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt10_Click(object sender, RoutedEventArgs e)
        {
            showLecBt10Function();
            w10.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w1.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt11_Click(object sender, RoutedEventArgs e)
        {
            showLecBt11Function();
            w11.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w1.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt12_Click(object sender, RoutedEventArgs e)
        {
            showLecBt12Function();
            w12.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w1.Background = oldbrush;
            w13.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt13_Click(object sender, RoutedEventArgs e)
        {
            showLecBt13Function();
            w13.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w1.Background = oldbrush;
            w14.Background = oldbrush;
        }

        private void bt14_Click(object sender, RoutedEventArgs e)
        {
            showLecBt14Function();
            w13.Background = oldbrush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w1.Background = oldbrush;
            w14.Background = brush;
        }
    }
}
