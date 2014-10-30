using Caliburn.Micro;
using LaunchPadLucasWalter.Models;
using System.Threading.Tasks;

namespace LaunchPadLucasWalter.ViewModels
{
    class RoverViewModel : PropertyChangedBase
    {
        private MainWindowViewModel MainWindow;
        private RoverModel Model;
        
        public string RoverName
        {
            get
            {
                return Model.roverName;
            }

            set
            {
                Model.roverName = value;
                NotifyOfPropertyChange();

            }
        }

        public int Speed
        {
            get
            {
                return Model.speed;
            }

            set
            {
                Model.speed = value;
                NotifyOfPropertyChange();

            }
        }

        public double Temperature
        {
            get
            {
                return Model.temperature;
            }

            set
            {
                Model.temperature = value;
                NotifyOfPropertyChange();

            }
        }

        public bool IsConnected
        {
            get
            {
                return Model.isConnected;
            }

            set
            {
                Model.isConnected = value;
                NotifyOfPropertyChange();

            }
        }

        public RoverViewModel(MainWindowViewModel mainWindow)
        {
            Model = new RoverModel();
            MainWindow = mainWindow;
            RoverName = "Schlot Bot";
        }

        public void Rove()
        {
            if (IsConnected)
            {
                Task.Run(async () =>
                {
                    for (var i = 0; i < 15; i++)
                    {
                        Speed += 1;
                        Temperature = 50 + Speed / 4;
                        await Task.Delay(200);
                    }
                    for (var i = 14; i >= 0; i--)
                    {
                        Speed -= 1;
                        Temperature = 50 + Speed / 4;
                        await Task.Delay(200);
                    }
                });
            }
            else
            {
                // TODO
            }
        }
    }
}
