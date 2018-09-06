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
using ITITouch.Faculty.AssociateProfessor;
using ITITouch.Faculty.Professor;
using System.Threading;

namespace ITITouch.Faculty
{
    /// <summary>
    /// FacultyWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FacultyWindow : Window
    {
        public FacultyWindow()
        {
            InitializeComponent();
            this.rb1_Click(this,null);
            this.rb1.IsChecked = true;
        }

        private void bt_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void rb1_Click(object sender, RoutedEventArgs e)
        {
            NaviPage2 nv2 = new NaviPage2();
            this.frameNavi.Content = nv2;
            nv2.showproNextFunction += new ProfessorShowNextHandle(ShowProNextPage);
            this.frameShow.Content = itip;
            //nv2.showProfessorbt1Function += new Professorbt1Handle(Pbt1);
            //nv2.showProfessorbt2Function += new Professorbt2Handle(Pbt2);
            //nv2.showProfessorbt3Function += new Professorbt3Handle(Pbt3);
            //nv2.showProfessorbt4Function += new Professorbt4Handle(Pbt4);
            //nv2.showProfessorbt5Function += new Professorbt5Handle(Pbt5);
            //nv2.showProfessorbt6Function += new Professorbt6Handle(Pbt6);
            //nv2.showProfessorbt7Function += new Professorbt7Handle(Pbt7);
            //nv2.showProfessorbt8Function += new Professorbt8Handle(Pbt8);
            //nv2.showProfessorbt9Function += new Professorbt9Handle(Pbt9);
            //nv2.showProfessorbt10Function += new Professorbt10Handle(Pbt10);
            //nv2.showProfessorbt11Function += new Professorbt11Handle(Pbt11);
            //nv2.showProfessorbt12Function += new Professorbt12Handle(Pbt12);
            //nv2.showProfessorbt13Function += new Professorbt13Handle(Pbt13);
            nv2.sendPage += GetPage;
            
        }
        InitialPage itip = new InitialPage();
        private void rb2_Click(object sender, RoutedEventArgs e)
        {
            NaviPage1 nv1 = new NaviPage1();
            this.frameNavi.Content = nv1;
            nv1.showNextFuction += new showNextHandle(showNextPage);
            this.frameShow.Content = itip;
            nv1.showBt1Function += new showbt1Handle(APbt1);
            //nv1.showBt2Function += new showbt2Handle(APbt2);
            //nv1.showBt3Function += new showbt3Handle(APbt3);
            nv1.showBt4Function += new showbt4Handle(APbt4);
            //nv1.showBt5Function += new showbt5Handle(APbt5);
            //nv1.showBt6Function += new showbt6Handle(APbt6);
            //nv1.showBt7Function += new showbt7Handle(APbt7);
            //nv1.showBt8Function += new showbt8Handle(APbt8);
            //nv1.showBt9Function += new showbt9Handle(APbt9);
            //nv1.showBt10Function += new showbt10Handle(APbt10);
            //nv1.showBt11Function += new showbt11Handle(APbt11);
            //nv1.showBt12Function += new showbt12Handle(APbt12);
            //nv1.showBt13Function += new showbt13Handle(APbt13);
            nv1.sendPage += GetPage;
            
        }

        private void rb3_Click(object sender, RoutedEventArgs e)
        {
            NaviPage3 nv3 = new NaviPage3();          
            this.frameNavi.Content = nv3;
            nv3.showLectuerDownFunction += new showLectuerDownHandle(showlecDown);
            this.frameShow.Content = itip;
            nv3.showLectuerbt1Function += new showLectuerbt1Handle(lec1);
            //nv3.showLectuerbt2Function += new showLectuerbt2Handle(lec2);
            nv3.showLectuerbt3Function += new showLectuerbt3Handle(lec3);
            nv3.showLectuerbt4Function += new showLectuerbt4Handle(lec4);
            //nv3.showLectuerbt5Function += new showLectuerbt5Handle(lec5);
            //nv3.showLectuerbt6Function += new showLectuerbt6Handle(lec6);
            //nv3.showLectuerbt7Function += new showLectuerbt7Handle(lec7);
            //nv3.showLectuerbt8Function += new showLectuerbt8Handle(lec8);
            nv3.showLectuerbt9Function += new showLectuerbt9Handle(lec9);
            nv3.showLectuerbt10Function += new showLectuerbt10Handle(lec10);
            //nv3.showLectuerbt11Function += new showLectuerbt11Handle(lec11);
            //nv3.showLectuerbt12Function += new showLectuerbt12Handle(lec12);
            //nv3.showLectuerbt13Function += new showLectuerbt13Handle(lec13);
            nv3.sendPage += GetPage;
        }

        private void rb4_Click(object sender, RoutedEventArgs e)
        {
            NaviPage4 nv4 = new NaviPage4();
            this.frameNavi.Content = nv4;
            this.frameShow.Content = itip;
            nv4.showVistingbt1Function += new Visitingbt1Handle(vbt1);
            nv4.showVistingbt2Function += new Visitingbt2Handle(vbt2);
            nv4.showVistingbt3Function += new Visitingbt3Handle(vbt3);
            nv4.showVistingbt4Function += new Visitingbt4Handle(vbt4);
            nv4.showVistingbt5Function += new Visitingbt5Handle(vbt5);
            nv4.showVistingbt6Function += new Visitingbt6Handle(vbt6);
            nv4.showVistingbt7Function += new Visitingbt7Handle(vbt7);
            nv4.sendPage += GetPage;

        }

        TeacherWebBrowserPage twpF = new TeacherWebBrowserPage("");
        private void GetPage(String url)
        {
            //if (typeof(this.frameShow.Content) == typeof(TeacherWebBrowserPage))
            //{
            //    TeacherWebBrowserPage twp = new TeacherWebBrowserPage(url);
            //    this.frameShow.Content = twp;
            //}
            //else
            //{
            //    TeacherWebBrowserPage twp = (TeacherWebBrowserPage)this.frameShow.Content;
            //    twp.Uri = url;
            //    twp.Navigate(url);
            //}
            try
            {
                TeacherWebBrowserPage twp = (TeacherWebBrowserPage)this.frameShow.Content;
                twp.Uri = url;
            }
            catch
            {
                twpF.Uri = url;
                this.frameShow.Content = twpF;
            }
        }
       
        #region 副教授-委托
        private void showNextPage() 
        {
            NaviPage12 na12 = new NaviPage12();
            this.frameNavi.Content = na12;
            InitialPage itip = new InitialPage();          
            this.frameShow.Content = itip;
            na12.showUpFunction += new showUpHandle(showUpPage);
            na12.showNextFuction += new showNextHandle(showNextPage1);

            //na12.showBt1Function += new showBt1Handle(APBT1);
            //na12.showBt2Function += new showBt2Handle(APBT2);
            //na12.showBt3Function += new showBt3Handle(APBT3);
            //na12.showBt4Function += new showBt4Handle(APBT4);
            //na12.showBt5Function += new showBt5Handle(APBT5);
            na12.showBt6Function += new showBt6Handle(APBT6);
            //na12.showBt7Function += new showBt7Handle(APBT7);
            //na12.showBt8Function += new showBt8Handle(APBT8);
            //na12.showBt9Function += new showBt9Handle(APBT9);
            na12.sendPage += GetPage;
        }
        private void showNextPage1()
        {
            NaviPage13 na13 = new NaviPage13();
            this.frameNavi.Content = na13;
            InitialPage itip = new InitialPage();
            this.frameShow.Content = itip;
            na13.showUpFunction += new showUpHandle(showUpPage1);
            na13.sendPage += GetPage;
        }
        private void showUpPage() 
        {
           this.rb2_Click(this, null);
        }
        private void showUpPage1()
        {
           this.showNextPage();
        }

        private void APbt1()
        {
            Lecturer.CaoBin.MainPage cb = new Lecturer.CaoBin.MainPage();
            this.frameShow.Content = cb;
        }
        //private void APbt2()
        //{
        //    AssociateProfessor.FuKun.MainPage fk = new AssociateProfessor.FuKun.MainPage();
        //    this.frameShow.Content = fk;
        //}
        //private void APbt3()
        //{
        //    AssociateProfessor.FuLingLi.MainPage fll = new AssociateProfessor.FuLingLi.MainPage();
        //    this.frameShow.Content = fll;
        //}
        private void APbt4()
        {
            AssociateProfessor.FuKun.MainPage fk = new AssociateProfessor.FuKun.MainPage();
            this.frameShow.Content = fk;
        }
        //private void APbt5()
        //{
        //    AssociateProfessor.HePing.MainPage hp = new AssociateProfessor.HePing.MainPage();
        //    this.frameShow.Content = hp;

        //}
        //private void APbt6()
        //{
        //    AssociateProfessor.HouXiangDan.MainPage hxd = new AssociateProfessor.HouXiangDan.MainPage();
        //    this.frameShow.Content = hxd;

        //}
        //private void APbt7()
        //{
        //    AssociateProfessor.LiJianWei.MainPage ljw = new AssociateProfessor.LiJianWei.MainPage();
        //    this.frameShow.Content = ljw;

        //}
        //private void APbt8()
        //{
        //    AssociateProfessor.LiNaNa.MainPage lnn = new AssociateProfessor.LiNaNa.MainPage();
        //    this.frameShow.Content = lnn;
        //}
        //private void APbt9()
        //{
        //    AssociateProfessor.LiangYanHong.MainPage lyh = new AssociateProfessor.LiangYanHong.MainPage();
        //    this.frameShow.Content = lyh;
        //}
        //private void APbt10()
        //{
        //    AssociateProfessor.LiuEnHai.MainPage leh = new AssociateProfessor.LiuEnHai.MainPage();
        //    this.frameShow.Content = leh;
        //}
        //private void APbt11()
        //{
        //    AssociateProfessor.LiuJingYu.MainPage ljy = new AssociateProfessor.LiuJingYu.MainPage();
        //    this.frameShow.Content = ljy;
        //}
        //private void APbt12()
        //{
        //    AssociateProfessor.ShiQiaoShuo.MainPage sqs = new AssociateProfessor.ShiQiaoShuo.MainPage();
        //    this.frameShow.Content = sqs;
        //}
        //private void APbt13()
        //{
        //    AssociateProfessor.TianHongLi.MainPage thl = new AssociateProfessor.TianHongLi.MainPage();
        //    this.frameShow.Content = thl;
        //}

        //private void APBT1() 
        //{
        //    AssociateProfessor.WangPeng.MainPage wp = new AssociateProfessor.WangPeng.MainPage();
        //    this.frameShow.Content = wp;
        //}
        //private void APBT2()
        //{
        //    AssociateProfessor.WanYanPing.MainPage wyp = new AssociateProfessor.WanYanPing.MainPage();
        //    this.frameShow.Content = wyp;
        //}
        //private void APBT3()
        //{
        //    AssociateProfessor.XiaoGuoXi.MainPage xgx = new AssociateProfessor.XiaoGuoXi.MainPage();
        //    this.frameShow.Content = xgx;
        //}
        //private void APBT4()
        //{
        //    AssociateProfessor.XuZhiHong.MainPage xzh = new AssociateProfessor.XuZhiHong.MainPage();
        //    this.frameShow.Content = xzh;
        //}
        //private void APBT5()
        //{
        //    AssociateProfessor.YanGang.MainPage yg = new AssociateProfessor.YanGang.MainPage();
        //    this.frameShow.Content = yg;
        //}
        private void APBT6()
        {
            AssociateProfessor.WangPeng.MainPage wp = new AssociateProfessor.WangPeng.MainPage();
            this.frameShow.Content = wp;
        }
        //private void APBT7()
        //{
        //    AssociateProfessor.ZhangHongMei.MainPage zhm = new AssociateProfessor.ZhangHongMei.MainPage();
        //    this.frameShow.Content = zhm;
        //}
        //private void APBT8()
        //{
        //    AssociateProfessor.ZhangJun.MainPage zj = new AssociateProfessor.ZhangJun.MainPage();
        //    this.frameShow.Content = zj;
        //}
        //private void APBT9()
        //{
        //    AssociateProfessor.ZhangManDun.MainPage zmd = new AssociateProfessor.ZhangManDun.MainPage();
        //    this.frameShow.Content = zmd;
        //}


        #endregion

        #region 教授-委托
        private void ShowProNextPage() 
        {
            NaviPage22 nv22 = new NaviPage22();
            this.frameNavi.Content = nv22;
            this.frameShow.Content = itip; 
            nv22.showProUpFunction += new ProUpPageHandle(showProUp);
            nv22.showproNextFunction += new ProfessorShowNextHandle(ShowProNextPage1);
            //nv22.showBt1Function += new ProBt1Handle(PBt1);
            //nv22.showBt2Function += new ProBt2Handle(PBt2);
            //nv22.showBt3Function += new ProBt3Handle(PBt3);
            //nv22.showBt4Function += new ProBt4Handle(PBt4);
            nv22.showBt5Function += new ProBt5Handle(Pbt5);
            //nv22.showBt6Function += new ProBt6Handle(PBt6);
            nv22.sendPage += GetPage;

        }  //用于从第一张到显示第二张

        private void ShowProNextPage1()   //用于从第二张到显示第三张
        {
            NaviPage23 nv23 = new NaviPage23();
            this.frameNavi.Content = nv23;
            this.frameShow.Content = itip;
            nv23.showProUpFunction += new ProUpPageHandle(showProUp1);
            nv23.sendPage += GetPage;

        }

        private void showProUp() 
        {
            this.rb1_Click(this,null);
        }   //用于从第二张到显示第一张

        private void showProUp1()
        {
            this.ShowProNextPage();
        }   //用于从第三张到显示第二张

        //private void PBt1()
        //{
        //    Professor.WeiWei.MainPage ww = new Professor.WeiWei.MainPage();
        //    this.frameShow.Content = ww;
        //}
        //private void PBt2()
        //{
        //    Professor.WuQing.MainPage wq = new Professor.WuQing.MainPage();
        //    this.frameShow.Content = wq;
        //}
        //private void PBt3()
        //{
        //    Professor.WuYouXi.MainPage wyx = new Professor.WuYouXi.MainPage();
        //    this.frameShow.Content = wyx;
        //}
        //private void PBt4()
        //{
        //    EmptyPage zjw = new EmptyPage("周建伟", "教授");
        //    this.frameShow.Content = zjw.Page;
        //}
        //private void PBt5()
        //{
        //    Professor.ShiLuKui.MainPage slk = new Professor.ShiLuKui.MainPage();
        //    this.frameShow.Content = slk;
        //}
        //private void PBt6()
        //{
        //    Professor.YuMing.MainPage ym = new Professor.YuMing.MainPage();
        //    this.frameShow.Content = ym;
        //}





        //private void Pbt1() 
        //{
        //    Professor.ChaiXin.MainPage cx = new Professor.ChaiXin.MainPage();
        //    this.frameShow.Content = cx;
        //}
        //private void Pbt2()
        //{
        //    Professor.DongYongFeng.MainPage dyf = new Professor.DongYongFeng.MainPage();
        //    this.frameShow.Content = dyf;
        //}
        //private void Pbt3()
        //{
        //    Professor.GengHengShan.MainPage ghs = new Professor.GengHengShan.MainPage();
        //    this.frameShow.Content = ghs;
        //}
        //private void Pbt4()
        //{
        //    Professor.GuJunHua.MainPage gjh = new Professor.GuJunHua.MainPage();
        //    this.frameShow.Content = gjh;
        //}
        private void Pbt5()
        {
            EmptyPage lgl = new EmptyPage("刘国丽", "教授");
            this.frameShow.Content = lgl.Page;

        }
        //private void Pbt6()
        //{
        //    Professor.LiuJing.MainPage lj = new Professor.LiuJing.MainPage();
        //    this.frameShow.Content = lj;
        //}
        //private void Pbt7()
        //{
        //    Professor.LinTao.MainPage lt = new Professor.LinTao.MainPage();
        //    this.frameShow.Content = lt;
        //}
        //private void Pbt8()
        //{
        //    Professor.MaJianHong.MainPage mjh = new Professor.MaJianHong.MainPage();
        //    this.frameShow.Content = mjh;
        //}
        //private void Pbt9()
        //{
        //    EmptyPage ncl = new EmptyPage("牛存良","教授");
        //    this.frameShow.Content = ncl.Page;
        //}
        //private void Pbt10()
        //{
        //    Professor.PengYuQing.MainPage pyq = new Professor.PengYuQing.MainPage();
        //    this.frameShow.Content = pyq;
        //}
        //private void Pbt11()
        //{
        //    Professor.ShenXiTing.MainPage sxt = new Professor.ShenXiTing.MainPage();
        //    this.frameShow.Content = sxt;
        //}
        //private void Pbt12()
        //{
        //    EmptyPage sj = new EmptyPage("宋洁","教授");
        //    this.frameShow.Content = sj.Page;
        //}
        //private void Pbt13()
        //{
        //    Professor.WangYuanQuan.MainPage wyq = new Professor.WangYuanQuan.MainPage();
        //    this.frameShow.Content = wyq;
        //}
        #endregion

        #region 兼职导师
        private void vbt1()
        {
            EmptyPage lk = new EmptyPage("连柯", "兼职硕士生导师");
            this.frameShow.Content = lk.Page;
        }
        private void vbt2()
        {
            EmptyPage ljm = new EmptyPage("刘教民", "兼职硕士生导师");
            this.frameShow.Content = ljm.Page;
        }
        private void vbt3()
        {
            EmptyPage ghy = new EmptyPage("郭鸿湧", "兼职硕士生导师");
            this.frameShow.Content = ghy.Page;
        }
        private void vbt4()
        {
            EmptyPage qyb = new EmptyPage("邱玉宝", "兼职硕士生导师");
            this.frameShow.Content = qyb.Page;
        }
        private void vbt5()
        {
            EmptyPage qhb = new EmptyPage("曲寒冰", "兼职硕士生导师");
            this.frameShow.Content = qhb.Page;
        }
        private void vbt6()
        {
            EmptyPage wf = new EmptyPage("吴峰", "兼职硕士生导师");
            this.frameShow.Content = wf.Page;
        }
        private void vbt7()
        {
            EmptyPage ytz = new EmptyPage("于铁忠", "兼职硕士生导师");
            this.frameShow.Content = ytz.Page;
        }
        #endregion

        #region 讲师
        private void showlecDown() 
        {
            NaviPage32 nv32 = new NaviPage32();
            this.frameNavi.Content = nv32;
            nv32.showLecturerUpFunction += new showLecturerUpHandle(showlecUp);
            nv32.showLectuerDownFunction += new showLectuerDownHandle(showlecDown1);
            //nv32.showLecBt1Function += new showLecBt1Handle(Lec1);
            //nv32.showLecBt2Function += new showLecBt2Handle(Lec2);
            nv32.showLecBt3Function += new showLecBt3Handle(Lec3);
            //nv32.showLecBt4Function += new showLecBt4Handle(Lec4);
            nv32.showLecBt5Function += new showLecBt5Handle(Lec5);
            //nv32.showLecBt6Function += new showLecBt6Handle(Lec6);
            //nv32.showLecBt7Function += new showLecBt7Handle(Lec7);
            //nv32.showLecBt8Function += new showLecBt8Handle(Lec8);
            nv32.showLecBt9Function += new showLecBt9Handle(Lec9);
            //nv32.showLecBt10Function += new showLecBt10Handle(Lec10);
            //nv32.showLecBt11Function += new showLecBt11Handle(Lec11);
            //nv32.showLecBt12Function += new showLecBt12Handle(Lec12);
            nv32.showLecBt13Function += new showLecBt13Handle(Lec13);
            //nv32.showLecBt14Function += new showLecBt14Handle(Lec14);
            nv32.sendPage += GetPage;

        }
        private void showlecDown1()
        {
            NaviPage33 nv33 = new NaviPage33();
            this.frameNavi.Content = nv33;
            nv33.showLecturerUpFunction += new showLecturerUpHandle(showlecUp1);
            nv33.showLec1Bt5Function += new showLec1Bt5Handle(lec5);
            nv33.sendPage += GetPage;

        }
        private void showlecUp() 
        {
            this.rb3_Click(this,null);
        }
        private void showlecUp1()
        {
            this.showlecDown();
        }

        private void lec1()
        {
            EmptyPage bxb = new EmptyPage("毕晓博", "讲师");
            this.frameShow.Content = bxb.Page;
        }
        //private void lec2()
        //{
        //    Lecturer.CaoBin.MainPage cb = new Lecturer.CaoBin.MainPage();
        //    this.frameShow.Content = cb;
        //}
        private void lec3()
        {
            EmptyPage dy = new EmptyPage("董瑶", "讲师");
            this.frameShow.Content = dy.Page;
        }
        private void lec4()
        {
            EmptyPage gwx = new EmptyPage("高卫香", "讲师");
            this.frameShow.Content = gwx.Page;
        }
        private void lec5()
        {
            EmptyPage zyj = new EmptyPage("张亚娟", "讲师");
            this.frameShow.Content = zyj.Page;
        }
        //private void lec6()
        //{
        //    EmptyPage lj = new EmptyPage("李娟", "讲师");
        //    this.frameShow.Content = lj.Page;
        //}
        //private void lec7()
        //{
        //    EmptyPage lz = new EmptyPage("李智", "讲师");
        //    this.frameShow.Content = lz.Page;
        //}
        //private void lec8()
        //{
        //    Lecturer.LinXiaoJing.MainPage lxj = new Lecturer.LinXiaoJing.MainPage();
        //    this.frameShow.Content = lxj;
        //}
        private void lec9()
        {
            EmptyPage lj = new EmptyPage("李娟", "讲师");
            this.frameShow.Content = lj.Page;
        }
        private void lec10()
        {
            EmptyPage lz = new EmptyPage("李智", "讲师");
            this.frameShow.Content = lz.Page;
        }
        //private void lec11()
        //{
        //    Lecturer.LuJing.MainPage lj = new Lecturer.LuJing.MainPage();
        //    this.frameShow.Content = lj;
        //}
        //private void lec12()
        //{
        //    Lecturer.LvHua.MainPage lh = new Lecturer.LvHua.MainPage();
        //    this.frameShow.Content = lh;
        //}
        //private void lec13()
        //{
        //    EmptyPage ml = new EmptyPage("马梁", "讲师");
        //    this.frameShow.Content = ml.Page;
        //}

        //private void Lec1()
        //{
        //    Lecturer.ShiShuo.MainPage ss = new Lecturer.ShiShuo.MainPage();
        //    this.frameShow.Content = ss;
        //}
        //private void Lec2()
        //{
        //    EmptyPage wjx = new EmptyPage("王建勋", "讲师");
        //    this.frameShow.Content = wjx.Page;
        //}
        private void Lec3()
        {
            EmptyPage ml = new EmptyPage("马梁", "讲师");
            this.frameShow.Content = ml.Page;
        }
        //private void Lec4()
        //{
        //    Lecturer.WangLiQin.MainPage wlq = new Lecturer.WangLiQin.MainPage();
        //    this.frameShow.Content = wlq;
        //}
        private void Lec5()
        {
            EmptyPage wjx = new EmptyPage("王建勋", "讲师");
            this.frameShow.Content = wjx.Page;
        }
        //private void Lec6()
        //{
        //    Lecturer.WuHongTao.MainPage wht = new Lecturer.WuHongTao.MainPage();
        //    this.frameShow.Content = wht;
        //}
        //private void Lec7()
        //{
        //    Lecturer.XueGuiXiang.MainPage xgx = new Lecturer.XueGuiXiang.MainPage();
        //    this.frameShow.Content = xgx;
        //}
        //private void Lec8()
        //{
        //    EmptyPage ywj = new EmptyPage("闫文杰", "讲师");
        //    this.frameShow.Content = ywj.Page;
        //}
        private void Lec9()
        {
            EmptyPage wxf = new EmptyPage("王小芳", "讲师");
            this.frameShow.Content = wxf.Page;
        }
        //private void Lec10()
        //{
        //    Lecturer.YuanYuQian.MainPage yyq = new Lecturer.YuanYuQian.MainPage();
        //    this.frameShow.Content = yyq;
        //}
        //private void Lec11()
        //{
        //    Lecturer.ZhaiYanDong.MainPage zyd = new Lecturer.ZhaiYanDong.MainPage();
        //    this.frameShow.Content = zyd;
        //}
        //private void Lec12()
        //{
        //    Lecturer.ZhangJianNan.MainPage zjn = new Lecturer.ZhangJianNan.MainPage();
        //    this.frameShow.Content = zjn;
        //}
        private void Lec13()
        {
            EmptyPage yy = new EmptyPage("于洋", "讲师");
            this.frameShow.Content = yy.Page;
        }
        //private void Lec14()
        //{
        //    Lecturer.ZhuHuaiZhong.MainPage zhz = new Lecturer.ZhuHuaiZhong.MainPage();
        //    this.frameShow.Content = zhz;
        //}
        #endregion

       



    }
}
