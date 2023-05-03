const word = prompt("Informe uma palavra")
let palavraInvertida = ""

for(let i = word.length - 1; i >= 0; i--){
    palavraInvertida += word[i]
}

if(word === palavraInvertida){
    alert(word + " é um palíndromo!")
} else{
    alert(
        word + " não é um palíndromo!\n\n" +
        word + " !== " + palavraInvertida
    )
}