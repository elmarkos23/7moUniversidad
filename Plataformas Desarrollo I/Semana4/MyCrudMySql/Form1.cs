using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCrudMySql
{
  public partial class Form1 : Form
  {
    public Conexion con = new Conexion();
    int Id;
    Boolean editar;
    public Form1()
    {
      InitializeComponent();
    }

    private void textBox4_KeyUp(object sender, KeyEventArgs e)
    {
      con.Actualizar(dataGridView1, "select * from Alumno where Nombre like '" + textBox4.Text + "%'");
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      if (editar)
      {
        con.Conectar();
        string consulta = "update alumno set Nombre='" + textBox1.Text + "',Apellido='" + textBox2.Text + "', Edad=" + textBox3.Text + " where Id=" + Id + "; ";
        con.EjecutarSql(consulta);
        this.ActualizarGrid();
        this.Limpiar();
        editar = false;
      }
      else
      {
        con.Conectar();
        string consulta = "insert into Alumno(Nombre,Apellido,Edad) values ('" + textBox1.Text + "','" + textBox2.Text + "'," + textBox3.Text + "); ";
        con.EjecutarSql(consulta);
        this.ActualizarGrid();
        this.Limpiar();

      }
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      editar = true;
      Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
      textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
      textBox2.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
      textBox3.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      Id = int.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());
      var resultado = MessageBox.Show("desea eliminar el registro", "Confirmación de Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (resultado == DialogResult.Yes)
      {
        con.Conectar();
        con.EjecutarSql("delete from Alumno where Id=" + Id + ";");
        this.ActualizarGrid();
        con.Desconectar();
      }

    }

    public void ActualizarGrid()
    {
      con.Actualizar(dataGridView1, "select * from alumno");
    }
    public void Limpiar()
    {
      textBox1.Text = "";
      textBox2.Text = "";
      textBox3.Text = "";
      textBox4.Text = "";
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      editar = false;
      this.ActualizarGrid();
    }
  }
}
