validateBtn.addEventListener(
	'click', 
	function () {
		var validateBtn = document.getElementById('validateBtn');
		var email = document.getElementById('emailField').value;
		var divOutput = document.getElementById('divOutput');
		var color = '#FF0000';
		
		var emailRegex = /\w+\@\w+\.\w+/g;
		
		divOutput.innerHTML = email;
		if(emailRegex.test(email)) {
			color = '#00ff00';
		} 
		
		divOutput.style.backgroundColor = color;
	},
	false
);