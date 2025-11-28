using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma frase com espaços no início e fim, e palavras separadas por vírgulas: ");
        string frase = Console.ReadLine();
        
        string fraseLimpa = frase.Trim();
        Console.WriteLine($"\nFrase sem espaços extras: '{fraseLimpa}'");
        
        string[] partes = fraseLimpa.Split(',');
        Console.WriteLine($"\nFrase dividida em {partes.Length} partes:");
        for(int i = 0; i < partes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {partes[i].Trim()}");
        }
        
        Console.Write("\nDigite a palavra que deseja substituir: ");
        string palavraAntiga = Console.ReadLine();
        Console.Write("Digite a nova palavra: ");
        string palavraNova = Console.ReadLine();
        string fraseModificada = fraseLimpa.Replace(palavraAntiga, palavraNova);
        Console.WriteLine($"Frase modificada: {fraseModificada}");
        
        Console.Write("\nDigite uma palavra para verificar se a frase começa com ela: ");
        string inicio = Console.ReadLine();
        bool comecaCom = fraseLimpa.StartsWith(inicio);
        Console.WriteLine($"A frase começa com '{inicio}'? {comecaCom}");
        
        Console.Write("\nDigite uma palavra para verificar se a frase termina com ela: ");
        string fim = Console.ReadLine();
        bool terminaCom = fraseLimpa.EndsWith(fim);
        Console.WriteLine($"A frase termina com '{fim}'? {terminaCom}");
    }
}
