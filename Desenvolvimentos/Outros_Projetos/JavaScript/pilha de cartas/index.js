let option = ""
let baralho = []
do{

    let letter = ""
    for(let i = 0; i < baralho.length; i++){
        letter += baralho[i] + "\n"
    }
   option = prompt(
    "Cartas: \n" + letter +
    "\n1. Adicionar uma carta\n2. Puxar uma carta\n3. Sair" 
   )

   switch(option){
    case "1":
        const newLetter = prompt("Qual o nome da carta que deseja adicionar?")
        baralho.push(newLetter)
        break
    case "2":
        const removeLetter = baralho.shift()
        alert(removeLetter + " foi removido")
        break
    case "3":
        alert("Encerrando...")
        break
    default:
        alert("Opção inválida")
   }
    


} while(option !== "3")