using System;

// 1. Crie uma classe Pessoa com um campo Nome.
public class Pessoa
{
    public string Nome { get; set; }
}

public class Questao2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Questão 2: Cópia de Tipos de Referência (Classe) ---");
        
      
        Pessoa pessoa1 = new Pessoa { Nome = "Alice" };
        Pessoa pessoa2 = pessoa1; 
        
        Console.WriteLine($"Antes da modificação: Pessoa1.Nome = {pessoa1.Nome}, Pessoa2.Nome = {pessoa2.Nome}");

       
        pessoa2.Nome = "Bob"; 

       
        Console.WriteLine($"Após a modificação:");
        Console.WriteLine($"Nome de pessoa1: {pessoa1.Nome}"); 
        Console.WriteLine($"Nome de pessoa2: {pessoa2.Nome}"); 
        

    }
}
