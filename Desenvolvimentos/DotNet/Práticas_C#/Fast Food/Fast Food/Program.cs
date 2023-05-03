using Fast_Food;

Consumidor consumista = new Consumidor();
consumista.nome = "José Nascimento";
consumista.cpf = "987654321";

Endereco localizacao = new Endereco();
localizacao.bairro = "Jardins";
localizacao.rua = "Rua do beco";
localizacao.numero = "102";

Opcoes itens = new Opcoes();
itens.item1 = "X-tudo";
itens.item2 = "Coca-Cola";

Lanchonete pedido = new Lanchonete();
pedido.cliente = consumista;
pedido.enderecoCliente = localizacao;
pedido.itens= itens;

Console.WriteLine("Informações do cliente:\r\n" + pedido.cliente.nome + "\r\n" + pedido.cliente.cpf);
Console.WriteLine("----------------------");
Console.WriteLine("Endereço do cliente:\r\n" + pedido.enderecoCliente.bairro + "\r\n" + pedido.enderecoCliente.rua + "\r\n" + pedido.enderecoCliente.numero);
Console.WriteLine("----------------------");
Console.WriteLine("Pedido:\r\n" + pedido.itens.item1 + "\r\n" + pedido.itens.item2);
