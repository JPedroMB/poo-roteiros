8.
obj esta tratando 123 como se fosse string, e esta dando erro pois estao tentando converter pra int de forma incompativel, para corrigir deve covnerter a string para int usando: int.Parse()

object obj = "123";
int x = int.Parse((string)obj);
Console.WriteLine(x);
