using Microsoft.Toolkit.Mvvm.ComponentModel;
using RepasoExamenEv2_DINT.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenEv2_DINT.Clases
{
    class MainWindowVM : ObservableObject
    {
        //Servicios
        ListaComponentesService componentesService;

        //Variables
        private ObservableCollection<Componente> _listaComponentes;
        public ObservableCollection<Componente> ListaComponentes
        {
            get { return _listaComponentes; }
            set { SetProperty(ref _listaComponentes, value); }
        }
        private Componente _componenteActual;
        public Componente ComponenteActual 
        {
            get { return _componenteActual; }
            set { SetProperty(ref _componenteActual, value); }
        }


        public MainWindowVM()
        {
            //Servicios
            componentesService = new ListaComponentesService();

            //Variables
            _listaComponentes = componentesService.GetComponentes();
        }
    }
}
