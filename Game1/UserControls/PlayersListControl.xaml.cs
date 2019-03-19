using Game1.ViewModels;
using Game1.Windows;
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

namespace Game1.UserControls
{
    /// <summary>
    /// Interaction logic for PlayersListControl.xaml
    /// </summary>
    public partial class PlayersListControl : UserControl
    {
        public PlayersListControl()
        {
            InitializeComponent();
        }

        private void Grid_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ClickCount == 2)
            {
                var grid = sender as Grid;
                var user = grid.DataContext as UserViewModel;
                //user.IsInEditMode = true;

                EditPlayerScoreWindow editWindow = new EditPlayerScoreWindow(user);
                                
                if (editWindow.ShowDialog().Value)
                {
                    user.Score = editWindow.Score;
                }
            }
        }
    }
}
