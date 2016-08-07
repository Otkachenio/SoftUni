function printTable(arr) {	
	var startNum = Number(arr[0]);
	var endNum = Number(arr[1]);
	var FibNumbers = FibonacciNumbers(endNum);
	
	console.log('<table>');
	console.log('<tr><th>Num</th><th>Square</th><th>Fib</th></tr>');
	while(startNum <= endNum) {
		console.log(
			'<tr><td>' + startNum + 
			'</td><td>' + (startNum * startNum) + 
			'</td><td>' + isFibonacci(startNum) + '</td></tr>');
		
		startNum++;
	}
	console.log('</table>');
	
	function FibonacciNumbers(maxNum) {
		var a = 0, b = 1, f = 1;
		var array = [];
		
		while(f <= maxNum) {
			f = a + b;
			a = b;
			b = f;
			
			array.push(f);
		}
		
		return array;
	}
	
	function isFibonacci(num) {
		if (FibNumbers.indexOf(num) >= 0) {
			return 'yes';
		} else {
			return 'no';
		}
	}
}