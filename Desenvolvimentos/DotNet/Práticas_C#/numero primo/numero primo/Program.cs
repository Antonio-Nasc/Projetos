int[] numeros = new int[10];
int cont = 1;
Console.WriteLine("Informe 10 valores");
for (int i = 0; i < numeros.Length; i++)
{
    numeros[i] = Convert.ToInt32(Console.ReadLine());
}
Array.Reverse(numeros);

foreach(int p in numeros)
{
    for(int i=2; i<= p; i++)
    {
        if(p % i == 0 && i != p)
        {
            Console.WriteLine(p);
            break;
        }
        if(p % i == 0 && i == p)
        {
            Console.WriteLine(p + " é primo");
            break;
        }
    }
}
