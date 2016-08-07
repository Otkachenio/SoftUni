"use strict";

function QuadraticEquation(QEForm) {
    var a = Number(document.getElementsByName('a')[0].value);
    var b = Number(document.getElementsByName('b')[0].value);
    var c = Number(document.getElementsByName('c')[0].value);

    var D = (b * b) - (4 * a * c);

    if (D < 0) {
        alert('No real roots');
    } else if (D == 0) {
        var X = (-b) / (2 * a);

        alert('X = ' + X);
    } else {
        D = Math.sqrt(D);

        var x1 = (-b + D) / (2 * a);

        var x2 = (-b - D) / (2 * a);

        alert('X1 = ' + x1 + '\n' + 'X2 = ' + x2);
    }
}