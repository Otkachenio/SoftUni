function FilterOut(arr) {
	var filteredArr = [];
	
	for(var ind in arr) {
		var number = Number(arr[ind]);
		
		if (number > 0 && number < 400) {
			filteredArr.push(number);
		}
	}

	filteredArr.sort(
		function(a, b) {
			return a > b;
	});
	
	var finalScores = [];
	
	for(var index in filteredArr) {
		var num = filteredArr[index] - (filteredArr[index] * 0.2);
		
		finalScores.push(num);
	}
	
	console.log(finalScores);
} 

FilterOut([200, 120, 23, 67, 350, 420, 170, 212, 401, 615, -1]);