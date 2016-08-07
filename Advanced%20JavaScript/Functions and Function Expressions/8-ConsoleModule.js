var specialConsole = (function() {
	function parseAguments(arguments) {
		var string = arguments[0];
		if(arguments.length > 1) {
			for(var index = 1; index < arguments.length; index++) {
				string = string.replace('{' + (index - 1) + '}', arguments[index]);
			}
		}

		return string;
	}
	
	function writeLine() {
		console.log(parseAguments(arguments));
	}
	
	function writeError() {
		console.error(parseAguments(arguments));
	}
	
	function writeWarning() {
		console.warn(parseAguments(arguments));
	}
	
	function writeInfo() {
		console.info(parseAguments(arguments));
	}
	
	return {
		writeLine,
		writeError,
		writeWarning,
		writeInfo
	};
})();

specialConsole.writeLine("Message: hello");
specialConsole.writeLine("Message: {0}", "hello");
specialConsole.writeLine("Object: {0}", { name: "Gosho", toString: function() { return this.name }});
specialConsole.writeError("Error: {0}", "A fatal error has occurred.");
specialConsole.writeWarning("Warning: {0}", "You are not allowed to do that!");
specialConsole.writeInfo("Info: {0}", "Hi there! Here is some info for you.");
specialConsole.writeError("Error object: {0}", { msg: "An error happened", toString: function() { return this.msg }});
specialConsole.writeLine('{0} {1} {2}', 'Just', 'For', 'Test');