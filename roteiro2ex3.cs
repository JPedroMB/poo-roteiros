using System;
public class Elevador
{
    private int andarAtual = 0;
    private int totalAndares;
    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
    }

    public int AndarAtual
    {
        get { return andarAtual; }
        private set
        {
            if (andarAtual < 0 && andarAtual > totalAndares)
            {
                Console.WriteLine("Andar inválido");
            }
            else
            {
                value = andarAtual;
            }
        }
    }
    public void Subir()
    {
        this.andarAtual++;
    }
    public void Descer()
    {
        if (andarAtual < 1 || andarAtual > totalAndares)
        {
            this.andarAtual = 0;
        }
        else
        {
            this.andarAtual--;
        }
    }

}
class Program
{
    public static void Main()
    {
        Elevador e = new Elevador(10);
        e.Subir();
        e.Subir();
        Console.WriteLine(e.AndarAtual); 
        e.Descer();
        Console.WriteLine(e.AndarAtual);
        e.Descer();
        e.Descer();
    }
}
