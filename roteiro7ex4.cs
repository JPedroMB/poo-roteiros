using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> fila = new Queue<string>();
        string opcao = "";

        while(opcao != "4")
        {
            Console.WriteLine("\n1. Adicionar cliente");
            Console.WriteLine("2. Atender próximo");
            Console.WriteLine("3. Ver tamanho da fila");
            Console.WriteLine("4. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            if(opcao == "1")
            {
                Console.Write("Nome do cliente: ");
                string nome = Console.ReadLine();
                fila.Enqueue(nome);
                Console.WriteLine("Cliente adicionado à fila!");
            }
            else if(opcao == "2")
            {
                if(fila.Count > 0)
                {
                    string cliente = fila.Dequeue();
                    Console.WriteLine($"Atendendo: {cliente}");
                }
                else
                    Console.WriteLine("Fila vazia!");
            }
            else if(opcao == "3")
            {
                Console.WriteLine($"Clientes na fila: {fila.Count}");
            }
        }
    }
}
