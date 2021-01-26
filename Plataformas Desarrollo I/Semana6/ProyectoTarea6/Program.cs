using ProyectoTarea6.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTarea6
{
  static class Program
  {
    public static List<Horario> ListaHorarios = new List<Horario>();
    public static List<Asistencia> ListaAsistencia = new List<Asistencia>();
    public static List<Estudiante> ListaEstudiantes = new List<Estudiante>();

    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new Form1());

     
    }

    

  }
}
