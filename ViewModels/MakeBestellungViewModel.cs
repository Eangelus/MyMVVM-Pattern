using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Pattern.ViewModels
{
    internal class MakeBestellungViewModel : BaseViewModel
    {

        private string _kundenName;

        public string Kundenname
        {
            get
            {
                return _kundenName;
            }
            set
            {
                _kundenName = value;
                OnPropertyChanged(nameof(Kundenname));
            }

        }

        private int _bestellNummer;

        public int Bestellnummer
        {
            get
            {
                return _bestellNummer;
            }
            set
            {
                _bestellNummer = value;
                OnPropertyChanged(nameof(Bestellnummer));
            }

        }


        private int _kundenNummer;

        public int Kundennummer
        {
            get
            {
                return _bestellNummer;
            }
            set
            {
                _bestellNummer = value;
                OnPropertyChanged(nameof(Kundennummer));
            }

        }

        public MakeBestellungViewModel()
        {
            
        }
    }
}
