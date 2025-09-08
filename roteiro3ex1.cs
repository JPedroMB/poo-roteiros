using System;

public class Animal
{
    public string nome;

    public void EmitirSom()
    {
        Console.WriteLine("Som genérico do animal");
    }
}
public class Cachorro : Animal
{
    static void Main() 
    { 
    Cachorro cachorro1 = new Cachorro();
    cachorro1.nome = "Luiz";
    cachorro1.EmitirSom();
    }

}
