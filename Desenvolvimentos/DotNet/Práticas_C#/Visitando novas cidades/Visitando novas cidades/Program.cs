Console.WriteLine("Informe o nome do turista");
string turista = Console.ReadLine();

Console.WriteLine("Você já visitou alguma cidade? (Sim/Não");
string visita = Console.ReadLine();

string cidades = "";
int contagem = 0;

while(visita == "Sim")
{
    Console.WriteLine("Qual o nome da cidade visitada?");
    string cidade = Console.ReadLine();
    cidades += " - " + cidade + "\r\n";
    contagem++;
    Console.WriteLine("Você visitou alguma outra cidade? (Sim/Não)");
    visita = Console.ReadLine();
}
Console.WriteLine(turista + " Visitou " + contagem + " cidades, que foram as " + cidades);



