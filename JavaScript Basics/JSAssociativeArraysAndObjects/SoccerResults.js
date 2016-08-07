"use strict";

function soccerResult(input) {
	var results = [];
	
	for(var row in input) {
		var tokens = input[row].trim().split(':');	
		var containsA = false;
		var containsB = false;
		var positionA;
		var positionB;

		var teams = tokens[0].split('\/');
		var teamA = teams[0].trim();
		var teamB = teams[1].trim();
		
		var scores = tokens[1].split('-');
		var scoreA = Number(scores[0]);
		var scoreB = Number(scores[1]);		

		for(var r in results) {
			if(results[r].team === teamA) {
				containsA = true;
				positionA = r;
				break;
			}
		}
		
		for(var r in results) {
			if(results[r].team === teamB) {
				containsB = true;
				positionB = r;
				break;
			}
		}
		
		if(containsA) {
			results[positionA].goalsScored += scoreA;
			results[positionA].goalsConceded += scoreB;		
			
			if(results[positionA].matchesPlayedWith.indexOf(teamB) === -1) {
				results[positionA].matchesPlayedWith.push(teamB);
			}					
		} else {
			results.push({
				team: teamA, 
				goalsScored: scoreA, 
				goalsConceded: scoreB, 
				matchesPlayedWith: [teamB]
			});
		}

		if(containsB) {
			results[positionB].goalsScored += scoreB;
			results[positionB].goalsConceded += scoreA;
			
			if(results[positionB].matchesPlayedWith.indexOf(teamA) === -1) {
				results[positionB].matchesPlayedWith.push(teamA);
			}			
		} else {
			results.push({
				team: teamB, 
				goalsScored: scoreB, 
				goalsConceded: scoreA, 
				matchesPlayedWith: [teamA]
			});
		}
	}

	results.sort(function fn(a, b) {
		if(a.team < b.team) return -1;
		if(a.team > b.team) return 1;
		return 0;
	});	

	function print(result) {
		var output = '{';
		
		for(var r in results) {
			var matchesWith = '"' + results[r].matchesPlayedWith.sort(
					function func(a, b) {
						return a > b; + '"';
					}).join('","');
			output += '"' + results[r].team + '":{' +
				'"goalsScored":' + results[r].goalsScored +
				',"goalsConceded":' + results[r].goalsConceded +
				',"matchesPlayedWith":[' + matchesWith + '"]},';
		}
		
		output = output.substr(0, output.length - 1);
		output += '}';
		
		console.log(output);
	}	
	
	print(results);
}



soccerResult([
	"Levski / CSKA: 0-2"
,"Pavlikeni / Loko Gorna: 4-2"
,"Loko Gorna / Levski: 1-4"
,"Litex / Loko Gorna: 0-0"
,"Beroe / Botev Plovdiv: 2-1"
,"Loko Gorna / Beroe: 3-1"
,"CSKA / Marek: 3-2"
,"Pavlikeni / Ludogorets: 0-2"
,"Loko Sofia / Litex: 0-2"
,"Pavlikeni / Marek: 1-1"
,"Litex / Levski: 0-0"
,"Beroe / Litex: 3-2"
,"Litex / Beroe: 1-0"
,"Ludogorets / Litex: 3-0"
,"Litex / Ludogorets: 1-0"
,"CSKA / Beroe: 1-0"
,"Botev Plovdiv / CSKA: 1-1"
,"Ludogorets / Loko Sofia: 1-0"
,"Litex / CSKA: 0-1"
,"Marek / Haskovo: 0-1"
,"Levski / Loko Gorna: 1-1"
,"Pavlikeni / Ludogorets: 0-2"
,"Loko Sofia / Litex: 0-2"
,"Pavlikeni / Marek: 1-1"
,"Litex / Levski: 0-0"
,"Beroe / Litex: 3-2"
,"Litex / Beroe: 1-0"
,"Ludogorets / Litex: 3-0"    
]);