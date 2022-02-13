using Microsoft.Toolkit.Mvvm.ComponentModel;
using RepasoExamenEv2_DINT.Servicios;
using System.Collections.Generic;
using System.Collections.ObjectModel;

class Componente :ObservableObject
{
    private string _nombre;
    private string _tipo;
    private string _imagen;
    private int _precio;


    public string Nombre { 
        get { return _nombre; }
        set { SetProperty(ref _nombre, value); }
    }
    
    public string Tipo
    {
        get { return _tipo; }
        set { SetProperty(ref _tipo, value); }
    }

    public string Imagen
    {
        get { return _imagen; }
        set { SetProperty(ref _imagen, value); }
    }

    public int Precio
    {
        get { return _precio; }
        set { SetProperty(ref _precio, value); }
    }

    public Componente(string nombre, string tipo, string imagen, int precio)
    {
        this._nombre = nombre;
        this._tipo = tipo;
        this._imagen = imagen;
        this._precio = precio;
    } 
}

