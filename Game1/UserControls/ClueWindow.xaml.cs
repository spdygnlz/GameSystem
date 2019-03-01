using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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
    /// Interaction logic for ClueWindow.xaml
    /// </summary>
    public partial class ClueWindow : UserControl
    {
        public ClueWindow()
        {
            InitializeComponent();
            this.Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            //SpeechSynthesizer syn = new SpeechSynthesizer();
            //var voices = syn.GetInstalledVoices();
            //syn.SpeakAsync(ClueText);
        }

        public string ClueText
        {
            get { return (string)GetValue(ClueTextProperty); }
            set { SetValue(ClueTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ClueText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClueTextProperty =
            DependencyProperty.Register("ClueText", typeof(string), typeof(ClueWindow), new UIPropertyMetadata(null));

        public bool DailyDouble
        {
            get { return (bool)GetValue(DailyDoubleProperty); }
            set { SetValue(DailyDoubleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DailyDouble.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DailyDoubleProperty =
            DependencyProperty.Register("DailyDouble", typeof(bool), typeof(ClueWindow), new UIPropertyMetadata(false));

    }
}
