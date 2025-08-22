using System;
public class Fantasminhas{
    public string habilidade;
    public string nick;
    public string cor;
    
    public void GerarFanstasma(){
        Console.WriteLine($"{habilidade},{nick},{cor}");
    }
    public void Mover(string direcao){
        Console.WriteLine($"Fantasminha {nick} se moveu para {direcao}");
    }
    
}
public class Program{
    static void Main()
    {
        Fantasminhas f1 = new Fantasminhas();
        f1.nick = "Gerson";
        f1.habilidade = "Dançar";
        f1.cor = "roxo";
        f1.GerarFanstasma();
        f1.Mover("Esquerda");
    }
}
