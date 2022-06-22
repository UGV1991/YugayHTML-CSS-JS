let numberOne = document.querySelector(".number-One")
let numberTwo = document.querySelector(".number-Two")


let plusButton = document.querySelector(".plus")
let minusButton = document.querySelector(".minus")
let multiplyButton = document.querySelector(".multiply")
let divideButton = document.querySelector(".divide")
let resultText = document.querySelector(".result")

plusButton.addEventListener("click", function(){
	let numOne = parseInt(numberOne.value)
	let numTwo = parseInt(numberTwo.value)
	let sum = numOne + numTwo
	resultText.innerText = sum
})

minusButton.addEventListener("click", function(){
	let numOne = parseInt(numberOne.value)
	let numTwo = parseInt(numberTwo.value)
	let sum = numOne - numTwo
	resultText.innerText = sum
})

divideButton.addEventListener("click", function(){
	let numOne = parseInt(numberOne.value)
	let numTwo = parseInt(numberTwo.value)
	let sum = numOne / numTwo
	resultText.innerText = sum
})

multiplyButton.addEventListener("click", function(){
	let numOne = parseInt(numberOne.value)
	let numTwo = parseInt(numberTwo.value)
	let sum = numOne * numTwo
	resultText.innerText = sum
})