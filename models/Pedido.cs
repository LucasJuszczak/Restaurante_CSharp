using System.Collections.Generic;

namespace Restaurante_CSharp;

public abstract class Pedido
{
    public string NumeroPedido { get; set; }
    public List<Prato> Pratos { get; set; }
}