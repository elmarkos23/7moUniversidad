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
  public partial class FormActividad : Form1
  {
    public FormActividad()
    {
      InitializeComponent();

      cmbTutor.DataSource = Program.listaTutores.ToList();
      cmbTutor.DisplayMember = "Nombres";
      cmbTutor.ValueMember = "Identificacion";
    }

    private void cmbTutor_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (Program.listaAsignaciones.Where(x => x.identificaciontTutor.Equals(cmbTutor.SelectedValue.ToString())).ToList().Count > 0)
      {
        cmbEstudiante.DataSource = Program.listaAsignaciones.Where(x => x.identificaciontTutor.Equals(cmbTutor.SelectedValue.ToString())).ToList();
        cmbEstudiante.DisplayMember = "nombresEstudiante";
        cmbEstudiante.ValueMember = "identificacionEstudiante";
      }
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      Program.listaActividades.Add(new Modelos.Actividad
      {
        identificacionTutor = cmbTutor.SelectedValue.ToString(),
        identificacionEstudiante = cmbEstudiante.SelectedValue.ToString(),
        nombreActividad = cmbActividad.Text,
        detalleActividad = txtDetalles.Text,
        estadoActividad = cmbEstado.Text.ToString(),
        fechaActividad = dtpFechaActividad.Value
      });
      MessageBox.Show("Tarea Asignada");
     
      txtDetalles.Text = string.Empty;
    }
  }
}
