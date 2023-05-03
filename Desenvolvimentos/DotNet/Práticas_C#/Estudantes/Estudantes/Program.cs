string[] nomeEstudantes = new string[10];
int[] idadeEstudantes = new int[10];
string[] lista = new string[10];
Console.WriteLine("Informe 10 nomes de estudantes e suas respectivas idade");
for (int i = 0; i < nomeEstudantes.Length; i++)
{
    Console.WriteLine("Estudante:");
    nomeEstudantes[i] = Console.ReadLine();

    Console.WriteLine("Idade:");
    idadeEstudantes[i] = Convert.ToInt32(Console.ReadLine());
}

