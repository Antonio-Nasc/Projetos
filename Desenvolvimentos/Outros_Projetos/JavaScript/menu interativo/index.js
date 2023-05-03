let menu = "5"

do{
    menu = prompt("Escolha uma opção: \n1) Iniciar \n2) Retornar \n3) Reiniciar \n4) Configuração \n5) Encerrar")

    switch(menu){
        case "1":
            alert("Você escolheu a opção 1")
            break
            case "2":
            alert("Você escolheu a opção 2")
            break
            case "3":
            alert("Você escolheu a opção 3")
            break
            case "4":
            alert("Você escolheu a opção 5")
            break
            case "5":
            alert("Você escolheu encerrar")
            alert("Encerrando...")
            break
            default:
                alert("Opção inválida")
    }
} while (menu !== "5")