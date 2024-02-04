using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Pattern.Commands
{
    internal class AuflistungsCommand : BaseCommands
    {
        public ICommand MakeBestellungCommand { get;  }

        public AuflistungsCommand()
        {
            
        }
    }
}
