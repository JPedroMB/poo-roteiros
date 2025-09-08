using System;

public class Produto
{
    private string nome;
    private decimal preco;
    public Produto(string nome, decimal preco)
    {
        this.nome = nome;
        this.preco = preco;
    }
    public string Nome
    {
        get { return nome; }
    }
    public decimal Preco
    {
        get { return preco; }
        private set
        {
            if (preco >= 0)
            {
                preco = value;
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
        }
    }
    public void ExibirDetalhes()
    {
        Console.WriteLine($"O produto é {nome} e o valor é R${preco}");
    }
}
class Program 
{
    public static void Main() 
    {
        Produto p = new Produto("PC", 3000);
        p.ExibirDetalhes();

    }
}

