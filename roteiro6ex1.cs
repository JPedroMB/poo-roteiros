using System;

class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException(string mensagem) : base(mensagem) { }
}

class Program
{
    static void Main()
    {
        Exercicio1();
        Console.WriteLine("\n---\n");
        Exercicio2();
        Console.WriteLine("\n---\n");
        Exercicio3();
        Console.WriteLine("\n---\n");
        Exercicio4();
    }

    static void Exercicio1()
    {
        try
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(nome))
            {
                throw new Exception("O nome do produto não pode estar em branco.");
            }

            Console.Write("Digite o preço do produto: ");
            double preco = double.Parse(Console.ReadLine());

            if(preco <= 0)
            {
                throw new Exception("O preço do produto deve ser maior que zero.");
            }

            Console.WriteLine($"\nProduto cadastrado: {nome} - R$ {preco:F2}");
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void Exercicio2()
    {
        float temperatura = 0;
        bool valido = false;

        while(!valido)
        {
            try
            {
                Console.Write("Digite a temperatura em Celsius: ");
                string entrada = Console.ReadLine();
                temperatura = float.Parse(entrada);
                valido = true;
            }
            catch(FormatException)
            {
                Console.WriteLine("Formato inválido. Digite um número válido.");
            }
        }

        Console.WriteLine($"Temperatura registrada: {temperatura}°C");
    }

    static void Exercicio3()
    {
        try
        {
            Console.Write("Digite um número inteiro: ");
            string entrada = Console.ReadLine();
            int numero = int.Parse(entrada);
            Console.WriteLine($"Número digitado: {numero}");
        }
        catch
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
        }
    }

    static void Exercicio4()
    {
        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine());

        try
        {
            VerificarIdade(idade);
        }
        catch(IdadeInvalidaException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }

    static void VerificarIdade(int idade)
    {
        if(idade < 18)
        {
            throw new IdadeInvalidaException("Idade mínima para acesso é 18 anos.");
        }
        Console.WriteLine("Acesso permitido.");
    }
}
