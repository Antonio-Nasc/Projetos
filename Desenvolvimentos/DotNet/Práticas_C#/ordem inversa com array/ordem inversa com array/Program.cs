int[] valores = new int[4];
Random rand = new Random();
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = rand.Next(1, 100);
}
for (int i = 0; i < valores.Length; i++)
{
    Console.WriteLine($"Posição: {i}\nValor: {valores[i]}");
}
Console.WriteLine("------------------------------------");
for (int i = valores.Length-1; i >= 0; i--)
{
    Console.WriteLine($"Posição: {i}\nValor: {valores[i]}");
}
