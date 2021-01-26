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
  public partial class FormResumenAsistencia : Form
  {
    int i = 0;
    Pen f = new Pen(Color.Red);
    Pen f1 = new Pen(Color.Blue);
    Pen f2 = new Pen(Color.Beige);
    Font tipo1 = new Font("Arial", 10);
    Font tipo2 = new Font("Comic Sans MS", 9);
    bool band = false;
    public List<Asistencia> ListaAsistenciaEstudiante = new List<Asistencia>();
    public FormResumenAsistencia()
    {
      InitializeComponent();
      cmbEstudiante.DataSource = Program.ListaEstudiantes;
      cmbEstudiante.DisplayMember = "Nombres";
      cmbEstudiante.ValueMember = "Identificacion";
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      if (band)
      {
        graficoBarras(panel1.CreateGraphics(), ListaAsistenciaEstudiante, 100, 300);
      }
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
      if (band)
      {
        graficoPastel(panel2.CreateGraphics(), 50, 125);
      }
    }

    private void FormResumenAsistencia_Load(object sender, EventArgs e)
    {
      band = true;
      
    }
    public void graficoBarras(Graphics t, List<Asistencia> A, int x, int y)
    {
      int contS = 0, contC = 0, a = 20, ancho = 40;
      for (int i = 0; i < A.Count; i++)
      {
        if (A[i].estadoAsistencia.Equals(true)) contS++;
        if (!A[i].estadoAsistencia.Equals(true)) contC++;
      }
      t.DrawLine(f1, x, y, x + 300, y); t.DrawLine(f1, x, y, x, y - 250);
      t.DrawString("Registro Asistencia", tipo2, Brushes.Black, x + 300, y);
      t.DrawString("Contador", tipo2, Brushes.Black, x - 100, y - 250);
      t.DrawRectangle(f1, x + 250, y - 190, 160, 100); t.DrawString("Leyenda", tipo2, Brushes.Black, x + 270, y - 170);
      t.FillRectangle(Brushes.SkyBlue, x + 270, y - 150, ancho, ancho / 2);
      t.FillRectangle(Brushes.Purple, x + 270, y - 120, ancho, ancho / 2);
      t.DrawRectangle(f1, x + 270, y - 150, ancho, ancho / 2);
      t.DrawRectangle(f1, x + 270, y - 120, ancho, ancho / 2);
      t.DrawString("Asistencia", tipo2, Brushes.Black, x + 320, y - 150);
      t.DrawString("Falta", tipo2, Brushes.Black, x + 320, y - 120);
      t.DrawRectangle(f1, x + 270, y - 150, ancho, ancho / 2);
      t.DrawRectangle(f1, x + 270, y - 120, ancho, ancho / 2);
      t.DrawString("Asistencia", tipo2, Brushes.Black, x + 320, y - 150);
      t.DrawString("Falta", tipo2, Brushes.Black, x + 320, y - 120);

      t.FillRectangle(Brushes.SkyBlue, x + 50, y - (contS * a), ancho, contS * a);
      t.DrawRectangle(f1, x + 50, y - (contS * a), ancho, contS * a);
      t.DrawLine(f1, x, y - (contS * a), x + 50 + ancho, y - (contS * a));

      t.DrawString("Asistencia", tipo2, Brushes.Black, x + 50, y + 30);
      t.DrawString("" + contS, tipo2, Brushes.Black, x - 20, y - (contS * a));
      t.FillRectangle(Brushes.Purple, x + 140, y - (contC * a), ancho, contC * a);
      t.DrawRectangle(f1, x + 140, y - (contC * a), ancho, contC * a);
      t.DrawLine(f1, x + 50 + ancho, y - (contC * a), x + 140 + ancho, y - (contC * a));
      t.DrawString("Falta", tipo2, Brushes.Black, x + 140, y + 30);
      t.DrawString("" + contC, tipo2, Brushes.Black, x - 20, y - (contC * a));
    }
    public void graficoPastel(Graphics g, int x, int y)
    {
      int ptot = 0; int s = 0, ns = 0;
      for (int i = 0; i < ListaAsistenciaEstudiante.Count; i++)
      {
        if (ListaAsistenciaEstudiante[i].estadoAsistencia.Equals(true)) s++;
        if (!ListaAsistenciaEstudiante[i].estadoAsistencia.Equals(true)) ns++;
      }
      ptot = ListaAsistenciaEstudiante.Count; if (ptot != 0)
      {
        g.DrawRectangle(f1, x + 200, y + 20, 200, 100);
        g.DrawString("Leyenda:", tipo2, Brushes.Black, x + 210, y + 40);
        g.DrawString("Asistencia " + (double)(s * 100 / ptot) + " %", tipo2, Brushes.Black, x + 230, y + 60);
        g.DrawString("Falta " + (double)(ns * 100 / ptot) + " %", tipo2, Brushes.Black, x + 230, y + 80);
        g.DrawRectangle(f1, x + 210, y + 60, 10, 10);
        g.DrawRectangle(f1, x + 210, y + 80, 10, 10);
        g.FillEllipse(Brushes.Blue, x - 3, y - 3, 156, 156);

        g.FillPie(Brushes.SkyBlue, x, y, 150, 150, 0, (int)(s * 360 / ptot));
        g.FillRectangle(Brushes.SkyBlue, x + 210, y + 60, 10, 10);
        g.FillPie(Brushes.Purple, x, y, 150, 150, (int)(s * 360 / ptot), (int)(ns * 360 / ptot));
        g.FillRectangle(Brushes.Purple, x + 210, y + 80, 10, 10);
      }
    }

    private void cmbEstudiante_SelectionChangeCommitted(object sender, EventArgs e)
    {
      ListaAsistenciaEstudiante = Program.ListaAsistencia.Where(x => x.identificacion.Equals(cmbEstudiante.SelectedValue.ToString())).ToList();

      band = true;
      this.Refresh();
    }
  }
}
