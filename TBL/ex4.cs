using System;

public class Questao4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- Questão 4: Conversão Segura com TryParse ---");

        Console.Write("Digite um número: ");
        string entradaUsuario = Console.ReadLine();

        if (int.TryParse(entradaUsuario, out int numeroConvertido))
        {
           
            Console.WriteLine($"Sucesso! Número convertido: {numeroConvertido}");
        }
        else
        {

            Console.WriteLine("Entrada inválida. Digite um número válido.");
        }
    }
}
