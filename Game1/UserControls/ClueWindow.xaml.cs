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
        private LockoutKeyboardCapture _kb;

        public ClueWindow()
        {
            InitializeComponent();
            _kb = ServiceLocator.Current.GetInstance<IKeyboardCapture>() as LockoutKeyboardCapture;
            _kb.PropertyChanged += _kb_PropertyChanged;
            DataContext = this;

            // TODO: start timer?
        }

        public bool IsLocked
        {
            get
            {
                return _kb?.IsLocked ?? false;
            }

            private set
            {
                _kb.IsLocked = value;
            }
        }

        private void _kb_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsLocked)));
        }

        public override void Dispose()
        {
            _kb.PropertyChanged -= _kb_PropertyChanged;
            // Wheres the timer?
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
