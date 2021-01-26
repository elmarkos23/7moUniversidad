using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea6.Modelos
{
 public class TipoActividad
  {
    public string nombre { get; set; }

    public TipoActividad()
    {
      nombre = string.Empty;
    }
    public static List<TipoActividad> getTipos()
    {
      List<TipoActividad> lista = new List<TipoActividad>();
      lista.Add(new TipoActividad { nombre = "Seleccione" });
      lista.Add(new TipoActividad { nombre = "Asesorias" });
      lista.Add(new TipoActividad { nombre = "Curso de Base de Datos" });
      lista.Add(new TipoActividad { nombre = "Desarrollo de Aplicaciones Moviles" });
      lista.Add(new TipoActividad { nombre = "Formateo de Computadores" });

      return lista;
    }
  }
}
