function somar(){
    let tn1 = document.getElementById('txtn1')
    let tn2 = document.getElementById('txtn2')
    let resultsoma = document.getElementById('resultsoma')
    let n1 = parseFloat(tn1.value)
    let n2 = parseFloat(tn2.value)
    let soma = n1 + n2

    resultsoma.innerText = `A soma entre ${n1} e ${n2} é igual a ${soma}`


}

function subtrair(){
    let sub1 = document.getElementById('valor1').value
    let sub2 = document.getElementById('valor2').value
    let resulSub = document.getElementById('sub')

    let vlr = sub1 - sub2
    resulSub.innerText = `A subtração do valor ${sub1} e ${sub2} é igual a ${vlr}`
}