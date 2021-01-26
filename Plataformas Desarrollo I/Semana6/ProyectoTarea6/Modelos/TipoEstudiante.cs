using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea6.Modelos
{
  public class TipoEstudiante
  {
    public string nombre { get; set; }

    public TipoEstudiante()
    {
      nombre = string.Empty;
    }
    public static List<TipoEstudiante> getTipos()
    {
      List<TipoEstudiante> lista = new List<TipoEstudiante>();
      lista.Add(new TipoEstudiante { nombre = "Seleccione" });
      lista.Add(new TipoEstudiante { nombre = "Ayudante" });
      lista.Add(new TipoEstudiante { nombre = "Becario" });
      return lista;
    }
  }
}
