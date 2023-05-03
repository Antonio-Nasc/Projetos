using Formula1.Dados;
using Formula1.Informacoes;

ListaDePilotos listaPilotos = new ListaDePilotos();
listaPilotos.Adicionar(new Pilotos("Vettal", "Ferrari"));
listaPilotos.Adicionar(new Pilotos("Filipe Massa", "Ferrari"));
listaPilotos.Adicionar(new Pilotos("Sena", "Red bull"));

var hami = new Pilotos("Hamilton", "Mercedez");
listaPilotos.Adicionar(hami);
listaPilotos.ExibirResultado();
listaPilotos.Remover(hami);
listaPilotos.ExibirResultado();




