using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma palavra: ");
        string palavra = Console.ReadLine();
        
        Stack<char> pilha = new Stack<char>();
        
        for(int i = 0; i < palavra.Length; i++)
        {
            pilha.Push(palavra[i]);
        }
        
        string invertida = "";
        
        while(pilha.Count > 0)
        {
            invertida += pilha.Pop();
        }
        
        Console.WriteLine($"Palavra invertida: {invertida}");
    }
}
