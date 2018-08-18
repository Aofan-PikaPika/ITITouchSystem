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
    public delegate void ProBt1Handle();
    public delegate void ProBt2Handle();
    public delegate void ProBt3Handle();
    public delegate void ProBt4Handle();
    public delegate void ProBt5Handle();
    public delegate void ProBt6Handle();
    public delegate void ProUpPageHandle();

    /// <summary>
    /// NaviPage22.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage22 : Page
    {
        public ProBt1Handle showBt1Function;
        public ProBt2Handle showBt2Function;
        public ProBt3Handle showBt3Function;

        public ProBt4Handle showBt4Function;
        public ProBt5Handle showBt5Function;
        public ProBt6Handle showBt6Function;
        public ProUpPageHandle showProUpFunction;

        public NaviPage22()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            showBt1Function();
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
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
        }

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            showProUpFunction();
        }
    }
}
