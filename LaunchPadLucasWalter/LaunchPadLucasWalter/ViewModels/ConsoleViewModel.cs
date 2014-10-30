using Caliburn.Micro;
using LaunchPadLucasWalter.Models;

namespace LaunchPadLucasWalter.ViewModels
{
    class ConsoleViewModel : PropertyChangedBase
    {
        private MainWindowViewModel MainWindow;
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

        public ConsoleViewModel(MainWindowViewModel mainWindow)
        {
            Model = new ConsoleModel();
            MainWindow = mainWindow;
            UpdateConsole("Welcome!");
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
