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
    public partial class ClueWindow : ClueWindowBase, IDisposable, INotifyPropertyChanged
    {
        public ClueWindow()
        {
            InitializeComponent();
         
            DataContext = this;

            // TODO: start timer?
        }

        public override void Dispose()
        {

            // Wheres the timer?
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
