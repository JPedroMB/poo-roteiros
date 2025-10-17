saida: 100
o valor foi alterado pq nao cria uma copia do valor, e sim uma referencia, portanto alterar numeros2[0] tambem altera numeros 1[0]
para nao alterar, voce precisa criar uma copia, semelhante ao exercicio 1, ex: 
int a = 10;
int b = a; // Aqui, b recebe uma cópia do valor de a.
b = 20;
