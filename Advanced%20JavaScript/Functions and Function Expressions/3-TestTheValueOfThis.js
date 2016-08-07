function testContext() {
	console.log(this);
}

function testFunc() {
	testContext();
}

var test = new testContext();

//testContext();
//testFunc();