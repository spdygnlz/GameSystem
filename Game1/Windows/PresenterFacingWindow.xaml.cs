﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace Game1.Windows
{
    /// <summary>
    /// Interaction logic for PresenterFacingWindow.xaml
    /// </summary>
    [Export]
    public partial class PresenterFacingWindow : Window
    {
        [ImportingConstructor]
        public PresenterFacingWindow()
        {
            InitializeComponent();
        }

    }
}