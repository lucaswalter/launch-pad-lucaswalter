using Caliburn.Micro;
using LaunchPadLucasWalter.Models;

namespace LaunchPadLucasWalter.ViewModels
{
    class MainWindowViewModel : PropertyChangedBase
    {
        private MainWindowModel Model;

        public MainWindowViewModel()
        {
            Model = new MainWindowModel();
        }
    }
}
