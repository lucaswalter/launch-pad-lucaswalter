using Caliburn.Micro;
using LaunchPadLucasWalter.Models;

namespace LaunchPadLucasWalter.ViewModels
{
    public class ConsoleViewModel : PropertyChangedBase
    {
        private ConsoleModel Model;

        public string Text
        {
            get
            {
                return Model.text;
            }

            set
            {
                Model.text = value;
                NotifyOfPropertyChange();

            }
        }

        public ConsoleViewModel()
        {
            Model = new ConsoleModel();
        }

    }
}
