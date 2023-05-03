const nomePersonagem1 = prompt("Informe o nome do personagem: ")
const poderAtaque = prompt("Informe o poder do personagem")

const nomePersonagem2 = prompt("Informe o nome do segundo personagem")
let pontosDeVida = prompt("Informe a quantidade de pontos de vida do segundo personagem")
const poderDefesa = prompt("Informe o poder de defesa do segundo personagem")
const escudo = prompt("O segundo personagem possui um escudo? (Sim/Não)")

let danoCausado = 0

if (poderAtaque > poderDefesa && escudo === "Não") {
    danoCausado = poderAtaque - poderDefesa
} else if (poderAtaque > poderDefesa && escudo === "Sim") {
    danoCausado = (poderAtaque - poderDefesa) / 2
}

pontosDeVida -= danoCausado

alert(nomePersonagem1 + " causou " + danoCausado + " pontos de dano em " + nomePersonagem2)
alert(
    nomePersonagem1 + "\nPoder de ataque: " + poderAtaque + "\n\n" +
    nomePersonagem2 + "\nPoder de defesa: " + poderDefesa + "\nPontos de vida: " + pontosDeVida + 
    "\nPossui escudo: " + escudo
)