var HTMLGen = (function () {
	function createParagraph(id, text) {
		var p = document.createElement('p');
		var target = document.getElementById(id);
		p.innerHTML = text;
		target.appendChild(p);
	}
	
	function createDiv(id, divClass) {
		var div = document.createElement('div');
		var target = document.getElementById(id);
		div.className = divClass;
		target.appendChild(div);
	}
	
	function createLink(id, text, url) {
		var newLink = document.createElement('a');
		var target = document.getElementById(id);
		newLink.innerHTML = text;
		newLink.href = url;
		target.appendChild(newLink);
	}
	
	return {
		createParagraph,
		createDiv,
		createLink
	};
})();

HTMLGen.createParagraph('wrapper', 'Soft Uni');
HTMLGen.createDiv('wrapper', 'section');
HTMLGen.createLink('book', 'C# basics book', 'http://www.introprogramming.info/');