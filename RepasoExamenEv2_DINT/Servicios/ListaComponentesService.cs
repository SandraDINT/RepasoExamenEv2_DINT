using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoExamenEv2_DINT.Servicios
{
    class ListaComponentesService
    {
        public  ObservableCollection<Componente> GetComponentes()
        {
            var lista = new ObservableCollection<Componente>();
            lista.Add(new Componente("AMD Ryzen 7 5800X", "Procesador", "../Assets/amd_ryzen.jpg", 452));
            lista.Add(new Componente("Intel Core i7-11700K", "Procesador", "../Assets/Intel_Core_i7_11700K.jpg", 365));
            lista.Add(new Componente("Gainward 471056224", "Tarjeta", "../Assets/gainward.jpg", 1719));
            lista.Add(new Componente("ASUS ROG Maximus XIII Extreme", "Placa base", "../Assets/asus.jpg", 976));
            lista.Add(new Componente("ASRock X570 Creator", "Placa base", "../Assets/ASRock.jpg", 512));
            return lista;
        }
    }
}
