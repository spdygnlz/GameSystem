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
using System.Windows.Shapes;

namespace Game1
{
    /// <summary>
    /// Interaction logic for OpenFile.xaml
    /// </summary>
    public partial class OpenFile : Window
    {
        public string Filename { get; set; }

        public OpenFile()
        {
            InitializeComponent();
        }

        private void OpenFile1(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = @"Jeopardy Files (*.jeo)|*.jeo";
            dialog.CheckFileExists = true;
            var result = dialog.ShowDialog();
            if (result != null && result == true)
            {                
                this.jeopardyFileTextBox.Text = dialog.FileName;
                Filename = dialog.FileName;
                this.openButton.IsEnabled = true;
                this.editButton.IsEnabled = true;
            }
        }

        private void Open(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Edit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
