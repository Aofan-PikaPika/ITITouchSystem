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

namespace ITITouch.Scientific
{
    /// <summary>
    /// ScientificWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ScientificWindow : Window
    {
        public ScientificWindow()
        {
            InitializeComponent();
            NaviPage nv = new NaviPage();
            this.frameNavi.Content = nv;
            nv.showIn1Fuction += new showIn1Handle(In1);
            nv.showIn2Fuction += new showIn2Handle(In2);
            nv.showIn3Fuction += new showIn3Handle(In3);
            nv.Initialization();
        }
        public void In1() 
        {
            Page1Institute p1 = new Page1Institute();
            this.frameShow.Content = p1;
        }
        public void In2() 
        {
            Page2Institute p2 = new Page2Institute();
            this.frameShow.Content = p2;
        }
        public void In3() 
        {
            Page3Institute p3 = new Page3Institute();
            this.frameShow.Content = p3;
        }

        private void bt_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
