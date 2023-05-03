Console.WriteLine("Informe o primeiro valor");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o segundo valor");
double num2 = Convert.ToDouble(Console.ReadLine());

double somar = num1 + num2;
double subtrair = num1 - num2;
double dividir = num1 / num2;
double multiplicar = num1 * num2;

Console.WriteLine("Soma: " + somar + "\r\nSubtração: " + subtrair + "\r\nDivisão: " + dividir + "\r\nMultiplicar: " + multiplicar);
