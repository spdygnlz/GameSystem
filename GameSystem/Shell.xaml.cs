using GameInterfaces.Events;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
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

namespace GameSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [Export(typeof(Shell))]
    public partial class Shell : Window
    {
        //[Import]
        //ShellViewModel ViewModel
        //{
        //    set
        //    {
        //        DataContext = value;
        //    }
        //}

        [ImportingConstructor]
        public Shell()
        {            
            InitializeComponent();
        }
    }
}
