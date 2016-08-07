'use strict'

function RabbitFunction(arr) {
	var directionTokens = arr[0].split(', ');
	var matrix = [[]];
	var rabbitPosition = [0,0];
	var wallsHit = 0;
	var lettuce = 0, cabbage = 0 , turnip = 0, carrots = 0;
	var cellsPassed = [];
	
	for(var ind in arr) {
		var currentRow = Number(ind) - 1;		
		if(currentRow === -1) {
			continue;	
		}
		var row = arr[ind].split(', ');
		
		matrix[currentRow] = new Array(row.length);
		for(var i = 0; i < row.length; i++) {			
			matrix[currentRow][i] = row[i];
		}		
	}
	
	matrix[0][0] = matrix[0][0].replace('{&}', '@');
	matrix[0][0] = matrix[0][0].replace('{*}', '@');
	matrix[0][0] = matrix[0][0].replace('{#}', '@');
	matrix[0][0] = matrix[0][0].replace('{!}', '@');
	
	for(var directionInd in directionTokens) {
		var isHit = false;
		
		switch(directionTokens[directionInd]) {
			case 'up':
				if(rabbitPosition[0] === 0) {
					wallsHit++;
					isHit = true;
					break;
				}
				rabbitPosition[0]--;
				break;
			case 'down':
				if(rabbitPosition[0] === matrix.length - 1) {
					wallsHit++;
					isHit = true;
					break;
				}
				rabbitPosition[0]++;
				break;
			case 'left':
				if(rabbitPosition[1] === 0) {
					wallsHit++;
					isHit = true;
					break;
				}
				rabbitPosition[1]--;
				break;
			case 'right':
				if(rabbitPosition[1] === matrix[0].length - 1) {
					wallsHit++;
					isHit = true;
					break;
				}
				rabbitPosition[1]++;
				break;		
		}
		
		if(matrix[rabbitPosition[0]][rabbitPosition[1]].indexOf('{&}') >= 0) {
			matrix[rabbitPosition[0]][rabbitPosition[1]] =
			matrix[rabbitPosition[0]][rabbitPosition[1]].replace('{&}', '@');
			lettuce++;
		} 
		if(matrix[rabbitPosition[0]][rabbitPosition[1]].indexOf('{*}') >= 0) {
			matrix[rabbitPosition[0]][rabbitPosition[1]] =
			matrix[rabbitPosition[0]][rabbitPosition[1]].replace('{*}', '@');
			cabbage++;
		} 
		if(matrix[rabbitPosition[0]][rabbitPosition[1]].indexOf('{#}') >= 0) {
			matrix[rabbitPosition[0]][rabbitPosition[1]] =
			matrix[rabbitPosition[0]][rabbitPosition[1]].replace('{#}', '@');
			turnip++;
		} 
		if(matrix[rabbitPosition[0]][rabbitPosition[1]].indexOf('{!}') >= 0) {
			matrix[rabbitPosition[0]][rabbitPosition[1]] =
			matrix[rabbitPosition[0]][rabbitPosition[1]].replace('{!}', '@');
			carrots++;
		}
		
		if(!isHit) {
			cellsPassed.push(matrix[rabbitPosition[0]][rabbitPosition[1]]);		
		}		
	}
	
	console.log('{"&":' + lettuce +
				',"*":' + cabbage +
				',"#":' + turnip + 
				',"!":' + carrots + 
				',"wall hits":' + wallsHit + '}');
	console.log(cellsPassed.length !== 0 ? cellsPassed.join('|') : 'no');
}

RabbitFunction([
	'right, up, up, down'
	,'asdf, as{#}aj{g}dasd, kjldk{}fdffd, jdflk{#}jdfj'
	,'tr{X}yrty, zxx{*}zxc, mncvnvcn, popipoip'
	,'poiopipo, nmf{X}d{X}ei, mzoijwq, omcxzne'
])