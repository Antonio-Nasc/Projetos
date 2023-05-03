let endereco = {
    rua: "A",
    bairro: "Industrial",
    complemento: "Casa"
}
console.log(endereco)

endereco.bairro = "Suíssa"
console.log(endereco)

const lista = ["Carro", "Moto", "Trem"]

function exibir(a, b, c){
    console.log({
        a,
        b,
        c
    })
}

lista.forEach(exibir)

