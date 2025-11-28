using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();
        
        Console.Write("Digite a data e hora do compromisso (dd/MM/yyyy HH:mm): ");
        string dataTexto = Console.ReadLine();
        
        DateTime compromisso = DateTime.ParseExact(dataTexto, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        DateTime hoje = DateTime.Now;
        
        TimeSpan diferenca = compromisso.Date - hoje.Date;
        int diasRestantes = (int)diferenca.TotalDays;
        
        string[] diasSemana = { "domingo", "segunda-feira", "terça-feira", "quarta-feira", "quinta-feira", "sexta-feira", "sábado" };
        string diaSemana = diasSemana[(int)compromisso.DayOfWeek];
        
        string mensagem = string.Format("Olá, {0}! Seu compromisso será em {1} dias, na {2}. Data marcada: {3:dd/MM/yyyy} às {3:HH:mm}", 
            nome, diasRestantes, diaSemana, compromisso);
        
        Console.WriteLine($"\n{mensagem}");
    }
}
