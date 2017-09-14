using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Threading;
using System.Windows;
using System.Windows.Input;

namespace ITITouch.Controls
{
    public class ScrollContainerView : ScrollViewer
    {
        private DispatcherTimer _timer = new DispatcherTimer();
        private StackPanel _panel = new StackPanel();
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            _timer = new DispatcherTimer();
            _panel = new StackPanel();
            _panel.Orientation = Orientation.Horizontal;
            _panel.Margin = new Thickness(0);
            _panel.VerticalAlignment = VerticalAlignment.Top;
            this.AddChild(_panel);
            this.VerticalAlignment = VerticalAlignment.Top;
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 2);
            _timer.Tick += new EventHandler(_timer_Tick);
            _timer.Start();

            this.HorizontalScrollBarVisibility = ScrollBarVisibility.Visible;
            this.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
        }
        double _current = 0;
        double _target = 0;
        double _ContentHorizontalOffset;
        void _timer_Tick(object sender, EventArgs e)
        {
            double affdistance = _target - _current;
            if (Math.Abs(affdistance) > 0.05)
            {
                this.ScrollToHorizontalOffset(_ContentHorizontalOffset + 2);
                _current += affdistance * 0.01;
            }
        }
        public void AddView(UIElement view)
        {
            ContainerBox box = new ContainerBox();
            //  box.Child = view;

            ScrollViewer scroll = new ScrollViewer();
            scroll.Height = 768;
            scroll.Width = 1024;
            scroll.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
            scroll.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
            scroll.MouseMove += new MouseEventHandler(scroll_MouseMove);
            scroll.Content = view;

            _panel.Children.Add(scroll);
        }
        double movedistance = 0;
        double mouseposition;
        void scroll_MouseMove(object sender, MouseEventArgs e)
        {
            ScrollViewer scroll = (ScrollViewer)sender;

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                movedistance = mouseposition - e.GetPosition(scroll).Y;
                scroll.ScrollToVerticalOffset(scroll.ContentVerticalOffset + movedistance);
            }

            mouseposition = e.GetPosition(scroll).Y;
        }

        private Point tempMouseLocation;
        protected override void OnMouseMove(System.Windows.Input.MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {

                this.ScrollToHorizontalOffset(this.ContentHorizontalOffset + tempMouseLocation.X - e.GetPosition(this).X);
                if (tempMouseLocation.X - e.GetPosition(this).X > 0)
                    _target -= 1;
                else
                    _target += 1;
            }
            base.OnMouseMove(e);

            tempMouseLocation = e.GetPosition(this);
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            _ContentHorizontalOffset = this.ContentHorizontalOffset;
            base.OnMouseUp(e);
        }
    }
}
