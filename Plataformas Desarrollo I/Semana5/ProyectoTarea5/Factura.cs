using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTarea5
{
  public class Factura
  {
    private Cliente cliente;
    private Vendedor vendedor;
    private Computador computador;

    public Factura(Cliente cliente, Vendedor vendedor, Computador computador)
    {
      this.cliente = cliente;
      this.vendedor = vendedor;
      this.computador = computador;
    }

    public Cliente Cliente { get => cliente; set => cliente = value; }
    public Vendedor Vendedor { get => vendedor; set => vendedor = value; }
    public Computador Computador { get => computador; set => computador = value; }
  }
}
