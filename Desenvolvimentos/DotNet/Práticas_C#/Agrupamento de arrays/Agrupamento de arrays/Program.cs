// Escreva uma aplicação no qual o usuário deverá informar 10 números inteiro e maiores que Zero em um vetor. Em um segundo vetor, armazene apenas os números pares e em um terceiro apenas os ímpares. Exiba os 3 vetores, todos em ordem crescente.

int[] numeros = new int[10];
Console.WriteLine("Informe 10 números inteiros e maiores que zero: ");
for (int i = 0; i < numeros.Length; i++)
{
        numeros[i] = Convert.ToInt32(Console.ReadLine());   
}

int[] pares = new int[10];
int[] impares = new int[10];

for(int i = 0;i < numeros.Length; i++)
{
    if (numeros[i] % 2 == 0)
    {
        pares[i] = numeros[i];
    }
    else
    {
        impares[i] = numeros[i];
    }
}

Array.Sort(pares);
Array.Sort(impares);
Array.Sort(numeros);

Console.WriteLine("Esses são os números que você digitou: ");
foreach(int num in numeros)
{
    Console.WriteLine(num);
}

Console.WriteLine("Esses são os números pares");
foreach(int num in pares)
{
    if(num != 0) Console.WriteLine(num);
}

Console.WriteLine("Esses são os números ímpares: ");
foreach(int num in impares)
{
   if(num != 0) Console.WriteLine(num);
}

