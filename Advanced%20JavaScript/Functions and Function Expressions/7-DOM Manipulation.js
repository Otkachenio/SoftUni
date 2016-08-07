var domModule = (function domModule() {
	function appendChild(domElement, selector) {
		var target = document.querySelector(selector);
		target.appendChild(domElement);
	}
	
	function removeChild(parentSelector, childSelector) {
		var target = document.querySelector(parentSelector);
		var child = document.querySelector(childSelector);
		target.removeChild(child);
	}
	
	function addHandler(selector, eventType, eventFunction) {
		var targets = document.querySelectorAll(selector);
		
		for(var index = 0; index < targets.length; index++) {
			targets[index].addEventListener(eventType, eventFunction);
		}
	}
	
	function retrieveElements(selector) {
		var elements = document.querySelectorAll(selector);
		
		return elements;
	}
	
	return {
		appendChild,
		removeChild,
		addHandler,
		retrieveElements
	};
})();
var liElement = document.createElement("li");
	// Appends a list item to ul.birds-list
domModule.appendChild(liElement,".birds-list"); 
	// Removes the first li child from the bird list
domModule.removeChild("ul.birds-list","li:first-child"); 
	// Adds a click event to all bird list items
domModule.addHandler("li.bird", 'click', function(){ alert("I'm a bird!") });
	// Retrives all elements of class "bird"
var elements = domModule.retrieveElements(".bird");
