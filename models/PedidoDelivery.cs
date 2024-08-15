namespace Restaurante_CSharp;

public class PedidoDelivery : Pedido
{
    private const decimal taxaEntrega = 9.50m;

    public override decimal CalcularTotal()
    {
        return Pratos.Sum(prato => prato.ObterPreco()) + taxaEntrega;
    }
}