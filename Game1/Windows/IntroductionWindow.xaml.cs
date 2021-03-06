﻿using InputCapture;
using Microsoft.Practices.ServiceLocation;
using Prism.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
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
    /// Interaction logic for IntroductionWindow.xaml
    /// </summary>
    [Export]
    public partial class IntroductionWindow : Window
    {
        [ImportingConstructor]
        public IntroductionWindow()
        {
            InitializeComponent();

            IKeyboardCapture kb = new LockoutKeyboardCapture(Key.Space);
            var contianer = ServiceLocator.Current.GetInstance<CompositionContainer>();
            contianer.ComposeExportedValue(kb);
        }
    }
}
