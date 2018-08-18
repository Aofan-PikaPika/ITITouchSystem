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
using ITITouch.Controls;

namespace ITITouch.Infomation
{
    /// <summary>
    /// CollegeLogo.xaml 的交互逻辑
    /// </summary>
    public partial class CollegeLogo : Page
    {
        public CollegeLogo()
        {
            InitializeComponent();
        }

        Viewport3DControl view;

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            view3dball.MoveToRight();
            if (view != null)
            {
                view.MoveToRight();
            }
            txtleft.Visibility = Visibility.Hidden;
            txtright.Visibility = Visibility.Visible;
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            view3dball.MoveToLeft();
            if (view != null)
            {
                view.MoveToLeft();
            }
            txtleft.Visibility = Visibility.Visible;
            txtright.Visibility = Visibility.Hidden;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            view3dball.MoveToCenter();
            txtleft.Visibility = Visibility.Hidden;
            txtright.Visibility = Visibility.Hidden;
        }
    }
}
