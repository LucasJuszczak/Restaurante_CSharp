namespace Restaurante_CSharp;

public class PedidoPresencial : Pedido
{
    public override decimal CalcularTotal()
    {
        return Pratos.Sum(prato => prato.ObterPreco());
    }
}