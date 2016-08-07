'use strict'

function reverseWordsInString(str) {
	var tokens = str.split(' ');
	var result = '';
	
	for(var ind in tokens) {
		for(var i = tokens[ind].length - 1; i >= 0; i--) {
			result += tokens[ind][i];
		}
		
		result += ' ';
	}
	
	console.log(result);
}

reverseWordsInString('Hello, how are you.');
reverseWordsInString('Life is pretty good, isn’t it?');