using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ITITouch.Controls
{
    public class ContainerBox : Viewbox
    {
        private int _Index;

        public int Index
        {
            get { return _Index; }
            set { _Index = value; }
        }
    }
}
