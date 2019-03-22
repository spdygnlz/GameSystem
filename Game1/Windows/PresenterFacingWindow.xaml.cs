using Game1.Pages;
using Game1.UserControls;
using InputCapture;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Game1.Windows
{
    /// <summary>
    /// Interaction logic for PresenterFacingWindow.xaml
    /// </summary>
    [Export]
    public partial class PresenterFacingWindow : Window
    {
        private readonly IEventAggregator eventAggregator;

        private IKeyboardCapture kb;


        [ImportingConstructor]
        public PresenterFacingWindow(IEventAggregator eventAggregator)
        {
            InitializeComponent();

            kb = ServiceLocator.Current.GetInstance<IKeyboardCapture>();
            kb.RegisterWindow(this);

            //var contianer = ServiceLocator.Current.GetInstance<CompositionContainer>();
            //contianer.ComposeExportedValue(kb);

            eventAggregator.GetEvent<PubSubEvent<JeopardyViewModel>>().Subscribe((vm) =>
            {
                if (Content != null)
                {
                    var oldContent = Content as PresenterFacingGameMain;
                    var mainControl = oldContent?.MainContent?.Content as PlayMainControl;
                    mainControl?.Dispose();
                }
                Content = new PresenterFacingGameMain(vm);
            });

            this.eventAggregator = eventAggregator;
        }
    }
}
