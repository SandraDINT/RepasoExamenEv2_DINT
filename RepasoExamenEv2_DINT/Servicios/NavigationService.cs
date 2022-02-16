using RepasoExamenEv2_DINT.Dialogo;
using RepasoExamenEv2_DINT.VistaUserControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RepasoExamenEv2_DINT.Servicios
{
    class NavigationService
    {
        public UserControl AbrirDetalleComponentes()
        {
            return new DetalleUserControl();
        }
        public void AbrirDialogoInfo()
        {
            DialogoInfo dialogo = new DialogoInfo();
            dialogo.ShowDialog();
        }
    }
}
