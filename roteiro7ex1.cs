using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> listaCompras = new List<string>();
        string opcao = "";

        while(opcao != "4")
        {
            Console.WriteLine("\n1. Adicionar item");
            Console.WriteLine("2. Remover item");
            Console.WriteLine("3. Listar itens");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            if(opcao == "1")
            {
                Console.Write("Digite o item: ");
                string item = Console.ReadLine();
                listaCompras.Add(item);
                Console.WriteLine("Item adicionado!");
            }
            else if(opcao == "2")
            {
                Console.Write("Digite o item a remover: ");
                string item = Console.ReadLine();
                if(listaCompras.Remove(item))
                    Console.WriteLine("Item removido!");
                else
                    Console.WriteLine("Item não encontrado.");
            }
            else if(opcao == "3")
            {
                Console.WriteLine($"\nTotal de itens: {listaCompras.Count}");
                for(int i = 0; i < listaCompras.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {listaCompras[i]}");
                }
            }
        }
    }
}
