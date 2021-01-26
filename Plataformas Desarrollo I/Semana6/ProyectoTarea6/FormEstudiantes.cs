using ProyectoTarea6.Modelos;
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
  public partial class FormEstudiantes : Form
  {
    public FormEstudiantes()
    {
      InitializeComponent();
      cmbTipoEstudiante.DataSource = TipoEstudiante.getTipos();
      cmbTipoEstudiante.DisplayMember = "nombre";
      cmbTipoEstudiante.ValueMember = "nombre";
    }

    private void button2_Click(object sender, EventArgs e)
    {
      txtIdentificacion.Text = string.Empty;
      txtNombres.Text = string.Empty;
      txtApelidos.Text = string.Empty;
      cmbTipoEstudiante.SelectedIndex=0;
    }

    private bool Valida()
    {
      if (txtIdentificacion.Text == string.Empty)
      {
        MessageBox.Show(this, "La identificacion esta vacia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtIdentificacion.Focus();
        return false;
      }
      else if (txtNombres.Text == string.Empty)
      {
        MessageBox.Show(this, "El nombre esta vacia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtNombres.Focus();
        return false;
      }
      else if (txtApelidos.Text == string.Empty)
      {
        MessageBox.Show(this, "El Apellido esta vacia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        txtApelidos.Focus();
        return false;
      }
      else if (cmbTipoEstudiante.Text == "Seleccione")
      {
        MessageBox.Show(this, "Seleccione el tipo de estudiante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        cmbTipoEstudiante.Focus();
        return false;
      }
      else
      {
        return true;
      }

    }
    private void button1_Click(object sender, EventArgs e)
    {
      if (!Valida())
      {
        return;
      }
      int Id = Program.ListaEstudiantes.Count() + 1;
      Program.ListaEstudiantes.Add(new Estudiante
      {
        identificacion = txtIdentificacion.Text.Trim(),
        nombres = txtNombres.Text.Trim(),
        Apellidos = txtApelidos.Text.Trim(),
        tipoEstudiante = cmbTipoEstudiante.SelectedText
      });

      MessageBox.Show(this,"Estudiante Crado","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Information);
      button2_Click(sender,e);
    }
  }
}
