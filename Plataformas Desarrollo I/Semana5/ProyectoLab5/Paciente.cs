using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoLab5
{
  public class Paciente : Persona
  {
    public string enfermedad;
    public string seguro;
    public Paciente(string cedula, string nombre, string enfermedad, string seguro) : base(cedula, nombre)
    {
      this.enfermedad = enfermedad;
      this.seguro = seguro;
    }
    public String get_enfermedad()
    {
      return enfermedad;
    }
    public String get_seguro()
    {
      return seguro;
    }
  }
}