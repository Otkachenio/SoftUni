'use strit'

function Bag(arr) {
	var sum = 0;
	
	for(var ind in arr) {
		var tokens = arr[ind].split(' ');
	
		if(tokens[0].toLowerCase().trim() === 'coin'){
			if((!isNaN(Number(tokens[1])) &&
				isInt(Number(tokens[1])) &&
				(Number(tokens[1]) > 0))) {
				sum += Number(tokens[1]);						
			}
		}
	}
	
	function isInt(n) {
		return n % 1 === 0;
	}
	
	var gold = 0, silver = 0, coins = 0;	
	
	while(sum >= 100) {
		gold += Math.floor(sum / 100);
		sum = sum % 100;
		
	}
	silver = Math.floor(sum / 10);
	coins = sum % 10;
	
	console.log('gold : ' + gold);
	console.log('silver : ' + silver);
	console.log('bronze : ' + coins);
}

Bag([
	'coin 1000', 'coin 2000', 'coin 5000', 'coin 2000', 'coin -1000'
]);