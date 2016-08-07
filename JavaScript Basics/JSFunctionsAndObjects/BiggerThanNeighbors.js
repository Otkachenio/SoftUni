'use strict'

function biggerThanNeighbors(index, arr) {
	if(arr.length <= index) {
		console.log('invalid index');
	} else if(arr.length <= index + 1 || index - 1 < 0) {
		console.log('only one neighbor');
	} else if(arr[index - 1] < arr[index] && arr[index] > arr[index + 1]) {
		console.log('bigger');
	} else {
		console.log('not bigger');
	}
	
}

biggerThanNeighbors(2, [1, 2, 3, 3, 5]);
biggerThanNeighbors(2, [1, 2, 5, 3, 4]);
biggerThanNeighbors(5, [1, 2, 5, 3, 4]);
biggerThanNeighbors(0, [1, 2, 5, 3, 4]);