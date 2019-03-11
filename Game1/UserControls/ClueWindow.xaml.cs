using Game1.Events;
using InputCapture;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
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
    public partial class ClueWindow : UserControl, IDisposable
    {
        IKeyboardCapture kb = null;
        IEventAggregator eventAggregator = null;
        private int LastPlayerClicked = -1;

        public ClueWindow()
        {
            InitializeComponent();
            this.Loaded += OnLoaded;
            DataContext = this;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            //SpeechSynthesizer syn = new SpeechSynthesizer();
            //var voices = syn.GetInstalledVoices();
            //syn.SpeakAsync(ClueText);

            kb = ServiceLocator.Current.GetInstance<IKeyboardCapture>();
            kb.Reset();
            kb.KeyboardNotification += KeyboardNotification;

            eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
        }

        private void KeyboardNotification(object sender, KeyboardNotificationEventArgs e)
        {
            // Turn on the buttons
            PlayerClicked = true;

            LastPlayerClicked = kb.LookupIntKey(e.Key);
        }

        public void Dispose()
        {
            kb.KeyboardNotification -= KeyboardNotification;

            // Wheres the timer?
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

        public bool PlayerClicked
        {
            get { return (bool)GetValue(PlayerClickedProperty); }
            set { SetValue(PlayerClickedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for PlayerClicked.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty PlayerClickedProperty =
            DependencyProperty.Register("PlayerClicked", typeof(bool), typeof(ClueWindow), new UIPropertyMetadata(false));

        public string ClueAnswer { get; set; }
        public int ClueValue { get; set; }

        private void CorrectButtonClicked(object sender, RoutedEventArgs e)
        {
            PlayerScoreUpdate update = new PlayerScoreUpdate { ButtonId = LastPlayerClicked, ScoreAmount = (ClueValue) };
            eventAggregator.GetEvent<PubSubEvent<PlayerScoreUpdate>>().Publish(update);                        
        }

        private void IncorrectButton_Click(object sender, RoutedEventArgs e)
        {
            PlayerScoreUpdate update = new PlayerScoreUpdate { ButtonId = LastPlayerClicked, ScoreAmount = (-1 * ClueValue) };
            eventAggregator.GetEvent<PubSubEvent<PlayerScoreUpdate>>().Publish(update);
            PlayerClicked = false;
            LastPlayerClicked = -1;
            kb.Reset();
        }
    }
}
