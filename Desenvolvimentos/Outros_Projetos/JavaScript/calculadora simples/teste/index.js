const entrada1 = prompt("Informe o primeiro valor")
const entrada2 = prompt("Informe o segundo valor")

const num1 = parseFloat(entrada1)
const num2 = parseFloat(entrada2)

const soma = num1 + num2
const sub = num1 - num2
const divisao = num1 / num2
const multiplicacao = num1 * num2
alert(
    "Soma: " + (soma) +
    "\nSubtração: " + sub +
    "\nMultiplicação: " + multiplicacao +
    "\nDivisão: " + divisao
)