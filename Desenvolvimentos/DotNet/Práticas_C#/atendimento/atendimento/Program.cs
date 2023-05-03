using System.Collections;

Console.WriteLine("Bem-vindo ao ByteBank-Atendimento");
ArrayList _listaDeContas = new ArrayList();
void AtendimentoCliente()
{
    char opção = '0';
    while (opção != '6')
    {
        Console.Clear();
        Console.WriteLine("========================");
        Console.WriteLine("===    Atendimento    ===");
        Console.WriteLine("1 - Cadastrar Conta");
        Console.WriteLine("2 - Listar Contas");
        Console.WriteLine("3 - Remover Conta");
        Console.WriteLine("4 - Ordenar Contas");
        Console.WriteLine("5 - Pesquisar Conta");
        Console.WriteLine("6 - Sair do Sistema");
        Console.WriteLine("\n\n");
        Console.WriteLine("Digite a opção desejada: ");
        opção = Console.ReadLine()[0];
        switch(opção)
        {
            case '1':
                CadastrarConta();
                break;
            default: Console.WriteLine("Opção não implementada");
                break;
        }
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("===============================");
    Console.WriteLine("===   CADASTRO DE CONTAS    ===");
    Console.WriteLine("===============================");
    Console.WriteLine("\n");
    Console.WriteLine("=== Informe dados da conta ===");
    Console.Write("Número da conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Infome nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Infome CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Infome Profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);
    Console.WriteLine("... Conta cadastrada com sucesso! ...");
    Console.ReadKey();
}