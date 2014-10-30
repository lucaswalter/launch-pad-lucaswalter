using Caliburn.Micro;
using LaunchPadLucasWalter.Models;

namespace LaunchPadLucasWalter.ViewModels
{
    class RoverViewModel : PropertyChangedBase
    {
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

        public RoverViewModel()
        {
            Model = new RoverModel();
            RoverName = "Schlot Bot";
        }

        public void Rove()
        {
            // TODO
        }
    }
}
