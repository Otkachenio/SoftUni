function gradeScaling(grades) {
	for(var ind in grades) {
		grades[ind].score += (grades[ind].score * 0.1);
		
		if(grades[ind].score >= 100) {
			grades[ind].hasPassed = true;
		} else {
			grades[ind].hasPassed = false;
		}
	}
	
	grades.sort(function(a, b) {
		return a.name > b.name;
	});

	console.log(grades.filter(function(grade){
		return grade.score >= 100;
	}));
}

gradeScaling([
    {
        'name' : 'Пешо',
        'score' : 91
    },
    {
        'name' : 'Лилия',
        'score' : 290
    },
    {
        'name' : 'Алекс',
        'score' : 343
    },
    {
        'name' : 'Габриела',
        'score' : 400
    },
    {
        'name' : 'Жичка',
        'score' : 70
    }
]);