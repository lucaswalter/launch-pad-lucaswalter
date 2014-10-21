using System.Windows.Controls;
using LaunchPadLucasWalter.ViewModels;

namespace LaunchPadLucasWalter.Views
{
    /// <summary>
    /// Interaction logic for RoverView.xaml
    /// </summary>
    public partial class RoverView : UserControl
    {
        public RoverView()
        {
            InitializeComponent();
            this.DataContext = new RoverViewModel();
        }
    }
}
