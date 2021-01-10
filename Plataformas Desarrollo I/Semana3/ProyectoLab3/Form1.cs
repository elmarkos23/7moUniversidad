using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoLab3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Persona p = new Persona(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Text);
      richTextBox1.AppendText("\n" + p.getNombre() + " " + p.getApellido() + " " + p.getProfesion() + " " + p.getFecha());
    }
  }
}
