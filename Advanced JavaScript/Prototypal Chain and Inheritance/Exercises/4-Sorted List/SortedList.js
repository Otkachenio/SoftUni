/***** VARIANT I *****/

var SortedListI = (function() {
	function SortedList() {
		this._innerArr = [];
	}
	
	SortedList.prototype.length = 0;
	
	if(typeof SortedList.prototype.add !== 'function') {
		SortedList.prototype.add = function(num) {
			this._innerArr.push(num);
			SortedList.prototype.length++;
			this._innerArr.sort(function (a,b) {
				return a - b;
			});
		}
	}
	
	if(typeof SortedList.prototype.get !== 'function') {
		SortedList.prototype.get = function(index) {
			return this._innerArr[index];
		}
	}	
	
	return SortedList;
})();

var listI = new SortedListI;

listI.add(5);
listI.add(4);
listI.add(1);
listI.add(2);
listI.add(3);

console.log(listI);
console.log('List length: ' + listI.length);
console.log('List.get(0): ' + listI.get(0) + ' - List.get(4): ' + listI.get(4));


/***** VARIANT II *****/
console.log('--------------------------------');

var SortedListII = {
	init: function() {
		this._arr = [];
		this.length = this._arr.length;
	},
	
	add: function(num) {
		this._arr.push(num);
		this._arr.sort(function (a, b) { return a - b });
		this.length = this._arr.length;
	},
	
	get: function(index) {
		return this._arr[index];
	}
};

var listII = Object.create(SortedListII);
listII.init();

listII.add(5);
listII.add(4);
listII.add(1);
listII.add(2);
listII.add(3);

console.log(listII);
console.log('List length: ' + listII.length);
console.log('List.get(0): ' + listII.get(0) + ' - List.get(4): ' + listII.get(4));