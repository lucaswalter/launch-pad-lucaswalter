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

using LaunchPadLucasWalter.Models;

namespace LaunchPadLucasWalter.ViewModels
{
    /// <summary>
    /// Interaction logic for ConsoleViewModel.xaml
    /// </summary>
    public partial class ConsoleViewModel : Window
    {
        private ConsoleModel Model;

        public ConsoleViewModel()
        {
            InitializeComponent();
            this.DataContext = new ConsoleViewModel();
            Model = new ConsoleModel();
        }
    }
}
