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

namespace ITITouch.Organization
{
    /// <summary>
    /// OranizationWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OranizationWindow : Window
    {
        public OranizationWindow()
        {
            InitializeComponent();
            rb1_Click(this, null);
            rb1.IsChecked = true;
            Committee com = new Committee();
            this.frameShow.Content = com;
        }

        private void rb1_Click(object sender, RoutedEventArgs e)
        {
            NaviPage1 n1=new NaviPage1();
            this.frameNavi.Content = n1;
            n1.FunctionDepartment += new showDepartmentHandle(FunctionDepartment);
            n1.StudentDepartment += new showStudentHandle(StudentDepartment);
            n1.CollegeDepartment += new showCollegeHandle(CollegeDepartment);
            n1.Committee += new showCommiteeHandle(Committees);
            n1.Initialization();

        }

        private void rb2_Click(object sender, RoutedEventArgs e)
        {
            NaviPage2 n2 = new NaviPage2();
            this.frameNavi.Content = n2;
            n2.showComputerFunction += new showFramebt1Handle(Computer);
            n2.showNetFunction += new showFramebt2Handle(Net);
            n2.showSoftwareFunction += new showFramebt3Handle(Software);
            n2.showIOTFunction += new showFramebt4Handle(IOT);
            n2.showTeachFunction += new showFramebt5Handle(Teach);
            n2.showLabFunction += new showFramebt7Handle(Lab);
            n2.showNewEnergyScienceAndEngineering += new showFramebt8Handle(NewEnergy);
            n2.showAutomation += new showFramebt9Handle(Automation);
            n2.showIntelligentScienceAndTechnology += new showFramebt10Handle(TST);
            n2.showComputerExperimentCenter += new showFramebt11Handle(LCP);
            n2.Initialization();
            
        }
        private void LCP()
        {
            LabCenterPage lcp = new LabCenterPage();
            this.frameShow.Content = lcp;
        }

        private void TST()
        {
            showIntelligentScienceAndTechnology tst = new showIntelligentScienceAndTechnology();
            this.frameShow.Content = tst;
        }

        private void Automation()
        {
            showAutomation auto = new showAutomation();
            this.frameShow.Content = auto;
        }

        private void NewEnergy() 
        {
            showNewEnergyScienceAndEngineering nese = new showNewEnergyScienceAndEngineering();
            this.frameShow.Content = nese;
        }
        private void FunctionDepartment() 
        {
            FunctionDepartmentPage fdp = new FunctionDepartmentPage();
            this.frameShow.Content = fdp;
        }

        private void StudentDepartment() 
        {
            PageYouth py = new PageYouth();
            this.frameShow.Content = py;
        }
        private void CollegeDepartment() 
        {
            PageFunction pf = new PageFunction();
            this.frameShow.Content = pf;
        }
        private void Committees() 
        {
            Committee com = new Committee();
            this.frameShow.Content = com;
        }


        private void Computer() 
        {
            ComputerScienceAndTechnology cst = new ComputerScienceAndTechnology();
            this.frameShow.Content = cst;
        }
        private void Net() 
        {
            NetworkEngineering net = new NetworkEngineering();
            this.frameShow.Content = net;
        }

        private void Software() 
        {
            SoftwareEngineering soft = new SoftwareEngineering();
            this.frameShow.Content = soft;
        }

        private void IOT() 
        {
            InternetOfThingsPage iot = new InternetOfThingsPage();
            this.frameShow.Content = iot;
        }

        private void Center() 
        {
            LabCenterPage center = new LabCenterPage();
            this.frameShow.Content = center;
        }

        private void Teach() 
        {
            BasicTeachPage teach = new BasicTeachPage();
            this.frameShow.Content = teach;
        }

        private void Lab() 
        {
            LabPage lab = new LabPage();
            this.frameShow.Content = lab;
        }


        private void bt_return_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
