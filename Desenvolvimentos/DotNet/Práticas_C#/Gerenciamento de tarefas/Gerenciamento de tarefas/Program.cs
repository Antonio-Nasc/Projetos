//Permita usuário adicionar, editar, visualizar e excluir tarefas.

string option;
int i = 1;
int cont = 1;
List<string> tarefas = new List<string>();
do
{
    Console.WriteLine("Bem-vindo ao gerenciamento de tarefas!");
    Console.WriteLine("Aqui você organiza todas suas tarefas\n");
    Console.WriteLine("Escolha uma opção:\n\n1.Adicionar tarefa\n2.Editar alguma tarefa\n3.Visualizar tarefa(S)\n4.Sair");
    option = Console.ReadLine();
    switch (option)
    {
        //Adicionar tarefa
        case "1":
            Console.WriteLine("Digite a tarefa que deseja");
            string tarefa = Console.ReadLine();
            tarefas.Add(tarefa);
            Console.WriteLine(i++ + ". " + tarefa);
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadKey();
            Console.Clear();
            break;
            
        //Editar tarefas
        case "2":
            for (int indice = 0; indice < tarefas.Count; indice++)
            {
                
                Console.WriteLine(cont++ + ". " + tarefas[indice]);
                
            }
            Console.WriteLine("Qual você deseja editar?");
            int editar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o que quer para atualizar");
            string atualizar = Console.ReadLine();
            tarefas[editar] = atualizar;
            break;

        //Visualizar tarefas
        case "3":
            for(int indice = 0; indice < tarefas.Count; indice++)
            {
                Console.WriteLine(tarefas[indice]);      
            }
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadKey();
            break;

        case "4":
           
            for (int indice = 0; indice < tarefas.Count; indice++)
            {
                Console.WriteLine(tarefas[indice]);
            }
            Console.WriteLine("Qual item deseja remover?");
            int remover = Convert.ToInt32(Console.ReadLine());
            tarefas.Remove(remover);
            break;
        case "5":
            Console.WriteLine("Saindo...");
            break;
        default: 
            Console.WriteLine("Opção inválida!");
            break;
    }


} while (option != "5");
