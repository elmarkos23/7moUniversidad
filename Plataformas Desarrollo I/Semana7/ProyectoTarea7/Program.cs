using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTarea7
{
  static class Program
  {
    #region variables publicas
    public static List<Modelos.Estudiante> listaEstudiantes = new List<Modelos.Estudiante>();
    public static List<Modelos.Tutor> listaTutores = new List<Modelos.Tutor>();
    public static List<Modelos.AsignacionEstuadiante> listaAsignaciones = new List<Modelos.AsignacionEstuadiante>();
    public static List<Modelos.Actividad> listaActividades = new List<Modelos.Actividad>();
    #endregion

    [STAThread]
    static void Main()
    {
      //datos de prueba
      listaEstudiantes.Add(new Modelos.Estudiante { identificacion = "1721481586", nombres = "Marco Antonio", apellidos = "Ayala Lituma", carrera = "Ingenieria en Sistema", nivel = "Septimo" });
      listaEstudiantes.Add(new Modelos.Estudiante { identificacion = "1706067426", nombres = "Carlos Jose", apellidos = "Moreno Carrera", carrera = "Ingenieria en Telecomunicaciones", nivel = "Octavo" });
      listaTutores.Add(new Modelos.Tutor { identificacion = "0782232123", nombres = "Jorge", apellidos = "Tatayo", disponibilidad = "Virtual", facultad = "Ingenierias" });
      listaTutores.Add(new Modelos.Tutor { identificacion = "1723290890", nombres = "Manuel", apellidos = "Lopez", disponibilidad = "Presencial", facultad = "Licenciaturas" });
      listaTutores.Add(new Modelos.Tutor { identificacion = "0500121876", nombres = "Maria Belen", apellidos = "Santos", disponibilidad = "Virtual", facultad = "Licenciaturas" });
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new FormMenu());
    }
  }
}
