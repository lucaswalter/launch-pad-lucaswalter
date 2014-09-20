using Caliburn.Micro;
using LaunchPadLucasWalter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
