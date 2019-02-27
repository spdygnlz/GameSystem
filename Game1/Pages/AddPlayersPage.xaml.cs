using Game1.Windows;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Win32;
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

namespace Game1.Pages
{
    /// <summary>
    /// Interaction logic for PlayPage.xaml
    /// </summary>
    public partial class AddPlayersPage : Page
    {        
        public AddPlayersPage()
        {
            InitializeComponent();
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
    }
}
