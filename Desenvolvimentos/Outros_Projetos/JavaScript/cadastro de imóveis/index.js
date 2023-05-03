let option = ""
let imoveis = []

do{
    option = prompt("Imóveis cadastrados: " + imoveis.length + "\n" +
    "Escolha uma opção: \n" + "1. Salvar um imóvel\n2. Mostrar todos os imóveis salvos\n3. Sair")

    switch (option){
        case "1":
            const imovel = {}

            imovel.proprietario = prompt("Informa o nome do proprietário do imóvel:")
            imovel.quartos = prompt("Quantos quartos possui o imóvel?")
            imovel.banheiros = prompt("Quantos banheiros possui o imóvel?")
            imovel.garagem = prompt("O imóvel possui garagem? (Sim/Não)")
        case "2":
            for(let i = 0; i < imoveis.length; i++){
                alert(
                    "Imóvel: " + (i + 1) +
                    "\nProprietário: " + imoveis[i].proprietario +
                    "\nQuartos: " + imoveis[i].quartos + 
                    "\nBanheiros: " + imoveis[i].banheiros +
                    "\nPossui garagem? " + imoveis[i].garagem
                )
            }
            break
        case "3":
            alert("Encerrando...")
            break
        default:
            alert("Opção inválida")
    }


}while(option !== "3")