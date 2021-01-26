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
    public Form1()
    {
      InitializeComponent();
    }
    double[] valores = new double[20000];
    double[] valores1 = new double[20000];

    private void button2_Click(object sender, EventArgs e)
    {
      Graphics dibujo = pictureBox1.CreateGraphics();//parte grafica del picture 
      Pen lapiz = new Pen(Color.Black);
      Pen lapiz1 = new Pen(Color.Olive, 3);
      Pen lapiz2 = new Pen(Color.Aqua, 3);
      int xcentro = pictureBox1.Width / 2;
      int ycentro = pictureBox1.Height / 2;
      int cortes = 30;//numero de cortes en el eje x

      double n1 = 1.50;//cambio de valores de n1 
      double n2 = 1.01;//cambio de valores de n2 
      dibujo.TranslateTransform(xcentro, ycentro);//trasladamos lascoordenadas al centro 
      dibujo.ScaleTransform(1, -1);//Convertimos a coordenadas normales 
      //dibujamos ejes x-y 
      dibujo.DrawLine(lapiz, xcentro * -1, 0, xcentro * 2, 0);//ejex 
      dibujo.DrawLine(lapiz, 0, ycentro, 0, ycentro * -1);//ejey 
      //dibujamos puntos +x 
      int a;
      for (a = 0; a <= xcentro * 2; a += (pictureBox1.Width / cortes * 2))
      {
        dibujo.DrawLine(lapiz, a, 5, a, -5);
      }
      // dibujamos puntos -x 
      for (a = 0; a <= xcentro * -1; a += (-1 * pictureBox1.Width / cortes * 2))
      {
        dibujo.DrawLine(lapiz, a, 5, a, -5);
      }
      double xx, puntoX1, puntoY1, puntoX2, puntoY2;
      int con = 0;
      //dibujamos la gráfica 1 
      if (radioButton1.Checked == true)
      {
        for (xx = (pictureBox1.Width / 2) * -1; xx <= (pictureBox1.Width / 2) * 2; xx += 0.1)
        {
          //Escribimos la función a gráficar 
          valores[con] = System.Math.Abs((n1 * System.Math.Cos(xx) - System.Math.Sqrt(n2 * n2 - n1 * n1 * 
            System.Math.Sin(xx) * System.Math.Sin(xx))) / (n1 * System.Math.Cos(xx) + 
            System.Math.Sqrt(n2 * n2 - n1 * n1 * System.Math.Sin(xx) * System.Math.Sin(xx))));
          if (valores[con].ToString().Contains("N") == true)//en casode que existan números imaginarios 
            valores[con] = 1.0; con = con + 1;
        }

        con = 1;
        for (xx = (xcentro * -1) + 0.1; xx <= xcentro * 2; xx += 0.1)
        {
          //iniciamos una cordenada X adelante 
          //sacamos coordenadas 1 
          puntoX1 = (xx - 0.1) * (pictureBox1.Width / (cortes) * 2);
          puntoY1 = valores[con - 1] * ycentro;
          puntoY2 = valores[con] * ycentro;
          //sacamos coordenadas 2 
          puntoX2 = xx * (pictureBox1.Width / (cortes) * 2);
          dibujo.DrawLine(lapiz1, Convert.ToSingle(puntoX1), Convert.ToSingle(puntoY1), Convert.ToSingle(puntoX2), Convert.ToSingle(puntoY2));
          con = con + 1;
        }
      }
      if (radioButton2.Checked == true)
      {
        //grafica 2 
        con = 0;
        for (double xx1 = (pictureBox1.Width / 2) * -1; xx1 <= (pictureBox1.Width / 2) * 2; xx1 += 0.1)
        {
          //Escribimos la función a gráficar 
          valores1[con] = Math.Cos(xx1);
          if (valores1[con].ToString().Contains("N") == true)
          {
            valores1[con] = 1.0;
          }
          con = con + 1;
        }
        con = 1;
        for (double xx1 = (pictureBox1.Width / 2) * -1; xx1 <= (pictureBox1.Width / 2) * 2; xx1 += 0.1)
        {
          //iniciamos una cordenada X adelante 
          //sacamos coordenadas 1 
          puntoX1 = (xx1 - 0.1) * (pictureBox1.Width / (cortes) * 2);
          puntoY1 = valores1[con - 1] * ycentro;
          //sacamos coordenadas 2 
          puntoX2 = xx1 * (pictureBox1.Width / (cortes) * 2);
          puntoY2 = valores1[con] * ycentro;
          dibujo.DrawLine(lapiz2, Convert.ToSingle(puntoX1), Convert.ToSingle(puntoY1), Convert.ToSingle(puntoX2), Convert.ToSingle(puntoY2));
          con = con + 1;
        }
      }

    }
    public void EncerarPctGraf()
    {
      Graphics Lienzo = pictureBox1.CreateGraphics(); Lienzo.Clear(pictureBox1.BackColor);//Se borra el gráfico 
      Lienzo.Dispose();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      EncerarPctGraf();
    }

    private void button4_Click(object sender, EventArgs e)
    {
      this.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Form2 m = new Form2(); for (int c = 0; c < 90; c++)//visualizacion de los primero valores 
      {
        m.richTextBox1.AppendText("\n" + c);
        m.richTextBox2.AppendText("\n" + Math.Round(valores[c], 5));
        m.richTextBox3.AppendText("\n" + Math.Round(valores1[c], 5));
      }
      m.Show();
    }
  }
}
