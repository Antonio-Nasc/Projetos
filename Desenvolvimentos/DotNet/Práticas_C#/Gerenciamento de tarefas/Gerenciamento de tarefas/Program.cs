//Permita usuário adicionar, editar e excluir tarefas.

string option;
int i = 1;
List<string> tarefas = new List<string>();
do
{
    Console.WriteLine("Bem-vindo ao gerenciamento de tarefas!");
    Console.WriteLine("Aqui você organiza todas suas tarefas.\n");
    Console.WriteLine("Escolha uma opção:\n\n1.Adicionar tarefa\n2.Editar alguma tarefa\n3.Excluir tarefa\n4.Sair");
    option = Console.ReadLine();
    switch (option)
    {
        case "1":
            Console.WriteLine("Digite a tarefa que deseja");
            string tarefa = Console.ReadLine();
            tarefas.Add(tarefa);
            Console.WriteLine(i++ + ". " + tarefa);
            Console.WriteLine("Pressione enter para continuar.");
            Console.ReadKey();
            Console.Clear();
            break;

        case "4":
            Console.WriteLine("Saindo...");
            break;
        default: 
            Console.WriteLine("Opção inválida!");
            break;
    }


} while (option != "4");
