const nome1 = prompt("Informe o nome do veículo")
const velocidade1 = prompt("Informe a velocidade do veículo")

const nome2 = prompt("Informe o nome do veículo")
const velocidade2 = prompt("Informe a velocidade do veículo")

if (velocidade1 > velocidade2) {
    alert("O veículo " + nome1 + " é mais rápido que o veículo " + nome2)
} else if (velocidade2 > velocidade1) {
    alert("O veículo " + nome2 + " é mais rápido que o veículo " + nome1)
} else {
    alert("Ambos os veículos tem a mesma velocidade")
}