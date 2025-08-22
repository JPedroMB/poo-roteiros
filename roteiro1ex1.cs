using System;

public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos, sou {Cargo}.");
    }

    public void InformarSalario()
    {
        if (Cargo.ToLower() == "gerente")
        {
            Console.WriteLine("Salário: R$ 10.000,00");
        }
        else if (Cargo.ToLower() == "desenvolvedor")
        {
            Console.WriteLine("Salário: R$ 5.000,00");
        }
        else if (Cargo.ToLower() == "estagiário" || Cargo.ToLower() == "estagiario")
        {
            Console.WriteLine("Salário: R$ 100,00");
        }
        else
        {
            Console.WriteLine("Salário: R$ 0,00");
        }
    }
}

public class Program
{
    static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Nome = "João";
        p1.Idade = 30;
        p1.Cargo = "Programador"; 
        p1.Apresentar();
        p1.InformarSalario();

        Pessoa p2 = new Pessoa();
        p2.Nome = "Jorge";
        p2.Idade = 40;
        p2.Cargo = "Gerente";
        p2.Apresentar();
        p2.InformarSalario();

        Pessoa p3 = new Pessoa();
        p3.Nome = "Marcos";
        p3.Idade = 22;
        p3.Cargo = "Desenvolvedor";
        p3.Apresentar();
        p3.InformarSalario();

        Pessoa p4 = new Pessoa();
        p4.Nome = "José";
        p4.Idade = 18;
        p4.Cargo = "Estagiário";
        p4.Apresentar();
        p4.InformarSalario();
    }
}
