'use strict'

function findYoungestPerson(persons) {
	var youngestPerson = persons[0];
	
	for(var index in persons) {
		if(persons[index].age < youngestPerson.age) {
			youngestPerson = persons[index];
		}
	}
	
	console.log('The youngest person is ' + youngestPerson.firstname + ' ' + youngestPerson.lastname);
}

var persons = [
  { firstname : 'George', lastname: 'Kolev', age: 32}, 
  { firstname : 'Bay', lastname: 'Ivan', age: 81},
  { firstname : 'Baba', lastname: 'Ginka', age: 60},
  { firstname : 'Gosho', lastname: 'Totev', age: 34}]
findYoungestPerson(persons);