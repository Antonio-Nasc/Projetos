//Programa de Imposto De Renda(IR)

double salario = 3300.0;

if(salario >= 1900.0 && salario <= 2800.0)
{
    Console.WriteLine("IR é de 7.5%. Pode deduzir na declaração o valor de R$142.");
} else if(salario >= 2800.01 && salario <= 3751.0)
{
    Console.WriteLine("IR é de 15%. Pode deduzir na declaração o valor de R$350.");
} else if(salario >= 3751.01 && salario <= 4664.0)
{
    Console.WriteLine("IR é de 22.5%. Pode deduzir na declaração o valor de R$636");
}