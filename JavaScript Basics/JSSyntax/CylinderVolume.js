function calcCylinderVol(arr) {
	var vol = Math.round((Math.PI * (arr[0] * arr[0]) * arr[1]) * 1000) / 1000;
	
	console.log(vol);
}

calcCylinderVol([2, 4]);
calcCylinderVol([5, 8]);
calcCylinderVol([12, 3]);