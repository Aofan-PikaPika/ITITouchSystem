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
using System.Timers;

namespace ITITouch
{
    /// <summary>
    /// MsgNotFinish.xaml 的交互逻辑
    /// </summary>
    public partial class MsgNotFinish : Window
    {
        Timer tmClose = new Timer();
        public MsgNotFinish()
        {
            InitializeComponent();
            //窗体开启时，设定计时间隔，设定事件，启动计时器
            //三行代码时间耦合
            tmClose.Interval = 1000;
            tmClose.Elapsed += this.checkToClose;
            tmClose.Start();
        }

        //object sender, ElapsedEventArgs e这个必须有，可以直接在上面写方法名
        //然后ctrl + shift + f10
        int cnt = 0;
        private void checkToClose(object sender, ElapsedEventArgs e)
        {
            cnt++;
            //等五秒关闭
            if (cnt == 5)
            {
                //这里
                //由于窗体本身是窗体UI主线程生成的，而现在的位置在子线程
                //子线程没有权限调用主线程生成的对象
                //所以用this.Dispatcher.Invoke相当于一种“提权”操作
                this.Dispatcher.Invoke(new Action(CloseMe), null);

            }
        }

        //子线程里需要执行的关闭窗体的事件
        private void CloseMe()
        {
            this.Close();
        }



        private void lblQuit_MouseUp(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
