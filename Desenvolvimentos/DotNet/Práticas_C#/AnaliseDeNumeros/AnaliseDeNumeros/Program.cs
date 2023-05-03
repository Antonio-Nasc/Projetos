//Você deve fazer a leitura de 5 valores inteiros. Em seguida mostre quantos valores informados são pares, quantos valores informados são ímpares, quantos valores informados são positivos e quantos valores informados são negativos. Considere que o número zero é positivo, mas não pode ser considerado como positivo ou negativo
int[] valores = new int[5];

int quantidadePares = 0;
int quantidadeImpares = 0;
int quantidadePositivos = 0;
int quantidadeNegativos = 0;
Console.WriteLine("Informe 5 valores");
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = Convert.ToInt32(Console.ReadLine());
}

foreach (int resultado in valores)
{
    
    if (resultado % 2 == 0)
    {
        quantidadePares += 1;           
        Console.WriteLine("{0} par(es)", quantidadePares);
    }
    if(resultado % 3 == 0)
    {
        quantidadeImpares += 1;
        Console.WriteLine("{0} impar(es)", quantidadeImpares);
        
    }
    if(resultado > 0)
    {
        quantidadePositivos += 1;
        Console.WriteLine("{0} positivo(s)", quantidadePositivos);

    }
    if(resultado < 0)
    {
        quantidadeNegativos += 1;
        Console.WriteLine("{0} negativo(s)", quantidadeNegativos);
    }
}
