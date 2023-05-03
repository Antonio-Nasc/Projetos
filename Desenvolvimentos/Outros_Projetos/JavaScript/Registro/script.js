function register(element){
    const username = element.children.username.value
    const password = element.children.password.value
    const passwordConfirmation = element.children.passwordConfirmation.value

    if(password === passwordConfirmation){
        alert("Usuário " + username + " registrado!")
    } else{
        alert("Senha não compatível.")
    }

    document.getElementById('username').value = ''
    document.getElementById('password').value = ''
    document.getElementById('passwordConfirmation').value = ''
}