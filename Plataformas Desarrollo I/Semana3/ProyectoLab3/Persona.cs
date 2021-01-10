namespace ProyectoLab3
{
  public class Persona
  {
    /*atributos*/
    public string nombres;
    public string apellidos;
    public string profesion;
    public string fecha;
    /*constructor*/
    public Persona(string nombres, string apellidos, string profesion, string fecha)
    {
      this.nombres = nombres;
      this.apellidos = apellidos;
      this.profesion = profesion;
      this.fecha = fecha;
    }
    /*metodos get*/
    public string getNombre()
    {
      return this.nombres;
    }
    public string getApellido()
    {
      return this.apellidos;
    }
    public string getProfesion()
    {
      return this.profesion;
    }
    public string getFecha()
    {
      return this.fecha;
    }
  }
}
