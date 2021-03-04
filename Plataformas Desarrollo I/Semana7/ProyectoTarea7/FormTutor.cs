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
  public partial class FormTutor : Form1
  {
    public FormTutor()
    {
      InitializeComponent();
    }

    private void FormTutor_Load(object sender, EventArgs e)
    {
      CargarInformacion();
    }

    private void CargarInformacion()
    {
      dgvDatos.DataSource = Program.listaTutores.ToList();
      dgvDatos.Refresh();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      Program.listaTutores.Add(new Modelos.Tutor
      {
        identificacion = txtIdentificacion.Text.Trim(),
        nombres = txtNombres.Text.Trim(),
        apellidos = txtApellidos.Text.Trim(),
        disponibilidad = cmbDisponibilidad.SelectedItem.ToString(),
        facultad = cmbFacultad.SelectedItem.ToString()
      });
      CargarInformacion();
    }
  }
}
