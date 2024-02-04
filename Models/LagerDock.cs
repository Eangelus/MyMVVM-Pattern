using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.Models
{
    internal class LagerDock
    {
        private readonly List<Bestellung> _bestellungen;

        public LagerDock()
        {
            _bestellungen = new List<Bestellung>();
        }


        public IEnumerable<Bestellung> GetAllBestellungen()
        {
            return _bestellungen;
        }

        public void AddNewBestellung(Bestellung bestellung)
        {
            _bestellungen.Add(bestellung);
        }

    }
}
