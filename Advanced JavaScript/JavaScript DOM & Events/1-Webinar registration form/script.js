function showHideInvoice() {
	var checkBox = document.getElementById('CheckBox');

	var visible = 'none';
	
	if(checkBox.checked) {
		visible = 'block';
	}
	
	document.getElementById('invoice').style.display = visible;
}