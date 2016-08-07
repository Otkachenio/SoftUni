'use strict'

function findLargestBySumOfDigits() {
	var LargestSum = {
		digitsSum: 0,
		number: ''
	};	
	
	for(var ind in arguments) {
		if(!(typeof arguments[ind] === 'number') || arguments[ind].toString().indexOf('.') > 0) {
			console.log('undefined');
			return undefined;
		} 	
		
		var number = 0;
		var positiveNumber = arguments[ind];
		if(positiveNumber < 0) {
			positiveNumber *= -1;
		}
		
		var numberAsString = positiveNumber.toString();
		
		for(var index in numberAsString) {				
			number += Number(numberAsString[index]);
			
			if(number > LargestSum.digitsSum) {
				LargestSum.digitsSum = number;
				LargestSum.number = arguments[ind];
			}
		}	
	}
	
	console.log(LargestSum.number);
} 

findLargestBySumOfDigits(5, 10, 15, 111);
findLargestBySumOfDigits(33, 44, -99, 0, 20);
findLargestBySumOfDigits('hello');
findLargestBySumOfDigits(5, 3.33);