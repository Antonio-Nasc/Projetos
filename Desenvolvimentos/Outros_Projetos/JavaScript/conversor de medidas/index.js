let value = prompt("Informe um valor em metros")
let option = prompt("Qual opção esse valor deve ser convertido?\nmm\ncm\ndm\ndam\nhm\nkm")

switch(option){
    case "mm":  
        value = value * 1000
        alert("Valor de metro para milimetro será de: " + value)
        break
    case "cm":
        value = value * 100
        alert("Valor de metro para centímetro será de: " + value)
        break
    case "dm":
        value = value * 10
        alert("Valor de metro para decímetro será de: " + value)
        break
    case "dam":
        value = value / 10
        alert("Valor de metro para decâmetro será de: " + value)
        break
    case "hm":
        value = value / 100
        alert("Valor de metro para hectômetro será de: " + value)
        break
    case "km":
        value = value / 1000
        alert("Valor de metro para quilômetro será de: " + value)
        break
    default:
        alert("Opção invalida")
    
}