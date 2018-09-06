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
    /// <summary>
    /// NaviPage13.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage13 : Page
    {

        public showUpHandle showUpFunction;
        public event pageDelegate sendPage;

        public NaviPage13()
        {
            InitializeComponent();
        }

        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);

       
        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            showUpFunction();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)    //张满囤
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/zhang-man-tun.html"));
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)    //张萍
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e5-bc-a0-e8-90-8d.html"));
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)    //张强
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/zhang-qiang.html"));
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)    //周颖
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e5-91-a8-e9-a2-96.html"));
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
        }

        private void btDown_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
