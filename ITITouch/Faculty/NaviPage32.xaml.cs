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
    public delegate void showLecturerUpHandle();


    //public delegate void showLecBt1Handle();
    //public delegate void showLecBt2Handle();
    public delegate void showLecBt3Handle();
    //public delegate void showLecBt4Handle();
    public delegate void showLecBt5Handle();
    //public delegate void showLecBt6Handle();
    //public delegate void showLecBt7Handle();
    //public delegate void showLecBt8Handle();
    public delegate void showLecBt9Handle();
    //public delegate void showLecBt10Handle();
    //public delegate void showLecBt11Handle();
    //public delegate void showLecBt12Handle();
    public delegate void showLecBt13Handle();
    //public delegate void showLecBt14Handle();
    
    /// <summary>
    /// NaviPage32.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage32 : Page
    {
        public showLecturerUpHandle showLecturerUpFunction;

        public showLectuerDownHandle showLectuerDownFunction;
        //public showLecBt1Handle showLecBt1Function;
        //public showLecBt2Handle showLecBt2Function;
        public showLecBt3Handle showLecBt3Function;
        //public showLecBt4Handle showLecBt4Function;
        public showLecBt5Handle showLecBt5Function;
        //public showLecBt6Handle showLecBt6Function;
        //public showLecBt7Handle showLecBt7Function;
        //public showLecBt8Handle showLecBt8Function;
        public showLecBt9Handle showLecBt9Function;
        //public showLecBt10Handle showLecBt10Function;
        //public showLecBt11Handle showLecBt11Function;
        //public showLecBt12Handle showLecBt12Function;
        public showLecBt13Handle showLecBt13Function;
        //public showLecBt14Handle showLecBt14Function;
        public event pageDelegate sendPage;

        public NaviPage32()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            showLecturerUpFunction();
           
        }

        private void bt1_Click(object sender, RoutedEventArgs e)    //路静
        {
            //showLecBt1Function();
            sendPage("http://ai.hebut.edu.cn/staff/teachers/lujing.html");
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

        private void bt2_Click(object sender, RoutedEventArgs e)    //吕华
        {
            //showLecBt2Function();
            sendPage("http://ai.hebut.edu.cn/staff/teachers/lvhua.html");
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

        private void bt3_Click(object sender, RoutedEventArgs e)    //马梁
        {
            showLecBt3Function();
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

        private void bt4_Click(object sender, RoutedEventArgs e)    //师硕
        {
            //showLecBt4Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/shishuo.html"));
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

        private void bt5_Click(object sender, RoutedEventArgs e)    //王建勋
        {
            showLecBt5Function();
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

        private void bt6_Click(object sender, RoutedEventArgs e)    //王婕
        {
            //showLecBt6Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e7-8e-8b-e5-a9-95.html"));
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

        private void bt7_Click(object sender, RoutedEventArgs e)    //王立鹏
        {
            //showLecBt7Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/wanglipeng.html"));
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

        private void bt8_Click(object sender, RoutedEventArgs e)    //王利琴
        {
            //showLecBt8Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/wangliqin.html"));
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

        private void bt9_Click(object sender, RoutedEventArgs e)    //王小芳
        {
            showLecBt9Function();
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

        private void bt10_Click(object sender, RoutedEventArgs e)    //吴鸿韬
        {
            //showLecBt10Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/wuhongtao.html"));
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

        private void bt11_Click(object sender, RoutedEventArgs e)    //薛桂香
        {
            //showLecBt11Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/xueguixiang.html"));
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

        private void bt12_Click(object sender, RoutedEventArgs e)    //闫文杰
        {
            //showLecBt12Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/yan-wen-jie.html"));
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

        private void bt13_Click(object sender, RoutedEventArgs e)    //于洋
        {
            showLecBt13Function();
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
