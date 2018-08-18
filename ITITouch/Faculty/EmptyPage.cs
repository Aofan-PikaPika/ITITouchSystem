using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITITouch.Faculty.NoContent;
using System.Windows.Controls;

/**
 * 整个教师页面结构由北辰高端营销者倾情奉献
 * Author : Solodye
 */ 
namespace ITITouch.Faculty
{
    /// <summary>
    /// 为了避免重复引用不同的命名空间，故意将NoContent中的内容直接放在Faculty命名空间下
    /// 只需要在new时给出老师的姓名和职称名，即可创建一个空页面对象
    /// 一旦遇到了空的人名，就在框架的逻辑中调用这个类，它作为一个供调用的接口，将NoContent中的内容完全封装
    /// </summary>
    public class EmptyPage
    {

        /// <summary>
        /// 想调用空页面必须给出教授的姓名和职称名
        /// </summary>
        /// <param name="teacherName"></param>
        /// <param name="rankName"></param>
        public EmptyPage(string teacherName, string rankName)
        {
            _page = new MainPage();
            _page.TeacherName.Text = teacherName;
            _page.RankName.Text = rankName;
        }

        private MainPage _page = null;
        public MainPage Page
        {
            get { return _page; }
        }
    }
}
