using System.Collections.Generic;

namespace Restaurante_CSharp;

public class Restaurante : Estabelecimento
{
    public List<Prato> Cardapio { get; private set; } = new List<Prato>();

    public void AdicionarPrato(Prato prato)
    {
        Cardapio.Add(prato);
    }

    public void RemoverPrato(Prato prato)
    {
        Cardapio.Remove(prato);
    }
}