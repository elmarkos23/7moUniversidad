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
  public partial class FromHorario : Form
  {


    public FromHorario()
    {
      InitializeComponent();
      cmbEstudiante.DataSource = Program.ListaEstudiantes;
      cmbEstudiante.DisplayMember = "Nombres";
      cmbEstudiante.ValueMember = "Identificacion";
      cmbTarea.DataSource = Modelos.TipoActividad.getTipos();
      cmbTarea.DisplayMember = "nombre";
      cmbTarea.ValueMember = "nombre";
    }
    public void CargarInformacion(string Identificacion)
    {
      richTextBox1.Clear();
      foreach (var item in Program.ListaHorarios)
      {
        richTextBox1.AppendText("Estudiante:" + item.nombreEstudiante + " Día:" + item.dia + " Tarea:" + item.tarea + "\n");
      }
      dataGridView2.DataSource = Program.ListaHorarios.Where(x => x.identificacionEstudiante.Equals(Identificacion)).ToList();
      dataGridView2.Refresh();
    }

    private void cmbEstudiante_SelectionChangeCommitted(object sender, EventArgs e)
    {
      CargarInformacion(cmbEstudiante.SelectedValue.ToString());
    }

    private void btnGrabar_Click(object sender, EventArgs e)
    {
      Program.ListaHorarios.Add(new Modelos.Horario
      {
        dia = cmbDia.Text,
        identificacionEstudiante = cmbEstudiante.SelectedValue.ToString(),
        nombreEstudiante = cmbEstudiante.Text,
        tarea = cmbTarea.Text
      });
      CargarInformacion(cmbEstudiante.SelectedValue.ToString());
    }
  }
}
