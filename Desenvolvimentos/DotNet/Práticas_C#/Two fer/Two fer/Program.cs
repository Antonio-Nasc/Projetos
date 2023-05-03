Console.WriteLine("Qual o nome do amigo?");
string amigo = Console.ReadLine().ToUpper();
Console.WriteLine("Você gosta de biscoito?");
string amigoResposta = Console.ReadLine().ToUpper();

if(amigo == "ISA" && amigoResposta == "SIM")
{
    Console.WriteLine($"Um para {amigo}, um para mim.");
}
else
{
    Console.WriteLine("Um para você, um para mim.");
}