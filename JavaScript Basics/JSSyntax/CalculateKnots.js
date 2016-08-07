function KMhToKnots(kmh) {
	var knots = Math.round((kmh * 0.539956803455724) * 100) / 100;
	console.log(kmh + 'km/h = ' + knots + 'knots');
}

KMhToKnots(20);
KMhToKnots(112);
KMhToKnots(400);