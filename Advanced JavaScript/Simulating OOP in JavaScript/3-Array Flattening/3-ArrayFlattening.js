Array.prototype.flatten = function () {
	var newArray = [];	
	
	function extrackValues(array) {
		var length = array.length;
		
		for(var index = 0; index < length; index++) {
			var value = array[index];
			
			if(value instanceof Array) {
				extrackValues(value);
			} else {
				newArray.push(value);
			}
		}
	}
	
	extrackValues(this);
	return newArray;
};

var array = [1, 2, 3, 4];
console.log(array.flatten());
var array = [1, 2, [3, 4], [5, 6]];
console.log(array.flatten());
console.log(array); // Not changed
var array = [0, ["string", "values"], 5.5, [[1, 2, true], [3, 4, false]], 10];
console.log(array.flatten());