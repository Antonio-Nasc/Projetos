//Um número é azarado se contém um número 1 seguido por um 3 entre seus dígitos, ou seja, sempre que houver o caracteres "13", ele será considerado um número azarado. Por exemplo, o número 341329 é de má sorte, enquanto o número 12321 não é.

//Dado um inteiro N, seu programa terá que determinar se N é azarado ou não.

Console.WriteLine("Informe número(s)");
string numero = (Console.ReadLine());
string n = "13";
bool b = numero.Contains(n);
if (b)
{
    Console.WriteLine($"{numero} es de Mala suerte");
}
else
{
    Console.WriteLine($"{numero} No es de Mala Suerte");
}
