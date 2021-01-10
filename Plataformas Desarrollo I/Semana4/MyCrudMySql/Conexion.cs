using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCrudMySql
{
  public class Conexion
  {
    MySqlConnection conn;
    public void Conectar()
    {
      conn = new MySqlConnection("server=127.0.01;user id=root;password=Maal2308;database=uisrael");
      conn.Open();
    }
    public void Desconectar()
    {
      conn.Close();
    }
    public void EjecutarSql(String consulta)
    {
      MySqlCommand con = new MySqlCommand(consulta, conn);
      int filasAfctadas = con.ExecuteNonQuery();
      if (filasAfctadas > 0)
      {
        MessageBox.Show("Operacion realizada correctamente", "La base de datos a sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("No se ha conectado a la base de datos", "Error del sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
    public void Actualizar(DataGridView dg, String consulta)
    {
      this.Conectar();
      System.Data.DataSet ds = new System.Data.DataSet();
      MySqlDataAdapter da = new MySqlDataAdapter(consulta, conn);
      da.Fill(ds, "alumno");
      dg.DataSource = ds;
      dg.DataMember = "alumno";
      this.Desconectar();
    }

  }
}
