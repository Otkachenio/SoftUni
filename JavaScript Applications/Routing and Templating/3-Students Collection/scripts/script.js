$.get('template.html', function (template) {
    var requester = new XMLHttpRequest();

    requester.open('GET', 'https://baas.kinvey.com/appdata/kid_r1ywmyuv/Students', true);
    requester.setRequestHeader('Authorization', 'Basic T3RrYWNoZW5pbzoxMjM0NQ==');
    requester.setRequestHeader('Content-Type', 'application/json');
    requester.setRequestHeader('Accept', 'application/json');

    requester.onreadystatechange = function () {
        if (requester.readyState === 4) {
            switch (Math.floor(requester.status / 100)) {
                case 2:
                    success(requester.responseText, template);
                    break;
                default:
                    console.error(requester.responseText);
            }
        }
    }

    requester.send();
});

function success(data, template) {
    var dataArr = JSON.parse(data),
        studentsArr = [],
        students,
        index,
        outputHtml;

    for (index in dataArr) {
        studentsArr.push({
            'fullName': dataArr[index].firstName + ' ' + dataArr[index].lastName,
            'gender': dataArr[index].gender,
            'age': dataArr[index].age,
            'country': dataArr[index].country
        });
    }

    students = {
        'students': studentsArr
    };

    outputHtml = Mustache.render(template, input);
    $('#wrapper').html(outputHtml);
}