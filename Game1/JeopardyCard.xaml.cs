using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Game1
{
    /// <summary>
    /// Interaction logic for JeopardyCard.xaml
    /// </summary>
    public partial class JeopardyCard : UserControl
    {
        public JeopardyCard()
        {
            InitializeComponent();            
        }

        public uint ClueValue
        {
            get { return (uint)GetValue(ClueValueProperty); }
            set { SetValue(ClueValueProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClueValue.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClueValueProperty =
            DependencyProperty.Register("ClueValue", typeof(uint), typeof(JeopardyCard), new PropertyMetadata((uint)0));

        public string ClueText
        {
            get { return (string)GetValue(ClueTextProperty); }
            set { SetValue(ClueTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClueText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClueTextProperty =
            DependencyProperty.Register("ClueText", typeof(string), typeof(JeopardyCard), new PropertyMetadata("Empty"));

        public bool DailyDouble
        {
            get { return (bool)GetValue(DailyDoubleProperty); }
            set { SetValue(DailyDoubleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DailyDouble.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DailyDoubleProperty =
            DependencyProperty.Register("DailyDouble", typeof(bool), typeof(JeopardyCard), new PropertyMetadata(false));


    }
}
