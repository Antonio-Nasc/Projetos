List<string> alunos = new List<string>();
string option;
do
{
    
    Console.WriteLine("---- Bem-vindo(a) ao menu escolar! ----\n\n" + "Escolha uma opção abaixo: \n\n" +
        "1. Adicionar aluno\n2. Lista alunos matriculados em uma série\n3. Sair");
    option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.WriteLine("Informe o nome e grau escolar do aluno");
            string aluno = Console.ReadLine();
            if (aluno != null)
            {
                alunos.Add(aluno);
            }
            else
            {
                Console.WriteLine("Erro!");
            }

            break;
        case "2":
            foreach(string i in alunos)
            {
                Console.WriteLine("------------");
                Console.WriteLine(i);
                Console.WriteLine("------------");
            }

            break;
        case "3":
            Console.WriteLine("Saindo...");
            break;

        default: 
            Console.WriteLine("Opção não encontrada.");
            break;
    }
    
} while (option != "3");


//for(int i = 0; i < 3; i++)
//{
//    Console.WriteLine("Informe o nome do aluno e a série dele");
//    string aluno = Console.ReadLine();
//    alunos.Add(aluno);
//}
//foreach(string studant in alunos)
//{
//    Console.WriteLine(studant);
//}
