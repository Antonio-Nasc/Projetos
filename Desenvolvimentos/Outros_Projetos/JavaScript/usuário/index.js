let username = prompt("Informe seu nome")
let age = prompt("Informe sua idade")
let salary = prompt("Informe seu salário")
let gender = prompt("Informe sua sexualidade. (f/m)")
let civilStatus = prompt("Informe seu estado civil. (s/c/v/d)")

while(username.length < 4){
    alert("Nome inválido. Tente novamente.")
    username = prompt("Informe seu nome novamente acima de 3 caracteres")
}

while(age < 0 && age > 150){
    alert("Idade inválida. Tente novamente")
    age = prompt("Informe uma idade maior que 0 e menor que 151")
}

while(salary < 1){
    alert("Salário inválido")
    salary = prompt("Informe o salário acima de 0")
}
alert(username +
    "\n" + age  +
    "\n" + salary +
    "\n" + gender
    )