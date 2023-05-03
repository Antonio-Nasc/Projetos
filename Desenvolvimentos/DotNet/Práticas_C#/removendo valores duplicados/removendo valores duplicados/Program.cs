//int[] valores = new int[8] {2, 3, 15, 1, 2, 14, 15, 1};
//int[] semDuplicacao = valores.Distinct().ToArray();

//Console.WriteLine("Com valores duplicados");
//foreach(int i in valores)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("Sem valores duplicado");
//foreach (int i in semDuplicacao)
//{
//    Console.WriteLine(i);
//}

int[] valores = new int[5];
Console.WriteLine("Informe 5 valores");
for (int i = 0; i < valores.Length; i++)
{
    valores[i] = Convert.ToInt32(Console.ReadLine());
}
int[] semDuplicacao = valores.Distinct().ToArray();
Console.WriteLine("Com valores duplicados");
foreach(int i in valores)
{
    Console.WriteLine(i);
}
Console.WriteLine("Com valores não duplicados");
foreach(int i in semDuplicacao)
{
    Console.WriteLine(i);
}