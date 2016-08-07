"use strict";

var people = [
    new Person("Scott", "Guthrie", 38),
    new Person("Scott", "Johns", 36),
    new Person("Scott", "Hanselman", 39),
    new Person("Jesse", "Liberty", 57),
    new Person("Jon", "Skeet", 38)
];

function groupBy(criteria) {
	var result = [];
	
	people.forEach(function (element) {
		var key = element[criteria];
		
		if(result[key] === undefined) {
			result[key] = [];
		}
		
		result[key].push(element.toString());
	});
	
	print(result);
}

function print(forPrint) {
	for(var i in forPrint) {
	console.log('Group ' + i + ' : [' + forPrint[i].join(', ') + ']');
	}
}

function Person(firstName, lastName, age) {
	return {
		firstName : firstName,
		lastName : lastName,
		age : age,	
		toString: function() {
			return this.firstName + ' ' + this.lastName + '(age ' + this.age + ')';
		}
	}
}

groupBy('firstName');
console.log();

groupBy('age');
console.log();

groupBy('lastName');