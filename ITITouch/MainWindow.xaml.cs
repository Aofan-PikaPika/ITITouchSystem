using System;
using System.Collections.Generic;
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
using System.Threading;
using System.Windows.Threading;
using ITITouch.Weather;
using ITITouch.Controls;
using System.Net;
using System.Windows.Forms;
using ITITouch.Infomation;
using ITITouch.Website;
using ITITouch.WechatQRCode;

namespace ITITouch
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer ShowTimer;
        private DispatcherTimer ShowTimer1;
        private DispatcherTimer ShowTimer2;
        private String[] IMAGES = { "Resources/11.jpg", "Resources/12.jpg", "Resources/13.jpg", "Resources/14.jpg", "Resources/15.jpg", "Resources/16.png", "Resources/17.png", "Resources/18.png" };
        public MainWindow()
        {
            //clock
            InitializeComponent();
            ShowTimer = new DispatcherTimer();
            ShowTimer.Tick += new EventHandler(ShowCurTimer);
            ShowTimer.Interval = new TimeSpan(0, 0, 0, 1, 0);
            ShowTimer.Start();

            //weather
            ShowTimer1 = new DispatcherTimer();
            ShowTimer1.Tick += new EventHandler(ShowCurWeather);
            ShowTimer1.Interval = new TimeSpan(0, 0, 5, 0, 0);
            ShowTimer1.Start();

            //news

            ShowTimer2 = new DispatcherTimer();
            ShowTimer2.Tick += new EventHandler(ShowCurNews);
            ShowTimer2.Interval = new TimeSpan(0, 1, 0, 0, 0);
            ShowTimer2.Start();

            cutString();
            showcollageNews();


            
           

            imageScrollView1.ChildViewWidth = 750;
            imageScrollView1.ChildViewHeight = 400;
            imageScrollView1.SpaceWidth = 400;
            imageScrollView1.AddImages(IMAGES);
            imageScrollView1.Enableslide = false;
            imageScrollView1.SlideAffect = ImageScrollView.SlideAffectEnum.JumpSlide;

            

        }
        public void showcollageNews() 
        {
            System.Windows.Forms.WebBrowser web = new System.Windows.Forms.WebBrowser();
            web.Navigate("http://www.scse.hebut.edu.cn");
            web.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(web_DocumentCompleted);
        }

        private void ShowCurNews(object sender, EventArgs e)
        {
            showcollageNews();
        }


        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            System.Windows.Forms.WebBrowser web = (System.Windows.Forms.WebBrowser)sender;
            //获得新闻标题
            HtmlElementCollection ElementCollection = web.Document.GetElementsByTagName("header");
            List<string> listTitle = new List<string>();
            foreach (HtmlElement item in ElementCollection)
            {
                string[] sArray = item.InnerText.Split(' ');
                listTitle.Add(sArray[1]);
            }
            //获得图片路径
            HtmlElementCollection webImageCollection = web.Document.GetElementsByTagName("image");
            List<string> listImage = new List<string>();
            for (int i = 0; i < webImageCollection.Count; i++)
            {
                string imgUrl = webImageCollection[i].GetAttribute("src");
                listImage.Add(imgUrl);
            }

            //获得新闻链接
            List<string> listHref = new List<string>();
            HtmlElementCollection webHrefCollection = web.Document.GetElementsByTagName("a");
            for (int i = 0; i < webHrefCollection.Count; i++)
            {
                string href = webHrefCollection[i].GetAttribute("href");
                listHref.Add(href);
            }
            //加载文本、图片
            txt1.Text = listTitle[1];
            txt2.Text = listTitle[2];

            image1.Source = new BitmapImage(new Uri(listImage[6]));
            image2.Source = new BitmapImage(new Uri(listImage[7]));




        }





      
        public void ShowCurTimer(object sender,EventArgs e) 
        {
            this.Tt.Text = DateTime.Now.ToString("HH:mm");
            this.Tt1.Text = DateTime.Now.ToString("yyyy年MM月dd日")+"     "+DateTime.Now.ToString("dddd",new System.Globalization.CultureInfo("zh-cn"));
           
        }
       
        public void ShowCurWeather(object sender, EventArgs e) 
        {
            cutString();
        }

        public void cutString() 
        {
            string infoWeather = "";
            infoWeather = CWeather.GetAllWetherInfo();
            if (infoWeather != "")
            {
                string[] sArray = infoWeather.Split(' ');
                List<string> listInfo = new List<string>(sArray);

                this.releaseTime.Text = listInfo[6].ToString() + "发布";
                this.temperNow.Text = listInfo[2].ToString();
                this.state.Text = listInfo[3].ToString();
                this.temper.Text = listInfo[1].ToString();
                this.wind.Text=listInfo[4].ToString()+" "+listInfo[5].ToString();

                if (state.Text.IndexOf("晴") != -1)
                {
                    this.pic.Source = new BitmapImage(new Uri(@"Resources/sunny.png", UriKind.Relative));
                }
                else if (state.Text.IndexOf("云") != -1 || state.Text.IndexOf("阴") != -1 || state.Text.IndexOf("雾") != -1)
                {
                    this.pic.Source = new BitmapImage(new Uri(@"Resources/cloudy.png", UriKind.Relative));
                }
                else if (state.Text.IndexOf("雨") != -1)
                {
                    this.pic.Source = new BitmapImage(new Uri(@"Resources/rain.png", UriKind.Relative));
                }
                else if (state.Text.IndexOf("雪")!=-1)
                {
                      this.pic.Source = new BitmapImage(new Uri(@"Resources/snow.png",UriKind.Relative));
                }
                                          
            }
            else 
            {
                this.releaseTime.Text = "";
                this.temperNow.Text = "";
                this.state.Text = "";
                this.temper.Text = "";
                this.wind.Text = "";
                this.flag.Text = "无法访问网络";

            }

        }


        private void CollegeInfo_Click(object sender, RoutedEventArgs e)
        {
            CollegeInfoWindow win = new CollegeInfoWindow();
            win.ShowDialog();
        }

        private void Wechat_Click(object sender, RoutedEventArgs e)
        {
            WechatWindow wcw = new WechatWindow();
            wcw.ShowDialog();
        }

        private void web_Click(object sender, RoutedEventArgs e)
        {
            WebSiteWindow wsw = new WebSiteWindow();
            wsw.ShowDialog();
        }

        private void science_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

      

       

        
    }
}
