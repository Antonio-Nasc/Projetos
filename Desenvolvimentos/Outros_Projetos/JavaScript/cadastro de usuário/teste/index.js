const nome = prompt("Informe o primeiro nome do recruta: ")
const sobrenome = prompt("Informe o sobrenome do recruta: ")
const campoDeEstudo = prompt("Qual o campo de estudo do recruta?")
const anoDeNascimento = prompt("Qual é o ano de nascimento do recruta?")

alert(
    "Recruta cadastrado com sucesso" +
    "Nome completo: " + nome + " " + sobrenome +
    "Campo de estudo: " + campoDeEstudo +
    "Ano de nascimento: " + (2022 - anoDeNascimento)
)