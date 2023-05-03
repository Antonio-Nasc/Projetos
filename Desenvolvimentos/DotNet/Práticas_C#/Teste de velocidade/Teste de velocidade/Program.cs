Console.WriteLine("Informe o nome do primeiro veículo");
string veiculo1 = Console.ReadLine();
Console.WriteLine("Informe a velocidade do primeiro veículo");
double velocidade1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Informe o nome do segundo veículo");
string veiculo2 = Console.ReadLine();
Console.WriteLine("Informe a velocidade do segundo veículo");
double velocidade2 = Convert.ToDouble(Console.ReadLine());

if(velocidade1 > velocidade2)
{
    Console.WriteLine("O veículo " + veiculo1 + " é mais rápido de que o veículo " + veiculo2);
} else if(velocidade2 > velocidade1)
{
    Console.WriteLine("O veículo " + veiculo2 + " é mais rápido de que o veículo " + veiculo1);
}
else
{
    Console.WriteLine("Ambos tem a mesma velocidade.");
}

