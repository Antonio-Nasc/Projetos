// const name = prompt("What's your name?")
// const lastName = prompt("What's your last name?")
// const studyArea = prompt("What's your study area?")
// const yearBirth = parseFloat(prompt("report your year of birth:"))

// alert("Name: " + name +
// "\nLast name: " + lastName +
// "\nStudy area: " + studyArea +
// "\nYear birth: " + (2023 - yearBirth))


// function user(){
//     const name = prompt("What's your name?")
//     const lastName = prompt("What's your last name?")
//     const studyArea = prompt("What's your study area?")
//     const yearBirth = parseFloat(prompt("report your year of birth:"))
//     return alert("Name: " + name +
//     "\nLast name: " + lastName +
//     "\nStudy area: " + studyArea +
//     "\nYear birth: " + (2023 - yearBirth))
// }
// user()

// const valueOne = parseFloat(prompt("Report the first number:"))
// const valueTwo = parseFloat(prompt("Report the second number:"))

// const addition = valueOne + valueTwo
// const subtraction = valueOne - valueTwo
// const multiplication = valueOne * valueTwo
// const division = valueOne / valueTwo

// alert("Addition: " + addition +
// "\nSubtraction: " + subtraction +
// "\nMultiplication: "+ multiplication +
// "\nDivision: " + division)

// function calc(valueOne, valueTwo){
//     valueOne = parseFloat(prompt("Report the first number:"))
//     valueTwo = parseFloat(prompt("Report the second number:"))

//     const addition = valueOne + valueTwo
//     const subtraction = valueOne - valueTwo
//     const multiplication = valueOne * valueTwo
//     const division = valueOne / valueTwo

//     return alert("Addition: " + addition +
//         "\nSubtraction: " + subtraction +
//         "\nMultiplication: "+ multiplication +
//         "\nDivision: " + division)
// }
// calc()


const name1 = prompt("What's the name of the first vehicle?")
const vel1 = prompt("What's the speed of the first vehicle?")
const name2 = prompt("What's the name of the second vehicle?")
const vel2 = prompt("What's the speed of the second vehicle?")

if(vel1 > vel2){
    alert(name1 + " is faster than the vehicle " + name2)
} else if(vel2 > vel1){
    alert(name2 + " is faster than the vehicle " + name1)
} else{
    alert(name1 + " and " + name2 + " have the same speed!")
}
