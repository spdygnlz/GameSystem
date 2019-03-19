using Game1.Events;
using InputCapture;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    public partial class PresenterClueWindow : ClueWindowBase, INotifyPropertyChanged
    {
        IKeyboardCapture kb = null;
        IEventAggregator eventAggregator = null;
        private int LastPlayerClicked = -1;

        public PresenterClueWindow()
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

        public override void Dispose()
        {
            if (kb != null)
            {
                kb.KeyboardNotification -= KeyboardNotification;
            }


            // Wheres the timer?
        }

        
        public event PropertyChangedEventHandler PropertyChanged;

        private void CorrectButtonClicked(object sender, RoutedEventArgs e)
        {
            PlayerScoreUpdate update = new PlayerScoreUpdate { ButtonId = LastPlayerClicked, ScoreAmount = (ClueValue) };
            eventAggregator.GetEvent<PubSubEvent<PlayerScoreUpdate>>().Publish(update);

            var clueWindow = this as ClueWindowBase;
            eventAggregator.GetEvent<PubSubEvent<ClickClue>>().Publish(new ClickClue { ClueName = clueWindow.Name });
            kb.Reset();
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
