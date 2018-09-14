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

namespace JeopardyGame
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class JeopardyGameView : UserControl
    {
        public JeopardyGameView()
        {
            InitializeComponent();
        }


        private void InitGrid()
        {
            for (int column = 0; column < 6; column++)
            {
                // Create the header row
                var label = new Label();
                label.SetBinding(ContentProperty, new Binding($"Categories[{column}].Name"));
                label.HorizontalAlignment = HorizontalAlignment.Center;
                label.VerticalAlignment = VerticalAlignment.Center;

                label.Template = TryFindResource("LabelTemplate") as ControlTemplate;

                Grid.SetColumn(label, column);
                Grid.SetRow(label, 0);
                MainGrid.Children.Add(label);

                // Get the buttons for each of the 5 questions
                for (int row = 0; row < 5; row++)
                {
                    var card = new JeopardyCard();
                    var valueBinding = new Binding($"Categories[{column}][{row}].Value");
                    var valueBindingBase = card.SetBinding(JeopardyCard.ClueValueProperty, valueBinding);
                    var questionBinding = new Binding($"Categories[{column}][{row}].Question");
                    var questionBindingBase = card.SetBinding(JeopardyCard.ClueTextProperty, questionBinding);

                    card.Margin = new Thickness(4);
                    //                    button.Style = FindResource("CardStyle") as Style;

                    card.MouseDoubleClick += JeopardyCardDoubleClick;

                    Grid.SetColumn(card, column);
                    Grid.SetRow(card, row + 1);
                    MainGrid.Children.Add(card);
                }
            }
        }

        private void JeopardyCardDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var card = e.Source as JeopardyCard;

            ClueWindow window = new ClueWindow();
            window.MouseDoubleClick += (s, args) =>
            {
                Mouse.OverrideCursor = Cursors.Arrow;
                GameCanvas.Children.Remove((UIElement)s);
            };


            Point point = card.TransformToAncestor(Application.Current.MainWindow).Transform(new Point(0, 0));
            window.Width = System.Windows.SystemParameters.WorkArea.Width;
            window.Height = System.Windows.SystemParameters.WorkArea.Height;
            window.SetValue(Canvas.LeftProperty, point.X + (card.ActualWidth / 2));
            window.SetValue(Canvas.TopProperty, point.Y + (card.ActualHeight / 2));
            window.ClueText = card.ClueText;
            Mouse.OverrideCursor = Cursors.None;
            kb.Reset();

            GameCanvas.Children.Add(window);
            MainGrid.Children.Remove(card);
        }
    }
}
