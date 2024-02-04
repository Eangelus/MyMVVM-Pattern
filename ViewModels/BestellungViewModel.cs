using MVVM_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.ViewModels
{
    internal class BestellungViewModel
    {

        private readonly Bestellung _bestellung;

        public BestellungsID bestellungsID => _bestellung.bestellungsID;
        public string BestellungsEingang => _bestellung.BestellungsZeitPunkt.Date.ToString("d");

        public string Auslieferung => _bestellung.BestellAbschluß.Date.ToString("d");


        public BestellungViewModel(Bestellung bestellung)
        {
            _bestellung = bestellung;
        }
    }
}
