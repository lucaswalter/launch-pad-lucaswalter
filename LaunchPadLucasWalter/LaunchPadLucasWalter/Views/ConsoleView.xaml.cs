﻿using LaunchPadLucasWalter.ViewModels;
using System.Windows.Controls;

namespace LaunchPadLucasWalter.Views
{
    /// <summary>
    /// Interaction logic for ConsoleView.xaml
    /// </summary>
    public partial class ConsoleView : UserControl
    {
        public ConsoleView()
        {
            InitializeComponent();
            this.DataContext = new ConsoleViewModel();
        }
    }
}
