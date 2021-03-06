﻿using System;
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
    /// Interaction logic for PlayEditSelectionPage.xaml
    /// </summary>
    public partial class PlayEditSelectionPage : Page
    {
        public PlayEditSelectionPage()
        {
            InitializeComponent();
        }

        private void PlayButtonClick(object sender, RoutedEventArgs e)
        {
            NavigationService ns = this.NavigationService;
            AddPlayersPage page = new AddPlayersPage();
            ns.Navigate(page);
        }
    }
}
