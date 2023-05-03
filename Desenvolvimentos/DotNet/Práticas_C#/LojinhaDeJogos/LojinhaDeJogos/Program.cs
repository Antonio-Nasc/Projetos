using LojinhaDeJogos.Funcionarios;

Gerente carlos = new Gerente("José Nascimento", "92750972305", 4000);
Console.WriteLine(carlos.Nome);
Console.WriteLine(carlos.Cpf);
carlos.Comissao();
Console.WriteLine(carlos.Comissao());
Console.WriteLine(carlos.Salario);
carlos.AumentarSalario();
Console.WriteLine(carlos.Salario);

