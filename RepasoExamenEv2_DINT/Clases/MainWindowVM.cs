using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using RepasoExamenEv2_DINT.Servicios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RepasoExamenEv2_DINT.Clases
{
    class MainWindowVM : ObservableObject
    {
        //Servicios
        ListaComponentesService componentesService;
        NavigationService navigationService;

        //Comandos
        public RelayCommand AbrirDetalleCommand { get; }

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
        private UserControl _contenidoVentana;
        public UserControl ContenidoVentana
        {
            get { return _contenidoVentana; }
            set { SetProperty(ref _contenidoVentana, value); }
        }

        public MainWindowVM()
        {
            //Servicios
            componentesService = new ListaComponentesService();
            navigationService = new NavigationService();

            //Comandos
            AbrirDetalleCommand = new RelayCommand(AbrirDetalle);


            //Variables
            _listaComponentes = componentesService.GetComponentes();

            //Mensajes
            RegistrarMensajePasarDetalle();
        }

        //Mensajes
        private void RegistrarMensajePasarDetalle()
        {
            WeakReferenceMessenger.Default.Register<MainWindowVM, MensajeDetalleComponente>(this, (r, m) =>
            {
                if (!m.HasReceivedResponse)
                    m.Reply(r.ComponenteActual);
            });
        }
        private void AbrirDetalle()
        {
            ContenidoVentana = navigationService.AbrirDetalleComponentes();
        }
    }
}
