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
using System.Windows.Shapes;

namespace ITITouch.Education
{
    /// <summary>
    /// EducationWindow.xaml 的交互逻辑
    /// </summary>
    public partial class EducationWindow : Window
    {
        public EducationWindow()
        {
            InitializeComponent();
            NaviPage1 nv1 = new NaviPage1();
            frameNavi.Content = nv1;
            nv1.showCSFunction += new showCSHandle(CS);
            nv1.showIOTFunction += new showIOTHandle(IOT);
            nv1.showNetFunction += new showNetHandle(Net);
            nv1.showSWFunction += new showSWHandle(SW);
            nv1.Initialation();
            this.rb1.IsChecked = true;
        }

        private void bt_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rb2_Click(object sender, RoutedEventArgs e)
        {
            NaviPage2 nv2 = new NaviPage2();
            frameNavi.Content = nv2;
            nv2.showPostCSFunction += new showPostCSHandle(PostCS);
            nv2.showPostRCHandle += new showPostRCHandle(PostRC);
            nv2.showPostCTFunction += new showPostCTHandle(PostCT);
            nv2.showPostSWHandle += new showPostSWHandle(PostSW);
            nv2.Initialation();
        }

        private void rb1_Click(object sender, RoutedEventArgs e)
        {
            NaviPage1 nv1 = new NaviPage1();
            frameNavi.Content = nv1;
            nv1.showCSFunction += new showCSHandle(CS);
            nv1.showIOTFunction += new showIOTHandle(IOT);
            nv1.showNetFunction += new showNetHandle(Net);
            nv1.showSWFunction += new showSWHandle(SW);
            nv1.Initialation();
        }

        private void PostCS() 
        {
            PostgComputerScience pcs = new PostgComputerScience();
            this.frameShow.Content = pcs;
        }
        private void PostRC() 
        {
            PostgR pr= new PostgR();
            this.frameShow.Content = pr;
        }
        private void PostCT() 
        {
            PostgComputerT pct = new PostgComputerT();
            this.frameShow.Content = pct;
        }
        private void PostSW() 
        {
            PostSoftware psw = new PostSoftware();
            this.frameShow.Content = psw;
        }

        private void CS() 
        {
            ComputerScienceAndTechnology ct = new ComputerScienceAndTechnology();
            this.frameShow.Content = ct;
        }

        private void IOT() 
        {
            TheInternetOfThings iot = new TheInternetOfThings();
            this.frameShow.Content = iot;
        }

        private void SW() 
        {
            Software st = new Software();
            this.frameShow.Content = st;
        }

        private void Net() 
        {
            NetworkEngineering ne = new NetworkEngineering();
            this.frameShow.Content = ne;
        }

    }
}
