using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLab5
{
  public partial class Form1 : Form
  {
    Paciente[] A = new Paciente[3];
    int i = 0;
    Pen p = new Pen(Color.Red);
    Pen p1 = new Pen(Color.Blue);
    Pen p2 = new Pen(Color.Beige);
    Font tipo1 = new Font("Arial", 10);
    Font tipo2 = new Font("Comic Sans MS", 9);
    bool band = false;

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btnPacientes_Click(object sender, EventArgs e)
    {
      A[0] = new Paciente("1721481586", "Marco Ayala", "Ninguna", "Seguro");
      A[1] = new Paciente("1719343020", "Belen Narvaez", "Ninguna", "Seguro");
      A[2] = new Paciente("1706067426", "Salome Chicaiza", "Ninguna", "No Seguro");
      richTextBox1.AppendText("\nCédula - Apellidos y Nombres - Enfermedad- Seguro");
      richTextBox1.AppendText("\n-----------------------");
      for (i = 0; i < A.Length; i++)
      {
        richTextBox1.AppendText("\n" + A[0].get_cedula() + "-" +
                                       A[1].get_nombre() + "-" +
                                       A[i].get_enfermedad() + "-" +
                                       A[i].get_seguro());
        richTextBox1.AppendText("\n");
      }
    }

    public void graficoBarras(Graphics t, Paciente[] A, int x, int y)
    {
      int contS = 0, contC = 0, a = 20, ancho = 40;
      for (int i = 0; i < A.Length; i++)
      {
        if (A[i].get_seguro().Equals("Seguro")) contS++;
        if (A[i].get_seguro().Equals("No Seguro")) contC++;
      }
      t.DrawLine(p1, x, y, x + 300, y); t.DrawLine(p1, x, y, x, y - 250);
      t.DrawString("Tipo", tipo2, Brushes.Black, x + 300, y);
      t.DrawString("# Asegurados", tipo2, Brushes.Black, x - 100, y - 250);
      t.DrawRectangle(p1, x + 250, y - 190, 160, 100); t.DrawString("Leyenda", tipo2, Brushes.Black, x + 270, y - 170);
      t.FillRectangle(Brushes.LightBlue, x + 270, y - 150, ancho, ancho / 2);
      t.FillRectangle(Brushes.Blue, x + 270, y - 120, ancho, ancho / 2);
      t.DrawRectangle(p1, x + 270, y - 150, ancho, ancho / 2);
      t.DrawRectangle(p1, x + 270, y - 120, ancho, ancho / 2);
      t.DrawString("Seguro", tipo2, Brushes.Black, x + 320, y - 150);
      t.DrawString("No Seguro", tipo2, Brushes.Black, x + 320, y - 120);
      t.DrawRectangle(p1, x + 270, y - 150, ancho, ancho / 2);
      t.DrawRectangle(p1, x + 270, y - 120, ancho, ancho / 2);
      t.DrawString("Seguro", tipo2, Brushes.Black, x + 320, y - 150);
      t.DrawString("No Seguro", tipo2, Brushes.Black, x + 320, y - 120);

      t.FillRectangle(Brushes.LightBlue, x + 50, y - (contS * a),ancho, contS * a);t.DrawRectangle(p1, x + 50, y - (contS * a), ancho, contS * a);t.DrawLine(p1, x, y - (contS * a), x + 50 + ancho, y - (contS *a));t.DrawString("Seguro", tipo2, Brushes.Black, x+50,y+30);t.DrawString("" + contS, tipo2, Brushes.Black, x-20,y-(contS*a)); 
      t.FillRectangle(Brushes.Blue, x + 140, y - (contC * a), ancho,contC * a);t.DrawRectangle(p1, x+140,y-(contC*a),ancho,contC*a);t.DrawLine(p1, x + 50 + ancho, y - (contC * a), x + 140 + ancho,y - (contC * a));t.DrawString("No Seguro", tipo2, Brushes.Black, x + 140, y + 30);t.DrawString("" + contC, tipo2, Brushes.Black, x - 20, y - (contC* a));
    }
    public void graficoPastel(Graphics g, int x, int y)
    {
      int ptot = 0; int s = 0, ns = 0;
      for (int i = 0; i < A.Length; i++)
      {
        if (A[i].get_seguro().Equals("Seguro")) s++;
        if (A[i].get_seguro().Equals("No Seguro")) ns++;
      }
      ptot = A.Length; if (ptot != 0)
      {
        g.DrawRectangle(p1, x + 200, y + 20, 200, 100); 
        g.DrawString("Leyenda:", tipo2, Brushes.Black, x + 210, y + 40);
        g.DrawString("Seguro " + (double)(s * 100 / ptot) + " %", tipo2, Brushes.Black, x + 230, y + 60);
        g.DrawString("No Seguro " + (double)(ns * 100 / ptot) + " %", tipo2, Brushes.Black, x + 230, y + 80);
        g.DrawRectangle(p1, x + 210, y + 60, 10, 10); 
        g.DrawRectangle(p1, x + 210, y + 80, 10, 10);
        g.FillEllipse(Brushes.Blue, x - 3, y - 3, 156, 156);
        g.FillPie(Brushes.LightBlue, x, y, 150, 150, 0, (int)(s * 360 / ptot));
        g.FillRectangle(Brushes.LightBlue, x + 210, y + 60, 10, 10);
        g.FillPie(Brushes.Yellow, x, y, 150, 150, (int)(s * 360 / ptot), (int)(ns * 360 / ptot));
        g.FillRectangle(Brushes.Yellow, x + 210, y + 80, 10, 10);
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      richTextBox1.Clear();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      band = true;
      this.Refresh();
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
      if (band)
      {
        graficoBarras(panel2.CreateGraphics(),A,100,300);
      }
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {
      if (band)
      {
        graficoPastel(panel3.CreateGraphics(), 50,125);
      }
    }
  }
}
