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
    public delegate void showFloorOneHandle();
    public delegate void showFloorTwoHandle();
    public delegate void showFloorThreeHandle();
    /// <summary>
    /// NaviPage1.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage1 : Page
    {
        public showFloorOneHandle showFloorOneFunction;
        public showFloorTwoHandle showFloorTwoFunction;
        public showFloorThreeHandle showFloorThreeFunction;
        public NaviPage1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            showFloorOneFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            showFloorTwoFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            showFloorThreeFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
        }
        public void Initialization() 
        {
            this.bt1_Click(this, null);
        }
    }
}
