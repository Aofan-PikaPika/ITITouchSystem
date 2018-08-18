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

namespace ITITouch.Education
{
    public delegate void showCSHandle();
    public delegate void showSWHandle();
    public delegate void showNetHandle();
    public delegate void showIOTHandle();
    /// <summary>
    /// NaviPage1.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage1 : Page
    {
        public showCSHandle showCSFunction;
        public showSWHandle showSWFunction;
        public showNetHandle showNetFunction;
        public showIOTHandle showIOTFunction;
        public NaviPage1()
        {
            InitializeComponent();
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            showSWFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
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
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            showNetFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            showCSFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
        }

        public void Initialation() 
        {
            bt1_Click(this, null);
        }
    }
}
