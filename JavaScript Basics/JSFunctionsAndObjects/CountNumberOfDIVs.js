'use strict'

function countDivs(html) {
	var counter = 0;
	var index = 0;
	
	while(html.indexOf('<div', index) !== -1) {
		counter++;
		index = html.indexOf('<div', index) + 1;
	}
	
	console.log(counter);
}

countDivs('<!DOCTYPE html> \
<html> \
<head lang="en"> \
    <meta charset="UTF-8"> \
    <title>index</title> \
    <script src="/yourScript.js" defer></script> \
</head> \
<body> \
    <div id="outerDiv"> \
        <div \
    class="first"> \
            <div><div>hello</div></div> \
        </div> \
        <div>hi<div></div></div> \
        <div>I am a div</div> \
    </div> \
</body> \
</html>')