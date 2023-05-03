using bytebank_ADM.Funcionarios;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

//Funcionario Luana = new Funcionario("123456789", 3500);
//Luana.Nome = "José Nascimento";
//Console.WriteLine(Luana.Nome);
//Console.WriteLine(Luana.Salario);
//Console.WriteLine(Luana.GetBonificacao());

//Diretor Jorge = new Diretor("44444444", 6000);
//Jorge.Nome = "Jorge Oliveira";
//Console.WriteLine(Jorge.Nome);
//Console.WriteLine(Jorge.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(Jorge);
//gerenciador.Registrar(Luana);

//Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);


//Jorge.AumentarSalario();
//Luana.AumentarSalario();
//Console.WriteLine(Jorge.Salario);
//Console.WriteLine(Luana.Salario);

//Designer José = new Designer("400289221", 3000);
//Console.WriteLine(José.Salario);
//José.AumentarSalario();
//Console.WriteLine("Novo salário de José: " + José.Salario);

//Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
UsarSistema();
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor ingrid = new Diretor("12345678");
    ingrid.Nome = "Ingrid Ferreira";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("987654321", 2500);
    ursula.Nome = "Ursula Vieira";
    ursula.Senha = "321";

    sistema.Logar(ingrid, "987");
    sistema.Logar(ursula, "321");

}

