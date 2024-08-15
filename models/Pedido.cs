using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante_CSharp;

public abstract class Pedido
{
    public string NumeroPedido { get; set; }
    public List<Prato> Pratos { get; set; }

    public abstract decimal CalcularTotal();
}