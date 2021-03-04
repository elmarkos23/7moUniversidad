using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea7.Modelos
{
  public class Actividad
  {
    public string identificacionTutor { get; set; }
    public string identificacionEstudiante { get; set; }
    public string nombreActividad { get; set; }
    public string detalleActividad { get; set; }
    public DateTime fechaActividad { get; set; }
    public string estadoActividad { get; set; }
  }
}
