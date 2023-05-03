function resultado(){
    let pais = document.getElementById('pais').value
    let resul = document.getElementById('result')

    let confir = confirm(`Confirma que o país em que você vive é o(a) ${pais}?`)
    if(confir){
        if(pais != 'Brasil'){
            resul.innerText = "Você é estrangeiro. Você mora no(a) " + pais
        } else{
            resul.innerText = `Você é Brasileiro!`
        }
    }
    document.getElementById('pais').value = ''
}