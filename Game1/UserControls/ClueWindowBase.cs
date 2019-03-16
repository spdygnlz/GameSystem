using System;
using System.Windows;
using System.Windows.Controls;

namespace Game1
{
    public class ClueWindowBase : UserControl, IDisposable
    {
        public string ClueText
        {
            get { return (string)GetValue(ClueTextProperty); }
            set { SetValue(ClueTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClueText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClueTextProperty =
            DependencyProperty.Register("ClueText", typeof(string), typeof(ClueWindowBase), new UIPropertyMetadata(null));

        public string ClueAnswer
        {
            get { return (string)GetValue(ClueAnswerProperty); }
            set { SetValue(ClueAnswerProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClueText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClueAnswerProperty =
            DependencyProperty.Register("ClueAnswer", typeof(string), typeof(ClueWindowBase), new UIPropertyMetadata(null));


        public int ClueValue
        {
            get { return (int)GetValue(ClueValueProperty); }
            set { SetValue(ClueValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClueText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClueValueProperty =
            DependencyProperty.Register("ClueValue", typeof(int), typeof(ClueWindowBase), new UIPropertyMetadata(null));


        public bool DailyDouble
        {
            get { return (bool)GetValue(DailyDoubleProperty); }
            set { SetValue(DailyDoubleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DailyDouble.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DailyDoubleProperty =
            DependencyProperty.Register("DailyDouble", typeof(bool), typeof(ClueWindowBase), new UIPropertyMetadata(false));

        public bool PlayerClicked
        {
            get { return (bool)GetValue(PlayerClickedProperty); }
            set { SetValue(PlayerClickedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlayerClicked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlayerClickedProperty =
            DependencyProperty.Register("PlayerClicked", typeof(bool), typeof(ClueWindowBase), new UIPropertyMetadata(false));

        public virtual void Dispose() { }
    }
}
