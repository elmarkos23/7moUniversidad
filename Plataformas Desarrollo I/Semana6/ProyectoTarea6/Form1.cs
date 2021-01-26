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
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void registroEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormEstudiantes f = new FormEstudiantes();
      f.MdiParent = this;
      f.Show();
    }

    private void registroDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormRegistroAsistencia f = new FormRegistroAsistencia();
      f.MdiParent = this;
      f.Show();
    }

    private void resumenDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FormResumenAsistencia f = new FormResumenAsistencia();
      f.MdiParent = this;
      f.Show();
    }

    private void asignarHorarioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FromHorario f = new FromHorario();
      f.MdiParent = this;
      f.Show();
    }
  }
}
