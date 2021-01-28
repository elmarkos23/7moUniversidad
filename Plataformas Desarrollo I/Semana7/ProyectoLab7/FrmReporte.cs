using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLab7
{
  public partial class FrmReporte : Form
  {
    public FrmReporte()
    {
      InitializeComponent();
    }

    private void FrmReporte_Load(object sender, EventArgs e)
    {
      // TODO: esta línea de código carga datos en la tabla 'DataSet1.Usuarios' Puede moverla o quitarla según sea necesario.
      this.UsuariosTableAdapter.Fill(this.DataSet1.Usuarios);

      this.reportViewer1.RefreshReport();
    }
  }
}
