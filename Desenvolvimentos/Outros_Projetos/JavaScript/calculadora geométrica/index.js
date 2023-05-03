function triangulo(){
    const base = prompt("Informe a base do triângulo")
    const altura = prompt("Informe a altura do triângulo")
    return base * altura / 2
}
function retangulo(){
    const base = prompt("Informe a base do retangulo")
    const altura = prompt("Informe a altura do retângulo")
    return base * altura
}
function quadrado(){
    const lado = prompt("Informe o lado do quadrado")
    return lado * lado
}
function trapezio(){
    const baseMaior = parseFloat(prompt("Informe a base maior do trapézio:"))
    const baseMenor = parseFloat(prompt("Informe a base menor do trapézio:"))
    const altura = prompt("Informe a altura do trapézio:")
    return (baseMaior + baseMenor) * altura / 2
}
function circulo(){
    const raio = prompt("Informe o raio do círculo")
    return 3.14 * raio * raio
}
function menu(){
    return prompt("Seja bem-vindo ao menu geométrico!\n\n" + 
    "Escolha uma opção de cálculo:\n" + 
    "1. Área do triângulo\n2. Área do retângulo\n3. Área do quadrado\n4. Área do trapézio\n5. Área do círculo\n6. Sair")
}
function executar(){
    let option = ""

    do{
        option = menu()
        let resultado
        switch(option){
            case "1":
                resultado = triangulo()
                break
            case "2":
                resultado = retangulo()
                break
            case "3":
                resultado = quadrado()
                break
            case "4":
                resultado = trapezio()
                break
            case "5":
                resultado = circulo()
                break
            case "6":
                alert("Encerrando...")
                break
            default:
                alert("Opção inválida")
        }
        if(resultado){
            alert("Resultado: " + resultado)
        }
    }while(option !== "6")
}
executar()

