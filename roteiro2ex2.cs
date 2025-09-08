using System;
public class Carro
{
    private string modelo;
    private int velocidadeAtual;
    public Carro(string modelo, int velocidadeAtual)
    {
        this.modelo = modelo;
        this.velocidadeAtual = velocidadeAtual;
    }
    public string Modelo
    {
        get { return modelo; }
    }
    public int VelocidadeAtual
    {
        get { return velocidadeAtual; }
        private set
        {
            if (velocidadeAtual >= 0)
            {
                velocidadeAtual = value;
            }
            else
            {
                Console.WriteLine("Velocidade inválida");
            }
        }
    }
    public void Acelerar(int velocidade)
    {
       this.velocidadeAtual += velocidade;
    }
    public void Frear(int velocidade)
    {
       if(velocidade > this.velocidadeAtual)
        {
            this.velocidadeAtual = 0;
        }
        else
        {
            this.velocidadeAtual -= velocidade;
        }
    }

}
class Program
{
    public static void Main()
    {
     Carro carro1 = new Carro("BMW", 20);
        Console.WriteLine($"Modelo do carro é {carro1.Modelo} e a velocidade é {carro1.VelocidadeAtual}");
        carro1.Acelerar(30);
        Console.WriteLine($"Modelo do carro é {carro1.Modelo} e a velocidade é {carro1.VelocidadeAtual}");
        carro1.Frear(60);
        Console.WriteLine($"Modelo do carro é {carro1.Modelo} e a velocidade é {carro1.VelocidadeAtual}");
    }

}
