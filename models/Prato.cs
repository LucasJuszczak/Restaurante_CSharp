namespace Restaurante_CSharp;

public class Prato
{
    public string Nome { get; set; }
    public decimal Preco { get; private set; }
    public bool Vegetariano { get; set; }

    public Prato(string nome, decimal preco, bool vegetariano)
    {
        Nome = nome;
        AtualizarPreco(preco);
        Vegetariano = vegetariano;
    }

    public void AtualizarPreco(decimal novoPreco)
    {
        if (novoPreco > 0)
        {
            preco = novoPreco;
        }
        else
        {
            throw new ArgumentException("Preço inválido. O preço tem que obrigatoriamente ser positivo.");
        }
    }

    public decimal ObterPreco()
    {
        return preco;
    }
}