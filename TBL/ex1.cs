using System;

public class Questao1
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Questão 1: Cópia de Tipos de Valor (int) ---");
        
       
        int valorOriginal = 10;
        int copiaValor = valorOriginal; 
        
        Console.WriteLine($"Antes da modificação: valorOriginal = {valorOriginal}, copiaValor = {copiaValor}");

        
        copiaValor = 20;


        Console.WriteLine($"Após a modificação:");
        Console.WriteLine($"Valor Original: {valorOriginal}"); 
        Console.WriteLine($"Cópia do Valor: {copiaValor}");   
        
     
    }
}
