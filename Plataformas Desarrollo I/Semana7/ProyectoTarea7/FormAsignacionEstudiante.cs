using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTarea7
{
  public partial class FormAsignacionEstudiante : Form1
  {
    public FormAsignacionEstudiante()
    {
      InitializeComponent();
      cmbTutor.DataSource = Program.listaTutores.ToList();
      cmbTutor.DisplayMember = "Nombres";
      cmbTutor.ValueMember = "Identificacion";

      cmbEstudiante.DataSource = Program.listaEstudiantes.ToList();
      cmbEstudiante.DisplayMember = "Nombres";
      cmbEstudiante.ValueMember = "Identificacion";
      dtpFecha.Enabled = false;
    }

    private void btnAsignar_Click(object sender, EventArgs e)
    {
      if (Program.listaAsignaciones.FirstOrDefault(x => x.identificaciontTutor.Equals(cmbTutor.SelectedValue.ToString()) && x.identificacionEstudiante.Equals(cmbEstudiante.SelectedValue.ToString()))==null)
      {
        Program.listaAsignaciones.Add(
          new Modelos.AsignacionEstuadiante
          {
            identificaciontTutor = cmbTutor.SelectedValue.ToString(),
            nombresTutor = cmbTutor.Text.ToString(),
            identificacionEstudiante = cmbEstudiante.SelectedValue.ToString(),
            nombresEstudiante = cmbEstudiante.Text.ToString(),
            fechaAsignacion = dtpFecha.Value,
            idAsignacion = (Program.listaAsignaciones.Count + 1)
          }
          );
        CargarInformacion();
      }
    }
    public void CargarInformacion()
    {
      dataGridView1.DataSource = Program.listaAsignaciones.ToList();
      dataGridView1.Refresh();
    }

    private void FormAsignacionEstudiante_Load(object sender, EventArgs e)
    {
      CargarInformacion();
    }
  }
}
