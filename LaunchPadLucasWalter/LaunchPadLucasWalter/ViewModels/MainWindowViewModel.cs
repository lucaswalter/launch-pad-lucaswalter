using Caliburn.Micro;
using LaunchPadLucasWalter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
