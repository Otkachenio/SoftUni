'use strict'

function FleaRace(arr) {
	var jumsAllowed = Number(arr[0]), trackLength = Number(arr[1]);
	var fleas = [];
	var i = 0;
	
	for(i = 2; i < arr.length; i++) {
		var tokens = arr[i].split(', ');
		var name = tokens[0], jumpDistance = tokens[1];
		
		fleas.push({
			name: name,
			jumpDistance: jumpDistance,
			fleaPosition: 0,
			trackState: new Array(trackLength)
		});
	}
	
	var finished = false;
	var winner = '';
	for(var i = 0; i < jumsAllowed; i++) {
		for(var ind in fleas){
			fleas[ind].fleaPosition += Number(fleas[ind].jumpDistance);
			if(fleas[ind].fleaPosition >= trackLength - 1) {
				fleas[ind].fleaPosition = trackLength - 1;
				finished = true;
				winner = fleas[ind].name;
				break;
			}
		}	
	
		if(finished) {
			break;
		}
	}
	
	for(var index in fleas) {
		fleas[index].trackState[Number(fleas[index].fleaPosition)] = fleas[index].name[0].toUpperCase();
	}	
	
	if(!winner) {
		var best = 0;		
		for(index in fleas) {
			if(fleas[index].fleaPosition >= best) {
				winner = fleas[index].name;
				best = fleas[index].fleaPosition;
			}
		}
	}
	
	function print() {
		console.log(Array(trackLength + 1).join('#'));
		console.log(Array(trackLength + 1).join('#'));
		
		for(index in fleas) {
			console.log(fleas[index].trackState.join('.'));
		}
		
		console.log(Array(trackLength + 1).join('#'));
		console.log(Array(trackLength + 1).join('#'));
		console.log('Winner: ' + winner);
	}
	
	print();
}

FleaRace([
	3,
	40,
	'S, 5',
	'L, 1',
	'O, 7',
	'C, 3',
	'H, 10',
	'A, 12',
	'I, 5',
	'N, 8',
	'O, 0',
	'S, 6'
]);