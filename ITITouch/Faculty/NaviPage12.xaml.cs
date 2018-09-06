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
    //public delegate void showBt1Handle();
    //public delegate void showBt2Handle();
    //public delegate void showBt3Handle();
    //public delegate void showBt4Handle();
    //public delegate void showBt5Handle();
    public delegate void showBt6Handle();
    //public delegate void showBt7Handle();
    //public delegate void showBt8Handle();
    //public delegate void showBt9Handle();

    /// <summary>
    /// NaviPage12.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage12 : Page
    {
        public showUpHandle showUpFunction;

        public showNextHandle showNextFuction;
        //public showBt1Handle showBt1Function;
        //public showBt2Handle showBt2Function;
        //public showBt3Handle showBt3Function;
        //public showBt4Handle showBt4Function;
        //public showBt5Handle showBt5Function;
        public showBt6Handle showBt6Function;
        //public showBt7Handle showBt7Function;
        //public showBt8Handle showBt8Function;
        //public showBt9Handle showBt9Function;
        public event pageDelegate sendPage;

        public NaviPage12()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            showUpFunction();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)    //史巧硕
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/shiqiaoshuo.html"));
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
        }

        private void bt2_Click(object sender, RoutedEventArgs e)    //孙昊
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e5-ad-99-e6-98-8a.html"));
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
        }

        private void bt3_Click(object sender, RoutedEventArgs e)    //孙曙光
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e5-ad-99-e6-9b-99-e5-85-89.html"));
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
        }

        private void bt4_Click(object sender, RoutedEventArgs e)    //田红丽
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/tian-hong-li.html"));
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
        }

        private void bt5_Click(object sender, RoutedEventArgs e)    //宛艳萍
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/yuanyanping.html"));
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
        }

        private void bt6_Click(object sender, RoutedEventArgs e)    //汪鹏
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
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt7_Click(object sender, RoutedEventArgs e)    //肖国玺
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/xiaoguoxi.html"));
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
        }

        private void bt8_Click(object sender, RoutedEventArgs e)    //许智宏
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/xu-zhi-hong.html"));
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
        }

        private void bt9_Click(object sender, RoutedEventArgs e)    //阎刚
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/yan-gang.html"));
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
        }

        private void bt10_Click(object sender, RoutedEventArgs e)    //杨德东
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e6-9d-a8-e5-be-b7-e4-b8-9c.html"));
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
        }

        private void bt11_Click(object sender, RoutedEventArgs e)    //杨素梅
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/yangsumei.html"));
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
        }

        private void bt12_Click(object sender, RoutedEventArgs e)    //张红梅
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/zhanghongmei.html"));
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
        }

        private void bt13_Click(object sender, RoutedEventArgs e)    //张军
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/zhang-jun.html"));
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
        }

        private void btDown_Click(object sender, RoutedEventArgs e)
        {
            showNextFuction();
        }
    }
}
