using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTarea6
{
  public partial class FormRegistroAsistencia : Form
  {
    private string diaSeleccionado = string.Empty;
    public FormRegistroAsistencia()
    {
      InitializeComponent();

    }

    private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
    {
      diaSeleccionado = getNombreDia(dateTimePicker1.Value.DayOfWeek.ToString());// == DayOfWeek.Monday
      foreach (var item in Program.ListaHorarios)
      {
        if (item.dia.Equals(diaSeleccionado))
        {
          if (Program.ListaAsistencia.Where(x => x.fecha.Equals(dateTimePicker1.Value.ToString("dd-MM-yyyy")) && x.identificacion.Equals(item.identificacionEstudiante)).Count() == 0)
          {
            Program.ListaAsistencia.Add(new Modelos.Asistencia
            {
              estadoAsistencia = false,
              fecha = dateTimePicker1.Value.ToString("dd-MM-yyyy"),
              identificacion = item.identificacionEstudiante,
              tarea = item.tarea
            });
          }

        }
      }
      dataGridView1.DataSource = Program.ListaAsistencia.Where(x=>x.fecha.Equals(dateTimePicker1.Value.ToString("dd-MM-yyyy"))).ToList();
      dataGridView1.Refresh();
    }


    public string getNombreDia(string diaIngles)
    {
      switch (diaIngles)
      {
        case "Monday":
          return "Lunes";
        case "Tuesday":
          return "Martes";
        case "Wednesday":
          return "Miercoles";
        case "Thursday":
          return "Jueves";
        case "Friday":
          return "Viernes";
        case "Saturday":
          return "Sabado";
        case "Sunday":
          return "Donigo";
        default:
          return diaIngles;
      }
    }

  }
}
