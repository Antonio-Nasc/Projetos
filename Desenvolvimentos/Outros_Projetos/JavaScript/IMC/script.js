function calcular(){
    const peso = document.getElementById('peso').value
    const altura = document.getElementById('altura').value
    const resultado = document.getElementById('resultado')

    const confirmacao = confirm(`Você confirma que seu peso é ${peso} e sua altura é ${altura}`)
    const imc = peso/(altura * altura)
    const total = imc.toFixed(2)
    if(confirmacao){
        if(imc < 18.5){
            resultado.innerText = `Seu IMC é de ${total}. Sua classificação é: Magreza`
        }
        else if(imc >= 18.5 && imc <= 24.9){
            resultado.innerText = `Seu IMC é de ${total}. Sua classificaçao é: Normal`
        } else if(imc >= 25 && imc <= 29.9){
            resultado.innerText = `Seu IMC é de ${total}. Sua classificaçao é: Sobrepeso`
        } else if(imc >= 30 && imc <= 39.9){
            resultado.innerText = `Seu IMC é de ${total}. Sua classificaçao é: Obesidade`
        } else{
            resultado.innerText = `Seu IMC é de ${total}. Sua classificaçao é: Obesidade grave`
        }
    }
    document.getElementById('peso').value = ''
    document.getElementById('altura').value = ''
}

