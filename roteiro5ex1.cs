using System;

class Program
{
    static void Main()
    {
        double[] numeros = new double[5];
        
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"Digite o {i + 1}º número decimal: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }
        
        Console.WriteLine();
        
        for(int i = 0; i < 5; i++)
        {
            Console.WriteLine($"\nNúmero {i + 1}: {numeros[i]}");
            Console.WriteLine($"Arredondamento padrão: {Math.Round(numeros[i])}");
            Console.WriteLine($"Arredondamento para baixo: {Math.Floor(numeros[i])}");
            Console.WriteLine($"Arredondamento para cima: {Math.Ceiling(numeros[i])}");
            Console.WriteLine($"Truncamento: {Math.Truncate(numeros[i])}");
        }
    }
}
