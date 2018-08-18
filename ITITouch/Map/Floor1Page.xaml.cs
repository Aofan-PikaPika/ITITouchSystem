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
    /// <summary>
    /// Floor1Page.xaml 的交互逻辑
    /// </summary>
    public partial class Floor1Page : Page
    {
        public Floor1Page()
        {
            InitializeComponent();
        }

        private void bt116_Click(object sender, RoutedEventArgs e)
        {
            this.pop116.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "软件开发实验室";
            this.roomClass.Text = "研究生实验室";
            this.roomLocation.Text = "计算机科学与软件学院1楼116室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       实验室涉及的IT领域包括：JAVA WEB 网站开发；Android、iOS 手机客户端开发；C#Windows桌面应用开发";
        }

        private void career_Click(object sender, RoutedEventArgs e)
        {
            this.Pop_ca.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "大学生创新创业实践中心";
            this.roomClass.Text = "本科生创业工作室";
            this.roomLocation.Text = "计算机科学与软件学院1楼104室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/ca.jpg", UriKind.Relative));
            this.roomContent.Text = "       进驻工作室的创业公司有：爱帮农APP、精诺数据等";
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            poptxt.IsOpen = false;
        }

        private void meeting_Click(object sender, RoutedEventArgs e)
        {
            this.pop_meeting.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "学术报告厅";
            this.roomClass.Text = "学术报告厅";
            this.roomLocation.Text = "计算机科学与软件学院1楼124室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       学术报告厅是学生或者老师进行学术报告的场所。";
        }

        private void office_Click(object sender, RoutedEventArgs e)
        {
            this.pop_office.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "实验中心办公室";
            this.roomClass.Text = "实验中心办公室";
            this.roomLocation.Text = "计算机科学与软件学院1楼108室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       实验中心办公室。";
        }

        private void mobile_Click(object sender, RoutedEventArgs e)
        {
            this.pop_mobile.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "移动互联网实验室";
            this.roomClass.Text = "移动互联网实验室";
            this.roomLocation.Text = "计算机科学与软件学院1楼112室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该实验室主要进行移动互联网的研究。";
        }

        private void iot_Click(object sender, RoutedEventArgs e)
        {
            this.pop_iot.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "物联网实验室";
            this.roomClass.Text = "物联网实验室";
            this.roomLocation.Text = "计算机科学与软件学院1楼120室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该实验室主要进行物联网的研究。";
        }

        private void net_Click(object sender, RoutedEventArgs e)
        {
            this.pop_net.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "网络工程实验室";
            this.roomClass.Text = "网络工程实验室";
            this.roomLocation.Text = "计算机科学与软件学院1楼128室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该实验室主要进行网络工程的研究。";
        }

        private void test_Click(object sender, RoutedEventArgs e)
        {
            this.pop_test.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "软件测试实验室";
            this.roomClass.Text = "软件测试实验室";
            this.roomLocation.Text = "计算机科学与软件学院1楼124室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该实验室主要进行软件测试的研究。";
        }

        private void media_Click(object sender, RoutedEventArgs e)
        {
            this.pop_media.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "多媒体应用实验室";
            this.roomClass.Text = "多媒体应用实验室";
            this.roomLocation.Text = "计算机科学与软件学院1楼132室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       多媒体应用实验室在推进素质教育，开发学生潜能有着不可替代的作用。";
        }

        private void machine_Click(object sender, RoutedEventArgs e)
        {
            this.pop_machine.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "服务器机房";
            this.roomClass.Text = "计算机机房";
            this.roomLocation.Text = "计算机科学与软件学院1楼105室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       服务器机房老师学生均可使用";
        }

        private void student_Click(object sender, RoutedEventArgs e)
        {
            this.pop_student.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "学院学生会";
            this.roomClass.Text = "学院本科生学生会";
            this.roomLocation.Text = "计算机科学与软件学院1楼119室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       学生会是现在学校中的组织结构之一，是学生自己的群众性组织，是学校联系学生的桥梁和纽带。在校园运作中起着不可小觑的作用。";
        }

        private void qianrushi_Click(object sender, RoutedEventArgs e)
        {
            this.pop_qianrushi.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "嵌入式开发实验室";
            this.roomClass.Text = "本科生实验室";
            this.roomLocation.Text = "计算机科学与软件学院1楼111室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       嵌入式开发就是指在嵌入式操作系统下进行开发，一般常用的系统有WinCE,linux,android等。";
        }

        private void netdevel_Click(object sender, RoutedEventArgs e)
        {
            this.pop_netdevel.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "网络开发实验室";
            this.roomClass.Text = "网络开发实验室";
            this.roomLocation.Text = "计算机科学与软件学院1楼113室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该实验室主要进行网络开发的实验";
        }
    }
}
