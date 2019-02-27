using GameInterfaces;
using InputCapture;
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

namespace Game1.UserControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [Export(typeof(IGame))]
    public partial class PlayMainControl : UserControl, IGame
    {
        public string GameName
        {
            get
            {
                return "Jeopardy!";
            }
        }

        private IKeyboardCapture kb = new LockoutKeyboardCapture(Key.Space);

        public PlayMainControl()
        {           
            InitializeComponent();

            kb.RegisterWindow(this);
            kb.KeyboardNotification += (sender, args) => 
            {
                MessageBox.Show($"Got {args.Key} at {args.Time.ToString(@"ss\:fff")}");
            };
        }

        private void JeopardyCardDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Get the card that was clicked
            var card = e.Source as JeopardyCard;

            // Create the new window to show over the grid
            ClueWindow window = new ClueWindow();

            // Hook up the event that will close the window when it's double clicked
            window.MouseDoubleClick += (s, args) =>             
            {
                // Turn the mouse cursor back on
                Mouse.OverrideCursor = Cursors.Arrow;

                // Remove the overlay window
                GameCanvas.Children.Remove((UIElement)s);
            };

            // Set the width of the overlay window to the actual window
            window.Width = ActualWidth;
            window.Height = ActualHeight;

            // Place the overlay window directly over the actual window
            Window parentWindow = Window.GetWindow(this);
            Point point = card.TransformToAncestor(parentWindow).Transform(new Point(0, 0));
            window.SetValue(Canvas.LeftProperty, point.X + (card.ActualWidth / 2));
            window.SetValue(Canvas.TopProperty, point.Y + (card.ActualHeight / 2));

            // Set the text on the overlay window
            window.ClueText = card.ClueText;

            // Remove the mouse cursor 
            Mouse.OverrideCursor = Cursors.None;

            // Reset the lockout/timer on the keyboard capture module
            kb.Reset();

            // Add the overlay window to the main window
            GameCanvas.Children.Add(window);

            // Remove the original card so it can't be clicked on again
            MainGrid.Children.Remove(card);
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
