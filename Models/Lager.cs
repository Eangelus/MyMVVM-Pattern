using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.Models
{
    internal class Lager
    {
        private readonly LagerDock _lagerdock;

        public string Name { get;  }

        public Lager(string name)
        {
            _lagerdock = new LagerDock();
            Name = name;    

        }

        public IEnumerable<Bestellung> GetAllBestellungen() 
        {
            return _lagerdock.GetAllBestellungen();
        
        
        }

        public void MakeBestellung(Bestellung bestellung) 
        {
            _lagerdock.AddNewBestellung(bestellung);
        
        }

    }
}
