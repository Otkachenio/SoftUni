function DecToHexInput() {
    var input = prompt("Enter a number");

    if (input >= 0) {
        var inputToInt = parseInt(input);
        var hexNum = inputToInt.toString(16).toUpperCase();
        alert(hexNum);
    }
}
