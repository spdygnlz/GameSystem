using InputCapture;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for NewPlayerWindow.xaml
    /// </summary>
    public partial class NewPlayerWindow : Window, INotifyPropertyChanged
    {
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public int ButtonId { get; set; }
        public string ImagePath { get; set; }

        public NewPlayerWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            var names = PlayerName.Text.Split(' ');
            if (names.Length >= 1)
            {
                PlayerFirstName = names[0];
            }

            if (names.Length >= 2)
            {
                PlayerLastName = names[1];
            }

            DialogResult = true;
            Close();
        }

        private void Window_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int buttonId))
            {
                ButtonId = buttonId;
            }
        }

        private void PlayerName_TextInput(object sender, TextCompositionEventArgs e)
        {
            if (int.TryParse(e.Text, out int buttonId))
            {
                ButtonId = buttonId;
                e.Handled = true;
            }
        }
    }
}
