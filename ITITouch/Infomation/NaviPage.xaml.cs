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

namespace ITITouch.Infomation
{   
    public delegate void  showFramebt1Handle();
    public delegate void  showFramebt2Handle();
    public delegate void  showFramebt3Handle();
    public delegate void  showFramebt4Handle();
    public delegate void  showFramebt5Handle();
    /// <summary>
    /// NaviPage.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage : Page
    {
        public showFramebt1Handle showProfileFunction;
        public showFramebt2Handle showHistoryFunction;
        public showFramebt3Handle showLeaderFunction;
        public showFramebt4Handle showOldFunction;
        public showFramebt5Handle showLogoFuntion;
        public NaviPage()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            showProfileFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            showHistoryFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            showLeaderFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            showOldFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
            w5.Background = oldbrush;
        }

        public void Initialize() 
        {
            bt1_Click(this,null);
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            showLogoFuntion();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w4.Background = oldbrush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
            w5.Background = brush;
        }
    }
}
