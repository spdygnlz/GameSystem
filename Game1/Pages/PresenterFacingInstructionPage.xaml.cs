using Game1.Events;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
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
    /// Interaction logic for PresenterFacingInstructionPage.xaml
    /// </summary>
    public partial class PresenterFacingInstructionPage : Page
    {
        private IEventAggregator eventAggregator;

        public PresenterFacingInstructionPage()
        {            
            InitializeComponent();
            eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();
        }

        private void StartGameButton_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = ServiceLocator.Current.GetInstance<JeopardyViewModel>();
            eventAggregator.GetEvent<PubSubEvent<JeopardyViewModel>>().Publish(viewModel);
        }
    }
}
