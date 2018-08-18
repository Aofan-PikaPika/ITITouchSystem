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

namespace ITITouch.Faculty.Lecturer.LinXiaoJing
{
    /// <summary>
    /// MainPage.xaml 的交互逻辑
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            BlueBottomLblHide();
            clblResearchDirection_MouseUp(this, null);
        }

        private void clblResearchDirection_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.frmPersonal.Navigate(new Uri("Faculty/Lecturer/LinXiaoJing/ResearchDirection.xaml", UriKind.Relative));
            BlueBottomLblHide();
            this.lblResearchDirection.Visibility = Visibility.Visible;
        }

        private void clblPersonalProfile_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.frmPersonal.Navigate(new Uri("Faculty/Lecturer/LinXiaoJing/PersonalProfile.xaml", UriKind.Relative));
            BlueBottomLblHide();
            this.lblPersonalProfile.Visibility = Visibility.Visible;
        }

        public void BlueBottomLblHide()
        {
            this.lblAlbum.Visibility = Visibility.Hidden;
            this.lblPersonalProfile.Visibility = Visibility.Hidden;
            this.lblResearchDirection.Visibility = Visibility.Hidden;
        }

        private void clblAlbum_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.frmPersonal.Navigate(new Uri("Faculty/Lecturer/LinXiaoJing/Album.xaml", UriKind.Relative));
            BlueBottomLblHide();
            this.lblAlbum.Visibility = Visibility.Visible;
        }
    }
}