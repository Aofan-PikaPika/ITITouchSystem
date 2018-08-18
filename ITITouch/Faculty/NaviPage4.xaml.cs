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
    public delegate void Visitingbt1Handle();
    public delegate void Visitingbt2Handle();
    public delegate void Visitingbt3Handle();
    public delegate void Visitingbt4Handle();
    public delegate void Visitingbt5Handle();
    public delegate void Visitingbt6Handle();
    public delegate void Visitingbt7Handle();



    /// <summary>
    /// NaviPage4.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage4 : Page
    {
        public Visitingbt1Handle showVistingbt1Function;
        public Visitingbt2Handle showVistingbt2Function;
        public Visitingbt3Handle showVistingbt3Function;
        public Visitingbt4Handle showVistingbt4Function;
        public Visitingbt5Handle showVistingbt5Function;
        public Visitingbt6Handle showVistingbt6Function;
        public Visitingbt7Handle showVistingbt7Function;
        public NaviPage4()
        {
            InitializeComponent();
        }
        SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
        SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
      

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            showVistingbt1Function();
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            showVistingbt2Function();
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            showVistingbt3Function();
            w3.Background = brush;
            w2.Background = oldbrush;
            w1.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            showVistingbt4Function();
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
        }

        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            showVistingbt5Function();
            w5.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w1.Background = oldbrush;
            w6.Background = oldbrush;
            w7.Background = oldbrush;
        }

        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            showVistingbt6Function();
            w6.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w1.Background = oldbrush;
            w7.Background = oldbrush;
        }

        private void bt7_Click(object sender, RoutedEventArgs e)
        {
            showVistingbt7Function();
            w7.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
            w5.Background = oldbrush;
            w6.Background = oldbrush;
            w1.Background = oldbrush;
        }
    }
}
