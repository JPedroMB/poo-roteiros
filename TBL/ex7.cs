7.
tipos de valor armazenam os dados diretamente na stack, ao atribuir uma variável a outra, é feita uma copia e alteraçoes nao afetam uma a outra.
Exemplo:
int a = 10;
int b = a;
b = 20;
Console.WriteLine(a); // 10
Tipos de referência armazenam um endereço na stack que aponta para o objeto na heap ao atribuir uma variável a outra ambas apontam para o mesmo objeto, e alteraçoes afetam o objeto compartilhado, exemplo:
class Pessoa { public string Nome; }
Pessoa p1 = new Pessoa() { Nome = "joao" };
Pessoa p2 = p1;
p2.Nome = "andre";
Console.WriteLine(p1.Nome); // joao
