var balance = prompt("Informe sua quantidade de dinheiro inicial")
balance = parseFloat(balance)
let option = ""

do{
    alert("Você tem R$" + balance)
    option = prompt("O que deseja fazer?" + "\n1) Adicionar" + "\n2)Remover dinheiro" + "\n3) Sair")
    switch (option){
        case "1":
            balance += parseFloat(prompt("Informe o valor a ser adicionado:"))
            break
        case "2":
            balance -= parseFloat(prompt("Informe o valor a ser removido"))
            break
        case "3":
            alert("Encerrando...")
            break

        default:
            alert("Opção inválida")
    }   
} while(option !== "3")