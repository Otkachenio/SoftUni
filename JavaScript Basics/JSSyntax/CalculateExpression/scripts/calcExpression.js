function calculate(form) {
    var expression = document.getElementById('expression').value;
    var result = eval(expression);
    var sumbit = document.getElementById('button');  

    sumbit.live('click', document.getElementById('result').innerHTML = result);
}