using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> produtos = new Dictionary<int, string>();
        string opcao = "";

        while(opcao != "4")
        {
            Console.WriteLine("\n1. Adicionar produto");
            Console.WriteLine("2. Buscar produto");
            Console.WriteLine("3. Listar produtos");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            if(opcao == "1")
            {
                Console.Write("Digite o código: ");
                int codigo = int.Parse(Console.ReadLine());
                
                if(produtos.ContainsKey(codigo))
                {
                    Console.WriteLine("Código já existe!");
                }
                else
                {
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    produtos.Add(codigo, nome);
                    Console.WriteLine("Produto adicionado!");
                }
            }
            else if(opcao == "2")
            {
                Console.Write("Digite o código: ");
                int codigo = int.Parse(Console.ReadLine());
                
                if(produtos.ContainsKey(codigo))
                    Console.WriteLine($"Produto: {produtos[codigo]}");
                else
                    Console.WriteLine("Produto não encontrado.");
            }
            else if(opcao == "3")
            {
                Console.WriteLine("\nProdutos cadastrados:");
                foreach(var item in produtos)
                {
                    Console.WriteLine($"Código: {item.Key} - Nome: {item.Value}");
                }
            }
        }
    }
}
