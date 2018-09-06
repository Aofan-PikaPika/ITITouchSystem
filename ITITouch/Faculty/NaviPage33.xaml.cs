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

    public delegate void showLec1Bt5Handle();
    /// <summary>
    /// NaviPage33.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage33 : Page
    {

        public showLec1Bt5Handle showLec1Bt5Function;
        public showLecturerUpHandle showLecturerUpFunction;
        public event pageDelegate sendPage;
        public NaviPage33()
        {
            InitializeComponent();
        }

        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);

        private void btUp_Click(object sender, RoutedEventArgs e)
        {
            showLecturerUpFunction();
        }
        private void bt1_Click(object sender, RoutedEventArgs e)    //袁玉倩
        {
            
            sendPage("http://ai.hebut.edu.cn/staff/teachers/yuanyuqian.html");
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            


        }

        private void bt2_Click(object sender, RoutedEventArgs e)    //翟艳东
        {
           
            sendPage("http://ai.hebut.edu.cn/staff/teachers/zhaiyandong.html");
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
           
        }

        private void bt3_Click(object sender, RoutedEventArgs e)    //张家安
        {
            
            sendPage("http://ai.hebut.edu.cn/staff/teachers/e5-bc-a0-e5-ae-b6-e5-ae-89.html");
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
           
        }

        private void bt4_Click(object sender, RoutedEventArgs e)    //张健楠
        {
            
            sendPage("http://ai.hebut.edu.cn/staff/teachers/zhangjiannan.html");
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
          

        }

        private void bt5_Click(object sender, RoutedEventArgs e)    //张亚娟
        {
            showLec1Bt5Function();
            w5.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w1.Background = oldbrush;
            w6.Background = oldbrush;
            

        }

        private void bt6_Click(object sender, RoutedEventArgs e)    //朱怀忠
        {
           
            sendPage("http://ai.hebut.edu.cn/staff/teachers/zhuhuaizhong.html");
            w6.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w1.Background = oldbrush;
           
        }

        private void btDown_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
