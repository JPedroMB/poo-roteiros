using System;

public interface IVoar
{
    void Voar();
}
public interface INadar
{
    void Nadar();
}
public class Pato : INadar, IVoar
{
    public void Voar()
    {
        Console.WriteLine("O pato voa");
    }
    public void Nadar()
    {
        Console.WriteLine("O pato nada");
    }
}
public class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A Águia voa");
    }
}
public class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("O peixe nada");
    }
    
}
public class Program
{
    public static void Main()
    {
        Pato pato = new Pato();
        Aguia aguia = new Aguia();
        Peixe peixe = new Peixe();
        
        pato.Voar();
        pato.Nadar();
        aguia.Voar();
        peixe.Nadar();

    }
}
