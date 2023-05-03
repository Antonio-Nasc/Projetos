//Método FILTER

/*let dados = [
    {nome: "Ruan", idade: "18", cidade: "São Paulo"},
    {nome: "Paula", idade: "42", cidade: "Aracaju"},
    {nome: "José", idade: "22", cidade: "Aracaju"}
]
console.log(dados)

const filtrar = dados.filter(function(dado){
    return dado.cidade === "Aracaju"
})
console.log(filtrar)*/

//MÉTODO MAP

/*let dados = [
    {nome: "Ruan", idade: "18", cidade: "São Paulo"},
    {nome: "Paula", idade: "42", cidade: "Aracaju"},
    {nome: "José", idade: "22", cidade: "Aracaju"}
]
const lista = []

for (let i = 0; i < dados.length; i++){
    lista.push(`${dados[i].nome} has ${dados[i].idade} and lives in the city of ${dados[i].cidade}`)
}*/

/*let dados = [
    {nome: "Ruan", idade: "18", cidade: "São Paulo"},
    {nome: "Paula", idade: "42", cidade: "Aracaju"},
    {nome: "José", idade: "22", cidade: "Aracaju"}
]

const mapear = dados.map(function(dado){
    return `${dado.nome} has ${dado.idade} and lives in the city of ${dado.cidade}`
})


console.log(mapear)*/

//REDUCE

const numbers = [3, 7, 22, 74]

const sum = numbers.reduce((acummulator, number) => acummulator + number, 0)
console.log(sum)
