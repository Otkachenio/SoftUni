'use strict'

function findNthDigit(arr) {	
	var digit;
	var position = arr[0];
	
	if(!typeof arr[0] === 'number' || !typeof arr[1] === 'number') {
		return console.log('ERROR: Enter only numbers!');
	}
	
	if(arr[1] < 0) {
		arr[1] *= -1;
	}	
	var number = reverseNumber(arr[1]);
	
	var numberArr = number.toString().split('.');
	
	if(numberArr.length === 2) {
		digit = Number(numberArr[0] + numberArr[1]);
	} else {
		digit = Number(numberArr[0]);
	}
	
	if(position > digit.toString().length) {
		console.log('The number doesn’t have ' + position + ' digits');
	} else {
		digit = Number(digit.toString().substr(position - 1, 1));
		console.log(digit);
	}	
}

function reverseNumber(num) {
	var numStr = num.toString();
	var result = '';
	
	for(var i = numStr.length - 1; i >= 0; i--) {
		result += numStr[i];
	}
	
	return Number(result);
}

findNthDigit([1, 6]);
findNthDigit([2, -55]);
findNthDigit([6, 923456]);
findNthDigit([3, 1451.78]);
findNthDigit([6, 888.88]);