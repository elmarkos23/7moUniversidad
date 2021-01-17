using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea5
{
  public class Cliente: Persona
  {
    public int CodigoCliente;
    public decimal CupoCredito;

    public Cliente(string nombre, string apellido, int codigoCliente, decimal cupoCredito): base (nombre, apellido)
    {
      this.Nombre = nombre;
      this.Apellido = apellido;
      this.CodigoCliente = codigoCliente;
      this.CupoCredito = cupoCredito;
    }

    public int getCodigoCliente()
    { 
      return CodigoCliente;
    }
    public decimal getCupoCredito()
    {
      return CupoCredito;
    }
  }
}
