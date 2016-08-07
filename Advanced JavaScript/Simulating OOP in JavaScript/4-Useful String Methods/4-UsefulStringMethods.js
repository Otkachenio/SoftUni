String.prototype.startsWith = function (substr) {
	var substrLength = substr.length;
	var stringBeggining = this.substr(0, substrLength);
	
	if(substr === stringBeggining) {
		return true;
	} else {
		return false;
	}
}

String.prototype.endsWith = function (substr) {
	var substrLength = substr.length;
	var stringEnding = this.substr(this.length - substrLength, substrLength);
	
	if(substr === stringEnding) {
		return true;
	} else {
		return false;
	}
}

String.prototype.left = function (count) {
	if(this.length <= count) {
		return this.toString();
	}
	var string = this.substring(0, count);
	
	return string;
}

String.prototype.right = function (count) {
	if(this.length <= count) {
		return this.toString();
	}
	var string = this.substr(this.length - count, count);
	
	return string;
}

String.prototype.padLeft = function (count, character) {
	if(this.length >= count) {
		return this.toString();
	}
	
	var result = '';
	if(!character) {
		character = ' ';
	}
	
	result += new Array((count + 1) - this.length).join(character).toString();
	result += this;
	
	return result;
}

String.prototype.padRight = function (count, character) {
	if(this.length >= count) {
		return this.toString();
	}
	
	var result = this;
	if(!character) {
		character = ' ';
	}
	
	result += new Array((count + 1) - this.length).join(character).toString();
	
	return result;
}

String.prototype.repeat = function (count) {
	var character = this;
	var result = '';
	
	for(var i = 0; i < count; i++) {
		result += character;
	}
	
	return result;
}

var example = "This is an example string used only for demonstration purposes.";
console.log(example.startsWith("This"));
console.log(example.startsWith("this"));
console.log(example.startsWith("other"));
var example = "This is an example string used only for demonstration purposes.";
console.log(example.endsWith("poses."));
console.log(example.endsWith ("example"));
console.log(example.startsWith("something else"));
var example = "This is an example string used only for demonstration purposes.";
console.log(example.left(9));
console.log(example.left(90));
var example = "This is an example string used only for demonstration purposes.";
console.log(example.right(9));
console.log(example.right(90));
// Combinations must also work
var example = "abcdefgh";
console.log(example.left(5).right(2));
var hello = "hello";
console.log(hello.padLeft(5));
console.log(hello.padLeft(10));
console.log(hello.padLeft(5, "."));
console.log(hello.padLeft(10, "."));
console.log(hello.padLeft(2, "."));
var hello = "hello";
console.log(hello.padRight(5));
console.log(hello.padRight(10));
console.log(hello.padRight(5, "."));
console.log(hello.padRight(10, "."));
console.log(hello.padRight(2, "."));
var character = "*";
console.log(character.repeat(5));
// Alternative syntax
console.log("~".repeat(3));
// Another combination
console.log("*".repeat(5).padLeft(10, "-").padRight(15, "+"));
