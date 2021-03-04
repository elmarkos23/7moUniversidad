using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea7.Modelos
{
  public class AsignacionEstuadiante
  {
    public int idAsignacion { get; set; }
    public string identificaciontTutor { get; set; }
    public string nombresTutor { get; set; }
    public string identificacionEstudiante { get; set; }
    public string nombresEstudiante { get; set; }
    public DateTime fechaAsignacion { get; set; }
  }
}
