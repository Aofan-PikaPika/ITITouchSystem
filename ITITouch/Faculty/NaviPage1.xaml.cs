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
    public delegate void showNextHandle();
    public delegate void showbt1Handle();
    //public delegate void showbt2Handle();
    //public delegate void showbt3Handle();
    public delegate void showbt4Handle();
    //public delegate void showbt5Handle();
    //public delegate void showbt6Handle();
    //public delegate void showbt7Handle();
    //public delegate void showbt8Handle();
    //public delegate void showbt9Handle();
    //public delegate void showbt10Handle();
    //public delegate void showbt11Handle();
    //public delegate void showbt12Handle();
    //public delegate void showbt13Handle();
    public delegate void pageDelegate(String url);
    /// <summary>
    /// NaviPage1.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage1 : Page
    {
        public showNextHandle showNextFuction;
        public showbt1Handle showBt1Function;
        //public showbt2Handle showBt2Function;
        //public showbt3Handle showBt3Function;
        public showbt4Handle showBt4Function;
        //public showbt5Handle showBt5Function;
        //public showbt6Handle showBt6Function;
        //public showbt7Handle showBt7Function;
        //public showbt8Handle showBt8Function;
        //public showbt9Handle showBt9Function;
        //public showbt10Handle showBt10Function;
        //public showbt11Handle showBt11Function;
        //public showbt12Handle showBt12Function;
        //public showbt13Handle showBt13Function;
        //public event pageDelegate sendPage;
        public event pageDelegate sendPage;

        public NaviPage1()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
        private void bt1_Click(object sender, RoutedEventArgs e)    //曹斌
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
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)    //陈冀川
        {
            //showBt2Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/chenjichuan.html"));
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

        private void bt3_Click(object sender, RoutedEventArgs e)    //陈玲玲
        {
            //showBt3Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e9-99-88-e7-8e-b2-e7-8e-b2.html"));
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

        private void bt4_Click(object sender, RoutedEventArgs e)    //富坤
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
            w10.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)    //傅灵丽
        {
            //showBt5Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/fulingli.html"));
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

        private void bt6_Click(object sender, RoutedEventArgs e)    //郭永芳
        {
            //showBt6Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/guoyongfang.html"));
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

        private void bt7_Click(object sender, RoutedEventArgs e)    //何平
        {
            //showBt7Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/he-ping.html"));
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

        private void bt8_Click(object sender, RoutedEventArgs e)    //侯向丹
        {
            //showBt8Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/houxiangdan.html"));
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

        private void bt9_Click(object sender, RoutedEventArgs e)    //李娜娜
        {
            //showBt9Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/li-na-na.html"));
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

        private void bt10_Click(object sender, RoutedEventArgs e)    //梁艳红
        {
            //showBt10Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/liangyanhong.html"));
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

        private void bt11_Click(object sender, RoutedEventArgs e)    //刘恩海
        {
            //showBt11Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/liu-en-hai.html"));
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

        private void bt12_Click(object sender, RoutedEventArgs e)    //刘靖宇
        {
            //showBt12Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/liujingyu.html"));
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

        private void bt13_Click(object sender, RoutedEventArgs e)    //刘坤
        {
            //showBt13Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e5-88-98-e5-9d-a4.html"));
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
