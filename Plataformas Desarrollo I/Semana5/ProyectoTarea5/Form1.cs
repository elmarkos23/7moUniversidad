using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTarea5
{
  public partial class Form1 : Form
  {
    Factura[] A = new Factura[5];
    int i = 0;
    Pen f = new Pen(Color.Red);
    Pen f1 = new Pen(Color.Blue);
    Pen f2 = new Pen(Color.Beige);
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

    private void button1_Click(object sender, EventArgs e)
    {
      A[0] = new Factura(new Cliente("Marco", "Ayala", 1020, 100),
        new Vendedor("Carlos", "Narvaez", "EMP001", 20000),
        new Computador("HP", "NETBOOK", "440", 1100));
      A[1] = new Factura(new Cliente("Eduardo", "Proaño", 1020, 100),
        new Vendedor("Carlos", "Narvaez", "EMP001", 20000),
        new Computador("HP", "NETBOOK", "455", 1250));
      A[2] = new Factura(new Cliente("Fernando", "Castillo", 1020, 100),
        new Vendedor("Carlos", "Narvaez", "EMP001", 20000),
        new Computador("DELL", "NETBOOK", "120", 900));
      A[3] = new Factura(new Cliente("Fernando", "Castillo", 1020, 100),
        new Vendedor("Carlos", "Narvaez", "EMP001", 20000),
        new Computador("DELL", "NETBOOK", "120", 910));
      A[4] = new Factura(new Cliente("Fernando", "Castillo", 1020, 100),
        new Vendedor("Carlos", "Narvaez", "EMP001", 20000),
        new Computador("DELL", "NETBOOK", "120", 1800));

      richTextBox1.AppendText("Datos Factura");
      richTextBox1.AppendText("\n-----------------------");
      for (i = 0; i < A.Length; i++)
      {
        richTextBox1.AppendText("\n" + "Cliente:" + A[i].Cliente.getNombre() + " " + A[i].Cliente.getApellido() + " - " +
                                       "Vendedor:" + A[i].Vendedor.getNombre() + " - " +
                                       "Computador:" + A[i].Computador.getNombre() + " Precio:" + A[i].Computador.getPrecio());
        richTextBox1.AppendText("\n");
      }
    }

    private void panel2_Paint(object sender, PaintEventArgs e)
    {
      if (band)
      {
        graficoBarras(panel2.CreateGraphics(), A, 100, 300);
      }
    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {
      if (band)
      {
        graficoPastel(panel3.CreateGraphics(), 50, 125);
      }
    }
    public void graficoBarras(Graphics t, Factura[] A, int x, int y)
    {
      int contS = 0, contC = 0, a = 20, ancho = 40;
      for (int i = 0; i < A.Length; i++)
      {
        if (A[i].Computador.getPrecio() > 1000) contS++;
        if (A[i].Computador.getPrecio() < 1000) contC++;
      }
      t.DrawLine(f1, x, y, x + 300, y); t.DrawLine(f1, x, y, x, y - 250);
      t.DrawString("Tipo", tipo2, Brushes.Black, x + 300, y);
      t.DrawString("# Ventas", tipo2, Brushes.Black, x - 100, y - 250);
      t.DrawRectangle(f1, x + 250, y - 190, 160, 100); t.DrawString("Leyenda", tipo2, Brushes.Black, x + 270, y - 170);
      t.FillRectangle(Brushes.SkyBlue, x + 270, y - 150, ancho, ancho / 2);
      t.FillRectangle(Brushes.Purple, x + 270, y - 120, ancho, ancho / 2);
      t.DrawRectangle(f1, x + 270, y - 150, ancho, ancho / 2);
      t.DrawRectangle(f1, x + 270, y - 120, ancho, ancho / 2);
      t.DrawString("Mayor a 1000", tipo2, Brushes.Black, x + 320, y - 150);
      t.DrawString("Menor a 1000", tipo2, Brushes.Black, x + 320, y - 120);
      t.DrawRectangle(f1, x + 270, y - 150, ancho, ancho / 2);
      t.DrawRectangle(f1, x + 270, y - 120, ancho, ancho / 2);
      t.DrawString("Mayor a 1000", tipo2, Brushes.Black, x + 320, y - 150);
      t.DrawString("Menor a 1000", tipo2, Brushes.Black, x + 320, y - 120);

      t.FillRectangle(Brushes.SkyBlue, x + 50, y - (contS * a), ancho, contS * a); 
      t.DrawRectangle(f1, x + 50, y - (contS * a), ancho, contS * a); 
      t.DrawLine(f1, x, y - (contS * a), x + 50 + ancho, y - (contS * a));
      
      t.DrawString("Mayor a 1000", tipo2, Brushes.Black, x + 50, y + 30); 
      t.DrawString("" + contS, tipo2, Brushes.Black, x - 20, y - (contS * a));
      t.FillRectangle(Brushes.Purple, x + 140, y - (contC * a), ancho, contC * a); 
      t.DrawRectangle(f1, x + 140, y - (contC * a), ancho, contC * a); 
      t.DrawLine(f1, x + 50 + ancho, y - (contC * a), x + 140 + ancho, y - (contC * a));
      t.DrawString("Menor a 1000", tipo2, Brushes.Black, x + 140, y + 30); 
      t.DrawString("" + contC, tipo2, Brushes.Black, x - 20, y - (contC * a));
    }
    public void graficoPastel(Graphics g, int x, int y)
    {
      int ptot = 0; int s = 0, ns = 0;
      for (int i = 0; i < A.Length; i++)
      {
        if (A[i].Computador.getPrecio() > 1000) s++;
        if (A[i].Computador.getPrecio() < 1000) ns++;
      }
      ptot = A.Length; if (ptot != 0)
      {
        g.DrawRectangle(f1, x + 200, y + 20, 200, 100);
        g.DrawString("Leyenda:", tipo2, Brushes.Black, x + 210, y + 40);
        g.DrawString("Mayor a 1000 " + (double)(s * 100 / ptot) + " %", tipo2, Brushes.Black, x + 230, y + 60);
        g.DrawString("Menor a 1000 " + (double)(ns * 100 / ptot) + " %", tipo2, Brushes.Black, x + 230, y + 80);
        g.DrawRectangle(f1, x + 210, y + 60, 10, 10);
        g.DrawRectangle(f1, x + 210, y + 80, 10, 10);
        g.FillEllipse(Brushes.Blue, x - 3, y - 3, 156, 156);
        
        g.FillPie(Brushes.SkyBlue, x, y, 150, 150, 0, (int)(s * 360 / ptot));
        g.FillRectangle(Brushes.SkyBlue, x + 210, y + 60, 10, 10);
        g.FillPie(Brushes.Purple, x, y, 150, 150, (int)(s * 360 / ptot), (int)(ns * 360 / ptot));
        g.FillRectangle(Brushes.Purple, x + 210, y + 80, 10, 10);
      }
    }

    private void button3_Click(object sender, EventArgs e)
    {
      band = true;
      this.Refresh();
    }
  }
}
