string[] alunos = new string[10];
for (int i = 0; i < alunos.Length; i++)
{
    Console.WriteLine($"Informe o nome do {i + 1}º aluno");
    alunos[i] = Console.ReadLine();
    

}

int pos = 0;
Console.WriteLine("Qual posição deseja ver?");
pos = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(alunos[pos]);


