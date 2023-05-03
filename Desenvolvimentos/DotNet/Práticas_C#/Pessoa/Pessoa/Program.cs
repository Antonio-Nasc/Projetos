using Pessoa;

Cidadao pessoa = new Cidadao();
pessoa.Nome = "José Antônio";
pessoa.Altura = 1.81f;
pessoa.DataNascimento = new DateTime(2000, 5, 6);
pessoa.ImprimirDados();
int idade = pessoa.CalcularIdade();

Console.WriteLine(idade);
