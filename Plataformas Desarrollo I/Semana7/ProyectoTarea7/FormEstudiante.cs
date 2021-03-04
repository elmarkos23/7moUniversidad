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
  public partial class FormEstudiante : Form1
  {
    public FormEstudiante()
    {
      InitializeComponent();
    }
    public void CargarInformacion()
    {
      dgvDatos.DataSource = Program.listaEstudiantes.ToList();
      dgvDatos.Refresh();
    }
    private void btnGuardar_Click(object sender, EventArgs e)
    {
      Program.listaEstudiantes.Add(new Modelos.Estudiante
      {
        identificacion = txtIdentificacion.Text.Trim(),
        nombres = txtNombres.Text.Trim(),
        apellidos = txtApellidos.Text.Trim(),
        carrera = cmbCarrera.SelectedItem.ToString(),
        nivel = cmbNivel.SelectedItem.ToString()
      });
      CargarInformacion();
    }

    private void FormEstudiante_Load(object sender, EventArgs e)
    {
      CargarInformacion();
    }
  }
}
