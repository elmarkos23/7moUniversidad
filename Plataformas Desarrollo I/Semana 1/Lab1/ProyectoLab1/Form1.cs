using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLab1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnPares_Click(object sender, EventArgs e)
    {
      rtPares.Clear();
      for (int i = 0; i <= 20; i++)
        rtPares.AppendText("\n" + i * 2);
    }

    private void btnImpares_Click(object sender, EventArgs e)
    {
      rtImpares.Clear();
      for (int i = 0; i <= 20; i++)
        rtImpares.AppendText("\n" + (2 * i + 1));
    }

    private void btnFibonaci_Click(object sender, EventArgs e)
    {
      rtFibonaci.Clear();
      int f = 0; int t1 = 1;
      int t2;
      for (int i = 1; i <= 20; i++)
      {
        t2 = f;
        f = t1 + f;
        t1 = t2;
        rtFibonaci.AppendText("\n" + t1);
      }
    }

    private void btnPrimos_Click(object sender, EventArgs e)
    {
      rtPrimos.Clear();
      int contador = 0, num = 1, auxiliar = 0;
      do
      {
        for (int i = 1; i <= num; i++)
          if (num % i == 0) contador = contador + 1;
        if (contador <= 2)
        {
          rtPrimos.AppendText("\n" + num); auxiliar++;
        }
        num++;
        contador = 0;
      }
      while (auxiliar <= 20);
    }
  }
}
