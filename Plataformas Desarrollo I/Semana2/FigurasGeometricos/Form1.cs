using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricos
{
  public partial class Form1 : Form
  {
    Graphics g;
    bool band = false;
    public Form1()
    {
      InitializeComponent();
      g = panel1.CreateGraphics();
      band = true;


      Dibujar(g, 10, 10, 5);
      DibujarRectangulo(g, 20, 40, 200, 240);
      this.Refresh();
    }

    private void Dibujar(Graphics g, int x, int y, int radio)
    {
      Font letra = new Font("Arial", 10);
      Font letra1 = new Font("Calibri", 12);
      g.DrawString("Circulo", letra, Brushes.Black, x, y - 30, new StringFormat());
      g.FillEllipse(new SolidBrush(Color.CadetBlue), x, y, radio, radio * 4);
      g.DrawString("Area" + Math.PI * radio * radio + "m2", letra1, Brushes.Black, x, y + 120, new StringFormat());
      g.DrawString("Perimentro" + 2 * Math.PI * radio + "m2", letra1, Brushes.Black, x, y + 140, new StringFormat());
    }
    private void DibujarCuadrado(Graphics g, int x, int y, int radio)
    {
      Font letra = new Font("Arial", 10);
      Font letra1 = new Font("Calibri", 12);
      g.DrawString("Circulo", letra, Brushes.Black, x, y - 30, new StringFormat());
      g.FillEllipse(new SolidBrush(Color.CadetBlue), x, y, radio, radio * 4);
      g.DrawString("Area" + Math.PI * radio * radio + "m2", letra1, Brushes.Black, x, y + 120, new StringFormat());
      g.DrawString("Perimentro" + 2 * Math.PI * radio + "m2", letra1, Brushes.Black, x, y + 140, new StringFormat());
    }
    private void DibujarRectangulo(Graphics g, int x, int y, int bases, int altura)
    {
      Font letra = new Font("Arial", 10);
      Font letra1 = new Font("Calibri", 12);
      g.DrawString("Rectangulo", letra, Brushes.Black, x, y - 30, new StringFormat());
      g.FillRectangle(new SolidBrush(Color.SkyBlue), x, y, bases * 4, altura * 4);
      g.DrawString("Area" + Math.PI * bases * altura + "m2", letra1, Brushes.Black, x, y + 120, new StringFormat());
      g.DrawString("Perimentro" + 2 * 2 * bases + 2 * altura + "m2", letra1, Brushes.Black, x, y + 140, new StringFormat());
    }
  }
}
