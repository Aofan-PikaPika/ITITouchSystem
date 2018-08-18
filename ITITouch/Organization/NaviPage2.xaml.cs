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

namespace ITITouch.Organization
{
        public delegate void showFramebt1Handle();
        public delegate void showFramebt2Handle();
        public delegate void showFramebt3Handle();
        public delegate void showFramebt4Handle();
        public delegate void showFramebt5Handle();
        public delegate void showFramebt6Handle();
        public delegate void showFramebt7Handle();
    /// <summary>
    /// NaviPage2.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage2 : Page
    {
        public showFramebt1Handle showComputerFunction;
        public showFramebt2Handle showNetFunction;
        public showFramebt3Handle showSoftwareFunction;
        public showFramebt4Handle showIOTFunction;
        public showFramebt5Handle showTeachFunction;
        public showFramebt6Handle showCenterFunction;
        public showFramebt7Handle showLabFunction;
        public NaviPage2()
        {
            
            
            InitializeComponent();

        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            showComputerFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w7.Background = oldbrush;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            showNetFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;

            w7.Background = oldbrush;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            showSoftwareFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;

            w7.Background = oldbrush;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            showIOTFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
            w5.Background = oldbrush;

            w7.Background = oldbrush;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            showTeachFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w5.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;

            w7.Background = oldbrush;
        }



        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            showLabFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w7.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;

        }

        public void Initialization() 
        {
            this.bt1_Click(this, null);
        }
    }
}
