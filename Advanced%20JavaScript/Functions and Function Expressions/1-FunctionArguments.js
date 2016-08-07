function printArgsInfo() {
	for(var index in arguments) {
		if(Object.prototype.toString.call(arguments[index]) === '[object Array]') {
			console.log(arguments[index] + " (array)");
			
		} else {
			console.log(arguments[index] + " (" + typeof arguments[index] + ")");
		}		
	}
}

printArgsInfo.call();
printArgsInfo.call(null, 2, 3, 2.5, -110.5564, false);
console.log("---------------------");
printArgsInfo.apply();
printArgsInfo.apply(null, [2, 3, 2.5, -110.5564, false]);

//printArgsInfo("some string", [1, 2], ["string", "array"], ["mixed", 2, false, "array"], {name: "Peter", age: 20});
//printArgsInfo([[1, [2, [3, [4, 5]]]], ["string", "array"]]);