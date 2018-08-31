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
using ITITouch.Organization;
using ITITouch.Map;
using ITITouch.Faculty;
using ITITouch.Education;
using ITITouch.Scientific;
using System.Text.RegularExpressions;
//这是引用了控制服务器的exe文件
using TestManipulateMainPgPic;

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
        private String[] IMAGES = { "Resources/1.jpg", "Resources/2.jpg", "Resources/3.jpg", "Resources/4.jpg", "Resources/5.jpg", "Resources/6.jpg", "Resources/7.jpg" };
        
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //没联网下不下来也没关系，不需要报错
            try
            {
                //刚开始就把服务器上的数据保存下来
                for (int i = 1; i <= 7; i++)
                {
                    byte[] imgb = SqlSvrHelper.GetPicture(i);
                    //两个同名的Image会冲突
                    System.Drawing.Image img = IOHelper.ConvertImage(imgb);
                    string imgName = "Resources/" + i + ".jpg";
                    img.Save(imgName,System.Drawing.Imaging.ImageFormat.Jpeg);
                }

            }
            catch { }
        }

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
            web.ScriptErrorsSuppressed = true;
            web.Navigate("http://ai.hebut.edu.cn/category/info/news");
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
            HtmlElementCollection ElementCollection = web.Document.GetElementsByTagName("article");
            List<string> listTitle = new List<string>();
            foreach (HtmlElement item in ElementCollection)
            {
                string rawStr = item.InnerText;
                //用两个控制符来正则匹配出新闻标题
                Regex rFindBack = new Regex(@"\n(.*)\r");
                MatchCollection m = rFindBack.Matches(rawStr);
                string findBack = m[2].ToString();
                //再用正则匹配取消两个控制符
                Regex rThrowNR = new Regex(@"[^\n].*[^\r]");
                Match mfinal = rThrowNR.Match(findBack);
                string throwNR = mfinal.ToString();
                if (String.IsNullOrEmpty(throwNR))
                {
                    Regex rFindTitle = new Regex(@"title=""(.*?)""");
                    rawStr = item.InnerHtml;
                    Match mm = rFindTitle.Match(rawStr);
                    String rawText = mm.Value;
                    rThrowNR = new Regex(@"[^title=""].*[^""]");
                    mfinal = rThrowNR.Match(rawText);
                    listTitle.Add(mfinal.Value);
                }
                else 
                    listTitle.Add(throwNR);
            }

            //获得图片路径
            List<string> listImage = new List<string>();
            foreach (HtmlElement item in ElementCollection)
            {
                string rawStr = item.InnerHtml;
                Regex rFindBack = new Regex(@"src=""(.*)""");
                Match m = rFindBack.Match(rawStr);
                if (m.Success)
                {
                    Regex rFindlink = new Regex(@"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?"); // 匹配出超链接的正则表达式
                    Match mc = rFindlink.Match(m.Value);
                    listImage.Add(mc.Value);
                }
                else
                    listImage.Add("");
             
            }
            
            //获得新闻链接
            List<string> listHref = new List<string>();
            for (int i = 0; i < ElementCollection.Count; i++)
            {
                HtmlElementCollection hrefs = ElementCollection[i].GetElementsByTagName("a");
                if (hrefs.Count > 0)
                {
                    Regex rFindlink = new Regex(@"http://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?");
                    Match m = rFindlink.Match(hrefs[0].OuterHtml);
                    listHref.Add(m.Value);
                }
            }
            try
            {
                //加载文本、图片
                txt1.Text = listTitle[0];
                txt2.Text = listTitle[1];

                this.newsUrl1 = listHref[0];
                this.newsUrl2 = listHref[1];

                SetImageSource(image1, listImage[0]);
                SetImageSource(image2, listImage[1]);
            }
            catch {
                //web_DocumentCompleted(sender, null);
            }
           

        }
        public string newsUrl1 = "";
        public string newsUrl2 = "";

        // 设定图片源的函数
        public void SetImageSource(Image i, string picSource)
        {
            if (String.IsNullOrEmpty(picSource)) // 为空，则设定以前计算机学院的徽标
            {
                i.Source = new BitmapImage(new Uri("http://www.scse.hebut.edu.cn/wp-content/uploads/2018/05/thumb.png"));
            }
            else // 不空，则设定图片里面的徽标
            {
                i.Source = new BitmapImage(new Uri(picSource));
            }
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
            ScientificWindow sw = new ScientificWindow();
            sw.ShowDialog();
        }

        private void organzition_Click(object sender, RoutedEventArgs e)
        {
            MsgInPreparation mip = new MsgInPreparation();
            mip.ShowDialog();
            //OranizationWindow ozw = new OranizationWindow();
            //ozw.ShowDialog();
        }

        private void teach_Click(object sender, RoutedEventArgs e)
        {
            MsgInPreparation mip = new MsgInPreparation();
            mip.ShowDialog();
            //EducationWindow ew = new EducationWindow();
            //ew.ShowDialog();
        }

        private void teacher_Click(object sender, RoutedEventArgs e)
        {
            MsgInPreparation mip = new MsgInPreparation();
            mip.ShowDialog();
            //FacultyWindow fw = new FacultyWindow();
            //fw.ShowDialog();
        }

        private void close_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void map_Click(object sender, RoutedEventArgs e)
        {
            MapWindow mw = new MapWindow();
            mw.ShowDialog();
        }

        private void news1_MouseUp(object sender, MouseButtonEventArgs e)
        {
            WebSiteWindow wsw = new WebSiteWindow();
            wsw.newsNavigate(newsUrl1);
            wsw.ShowDialog();
        }

        private void news2_MouseUp(object sender, MouseButtonEventArgs e)
        {
            WebSiteWindow wsw = new WebSiteWindow();
            wsw.newsNavigate(newsUrl2);
            wsw.ShowDialog();
        }

      

       

        
    }
}
