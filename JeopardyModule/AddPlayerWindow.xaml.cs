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

namespace David.GameSystem.Modules
{
    /// <summary>
    /// Simple dialog for getting information to add a new player
    /// </summary>
    public partial class AddPlayerWindow : Window
    {
        [ImportingConstructor]
        public AddPlayerWindow()
        {            
            InitializeComponent();
            DataContext = this;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public bool IsCanceled { get; set; }

        private void CancelButtonClicked(object sender, RoutedEventArgs e)
        {
            IsCanceled = true;
        }

        private void OkButtonClicked(object sender, RoutedEventArgs e)
        {
            IsCanceled = false;
            this.Close();
        }        
    }
}
