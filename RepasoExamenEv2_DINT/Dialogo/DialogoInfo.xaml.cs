using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RepasoExamenEv2_DINT.Dialogo
{
    /// <summary>
    /// Lógica de interacción para DialogoInfo.xaml
    /// </summary>
    public partial class DialogoInfo : Window
    {
        DialogoInfoVM vm;
        public DialogoInfo()
        {
            InitializeComponent();
            vm = new DialogoInfoVM();
            this.DataContext = vm;
        }

        private void buttonCerrar_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
