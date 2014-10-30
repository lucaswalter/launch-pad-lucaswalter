using Caliburn.Micro;
using LaunchPadLucasWalter.Models;

namespace LaunchPadLucasWalter.ViewModels
{
    public class ConsoleViewModel : PropertyChangedBase
    {
        private ConsoleModel Model;
        private MainWindowViewModel MainWindow;

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
            UpdateConsole("Welconme!");
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
