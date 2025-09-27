using System;
using System.Collections.Generic;

public abstract class Funcionario(string nome, double salarioBase)
{
    public string Nome { get; set; } = nome;
    public double SalarioBase { get; set; } = salarioBase;

    public abstract double CalcularSalario();
}

public class Gerente(string nome, double salarioBase, double bonusAnual) 
    : Funcionario(nome, salarioBase)
{
    public double BonusAnual { get; set; } = bonusAnual;

    public override double CalcularSalario() => SalarioBase + BonusAnual;
}

public class Programador(string nome, double salarioBase, int horasExtras) 
    : Funcionario(nome, salarioBase)
{
    public int HorasExtras { get; set; } = horasExtras;
    private const double ValorHoraExtra = 50.0;

    public override double CalcularSalario() => SalarioBase + (HorasExtras * ValorHoraExtra);
}

class Program
{
    public static void Main()
    {
        List<Funcionario> equipe = new()
        {
            new Gerente("Ana Souza", 5000.00, 1500.00),
            new Programador("João Silva", 3000.00, 10),
            new Gerente("Carlos Lima", 6500.00, 2000.00)
        };

        Console.WriteLine("--- Processamento de Salários ---");

        foreach (var func in equipe)
        {
            double salarioTotal = func.CalcularSalario();
            
            Console.WriteLine($"\nFuncionário: {func.Nome} ({func.GetType().Name})");
            Console.WriteLine($"Salário Total: {salarioTotal:C}");
        }
    }
}
