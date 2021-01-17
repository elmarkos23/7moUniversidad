using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea5
{
  public class Persona
  {
    public string Nombre = string.Empty;
    public string Apellido = string.Empty;

    public Persona(string nombre, string apellido)
    {
      this.Nombre = nombre;
      this.Apellido = apellido;
    }

    public string getNombre()
    { return Nombre; }
    public string getApellido()
    { return Apellido; }
  }
}
