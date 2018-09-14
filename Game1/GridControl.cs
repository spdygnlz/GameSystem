using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Game1
{
    public class GridControl : Grid
    {
        #region Properties
        public bool ShowCustomGridLines
        {
            get { return (bool)GetValue(ShowCustomGridLinesProperty); }
            set { SetValue(ShowCustomGridLinesProperty, value); }
        }

        public static readonly DependencyProperty ShowCustomGridLinesProperty =
            DependencyProperty.Register("ShowCustomGridLines", typeof(bool), typeof(GridControl), new UIPropertyMetadata(false));

        public Brush GridLineBrush
        {
            get { return (Brush)GetValue(GridLineBrushProperty); }
            set { SetValue(GridLineBrushProperty, value); }
        }

        public static readonly DependencyProperty GridLineBrushProperty =
            DependencyProperty.Register("GridLineBrush", typeof(Brush), typeof(GridControl), new UIPropertyMetadata(Brushes.Black));

        public double GridLineThickness
        {
            get { return (double)GetValue(GridLineThicknessProperty); }
            set { SetValue(GridLineThicknessProperty, value); }
        }

        public static readonly DependencyProperty GridLineThicknessProperty =
            DependencyProperty.Register("GridLineThickness", typeof(double), typeof(GridControl), new UIPropertyMetadata(1.0));
        #endregion

        protected override void OnRender(DrawingContext dc)
        {
            base.OnRender(dc);
            if (ShowCustomGridLines)
            {
                foreach (var rowDefinition in RowDefinitions)
                {
                    double thickness = GridLineThickness;
                    var newRow = rowDefinition as GridControlRowDefinition;
                    if (newRow != null && newRow.CustomGridLineThickness >= 0)
                    {
                        thickness = newRow.CustomGridLineThickness;
                    }

                    dc.DrawLine(new Pen(GridLineBrush, thickness), new Point(0, rowDefinition.Offset), new Point(ActualWidth, rowDefinition.Offset));
                }

                foreach (var columnDefinition in ColumnDefinitions)
                {                    
                    dc.DrawLine(new Pen(GridLineBrush, GridLineThickness), new Point(columnDefinition.Offset, 0), new Point(columnDefinition.Offset, ActualHeight));
                }
                dc.DrawRectangle(Brushes.Transparent, new Pen(GridLineBrush, GridLineThickness), new Rect(0, 0, ActualWidth, ActualHeight));
            }
        }

        static GridControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GridControl), new FrameworkPropertyMetadata(typeof(GridControl)));
        }
    }

    public class GridControlRowDefinition : RowDefinition
    {
        public double CustomGridLineThickness
        {
            get { return (double)GetValue(CustomGridLineThicknessProperty); }
            set { SetValue(CustomGridLineThicknessProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CustomGridLineWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomGridLineThicknessProperty =
            DependencyProperty.Register("CustomGridLineThickness", typeof(double), typeof(GridControlRowDefinition), new PropertyMetadata((double)-1));
    }
}
