function soma() {
    var n1 = document.getElementById('n1')
    var n2 = document.getElementById('n2')
    var resp = document.getElementById('resp')
    var num1 = Number(n1.value)
    var num2 = Number(n2.value)
    var soma = num1 + num2

    resp.textContent = `A soma de ${num1} + ${num2} é ${soma}`
}
function sub() {
    var n1 = document.getElementById('n1')
    var n2 = document.getElementById('n2')
    var resp = document.getElementById('resp')
    var num1 = Number(n1.value)
    var num2 = Number(n2.value)
    var sub = num1 - num2

    resp.textContent = `A subtração de ${num1} - ${num2} é ${sub}`
}
function mult() {
    var n1 = document.getElementById('n1')
    var n2 = document.getElementById('n2')
    var resp = document.getElementById('resp')
    var num1 = Number(n1.value)
    var num2 = Number(n2.value)
    var mult = num1 * num2

    resp.textContent = `A multiplicação de ${num1} * ${num2} é ${mult}`
}

function div() {
    var n1 = document.getElementById('n1')
    var n2 = document.getElementById('n2')
    var resp = document.getElementById('resp')
    var num1 = Number(n1.value)
    var num2 = Number(n2.value)
    var div = num1 / num2

    resp.textContent = `A divisão de ${num1} / ${num2} é ${div}`
}