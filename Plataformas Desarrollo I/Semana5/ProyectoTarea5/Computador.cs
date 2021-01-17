using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea5
{
  public class Computador
  {
    public string Marca = string.Empty;
    public string Modelo = string.Empty;
    public string Nombre = string.Empty;
    public decimal Precio = 0;

    public Computador(string marca, string modelo, string nombre, decimal precio)
    {
      Marca = marca;
      Modelo = modelo;
      Nombre = nombre;
      Precio = precio;
    }

    public string getMarca() { return Marca; }
    public string getModelo() { return Modelo; }
    public string getNombre() { return Nombre; }
    public decimal getPrecio() { return Precio; }
  }
}
