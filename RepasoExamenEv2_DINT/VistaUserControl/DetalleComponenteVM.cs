using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenEv2_DINT.VistaUserControl
{
    class DetalleComponenteVM :ObservableRecipient
    {
        private Componente _componenteSeleccionado;
        public Componente ComponenteSeleccionado
        {
            get { return _componenteSeleccionado; }
            set { SetProperty(ref _componenteSeleccionado, value); }
        }

        public DetalleComponenteVM()
        {
            EnviarSolicitudDetalleComponente();
        }

        private void EnviarSolicitudDetalleComponente()
        {
            ComponenteSeleccionado = WeakReferenceMessenger.Default.Send<MensajeDetalleComponente>();
        }
    }
}
