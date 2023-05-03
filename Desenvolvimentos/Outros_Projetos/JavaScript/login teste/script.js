function register(element){
    const email = element.children.email.value
    const password = element.children.password.value
    const passwordConfirmation = element.children.passwordConfirmation.value

    const confirmation = confirm("Você tem certeza que quer cadastrar com esse dados?")

    if(confirmation){
        if(password === passwordConfirmation){
            alert("Cadastrado com sucesso!")
        }
        else{
            alert("Senhas diferente. Tente novamente")
        }
    }

    document.getElementById('email').value = ''
    document.getElementById('password').value = ''
    document.getElementById('passwordConfirmation').value = ''
}