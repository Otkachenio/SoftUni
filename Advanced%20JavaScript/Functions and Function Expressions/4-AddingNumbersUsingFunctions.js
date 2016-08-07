function sum(a) {

	var sum = a;

	function f(b) {
		sum += b;
		return f;
	}

	f.toString = function() { 
					return sum;
				 }

	return f;
}

console.log(sum(1).toString());
console.log(sum(2)(3)(2).toString());
console.log(sum(1)(1)(1)(1)(1).toString());
console.log(sum(1)(0)(-1)(-1).toString());

var addTwo = sum(2);
console.log(addTwo.toString());
var addTwo = sum(2); 
console.log(addTwo(3).toString());
var addTwo = sum(2); 
console.log(addTwo(3)(5).toString());