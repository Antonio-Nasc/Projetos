int[] numeros = new int[10];
Console.WriteLine("Informe 10 valores");
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}

Array.Sort(numeros);

foreach(int resul in numeros)
{
    Console.WriteLine("Os números escolhidos foram: ");
    Console.WriteLine(resul);
}
Console.WriteLine("Menor número: " + numeros[0]);
Console.WriteLine("Maior número: " + numeros[9]);
