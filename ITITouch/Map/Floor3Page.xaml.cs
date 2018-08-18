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
    /// Floor3Page.xaml 的交互逻辑
    /// </summary>
    public partial class Floor3Page : Page
    {
        public Floor3Page()
        {
            InitializeComponent();
        }

        private void vision_Click(object sender, RoutedEventArgs e)
        {
            this.pop_vision.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "图形图像与视觉计算研究室";
            this.roomClass.Text = "图形图像与视觉计算研究室";
            this.roomLocation.Text = "计算机科学与软件学院3楼348室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究室主要进行图形图像与视觉计算的研究。";
        }

        private void software_Click(object sender, RoutedEventArgs e)
        {
            this.pop_software.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "软件工程研究中心";
            this.roomClass.Text = "软件工程研究中心";
            this.roomLocation.Text = "计算机科学与软件学院3楼346室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究室主要进行软件工程的研究。";
        }

        private void storage3_Click(object sender, RoutedEventArgs e)
        {
            this.pop_storage3.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "储藏室（三）";
            this.roomClass.Text = "储藏室（三）";
            this.roomLocation.Text = "计算机科学与软件学院3楼344室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       用来储存各种资料。";
        }

        private void storage2_Click(object sender, RoutedEventArgs e)
        {
            this.pop_storage2.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "储藏室（二）";
            this.roomClass.Text = "储藏室（二）";
            this.roomLocation.Text = "计算机科学与软件学院3楼342室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       用来储存各种资料。";
        }

        private void storage1_Click(object sender, RoutedEventArgs e)
        {
            this.pop_storage1.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "储藏室（一）";
            this.roomClass.Text = "储藏室（一）";
            this.roomLocation.Text = "计算机科学与软件学院3楼340室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       用来储存各种资料。";
        }

        private void tutor1_Click(object sender, RoutedEventArgs e)
        {
            this.pop_tutor1.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "导师室";
            this.roomClass.Text = "导师室";
            this.roomLocation.Text = "计算机科学与软件学院3楼338室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：于明。";
        }

        private void net_Click(object sender, RoutedEventArgs e)
        {
            this.pop_net.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "网络工程系主任室";
            this.roomClass.Text = "网络工程系主任室";
            this.roomLocation.Text = "计算机科学与软件学院3楼336室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：吴清。";
        }

        private void hardware_Click(object sender, RoutedEventArgs e)
        {
            this.pop_hardware.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "硬件基础实验室主任室";
            this.roomClass.Text = "硬件基础实验室主任室";
            this.roomLocation.Text = "计算机科学与软件学院3楼334室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：陈冀川。";
        }

        private void education_Click(object sender, RoutedEventArgs e)
        {
            this.pop_education.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "基础教学部主任室";
            this.roomClass.Text = "基础教学部主任室";
            this.roomLocation.Text = "计算机科学与软件学院3楼332室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：柴欣。";
        }

        private void tutor2_Click(object sender, RoutedEventArgs e)
        {
            this.pop_tutor2.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "导师室";
            this.roomClass.Text = "导师室";
            this.roomLocation.Text = "计算机科学与软件学院3楼330室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：沈西挺。";
        }

        private void engineering_Click(object sender, RoutedEventArgs e)
        {
            this.pop_engineering.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "软件工程系主任室";
            this.roomClass.Text = "软件工程系主任室";
            this.roomLocation.Text = "计算机科学与软件学院3楼328室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：石陆魁。";
        }

        private void science_Click(object sender, RoutedEventArgs e)
        {
            this.pop_science.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "计算机科学与技术系主任室";
            this.roomClass.Text = "计算机科学与技术系主任室";
            this.roomLocation.Text = "计算机科学与软件学院3楼326室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：彭玉青。";
        }

        private void tutor3_Click(object sender, RoutedEventArgs e)
        {
            this.pop_tutor3.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "导师室";
            this.roomClass.Text = "导师室";
            this.roomLocation.Text = "计算机科学与软件学院3楼324室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：刘恩海。";
        }

        private void tutor4_Click(object sender, RoutedEventArgs e)
        {
            this.pop_tutor4.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "导师室";
            this.roomClass.Text = "导师室";
            this.roomLocation.Text = "计算机科学与软件学院3楼322室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：耿恒山。";
        }

        private void tutor5_Click(object sender, RoutedEventArgs e)
        {
            this.pop_tutor5.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "导师室";
            this.roomClass.Text = "导师室";
            this.roomLocation.Text = "计算机科学与软件学院3楼320室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：魏玮。";
        }

        private void innovation_Click(object sender, RoutedEventArgs e)
        {
            this.pop_innovation.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "协同创新办公室";
            this.roomClass.Text = "协同创新办公室";
            this.roomLocation.Text = "计算机科学与软件学院3楼318室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       进行协同创新的办公室。";
        }

        private void tutor6_Click(object sender, RoutedEventArgs e)
        {
            this.pop_tutor6.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "导师室";
            this.roomClass.Text = "导师室";
            this.roomLocation.Text = "计算机科学与软件学院3楼316室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：刘晶。";
        }

        private void tutor7_Click(object sender, RoutedEventArgs e)
        {
            this.pop_tutor7.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "导师室";
            this.roomClass.Text = "导师室";
            this.roomLocation.Text = "计算机科学与软件学院3楼314室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：王晓芳。";
        }

        private void advisory_Click(object sender, RoutedEventArgs e)
        {
            this.pop_advisory.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "学科建设咨询委员会";
            this.roomClass.Text = "学科建设咨询委员会";
            this.roomLocation.Text = "计算机科学与软件学院3楼312室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       进行学科建设咨询。";
        }

        private void deputy_Click(object sender, RoutedEventArgs e)
        {
            this.pop_deputy.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "副书记室；副院长室";
            this.roomClass.Text = "副书记室；副院长室";
            this.roomLocation.Text = "计算机科学与软件学院3楼310室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：王轩。";
        }

        private void dean_Click(object sender, RoutedEventArgs e)
        {
            this.pop_dean.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "院长室";
            this.roomClass.Text = "院长室";
            this.roomLocation.Text = "计算机科学与软件学院3楼308室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：于明。";
        }

        private void teaching_Click(object sender, RoutedEventArgs e)
        {
            this.pop_teaching.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "行政教学办公室";
            this.roomClass.Text = "行政教学办公室";
            this.roomLocation.Text = "计算机科学与软件学院3楼306室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：王靖鑫。";
        }

        private void lounge_Click(object sender, RoutedEventArgs e)
        {
            this.pop_lounge.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "教师休息室";
            this.roomClass.Text = "教师休息室";
            this.roomLocation.Text = "计算机科学与软件学院3楼304室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：王晓芳。";
        }

        private void meeting_Click(object sender, RoutedEventArgs e)
        {
            this.pop_meeting.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "会议室";
            this.roomClass.Text = "会议室";
            this.roomLocation.Text = "计算机科学与软件学院3楼302室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：王靖鑫。";
        }

        private void reference1_Click(object sender, RoutedEventArgs e)
        {
            this.pop_reference1.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "资料室";
            this.roomClass.Text = "资料室";
            this.roomLocation.Text = "计算机科学与软件学院3楼301室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：李妍。";
        }

        private void reference2_Click(object sender, RoutedEventArgs e)
        {
            this.pop_reference2.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "资料室";
            this.roomClass.Text = "资料室";
            this.roomLocation.Text = "计算机科学与软件学院3楼303室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：王靖鑫。";
        }

        private void exchange_Click(object sender, RoutedEventArgs e)
        {
            this.pop_exchange.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "学术交流室";
            this.roomClass.Text = "学术交流室";
            this.roomLocation.Text = "计算机科学与软件学院3楼305室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       在此进行学术的交流。";
        }

        private void reading_Click(object sender, RoutedEventArgs e)
        {
            this.pop_reading.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "阅览室";
            this.roomClass.Text = "阅览室";
            this.roomLocation.Text = "计算机科学与软件学院3楼309室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       阅览一些图书和资料。";
        }

        private void computer_Click(object sender, RoutedEventArgs e)
        {
            this.pop_computer.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "计算机系教研室";
            this.roomClass.Text = "计算机系教研室";
            this.roomLocation.Text = "计算机科学与软件学院3楼313室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       负责人：彭玉青。";
        }

        private void base_Click(object sender, RoutedEventArgs e)
        {
            this.pop_base.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "基础教学部教研室";
            this.roomClass.Text = "基础教学部教研室";
            this.roomLocation.Text = "计算机科学与软件学院3楼317室";
            this.roomPhone.Text = "无";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       基础教学部教研办公室。";
        }
    }
}
