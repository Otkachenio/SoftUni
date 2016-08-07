'use strict'

function lastDigitAsText(number) {
	var LastDigit = Number(number.toString().substr(-1));
	
	switch(LastDigit) {
		case 0: 
			console.log('Zero');
			break;
		case 1: 
			console.log('One');
			break;
		case 2: 
			console.log('Two');
			break;
		case 3: 
			console.log('Three');
			break;
		case 4: 
			console.log('Four');
			break;
		case 5: 
			console.log('Five');
			break;
		case 6: 
			console.log('Six');
			break;
		case 7: 
			console.log('Seven');
			break;
		case 8: 
			console.log('Eight');
			break;
		case 9: 
			console.log('Nine');
			break;		
	}
}

lastDigitAsText(6);		//Six
lastDigitAsText(-55);	//Five	
lastDigitAsText(133);	//Three
lastDigitAsText(14567);	//Seven