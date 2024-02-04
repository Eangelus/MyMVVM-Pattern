using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.Models
{
    internal class BestellungsID
    {


        public int BestellNummer { get;  }
        public int KundenNummer { get; }
        public string KundenName { get; }


        public BestellungsID(int bestellNummer, int kundenNummer, string kundenName)
        {
            BestellNummer = bestellNummer;
            KundenNummer = kundenNummer;
            KundenName = kundenName;    
        }

        public override string ToString()
        {
            return $"{BestellNummer}{KundenNummer}";
        }


        public override bool Equals(object obj)
        {
            return obj is BestellungsID bestellID &&
                KundenNummer == bestellID.KundenNummer &&
                BestellNummer == bestellID.BestellNummer;
        }

        public override int GetHashCode()
        {
            var hash = BestellNummer + KundenNummer;
            return hash;
        }

    }
}
