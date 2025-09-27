using System;

class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento processado");
    }
}
class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento feito no Cartão de Crédito");
    }
}
class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento feito no Boleto Bancário");
    }
}
class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento feito no Pix");
    }
}
class Programa
{
    public static void Main()
    {
        List<Pagamento> listaDePagamentos = new List<Pagamento>();
        listaDePagamentos.Add(new CartaoCredito());
        listaDePagamentos.Add(new BoletoBancario());
        listaDePagamentos.Add(new Pix());

        foreach (Pagamento pagamentoAtual in listaDePagamentos)
        {
            pagamentoAtual.ProcessarPagamento();
        }
    }
}
