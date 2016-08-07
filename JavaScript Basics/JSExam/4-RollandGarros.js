'use strict'

function TenisScores(arr) {
	var results = [];
	var i = 0;
	
	for(var ind in arr) {
		var tokens = arr[ind].split(':');
		var players = tokens[0].split('vs.');
		var player1 = players[0].replace(/\s\s+/g, ' ').trim();
		var player2 = players[1].replace(/\s\s+/g, ' ').trim();
		
		var scoreArrayUnfiltered = tokens[1].split(' ');
		var scoreArray = [];

		for(i in scoreArrayUnfiltered) {
			if(scoreArrayUnfiltered[i]) {
				scoreArray.push(scoreArrayUnfiltered[i]);
			}
		}
		
		var p1SetsWon = 0;
		var p2SetsWon = 0;
		var p1gamesWon = 0;
		var p2gamesWon = 0;
		
		for(i in scoreArray) {
			var points = scoreArray[i].split('-');
			p1gamesWon += Number(points[0]);
			p2gamesWon += Number(points[1]);	
			
			if(Number(points[0]) > Number(points[1])) {
				p1SetsWon++;
			} else {
				p2SetsWon++;
			}
		}
		
		var contains1 = false;
		var position1 = 0;
		var contains2 = false;
		var position2 = 0;
		
		for(i in results) {
			if(results[i].name === player1) {
				contains1 = true;
				position1 = i;
			}
		}
		
		for(i in results) {
			if(results[i].name === player2) {
				contains2 = true;
				position2 = i;
			}
		}
		
		var p1FScore = 0;
		var p2FScore = 0;
		
		if(p1SetsWon > p2SetsWon) {
			p1FScore = 1;
		} else {
			p2FScore = 1;
		}
		
		if(contains1) {
			results[position1].machesWon += p1FScore;
			results[position1].machesLost += p2FScore;
			results[position1].setsWon += p1SetsWon;
			results[position1].setsLost += p2SetsWon;
			results[position1].gamesWon += p1gamesWon;
			results[position1].gamesLost += p2gamesWon;
		} else {
			results.push({
				name: player1,
				machesWon: p1FScore,
				machesLost: p2FScore,
				setsWon: p1SetsWon,
				setsLost: p2SetsWon,
				gamesWon: p1gamesWon,
				gamesLost: p2gamesWon
			})
		}
		
		if(contains2) {
			results[position2].machesWon += p2FScore;
			results[position2].machesLost += p1FScore;
			results[position2].setsWon += p2SetsWon;
			results[position2].setsLost += p1SetsWon;
			results[position2].gamesWon += p2gamesWon;
			results[position2].gamesLost += p1gamesWon;
		} else {
			results.push({
				name: player2,
				machesWon: p2FScore,
				machesLost: p1FScore,
				setsWon: p2SetsWon,
				setsLost: p1SetsWon,
				gamesWon: p2gamesWon,
				gamesLost: p1gamesWon
			})
		}
	}	
	
	results.sort(function fn(a, b) {
		if(a.machesWon > b.machesWon) return -1;
		if(a.machesWon < b.machesWon) return 1;
		
		if(a.setsWon > b.setsWon) return -1;
		if(a.setsWon < b.setsWon) return 1;
		
		if(a.gamesWon > b.gamesWon) return -1;
		if(a.gamesWon < b.gamesWon) return 1;
		
		return a.name.localeCompare(b.name);
	})
	
	function print(result) {
		var output = '[';
		
		for(var r in result) {
			output += '{"name":"' + result[r].name +
				'","matchesWon":' + result[r].machesWon +
				',"matchesLost":' + result[r].machesLost +
				',"setsWon":' + result[r].setsWon +
				',"setsLost":' + result[r].setsLost +
				',"gamesWon":' + result[r].gamesWon +
				',"gamesLost":' + result[r].gamesLost + '},'
		}
		
		output = output.substr(0, output.length - 1);
		output += ']';
		
		console.log(output);
	}
	
	print(results);
}

TenisScores([
	'Rafa Nadal vs. His Knees : 5-4 2-3 7-5 4-6 0-1' 
	,'Roger 		Federervs.His			Age:7-6 6-3 6-1' 
	,'HuanMartin  delPotro			vs.Wrist Injuries:		6-3		1-6 2-6'
	,'WAYNE ODESNIK vs. Doping TwiceAlready             :0-6 0-6'
	,'Rafa Nadal vs. His Knees : 5-4 1-3 7-5 4-6 0-1'
	,'Roger 		Federervs.His			Age:7-6 6-3 6-1'
	,'HuanMartin  delPotro			vs.Wrist Injuries:		6-3		1-6 2-6'
	,'WAYNE ODESNIK vs. Doping TwiceAlready             :0-6 0-6 6-0 6-0 0-6'
	,'Rafa Nadal vs. His Knees : 7-4 2-3 7-5 4-6 2-5'
	,'Roger 		Federervs.His			Age:7-6 6-3 6-1'
	,'HuanMartin  delPotro			vs.Wrist Injuries:		6-3		1-6 2-6'
	,'WAYNE ODESNIK vs.Doping TwiceAlready             :0-6 0-6'
	,'Rafa Nadalvs.His Knees : 5-3 2-3 7-1 4-6 0-1'
	,'Roger Federer	vs.		His Age:7-6 6-3 6-1'
	,'HuanMartin  delPotrn			vs.Wrist Injuries:		6-3		1-6 2-6'
	,'WAYNE ODESNIK vs. Doping TwiceAlready             :0-6 0-6'
	,'Rafa Nadal vs. His Knees : 5-4 2-3 7-5 4-6 0-1'
	,'Roger 		Federervs.His			Age:7-6 6-3 6-1'
	,'HuanMartin  delPotrn	  vs.Wrist Injuries:		6-3		1-6 2-6'
	,'WAYNE ODESNIKvs. Doping TwiceAlready             :0-6 0-6'
	,'Rafa Nadal vs. His Knees : 5-1 2-4 7-5 2-6 0-1'
	,'Roger 		Federervs.His			Age:7-6 6-3 6-1'
	,'HuanMartin  	delPotrn			vs.Wrist Injuries:		6-3 1-6 2-6'
	,'WAYNE 	ODESNIK 	vs. Doping 		TwiceAlready	:1-6 2-6'
]);