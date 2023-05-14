using CarroPOO.Models;

Carro carro = new Carro();
Console.WriteLine("Informe a marca do carro");
carro.Marca = Console.ReadLine();
Console.WriteLine("Informe o modelo do carro");
carro.Modelo = Console.ReadLine();
Console.WriteLine("Informe o ano de fabricação do carro");
carro.AnoDeFabricacao = Console.ReadLine();
Console.WriteLine("Informe a cor do carro");
carro.Cor = Console.ReadLine();

Console.WriteLine("Resultado das informações:\nMarca: " + carro.Marca + "\nModelo: " + carro.Modelo + "\nAno de fabricação: " + carro.AnoDeFabricacao + "\nCor: " + carro.Cor);


int option;
do
{
    
    Console.WriteLine("Qual método deseja utilizar agora veículo:\n1. Acelerar\n2. Frear\n3. Mudar a marcha\n4. Ligar o motor\n5. Desligar o motor");
    option = Convert.ToInt32(Console.ReadLine());
    switch (option)
    {
        case 1: Console.WriteLine(carro.Acelerar()); break;
        case 2: Console.WriteLine(carro.frear()); break;
        case 3: Console.WriteLine(carro.MudarMarcha()); break;
        case 4: Console.WriteLine(carro.LigarMotor()); break;
        case 5: Console.WriteLine(carro.DesligarMotor()); break;

    }

} while (option != 5);