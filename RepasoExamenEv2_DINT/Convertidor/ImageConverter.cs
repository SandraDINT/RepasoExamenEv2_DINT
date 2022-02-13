using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace RepasoExamenEv2_DINT.Convertidor
{
    class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string tipo = (string)value;
            string imagenTipo = "";

            switch (tipo)
            {
                case "Procesador":
                    imagenTipo = "Assets/micro.png";
                    break;
                case "Placa base":
                    imagenTipo = "Assets/placa.png";
                    break;
                case "Tarjeta":
                    imagenTipo = "Assets/tarjeta.png";
                    break;
            }
            return imagenTipo;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
