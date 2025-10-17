using System;

public class Questao5
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Questão 5: Comparação de Strings ---");
        
        string s1 = "Olá";
        string s2 = "Olá";
        string s3 = new string("Olá");

        Console.WriteLine($"s1: \"{s1}\", s2: \"{s2}\", s3: \"{s3}\"");
        

        Console.WriteLine($"s1 == s2 (Valor): {s1 == s2}");
        Console.WriteLine($"s1 == s3 (Valor): {s1 == s3}");
       
        Console.WriteLine($"object.ReferenceEquals(s1, s2): {object.ReferenceEquals(s1, s2)}");
        Console.WriteLine($"object.ReferenceEquals(s1, s3): {object.ReferenceEquals(s1, s3)}");

        Console.WriteLine("\nExplicação:");
        Console.WriteLine("s1 == s2 e s1 == s3 são TRUE porque comparam o CONTEÚDO ('Olá').");
        Console.WriteLine($"object.ReferenceEquals(s1, s3) é FALSE porque 'new string(\"Olá\")' garante que s3 é um objeto diferente na memória.");
    }
}
