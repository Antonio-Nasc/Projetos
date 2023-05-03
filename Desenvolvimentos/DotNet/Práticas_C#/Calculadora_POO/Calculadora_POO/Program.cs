using Calculadora_POO.Calcular;

Operações calculo = new Operações();
Console.WriteLine("Informe o primeiro valor para cálculo");
calculo.Valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o segundo valor para cálculo");
calculo.Valor2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine(calculo.Somar());
Console.WriteLine(calculo.Subtrair());
Console.WriteLine(calculo.Multiplicar());
Console.WriteLine(calculo.Dividir());
