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
    public delegate void showLectuerDownHandle();
    public delegate void showLectuerbt1Handle();
    public delegate void showLectuerbt3Handle();
    public delegate void showLectuerbt4Handle();
    //public delegate void showLectuerbt5Handle();
    //public delegate void showLectuerbt6Handle();
    //public delegate void showLectuerbt7Handle();
    //public delegate void showLectuerbt8Handle();
    public delegate void showLectuerbt9Handle();
    public delegate void showLectuerbt10Handle();
    //public delegate void showLectuerbt11Handle();
    //public delegate void showLectuerbt12Handle();
    //public delegate void showLectuerbt13Handle();

    /// <summary>
    /// NaviPage3.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage3 : Page
    {
        public showLectuerDownHandle showLectuerDownFunction;
        public showLectuerbt1Handle showLectuerbt1Function;
        //public showLectuerbt2Handle showLectuerbt2Function;
        public showLectuerbt3Handle showLectuerbt3Function;
        public showLectuerbt4Handle showLectuerbt4Function;
        //public showLectuerbt5Handle showLectuerbt5Function;
        //public showLectuerbt6Handle showLectuerbt6Function;
        //public showLectuerbt7Handle showLectuerbt7Function;
        //public showLectuerbt8Handle showLectuerbt8Function;
        public showLectuerbt9Handle showLectuerbt9Function;
        public showLectuerbt10Handle showLectuerbt10Function;
        //public showLectuerbt11Handle showLectuerbt11Function;
        //public showLectuerbt12Handle showLectuerbt12Function;
        //public showLectuerbt13Handle showLectuerbt13Function;
        public event pageDelegate sendPage;

        public NaviPage3()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);



        private void bt1_Click(object sender, RoutedEventArgs e)    //毕晓博
        {
            showLectuerbt1Function();
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

        private void bt2_Click(object sender, RoutedEventArgs e)    //陈鹏
        {
            //showLectuerbt2Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e9-99-88-e9-b9-8f.html"));
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

        private void bt3_Click(object sender, RoutedEventArgs e)    //董瑶
        {
            showLectuerbt3Function();
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

        private void bt4_Click(object sender, RoutedEventArgs e)    //高卫香
        {
            showLectuerbt4Function();
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

        private void bt5_Click(object sender, RoutedEventArgs e)    //耿艳利
        {
            //showLectuerbt5Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e8-80-bf-e8-89-b3-e5-88-a9.html"));
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

        private void bt6_Click(object sender, RoutedEventArgs e)    //郝小可
        {
            //showLectuerbt6Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/hao-xiao-ke.html"));
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

        private void bt7_Click(object sender, RoutedEventArgs e)    //荆锴
        {
            //showLectuerbt7Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e8-8d-86-e9-94-b4.html"));
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

        private void bt8_Click(object sender, RoutedEventArgs e)    //李洁
        {
            //showLectuerbt8Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e6-9d-8e-e6-b4-81.html"));
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

        private void bt9_Click(object sender, RoutedEventArgs e)    //李娟
        {
            showLectuerbt9Function();
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

        private void bt10_Click(object sender, RoutedEventArgs e)    //李智
        {
            showLectuerbt10Function();
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

        private void bt11_Click(object sender, RoutedEventArgs e)    //林晓静
        {
            //showLectuerbt11Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/linxiaojing.html"));
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

        private void bt12_Click(object sender, RoutedEventArgs e)    //刘洪普
        {
            //showLectuerbt12Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/liuhongpu.html"));
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

        private void bt13_Click(object sender, RoutedEventArgs e)    //刘依
        {
            //showLectuerbt13Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/liuyi.html"));
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
            showLectuerDownFunction();
        }
    }
}
