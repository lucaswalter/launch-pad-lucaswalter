using Caliburn.Micro;
using LaunchPadLucasWalter.Models;

namespace LaunchPadLucasWalter.ViewModels
{
    public class ConsoleViewModel : PropertyChangedBase
    {
        private ConsoleModel Model;

        public ConsoleViewModel()
        {
            Model = new ConsoleModel();
        }
    }
}
