const userInput = document.getElementById('input-number');
let result = 0;

function add() {
    result = result + Number(userInput.value);
    console.log(result)
}