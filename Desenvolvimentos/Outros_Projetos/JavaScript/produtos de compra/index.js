let code = prompt("Informe o código do produto de 100 a 105")
let amount = prompt("Que quantidade você deseja?")

switch(code){
    case "100":
        alert("Valor total: " + 1.70 * amount)
        break
    case "101":
        alert("Valor total: " + 2.30 * amount)
        break
    case "102":
        alert("Valor total: " + 2.60 * amount)
        break
    case "103":
        alert("Valor total: " + 2.40 * amount)
        break
    case "104":
        alert("Valor total: " + 2.50 * amount)
        break
    case "105":
        alert("Valor total: " + 1.00 * amount)
        break
    default:
        alert("Código inválido")
}