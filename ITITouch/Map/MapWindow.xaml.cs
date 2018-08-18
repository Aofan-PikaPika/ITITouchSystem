using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace ITITouch.Map
{
    /// <summary>
    /// MapWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MapWindow : Window
    {
        public MapWindow()
        {
            InitializeComponent();
            NaviPage1 nv1 = new NaviPage1();
            this.frameNavi.Content = nv1;
            nv1.showFloorOneFunction += new showFloorOneHandle(FloorOne);
            nv1.showFloorTwoFunction += new showFloorTwoHandle(FloorTwo);
            nv1.showFloorThreeFunction += new showFloorThreeHandle(FloorThree);
            nv1.Initialization();
            this.rb1.IsChecked = true;
        }

        private void rb1_Click(object sender, RoutedEventArgs e)
        {
            NaviPage1 nv1 = new NaviPage1();
            this.frameNavi.Content = nv1;
            nv1.showFloorOneFunction += new showFloorOneHandle(FloorOne);
            nv1.showFloorTwoFunction += new showFloorTwoHandle(FloorTwo);
            nv1.showFloorThreeFunction += new showFloorThreeHandle(FloorThree);
            nv1.Initialization();
        }

        private void rb2_Click(object sender, RoutedEventArgs e)
        {
            if (PingIpOrDomainName("119.75.217.109"))
            {
                NaviPage2 nv2 = new NaviPage2();
                this.frameNavi.Content = nv2;
                nv2.BaiduFunction += new BaiduHandle(Baidu);
                nv2.Baidu3DFunction += new Baidu3DHandle(Baidu3D);
                nv2.Initialization();
            }
            else 
            {
                this.rb2.IsChecked = false;
                this.rb1.IsChecked = true;
                MsgNotFinish mnf = new MsgNotFinish();
                mnf.ShowDialog();
                
            }
            
        }

        private bool PingIpOrDomainName(string strIpOrDName)
        {
            try
            {
                Ping objPingSender = new Ping();
                PingOptions objpinOptions = new PingOptions();
                objpinOptions.DontFragment = true;
                string data = "";
                byte[] buffer = Encoding.UTF8.GetBytes(data);
                int intTimeout = 120;
                PingReply objPinReply = objPingSender.Send(strIpOrDName, intTimeout, buffer, objpinOptions);
                string strInfo = objPinReply.Status.ToString();
                //这里的netValue在别的函数中以全局变量的形式，判断返回状态
                int netValue = (int)objPinReply.RoundtripTime;
                if (strInfo == "Success")
                {
                    return true;

                }
                else
                {
                    return false;
                }


            }
            catch (Exception)
            {

                return false;
            }

        }

        private void bt_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        //委托事件
        private void FloorOne() 
        {
            Floor1Page f1=new Floor1Page();
            this.frameShow.Content = f1;
        }
        private void FloorTwo() 
        {
            Floor2Page f2 = new Floor2Page();
            this.frameShow.Content = f2;
        }
        private void FloorThree() 
        {
            Floor3Page f3 = new Floor3Page();
            this.frameShow.Content = f3;
        }
        private void Baidu() 
        {
            BaiduPage BP = new BaiduPage();
            this.frameShow.Content = BP;
        }
        private void Baidu3D() 
        {
            Baidu3DPage b3p = new Baidu3DPage();
            this.frameShow.Content = b3p;
        }

    }
}
