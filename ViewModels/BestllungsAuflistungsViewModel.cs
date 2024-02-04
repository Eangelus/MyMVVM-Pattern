using MVVM_Pattern.Commands;
using MVVM_Pattern.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Pattern.ViewModels
{
    internal class BestllungsAuflistungsViewModel : BaseViewModel
    {
        ICommand MakeBestellung = new AuflistungsCommand();

        private readonly ObservableCollection<BestellungViewModel> _bestellungen;

        public ObservableCollection<BestellungViewModel> Bestellungen => _bestellungen;
        public BestllungsAuflistungsViewModel()
        {

            _bestellungen = new ObservableCollection<BestellungViewModel>();


            _bestellungen.Add(new BestellungViewModel(new Bestellung (new BestellungsID(1, 1, "Tom"),DateTime.Now) ));
            _bestellungen.Add(new BestellungViewModel(new Bestellung(new BestellungsID(4, 2, "Michi"), DateTime.Now)));
            _bestellungen.Add(new BestellungViewModel(new Bestellung(new BestellungsID(123, 3, "Rudi"), DateTime.Now)));


        }



    }
}
