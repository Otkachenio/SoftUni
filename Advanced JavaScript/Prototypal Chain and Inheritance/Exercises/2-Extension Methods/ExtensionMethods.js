if (typeof Array.prototype.getRandom !== 'function') {
	Array.prototype.getRandom = function () {
		var array = this;
		
		var rand = Math.floor(Math.random() * 1000) % array.length;
		
		return array[rand]; 
	}
}

var arr = [1, 3, 5, 10];
console.log(arr.getRandom());

/***** --- *****/

if (typeof String.prototype.getRandom !== 'function') {
	String.prototype.getRandom = function () {
		var string = this;
		
		var rand = Math.floor(Math.random() * 1000) % string.length;
		
		return string[rand];
	}
}

var str = "This is an example string";
console.log(str.getRandom());

/***** --- *****/

if (typeof Object.prototype.getRandom !== 'function') {
	Object.prototype.getRandom = function () {
		var object = this;
		
		var rand = Math.floor(Math.random() * 1000) % Object.keys(object).length;
		var counter = 0;
		
		for(var property in object) {
			if(rand === counter) {
				return property;
			}
			
			counter++;
		}
		
		return 'FAILED';
	}
}

var obj = {
  name: "Gosho",
  age: 25,
  grade: 5.95,
  isActive: true,
  languages: ["English", "French"]
};

console.log(obj.getRandom()); 