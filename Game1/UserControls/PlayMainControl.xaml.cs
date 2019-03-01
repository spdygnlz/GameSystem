using GameInterfaces;
using InputCapture;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
using System;
using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Game1.UserControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    [Export(typeof(IGame))]
    public partial class PlayMainControl : UserControl, IGame
    {
        private IEventAggregator eventAggregator;

        public string GameName
        {
            get
            {
                return "Jeopardy!";
            }
        }

        private IKeyboardCapture kb = new LockoutKeyboardCapture(Key.Space);
        
        /// <summary>
        /// Constructor
        /// </summary>
        public PlayMainControl()
        {           
            InitializeComponent();

            eventAggregator = ServiceLocator.Current.GetInstance<IEventAggregator>();

            eventAggregator.GetEvent<PubSubEvent<ClickCard>>().Subscribe((card) => CardClick(card));
            eventAggregator.GetEvent<PubSubEvent<ClickClue>>().Subscribe((clue) => ClueClick(clue));

            kb.RegisterWindow(this);
            kb.KeyboardNotification += (sender, args) => 
            {
                MessageBox.Show($"Got {args.Key} at {args.Time.ToString(@"ss\:fff")}");
            };
        }

        /// <summary>
        /// Handles removing the clue window so the rest of the screen is displayed
        /// </summary>
        /// <param name="clue"></param>
        private void ClueClick(ClickClue clue)
        {
            // Find the clue window in the hierarchy
            var clueWindow = FindChild<ClueWindow>(Parent, clue.ClueName);

            // Remove the overlay window
            GameCanvas.Children.Remove(clueWindow);
        }

        /// <summary>
        /// Handles opening up a clue window from the card that was clicked on
        /// </summary>
        /// <param name="cardArgs"></param>
        private void CardClick(ClickCard cardArgs)
        {
            // Get the card that was clicked
            //var card = e.Source as JeopardyCard;
            var card = FindName(cardArgs.CardName) as JeopardyCard;

            // Create the new window to show over the grid
            ClueWindow window = new ClueWindow() { Name = $"Clue{cardArgs.CardName}"};

            // Hook up the event that will close the window when it's double clicked
            window.MouseDoubleClick += (s, args) =>             
            {
                var clueWindow = s as ClueWindow;
                eventAggregator.GetEvent<PubSubEvent<ClickClue>>().Publish(new ClickClue { ClueName = clueWindow.Name });
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

        /// <summary>
        /// Finds a Child of a given item in the visual tree. 
        /// </summary>
        /// <param name="parent">A direct parent of the queried item.</param>
        /// <typeparam name="T">The type of the queried item.</typeparam>
        /// <param name="childName">x:Name or Name of child. </param>
        /// <returns>The first parent item that matches the submitted type parameter. 
        /// If not matching item can be found, 
        /// a null parent is being returned.</returns>
        public static T FindChild<T>(DependencyObject parent, string childName)
           where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search
                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        // if the child's name is of the request name
                        foundChild = (T)child;
                        break;
                    }
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }

        private void JeopardyCardDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var card = e.Source as JeopardyCard;

            var cardArgs = new ClickCard() { CardName = card.Name };
            eventAggregator.GetEvent<PubSubEvent<ClickCard>>().Publish(cardArgs);
        }
    }
}
