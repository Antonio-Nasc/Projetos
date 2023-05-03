Console.WriteLine("Informe um ano");
int ano = Convert.ToInt32(Console.ReadLine());

if(DateTime.IsLeapYear(ano))
{
    Console.WriteLine($"{ano} é um ano bissexto");
}
else
{
    Console.WriteLine($"{ano} não é um ano bissexto");
}
