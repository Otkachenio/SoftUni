Function.prototype.call = function () {
    var newArg = [];
	var obj = arguments[0];
	
    for (var i = 1; i < arguments.length; i++) {
		newArg.push(arguments[i]);
    }
	
    return this.apply(obj, newArg);
}

function sum() {
	var sum = 0;
	
	for(var index in arguments) {
		sum += Number(arguments[index]);
	}
	
	return sum;
}

console.log(sum.call(this, 1, 2, 3, 5, 9, 8));