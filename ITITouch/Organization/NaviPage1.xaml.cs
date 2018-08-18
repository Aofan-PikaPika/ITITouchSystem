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

namespace ITITouch.Organization
{
    public delegate void showDepartmentHandle();
    public delegate void showCollegeHandle();
    public delegate void showStudentHandle();
    public delegate void showCommiteeHandle();


    /// <summary>
    /// NaviPage1.xaml 的交互逻辑
    /// </summary>
    public partial class NaviPage1 : Page
    {
        public showDepartmentHandle FunctionDepartment;
        public showCollegeHandle CollegeDepartment;
        public showStudentHandle StudentDepartment;
        public showCommiteeHandle Committee;
        public NaviPage1()
        {
            InitializeComponent();
        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            Committee();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w1.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            FunctionDepartment();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w2.Background = brush;
            w1.Background = oldbrush;
            w3.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            CollegeDepartment();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w3.Background = brush;
            w1.Background = oldbrush;
            w2.Background = oldbrush;
            w4.Background = oldbrush;
        }

        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            StudentDepartment();
            SolidColorBrush brush = new SolidColorBrush(Colors.LightSkyBlue);
            SolidColorBrush oldbrush = new SolidColorBrush(Colors.White);
            w4.Background = brush;
            w2.Background = oldbrush;
            w3.Background = oldbrush;
            w1.Background = oldbrush;
        }

        public void Initialization() 
        {
            this.bt1_Click(this, null);
        }
    }
}
