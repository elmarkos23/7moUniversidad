using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea5
{
  public class Vendedor:Persona
  {
    private string codigoVendedor = string.Empty;
    private decimal valorMinimoVentas = 0;

    public Vendedor(string nombre, string apellido,string codigoVendedor, decimal valorMinimoVentas): base(nombre,apellido)
    {
      this.Nombre = nombre;
      this.Apellido = apellido;
      this.codigoVendedor = codigoVendedor;
      this.valorMinimoVentas = valorMinimoVentas;
    }

    public string CodigoVendedor { get => codigoVendedor; set => codigoVendedor = value; }
    public decimal ValorMinimoVentas { get => valorMinimoVentas; set => valorMinimoVentas = value; }
  }
}
