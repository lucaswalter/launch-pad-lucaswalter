using Caliburn.Micro;
using LaunchPadLucasWalter.Models;

namespace LaunchPadLucasWalter.ViewModels
{
    class RoverViewModel : PropertyChangedBase
    {
        private RoverModel Model;

        public RoverViewModel()
        {
            Model = new RoverModel();
        }
    }
}
