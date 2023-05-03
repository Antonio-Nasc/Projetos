Console.WriteLine("Informe o nome do recruta");
string nome = Console.ReadLine();
Console.WriteLine("Informe o sobrenome do recruta");
string sobrenome = Console.ReadLine();
string fullName = nome + " " + sobrenome;
Console.WriteLine("Informe o campo de estudo do recruta");
string areaDeEstudo = Console.ReadLine();
Console.WriteLine("Informe o ano de nascimento do recruta");
int anoDeNascimento = Convert.ToInt32(Console.ReadLine());
int idade = 2023 - anoDeNascimento;

Console.WriteLine("Nome completo: " + fullName + "\r\nCampo de estudo: " + areaDeEstudo + "\r\nIdade: " + idade);