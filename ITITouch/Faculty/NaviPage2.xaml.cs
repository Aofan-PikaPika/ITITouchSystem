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
    
    public delegate void ProfessorShowNextHandle();
    //public delegate void Professorbt1Handle();
    //public delegate void Professorbt2Handle();
    //public delegate void Professorbt3Handle();
    //public delegate void Professorbt4Handle();
    //public delegate void Professorbt5Handle();
    //public delegate void Professorbt6Handle();
    //public delegate void Professorbt7Handle();
    //public delegate void Professorbt8Handle();
    //public delegate void Professorbt9Handle();
    //public delegate void Professorbt10Handle();
    //public delegate void Professorbt11Handle();
    //public delegate void Professorbt12Handle();
    //public delegate void Professorbt13Handle();
    /// <summary>
    /// NaviPage2.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage2 : Page
    {
          
        public ProfessorShowNextHandle showproNextFunction;
        //public Professorbt1Handle showProfessorbt1Function;
        //public Professorbt2Handle showProfessorbt2Function;
        //public Professorbt3Handle showProfessorbt3Function;
        //public Professorbt4Handle showProfessorbt4Function;
        //public Professorbt5Handle showProfessorbt5Function;
        //public Professorbt6Handle showProfessorbt6Function;
        //public Professorbt7Handle showProfessorbt7Function;
        //public Professorbt8Handle showProfessorbt8Function;
        //public Professorbt9Handle showProfessorbt9Function;
        //public Professorbt10Handle showProfessorbt10Function;
        //public Professorbt11Handle showProfessorbt11Function;
        //public Professorbt12Handle showProfessorbt12Function;
        //public Professorbt13Handle showProfessorbt13Function;
        public event pageDelegate sendPage;

        public NaviPage2()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
        private void bt1_Click(object sender, RoutedEventArgs e)    //柴欣
        {
            //showProfessorbt1Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/chaixin.html"));  
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

        private void bt2_Click(object sender, RoutedEventArgs e)    //陈海永
        {
            //showProfessorbt2Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e9-99-88-e6-b5-b7-e6-b0-b8.html")); 
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

        private void bt3_Click(object sender, RoutedEventArgs e)    //陈曦
        {
            //showProfessorbt3Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/chen-xi.html"));  
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

        private void bt4_Click(object sender, RoutedEventArgs e)     //丁宝苍
        {
            //showProfessorbt4Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e4-b8-81-e8-8b-8d-e5-ae-9d.html"));  //丁宝苍
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

        private void bt5_Click(object sender, RoutedEventArgs e)    //董砚
        {
            //showProfessorbt5Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e8-91-a3-e7-a0-9a.html"));  //董砚
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

        private void bt6_Click(object sender, RoutedEventArgs e)    //董永峰
        {
            //showProfessorbt6Function();
            sendPage(("http://ai.hebut.edu.cn/educate/education-master/tutor/dongyongfeng.html"));  //董永峰
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

        private void bt7_Click(object sender, RoutedEventArgs e)    //杜太行
        {
            //showProfessorbt7Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e6-9d-9c-e5-a4-aa-e8-a1-8c.html"));  //杜太行
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

        private void bt8_Click(object sender, RoutedEventArgs e)    //耿恒山
        {
            //showProfessorbt8Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/genghengshan.html"));  //耿恒山
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

        private void bt9_Click(object sender, RoutedEventArgs e)    //顾军华
        {
            //showProfessorbt9Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/gujunhua.html"));  //顾军华
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

        private void bt10_Click(object sender, RoutedEventArgs e)    //郭欣
        {
            //showProfessorbt10Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e9-83-ad-e6-ac-a3.html"));  //郭欣
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

        private void bt11_Click(object sender, RoutedEventArgs e)    //郭迎春
        {
            //showProfessorbt11Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/guo-ying-chun.html"));  //郭迎春
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

        private void bt12_Click(object sender, RoutedEventArgs e)    //李建伟
        {
            //showProfessorbt12Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/lijianwei.html"));  //李建伟
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

        private void bt13_Click(object sender, RoutedEventArgs e)    //李练兵
        {
            //showProfessorbt13Function();
            sendPage(("http://ai.hebut.edu.cn/staff/teachers/e6-9d-8e-e7-bb-83-e5-85-b5.html"));  //李练兵
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
            showproNextFunction();
        }
    }
}
