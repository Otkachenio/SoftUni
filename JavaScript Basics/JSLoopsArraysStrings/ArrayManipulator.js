function MostFrequent(array) {
	var num = array[0];
	var counter = 0;
	var bestCount = 0;
	
	for(ind in array) {		
		if(num === array[ind]) {
			counter++;
			
			if(counter > bestCount) {
				var mostFrequent = array[ind];
			}
		} else {
			var num = array[ind];			
			counter = 1;
		}
	}
	
	console.log('Most frequent number: ' + mostFrequent);
}

function FilterOut(arr) {
	var orderedArr = [];
	
	for (var index in arr){
		if (isFinite(arr[index])){
			var number = Number(arr[index]);
			orderedArr.push(number);
		}
	}
	
	if(!arr) {
		throw 'ERROR: Array cannot be empty!';
	}
	
	orderedArr.sort(
		function (a, b) {
			return a < b;
	});
		
	console.log('Min number: ' + orderedArr[orderedArr.length - 1]);
	console.log('Max number: ' + orderedArr[0]);
	
	MostFrequent(orderedArr);	
	console.log(orderedArr);
}

FilterOut(["Pesho", 2, "Gosho", 12, 2, "true", 9, undefined,
 0, "Penka", { bunniesCount : 10}, [10, 20, 30, 40]]);
 
