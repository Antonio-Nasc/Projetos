using Conta_bancaria.Models;

ContaBancaria conta1 = new ContaBancaria();

conta1.SaldoAtual = 250;
conta1.Sacar(50);
conta1.Depositar(150);
//Console.WriteLine(conta1.VerificarSaldo());
ContaBancaria conta2 = new ContaBancaria();
conta2.SaldoAtual = 100;
Console.WriteLine(conta2.SaldoAtual);
conta1.SaldoAtual += conta2.Transferir(40);
Console.WriteLine(conta2.SaldoAtual);


