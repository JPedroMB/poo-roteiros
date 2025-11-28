using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        HashSet<int> numeros = new HashSet<int>();
        int numero = -1;

        Console.WriteLine("Digite números inteiros (0 para parar):");
        
        while(numero != 0)
        {
            Console.Write("Número: ");
            numero = int.Parse(Console.ReadLine());
            
            if(numero != 0)
                numeros.Add(numero);
        }

        Console.WriteLine("\nNúmeros únicos digitados:");
        foreach(int n in numeros)
        {
            Console.WriteLine(n);
        }
    }
}
