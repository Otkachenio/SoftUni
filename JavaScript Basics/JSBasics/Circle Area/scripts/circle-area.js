function calcCircleArea(r) {
    var result = Math.PI * r * r;
    return result;
}

document.getElementById("area1").innerHTML = calcCircleArea(7);
document.getElementById("area2").innerHTML = calcCircleArea(1.5);
document.getElementById("area3").innerHTML = calcCircleArea(20);