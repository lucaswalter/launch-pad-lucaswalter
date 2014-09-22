using Caliburn.Micro;
using LaunchPadLucasWalter.Models;

namespace LaunchPadLucasWalter.ViewModels
{
    class MainWindowViewModel : PropertyChangedBase
    {
        private MainWindowModel Model;

        public ConsoleViewModel Console
        {
            get
            {
                return Model.console;
            }

            set
            {
                Model.console = value;
                NotifyOfPropertyChange();
            }
        }

        public MainWindowViewModel()
        {
            Model = new MainWindowModel();
            Model.console = new ConsoleViewModel();
        }
    }
}
