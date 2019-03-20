using Game1.ViewModels;
using Game1.Windows;
using InputCapture;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Win32;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
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

namespace Game1.Pages
{
    /// <summary>
    /// Interaction logic for PlayPage.xaml
    /// </summary>
    public partial class AddPlayersPage : Page
    {
        IEventAggregator eventAggregator;

        public ObservableCollection<UserViewModel> Users { get; set; }

        private IKeyboardCapture kb;

        public AddPlayersPage()
        {
            InitializeComponent();
            DataContext = this;
            Users = new ObservableCollection<UserViewModel>();
            kb = ServiceLocator.Current.GetInstance<IKeyboardCapture>();

            var container = ServiceLocator.Current.GetInstance<CompositionContainer>();
            container.ComposeExportedValue("Players", Users);
                        
            eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
            NextButton.IsEnabled = false;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {            
            var viewModel = ServiceLocator.Current.GetInstance<JeopardyViewModel>();
            viewModel.FileName = FileName.Text;
            viewModel.Users = Users;
            
            var playersWindow = ServiceLocator.Current.GetInstance<PlayersFacingWindow>();
            playersWindow.DataContext = viewModel;
            playersWindow.Show();

            var presenterWindow = ServiceLocator.Current.GetInstance<PresenterFacingWindow>();
            presenterWindow.DataContext = viewModel;
            presenterWindow.Show();

            foreach (Window window in Application.Current.Windows.OfType<IntroductionWindow>())
                ((IntroductionWindow)window).Close();
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFile.Filter = "Jeopardy files (*.jeo)|*.jeo|All files (*.*)|*.*";
            if (openFile.ShowDialog() == true)
            {
                FileName.Text = openFile.FileName;
                if (string.IsNullOrWhiteSpace(FileName.Text))
                {
                    NextButton.IsEnabled = false;
                }
                else
                {
                    NextButton.IsEnabled = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewPlayerWindow window = new NewPlayerWindow(Users);
            if (window.ShowDialog() == true)
            {
                UserViewModel userViewModel = new UserViewModel (eventAggregator, kb)
                {
                    FirstName = window.PlayerFirstName,
                    LastName = window.PlayerLastName,
                    ButtonId = window.ButtonId,
                    Score = 0
                };

                Users.Add(userViewModel);
                eventAggregator.GetEvent<PubSubEvent<UserViewModel>>().Publish(userViewModel);
            } 
        }
    }
}
