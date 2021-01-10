using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
  public partial class Form1 : Form
  {
    #region Variables Globales
    Graphics g;
    bool band = false;
    #endregion
    public Form1()
    {
      InitializeComponent();
      g = panel1.CreateGraphics();
    }
    private void button1_Click(object sender, EventArgs e)
    {
      band = true;
      this.Refresh();
    }

    public void dibujarcirculo(Graphics g, int x, int y, int radio)
    {
      Font letra = new Font("Arial", 10); Font letra1 = new Font("Calibri", 12);
      g.DrawString("Círculo", letra1, Brushes.Black, x, y - 30, new StringFormat());
      g.FillEllipse(new SolidBrush(Color.CadetBlue), x, y, radio * 4, radio * 4);
      g.DrawString("Área: " + radio * radio * Math.PI + "m²", letra, Brushes.Black, x, y + 120, new StringFormat());
      g.DrawString("Perímetro: " + 2 * Math.PI * radio + "m", letra, Brushes.Black, x, y + 140, new StringFormat());
    }
    public void dibujarelipse(Graphics g, int x, int y, int radio1, int radio2)
    {
      Font letra = new Font("Arial", 10); Font letra1 = new Font("Calibri", 12);
      g.DrawString("Elipse", letra1, Brushes.Black, x, y - 30, new StringFormat());
      g.FillEllipse(new SolidBrush(Color.Brown), x, y, radio1 * 4, radio2 * 4);
      g.DrawString("Área: " + radio1 * radio2 * Math.PI + "m²", letra, Brushes.Black, x, y + 120, new StringFormat());
      g.DrawString("Perímetro: " + 2 * Math.PI * Math.Pow((Math.Pow(radio1, 2) + Math.Pow(radio2, 2)) / 2, 0.5) + "m", letra, Brushes.Black, x, y + 140, new StringFormat());
    }
    public void dibujarcuadrado(Graphics g, int x, int y, int lado)
    {
      Font letra = new Font("Arial", 10);
      Font letra1 = new Font("Calibri", 12);
      g.DrawString("Cuadrado", letra1, Brushes.Black, x, y - 30, new StringFormat());
      g.FillRectangle(new SolidBrush(Color.Red), x, y, lado * 4, lado * 4);
      g.DrawString("Área: " + lado * lado + "m²", letra, Brushes.Black, x, y + 120, new StringFormat());
      g.DrawString("Perímetro: " + lado * 4 + "m", letra, Brushes.Black, x, y + 140, new StringFormat());
    }
    public void dibujarrectagulo(Graphics g, int x, int y, int a, int b)
    {
      Font letra = new Font("Arial", 10); Font letra1 = new Font("Calibri", 12);
      g.DrawString("Rectángulo", letra1, Brushes.Black, x, y - 30, new StringFormat());
      g.FillRectangle(new SolidBrush(Color.Yellow), x, y, a * 4, b * 4);
      g.DrawString("Área: " + b * a + "m²", letra, Brushes.Black, x, y + 120, new StringFormat());
      g.DrawString("Perímetro: " + 2 * b + 2 * a + "m", letra, Brushes.Black, x, y + 140, new StringFormat());
    }
    private void panel1_Paint(object sender, PaintEventArgs e)
    {
      if (band)
      {
        int x = 20, y = 40;
        dibujarcirculo(g, x + 240, y, 25);
        dibujarelipse(g, x, y, 50, 25);
        dibujarcuadrado(g, x + 480, y, 25);
        dibujarrectagulo(g, x, y + 240, 50, 25);
      }
    }
  }
}
