using System;

public class Questao3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Questão 3: Conversão Explícita (Casting) ---");
        

        double valorDouble = 123.789;

        Console.WriteLine($"Valor double original: {valorDouble}");


        int valorInt = (int)valorDouble;


        Console.WriteLine($"Valor int (após cast): {valorInt}");
        

    }
}
