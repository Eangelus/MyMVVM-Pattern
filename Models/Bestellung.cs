using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.Models
{
    internal class Bestellung
    {


        public BestellungsID bestellungsID { get; }
        public DateTime BestellungsZeitPunkt { get; }

        public DateTime BestellAbschluß { get; set; }


        public Bestellung(BestellungsID beID, DateTime bestellungsZeitPunkt)
        {
            bestellungsID = beID;
            BestellungsZeitPunkt = bestellungsZeitPunkt;
        }
    }
}
