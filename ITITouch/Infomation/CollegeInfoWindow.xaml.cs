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

namespace ITITouch.Infomation
{
    /// <summary>
    /// CollegeInfoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class CollegeInfoWindow : Window
    {
        public CollegeInfoWindow()
        {
            InitializeComponent();
            NaviPage NAVI = new NaviPage();
            NAVI.showProfileFunction += new showFramebt1Handle(showProfile);
            NAVI.showLeaderFunction += new showFramebt3Handle(showLeader);
            NAVI.showHistoryFunction += new showFramebt2Handle(showHistory);
            NAVI.showOldFunction += new showFramebt4Handle(showOld);
            NAVI.showLogoFuntion += new showFramebt5Handle(showLogo);
            this.frameNavi.Content = NAVI;
            NAVI.Initialize();
        }

        private void showProfile()
        {
            this.frameShow.Navigate(new Uri("Infomation/CollegeProfile.xaml", UriKind.Relative));
        }


        private void showHistory()
        {
            this.frameShow.Navigate(new Uri("Infomation/CollegeHistory.xaml", UriKind.Relative));
        }

        private void showLeader()
        {
            this.frameShow.Navigate(new Uri("Infomation/CurrentLeaders.xaml", UriKind.Relative));
        }

        private void showOld()
        {
            this.frameShow.Navigate(new Uri("Infomation/PreviousLeaders.xaml", UriKind.Relative));
        }

        private void showLogo() 
        {
            this.frameShow.Navigate(new Uri("Infomation/CollegeLogo.xaml", UriKind.Relative));
        }
        private void bt_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
