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
    /// Floor2Page.xaml 的交互逻辑
    /// </summary>
    public partial class Floor2Page : Page
    {
        public Floor2Page()
        {
            InitializeComponent();
        }

        private void staffroom_Click(object sender, RoutedEventArgs e)
        {
            this.pop_staffroom.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "教工活动室";
            this.roomClass.Text = "教工活动室";
            this.roomLocation.Text = "计算机科学与软件学院2楼202室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       教工活动室用来进行教工的一系列活动";
        }

        private void staffroom2_Click(object sender, RoutedEventArgs e)
        {
            this.pop_staffroom2.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "教工活动室";
            this.roomClass.Text = "教工活动室";
            this.roomLocation.Text = "计算机科学与软件学院2楼204室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       教工活动室用来进行教工的一系列活动";
        }

        private void studentjob_Click(object sender, RoutedEventArgs e)
        {
            this.pop_studentjob.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "学生工作办公室";
            this.roomClass.Text = "学生工作办公室";
            this.roomLocation.Text = "计算机科学与软件学院2楼206室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       学生工作办公室用来进行组织学生的一系列活动。";
        }

        private void salon_Click(object sender, RoutedEventArgs e)
        {
            this.pop_salon.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "教工沙龙室";
            this.roomClass.Text = "教工沙龙室";
            this.roomLocation.Text = "计算机科学与软件学院2楼208室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       教工沙龙室是教工进行休息的场所。";
        }

        private void software_Click(object sender, RoutedEventArgs e)
        {
            this.pop_software.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "软件工程系教研室";
            this.roomClass.Text = "软件工程系教研室";
            this.roomLocation.Text = "计算机科学与软件学院2楼210室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       软件工程系学生进行研究。";
        }

        private void internet_Click(object sender, RoutedEventArgs e)
        {
            this.pop_internet.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "网络工程系教研室";
            this.roomClass.Text = "网络工程系教研室";
            this.roomLocation.Text = "计算机科学与软件学院2楼212室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       网络工程系教研室学生进行研究。";
        }

        private void networks_Click(object sender, RoutedEventArgs e)
        {
            this.pop_networks.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "网络与分布式计算研究室";
            this.roomClass.Text = "网络与分布式计算研究室";
            this.roomLocation.Text = "计算机科学与软件学院2楼201室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究室主要研究有关网络与分布式计算。";
        }

        private void data_Click(object sender, RoutedEventArgs e)
        {
            this.pop_data.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "大数据处理实验室";
            this.roomClass.Text = "大数据处理实验室";
            this.roomLocation.Text = "计算机科学与软件学院2楼209室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该实验室主要进行有关大数据处理。";
        }

        private void information_Click(object sender, RoutedEventArgs e)
        {
            this.pop_information.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "电子商务与信息系统研究室";
            this.roomClass.Text = "电子商务与信息系统研究室";
            this.roomLocation.Text = "计算机科学与软件学院2楼213室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究室主要研究电子商务与信息系统。";
        }

        private void softwaretheory_Click(object sender, RoutedEventArgs e)
        {
            this.pop_softwaretheory.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "软件工程和理论实验室";
            this.roomClass.Text = "软件工程和理论实验室";
            this.roomLocation.Text = "计算机科学与软件学院2楼214室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该实验室主要进行软件工程和理论的研究。";
        }

        private void security_Click(object sender, RoutedEventArgs e)
        {
            this.pop_security.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "网络工程与信息安全研究室";
            this.roomClass.Text = "网络工程与信息安全研究室";
            this.roomLocation.Text = "计算机科学与软件学院2楼218室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究室主要进行网络工程与信息安全研究。";
        }

        private void image_Click(object sender, RoutedEventArgs e)
        {
            this.pop_image.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "图像处理与模式研究室";
            this.roomClass.Text = "图像处理与模式研究室";
            this.roomLocation.Text = "计算机科学与软件学院2楼222室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究室主要进行图像处理与模式的研究。";
        }

        private void intelligent_Click(object sender, RoutedEventArgs e)
        {
            this.pop_intelligent.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "智能信息处理与软计算研究室";
            this.roomClass.Text = "智能信息处理与软计算研究室";
            this.roomLocation.Text = "计算机科学与软件学院2楼226室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究室主要进行智能信息处理与软计算的研究。";
        }

        private void keydata_Click(object sender, RoutedEventArgs e)
        {
            this.pop_keydata.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "河北省大数据计算重点实验室";
            this.roomClass.Text = "河北省大数据计算重点实验室";
            this.roomLocation.Text = "计算机科学与软件学院2楼234室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该实验室是河北省大数据计算重点实验室。";
        }

        private void technology_Click(object sender, RoutedEventArgs e)
        {
            this.pop_technology.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "信息技术研究所";
            this.roomClass.Text = "信息技术研究所";
            this.roomLocation.Text = "计算机科学与软件学院2楼238室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究所主要进行信息技术的研究。";
        }

        private void transportation_Click(object sender, RoutedEventArgs e)
        {
            this.pop_transportation.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "交通领域智能技术研究室";
            this.roomClass.Text = "交通领域智能技术研究室";
            this.roomLocation.Text = "计算机科学与软件学院2楼240室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究室主要进行交通领域智能技术的研究。";
        }

        private void machinelearning_Click(object sender, RoutedEventArgs e)
        {
            this.pop_machinelearning.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "软件开发和机器学习研究室";
            this.roomClass.Text = "软件开发和机器学习研究室";
            this.roomLocation.Text = "计算机科学与软件学院2楼230室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       该研究室主要进行软件开发和机器学习的研究。";
        }

        private void research_Click(object sender, RoutedEventArgs e)
        {
            this.pop_research.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "研究生实验室";
            this.roomClass.Text = "研究生实验室";
            this.roomLocation.Text = "计算机科学与软件学院2楼205室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       研究生可以在实验室进行学习和研究。";
        }

        private void softwareheory_Click(object sender, RoutedEventArgs e)
        {
            this.pop_softwaretheory.IsOpen = true;
            this.poptxt.IsOpen = true;
            this.roomName.Text = "软工理论实验室";
            this.roomClass.Text = "软工理论实验室";
            this.roomLocation.Text = "计算机科学与软件学院2楼205室";
            this.roomPhone.Text = "5830";
            this.roomPic.Source = new BitmapImage(new Uri(@"/ITITouch;component/Resources/Rooms/rooms.png", UriKind.Relative));
            this.roomContent.Text = "       研究生可以在实验室进行软工理论的研究。";
        }
    }
}
