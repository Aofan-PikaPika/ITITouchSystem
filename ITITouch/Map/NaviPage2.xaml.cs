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
    public delegate void BaiduHandle();
    public delegate void Baidu3DHandle();
    /// <summary>
    /// NaviPage2.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage2 : Page
    {
        public BaiduHandle BaiduFunction;
        public Baidu3DHandle Baidu3DFunction;
        public NaviPage2()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            BaiduFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w1.Background = brush;
            w2.Background = oldbrush;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            Baidu3DFunction();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w2.Background = brush;
            w1.Background = oldbrush;
        }

        public void Initialization() 
        {
            this.bt1_Click(this,null);
        }
    }
}
