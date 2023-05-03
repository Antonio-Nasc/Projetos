//Calcule o nuúmero médio de cachorro-quente consumido pelos participantes.

Console.WriteLine("Informe o número de participantes");
double participantes = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe quantos cachorros-quentes foram consumidos");
double cachorrosQuentes = Convert.ToInt32(Console.ReadLine());

double media = participantes / cachorrosQuentes;
Console.WriteLine(media.ToString("F"));