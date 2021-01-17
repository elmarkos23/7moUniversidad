using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLab5
{
  public class Persona
  {
    public static string cedula;
    public static string nombre;
    public Persona(string cedula1, string nombre1)
    {
      nombre = nombre1; cedula = cedula1;
    }
    public string get_cedula()
    {
      return cedula;
    }
    public string get_nombre()
    {
      return nombre;
    }
    public void setea_datos(string cedula1, string nombre1)
    {
      nombre = nombre1; cedula = cedula1;
    }
  }
}
