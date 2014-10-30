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
            Model.text = "Test Text";
        }

        public void Clear()
        {
            Text = string.Empty;
        }

        public void Connect()
        {
            UpdateConsole("Connected!");
        }

        public void Disconnect()
        {
            UpdateConsole("Disconnected!");
        }

        public void UpdateConsole(string s)
        {
            Text += s;
            Text += System.Environment.NewLine;
        }
    }
}
