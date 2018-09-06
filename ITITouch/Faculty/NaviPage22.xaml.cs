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
    
    public delegate void ProUpPageHandle();

    
    //public delegate void ProBt1Handle();
    //public delegate void ProBt2Handle();
    //public delegate void ProBt3Handle();
    //public delegate void ProBt4Handle();
    public delegate void ProBt5Handle();
    //public delegate void ProBt6Handle();

    /// <summary>
    /// NaviPage22.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage22 : Page
    {
        
        public ProUpPageHandle showProUpFunction;

        public ProfessorShowNextHandle showproNextFunction;
        //public ProBt1Handle showBt1Function;
        //public ProBt2Handle showBt2Function;
        //public ProBt3Handle showBt3Function;

        //public ProBt4Handle showBt4Function;
        public ProBt5Handle showBt5Function;
        //public ProBt6Handle showBt6Function;
        public event pageDelegate sendPage;
        public NaviPage22()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            showProUpFunction();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)    //李志军
        {
            //showBt1Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e6-9d-8e-e5-bf-97-e5-86-9b.html"));  
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

        private void bt2_Click(object sender, RoutedEventArgs e)    //梁涛
        {
            //showBt2Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e9-83-ad-e6-ac-a3.htmlhttp://ai.hebut.edu.cn/staff/teachers/e6-a2-81-e6-b6-9b.html"));  
            w2.Background = brush;
            w10.Background = oldbrush;
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

        private void bt3_Click(object sender, RoutedEventArgs e)    //梁秀霞
        {
            //showBt3Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e6-a2-81-e7-a7-80-e9-9c-9e.html"));  
            w3.Background = brush;
            w2.Background = oldbrush;
            w10.Background = oldbrush;
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

        private void bt4_Click(object sender, RoutedEventArgs e)    //林涛
        {
            //showBt4Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/lintao.html"));  
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w10.Background = oldbrush;
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

        private void bt5_Click(object sender, RoutedEventArgs e)    //刘国丽
        {
            showBt5Function();
            //sendPage(("")); 
            w5.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w10.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w1.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt6_Click(object sender, RoutedEventArgs e)    //刘晶
        {
            //showBt6Function();
            sendPage(("http://ai.hebut.edu.cn/uncategorized/11774.html"));  
            w6.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w10.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w1.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt7_Click(object sender, RoutedEventArgs e)    //刘作军
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/liu-zuo-jun.html"));  
            w7.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w10.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w1.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt8_Click(object sender, RoutedEventArgs e)    //马建红
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/ma-jian-hong.html"));  
            w8.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w10.Background = oldbrush;
            w9.Background = oldbrush;
            w1.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt9_Click(object sender, RoutedEventArgs e)    //牛存良
        {
            sendPage((""));  
            w9.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w10.Background = oldbrush;
            w1.Background = oldbrush;
            w11.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt10_Click(object sender, RoutedEventArgs e)    //彭玉青
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/pengyuqing.html"));  
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

        private void bt11_Click(object sender, RoutedEventArgs e)    //沈西挺
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/shenxiting.html"));  
            w11.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
            w8.Background = oldbrush;
            w9.Background = oldbrush;
            w1.Background = oldbrush;
            w10.Background = oldbrush;
            w12.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt12_Click(object sender, RoutedEventArgs e)    //石陆魁
        {
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/11164.html"));  
            w12.Background = brush;
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
            w10.Background = oldbrush;
            w13.Background = oldbrush;
        }

        private void bt13_Click(object sender, RoutedEventArgs e)    //宋洁
        {
            sendPage((""));  
            w13.Background = brush;
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
            w10.Background = oldbrush;
        }

        private void btDown_Click(object sender, RoutedEventArgs e)
        {
            showproNextFunction();
        }
    }
}
